
using FileBackup_FleetPanda.Services.Abstract;
using FileBackup_FleetPanda.Services.Implementation;
using Microsoft.Extensions.DependencyInjection;
using System.ComponentModel.Design;

namespace FileBackup_FleetPanda
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// 
       
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();


            // Create instances of your services and set them in the ServiceContainer.
            //ServiceDependencies.ActivityLogService = new ActivityLogService();


            Application.Run(new Form1());
        }
    }
}