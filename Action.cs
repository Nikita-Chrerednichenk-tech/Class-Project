using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_5
{
    public static class Action
    {

        public static Result InfoAction()
        {
            return new Result()
            {
                DateTime1 = DateTime.Now,
                Message = "information",
                Status1 = Status.Info,
            };
        }

        public static Result ErrorAction()
        {
            Result result = new Result();
            result.DateTime1 = DateTime.Now;
            result.Message = "information";
            result.Status1 = Status.Error;

            return result;
        }
        public static Result WarningAction()
        {
            return new Result()
            {
                DateTime1 = DateTime.Now,
                Message = "information",
                Status1 = Status.Warning,
            };
        }

        

    }
}
