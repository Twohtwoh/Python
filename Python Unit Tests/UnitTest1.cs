using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Python.Classes;
using Python.Steps;
using Python;
using DecisionsFramework.ServiceLayer;
using System.Diagnostics;
using System.Collections.Generic;

namespace Python_Unit_Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
       
        public void TestMethod1()
        {
           // ModuleSettingsAccessor<PythonSettings>.GetSettings();
            string[] slist = { "Hello", "World" };
            var data = new InputParameter()
            {
                fileName = "test.py",
                args = slist
            };

            // using (Process process = new Process())
            //{
            //Process process = new Process();
            var pypath = "C:\\Users\\Corey\\AppData\\Local\\Programs\\Python\\Python37-32\\";
            var path = "C:\\Users\\Corey\\AppData\\Local\\Programs\\Python\\Python37-32\\python.exe";

               List<string> newArgs = new List<string>();
               newArgs.Add(pypath+data.fileName);
               newArgs.AddRange(data.args);

            //    var input = new ProcessStartInfo
            //    {
            //        FileName = path,
            //        Arguments = String.Join(" ", newArgs),
            //        UseShellExecute = false,
            //        RedirectStandardOutput = true
            //    };
            
            //process.Start();
            //    while (!process.StandardOutput.EndOfStream)
            //    {
            //        string line = process.StandardOutput.ReadLine();
            //        // do something with line
            //    }

                // string output = getter.ToString();
                // Synchronously read the standard output of the spawned process. 
                //StreamReader reader = Process.StandardOutput;
                //string output = reader.ReadToEnd();
                // return output;

                // Write the redirected output to this application's window.
                //Console.WriteLine(output);

                //process.WaitForExit();
           // }
            


        }
    }
}
