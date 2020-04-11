using DecisionsFramework.Design.Flow;
using Python.Classes;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// This is a sync step which behaves like a method step in "SimpleStepCode" but is a 
/// full implementation of our interfaces.  For more advanced steps you should use a 
/// CustomAsyncStep
/// </summary>
namespace Python.Steps
{
    [AutoRegisterMethodsOnClass(true, "Python Steps")]
    class CustomSyncStep
    {
        public static string RunScript(InputParameter Inputs)
        {
            using (Process process = new Process())
            {
                process.StartInfo.FileName = "ipconfig.exe";
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.RedirectStandardOutput = true;
                process.Start();

                // Synchronously read the standard output of the spawned process. 
                StreamReader reader = process.StandardOutput;
                string output = reader.ReadToEnd();
                return output;

                // Write the redirected output to this application's window.
                //Console.WriteLine(output);

                //process.WaitForExit();
            }

            //Console.WriteLine("\n\nPress any key to exit.");
            //Console.ReadLine();
           
            

        }
    }
}
