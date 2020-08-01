using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

using System.Reflection;
using System.Reflection.Emit;
using System.Runtime;
using System.Runtime.Loader;

using System.Windows;
using System.Windows.Forms;

using Application = System.Windows.Application;
using Size = System.Drawing.Size;

namespace NetBookLog {
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application {
        [STAThread]
        private void startup(object sender, StartupEventArgs e) {
            
            MainWindow mwin = new MainWindow();
            mwin.InitializeComponent();
            // try {
            //     const string assemblyFile = "C:\\Windows\\Microsoft.NET\\Framework\v4.0.30319\\System.Windows.dll";
            //     Assembly assembly = Assembly.LoadFrom(assemblyFile: assemblyFile);
            //     MethodInfo method = assembly.GetTypes()[0].GetMethod("Application");
            //     Console.WriteLine(method.ReturnType);
            // } catch (FileNotFoundException error) { Console.WriteLine(error.StackTrace); }
            // catch (ArgumentException error) { Console.WriteLine(error.StackTrace); }
            //
            // try {
            //     Process process = Process.Start(fileName: "cmd.exe", arguments: "cd D:\\Users\\qcaij\\RiderProjects");
            //     Console.WriteLine(process);
            //     process = Process.Start(fileName: "msedge.exe", arguments: "http://www.ufl.edu/");
            //     Console.WriteLine(process);
            // } catch (Win32Exception error) { Console.WriteLine(error.StackTrace); }
        }
    }
}