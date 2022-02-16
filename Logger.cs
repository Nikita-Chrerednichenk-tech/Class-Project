using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_5
{
    internal class Logger
    {
        public Result[] result { get; set; }
        public Status LogLevel { get; set; }

        private static Logger instance;

        private Logger()
        {
            LogLevel = Status.Warning;
            result = new Result[10];

        }

        //public static ArrayResult() {

        //    int[] arraylength = new int[10];
        //}



        public static Logger GetInstance()
        {
            if (instance == null)
                instance = new Logger();
            return instance;
        }


    }












}
