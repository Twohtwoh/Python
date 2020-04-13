using DecisionsFramework.Design.Flow;
using DecisionsFramework.ServiceLayer;
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
        public static string RunScript(InputParameter InputVariables)
        {
            PythonSettings settings = ModuleSettingsAccessor<PythonSettings>.GetSettings();
            //var pypath = "C:\\Users\\Corey\\AppData\\Local\\Programs\\Python\\Python37-32\\";
            //var path = "C:\\Users\\Corey\\AppData\\Local\\Programs\\Python\\Python37-32\\python.exe";
            var pypath = settings.PythonScriptDirectory;
            var path = settings.PythonDirectory;
            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            List<string> newArgs = new List<string>();
            newArgs.Add(pypath + InputVariables.fileName);
            newArgs.AddRange(InputVariables.args);

            process.StartInfo.Arguments = "/c" + path + " " + String.Join(" ", newArgs); // Note the /c command (*)
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardError = true;
            process.Start();
            //* Read the output (or the error)
            string output = process.StandardOutput.ReadToEnd();
            Console.WriteLine(output);
            if (output == "")

            {
                string err = process.StandardError.ReadToEnd();
                Console.WriteLine(err);
                process.WaitForExit();
                return err;
            }
            process.WaitForExit();
            return output;
            


        }
    }
}
