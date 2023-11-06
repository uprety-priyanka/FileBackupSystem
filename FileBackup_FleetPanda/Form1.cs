
using FileBackup_FleetPanda.Model;
using FileBackup_FleetPanda.Services.Abstract;
using FileBackup_FleetPanda.Services.Implementation;

namespace FileBackup_FleetPanda
{
    public partial class Form1 : Form
    {


        private ActivityLogModel activityLogModel= new();
        private CancellationTokenSource cancellationTokenSource;     
        private string sourceFolderPath;
        private string destinationFolderPath;
        private System.Threading.Timer backupTimer;       
        private IActivityLogService _activityLogService;



        public Form1()
        {
            InitializeComponent();
            _activityLogService = new ActivityLogService();

            cancellationTokenSource = new CancellationTokenSource();         
           
            backupFrequencyComboBox.Items.AddRange(new string[] { "Manual", "Every Minute", "Every Hour", "Every Day" });
            backupFrequencyComboBox.SelectedIndex = 0; // Default to "Manual"

            // Create a timer with an interval of time selected by user ( 1min, 1hr or 1day)
            backupTimer = new System.Threading.Timer(BackupTimer_Tick, null, Timeout.Infinite, Timeout.Infinite);  // setting up the timer for backup
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void sourceFolder_Click(object sender, EventArgs e)  // source folder selection button
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    sourceFolderPath = folderBrowserDialog.SelectedPath;
                    sourceFolderTextBox.Text = sourceFolderPath;  // selecting source folder path

                    activityLogModel.source_path = sourceFolderTextBox.Text; // binding source path in model variable
                }
            }
        }

        private void destinationFolder_Click(object sender, EventArgs e)  // destination folder selection button
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    destinationFolderPath = folderBrowserDialog.SelectedPath;
                    destinationFolderTextBox.Text = destinationFolderPath;  // selecting destination folder path

                    activityLogModel.destination_path = destinationFolderTextBox.Text; // binding destination path in model variable
                }
            }
        }
  
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void backupButton_Click(object sender, EventArgs e)  // backup button
        {
            //BackupFolder(sourceFolderPath, destinationFolderPath);

            if (string.IsNullOrEmpty(sourceFolderPath) || string.IsNullOrEmpty(destinationFolderPath))
            {
                MessageBox.Show("Please select a source folder and a backup folder.");
                return;
            }

            if (!Directory.Exists(sourceFolderPath))
            {
                MessageBox.Show("Source folder does not exist.");
                return;
            }

            if (!Directory.Exists(destinationFolderPath))
            {
                MessageBox.Show("Destination folder does not exist.");
                return;
            }

            if (backupFrequencyComboBox.SelectedIndex == 0) // Manual
            {
                // Perform a manual backup
                PerformBackup(sourceFolderPath, destinationFolderPath);
            }
            else
            {
                // Determine the backup interval based on the selected frequency
                int interval = 0;
                switch (backupFrequencyComboBox.SelectedIndex)
                {
                    case 1: // Every Minute
                        interval = 60000; // 60,000 milliseconds (1 minute = 60sec * 1000)
                        break;
                    case 2: // Every Hour
                        interval = 3600000; // 3,600,000 milliseconds (1 hour= 60sec * 60min * 1000)
                        break;
                    case 3: // Every Day
                        interval = 86400000; // 86,400,000 milliseconds (1 day= 60sec * 60min * 24hr * 1000)
                        break;
                }

                // Start the timer to trigger backups at the selected frequency
                backupTimer.Change(0, interval);
            }

        }

        private void BackupTimer_Tick(object state)
        {
            string sourceFolderPath = sourceFolderTextBox.Text;
            string destinationFolderPath = destinationFolderTextBox.Text;

            if (string.IsNullOrEmpty(sourceFolderPath) || string.IsNullOrEmpty(destinationFolderPath))
            {
                return;
            }

            if (!Directory.Exists(sourceFolderPath) || !Directory.Exists(destinationFolderPath))
            {
                return;
            }

            PerformBackup(sourceFolderPath, destinationFolderPath);
        }

        private void PerformBackup(string sourceFolderPath, string destinationFolderPath)
        {
            string result = string.Empty;

            // Check if the source folder is empty
            if (!Directory.EnumerateFiles(sourceFolderPath, "*", SearchOption.AllDirectories).Any())
            {
                MessageBox.Show("Source folder is empty. No backup performed.");
                return;
            }

            try
            {
                foreach (string sourceFile in Directory.GetFiles(sourceFolderPath, "*.*", SearchOption.AllDirectories))
                {
                    if (cancellationTokenSource.Token.IsCancellationRequested) // check for the cancellation request
                    {
                        break;  
                    }

                   
                    var sourceFolder = new DirectoryInfo(sourceFolderPath);
                    var destinationFolder = new DirectoryInfo(destinationFolderPath);
                  
                    foreach (var file in sourceFolder.GetFiles())  // select all the files from the source folder one at a time
                    {
                        string destinationFilePath = Path.Combine(destinationFolder.FullName, file.Name);

                        if (!File.Exists(destinationFilePath))    // Copy files from source to destination only if they don't already exist in the destination
                        {
                            file.CopyTo(destinationFilePath);     // Copy files from source to destination
                        }
                    }
                  
                }

                if (!cancellationTokenSource.Token.IsCancellationRequested) // check for the cancellation request
                {
                    int count = 0; 

                    activityLogModel.message = "backup process has be sucessful.";
                    activityLogModel.status = 'S';
                    
                    count = _activityLogService.InsertIntoActivityLog(activityLogModel);  // adding the log to database
                    if(count> 0) // if sucess  then display sucess message
                    {
                        MessageBox.Show("Backup complete.");
                    }
                    else
                    {
                        MessageBox.Show("Backup complete but gor error while adding log to database.");
                    }
                   
                }
            }
            catch (Exception ex)
            {
                activityLogModel.message = "Error occured during the backup process.";
                activityLogModel.status = 'E';

                _activityLogService.InsertIntoActivityLog(activityLogModel); // adding the log to database

                MessageBox.Show("An error occurred during backup: " + ex.Message);  // display if any error
               

              
            }
           
        }


        private void backupPause_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Are you sure that you want to cancel backup?", "Backup", MessageBoxButtons.OKCancel);  // asking for backup cancellation confirmation

            try
            {

                if (result == DialogResult.OK)   // if cancellation is confirmed
                {
                    int count = 0; 
                    cancellationTokenSource.Cancel(); // Cancel the backup
                    backupTimer.Change(Timeout.Infinite, Timeout.Infinite); //stop the timer

                    activityLogModel.message = "Backup has been cancelled";
                    activityLogModel.status = 'X';

                    count = _activityLogService.InsertIntoActivityLog(activityLogModel); // adding log to database
                    if(count> 0)
                    {
                        MessageBox.Show("Backup operation canceled.");  // show backup cancellation message
                    }
                    else
                    {
                        MessageBox.Show("Backup has been camcelled but got error while adding log to database.");
                    }

                }
                        
            }
            catch (Exception ex)
            {
                activityLogModel.message = "Error occured while cancelling the backup process.";
                activityLogModel.status = 'E';
                _activityLogService.InsertIntoActivityLog(activityLogModel);  // adding log to database
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
       
    }
}