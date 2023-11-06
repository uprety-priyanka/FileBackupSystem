namespace FileBackup_FleetPanda
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sourceFolder = new System.Windows.Forms.Button();
            this.destinationFolder = new System.Windows.Forms.Button();
            this.sourceFolderTextBox = new System.Windows.Forms.TextBox();
            this.destinationFolderTextBox = new System.Windows.Forms.TextBox();
            this.backupButton = new System.Windows.Forms.Button();
            this.backupFrequencyComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.backupPause = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(388, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "File Backup System";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(54, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select source path";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(54, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Select destination path";
            // 
            // sourceFolder
            // 
            this.sourceFolder.BackColor = System.Drawing.SystemColors.Control;
            this.sourceFolder.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.sourceFolder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.sourceFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sourceFolder.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sourceFolder.Location = new System.Drawing.Point(536, 96);
            this.sourceFolder.Name = "sourceFolder";
            this.sourceFolder.Size = new System.Drawing.Size(122, 36);
            this.sourceFolder.TabIndex = 3;
            this.sourceFolder.Text = "Select Folder";
            this.sourceFolder.UseVisualStyleBackColor = false;
            this.sourceFolder.Click += new System.EventHandler(this.sourceFolder_Click);
            // 
            // destinationFolder
            // 
            this.destinationFolder.BackColor = System.Drawing.SystemColors.Control;
            this.destinationFolder.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.destinationFolder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.destinationFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.destinationFolder.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.destinationFolder.ForeColor = System.Drawing.SystemColors.ControlText;
            this.destinationFolder.Location = new System.Drawing.Point(536, 161);
            this.destinationFolder.Name = "destinationFolder";
            this.destinationFolder.Size = new System.Drawing.Size(122, 35);
            this.destinationFolder.TabIndex = 4;
            this.destinationFolder.Text = "Select Folder";
            this.destinationFolder.UseVisualStyleBackColor = true;
            this.destinationFolder.Click += new System.EventHandler(this.destinationFolder_Click);
            // 
            // sourceFolderTextBox
            // 
            this.sourceFolderTextBox.Location = new System.Drawing.Point(314, 96);
            this.sourceFolderTextBox.Multiline = true;
            this.sourceFolderTextBox.Name = "sourceFolderTextBox";
            this.sourceFolderTextBox.Size = new System.Drawing.Size(225, 36);
            this.sourceFolderTextBox.TabIndex = 5;
            // 
            // destinationFolderTextBox
            // 
            this.destinationFolderTextBox.Location = new System.Drawing.Point(314, 161);
            this.destinationFolderTextBox.Multiline = true;
            this.destinationFolderTextBox.Name = "destinationFolderTextBox";
            this.destinationFolderTextBox.Size = new System.Drawing.Size(225, 35);
            this.destinationFolderTextBox.TabIndex = 6;
            // 
            // backupButton
            // 
            this.backupButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.backupButton.Location = new System.Drawing.Point(418, 321);
            this.backupButton.Name = "backupButton";
            this.backupButton.Size = new System.Drawing.Size(105, 32);
            this.backupButton.TabIndex = 7;
            this.backupButton.Text = "Backup";
            this.backupButton.UseVisualStyleBackColor = true;
            this.backupButton.Click += new System.EventHandler(this.backupButton_Click);
            // 
            // backupFrequencyComboBox
            // 
            this.backupFrequencyComboBox.FormattingEnabled = true;
            this.backupFrequencyComboBox.Location = new System.Drawing.Point(314, 242);
            this.backupFrequencyComboBox.Name = "backupFrequencyComboBox";
            this.backupFrequencyComboBox.Size = new System.Drawing.Size(225, 23);
            this.backupFrequencyComboBox.TabIndex = 8;
            this.backupFrequencyComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(54, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "Select backup option";
            // 
            // backupPause
            // 
            this.backupPause.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.backupPause.Location = new System.Drawing.Point(912, 52);
            this.backupPause.Name = "backupPause";
            this.backupPause.Size = new System.Drawing.Size(29, 28);
            this.backupPause.TabIndex = 10;
            this.backupPause.Text = "II";
            this.backupPause.UseVisualStyleBackColor = true;
            this.backupPause.Click += new System.EventHandler(this.backupPause_Click);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(963, 386);
            this.Controls.Add(this.backupPause);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.backupFrequencyComboBox);
            this.Controls.Add(this.backupButton);
            this.Controls.Add(this.destinationFolderTextBox);
            this.Controls.Add(this.sourceFolderTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sourceFolder);
            this.Controls.Add(this.destinationFolder);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button sourceFolder;
        private Button destinationFolder;
        private TextBox sourceFolderTextBox;
        private TextBox destinationFolderTextBox;
        private Button backupButton;
        private ComboBox backupFrequencyComboBox;
        private Label label4;
        private Button backupPause;
    }
}