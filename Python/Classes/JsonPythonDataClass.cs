using DecisionsFramework.Data.DataTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Python.Classes
{
    public class InputParameter
    {
        //public FileData file { get; set; }
        public string fileName { get; set; }

        //public bool NewFile { get; set; }

        public string[] args { get; set; }
    }
    public class OutputParameter
    {
        public object parameter { get; set; }
    }
    public class StepDataType
    {
        public InputParameter[] InParams { get; set; }
        public OutputParameter[] OutParams { get; set; }

    }
}

