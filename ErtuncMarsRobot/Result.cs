using System;
using System.Collections.Generic;
using System.Text;

namespace ErtuncMarsRobot
{
    public class Result<T>
    {
        public T Data { get; set; }
        public string Message { get; set; }
        public bool IsSuccess { get; set; }

        public Result(string Message)
        {
            this.IsSuccess = false;
            this.Message = Message;
        }

        public Result(T Data)
        {
            this.IsSuccess = true;
            this.Data= Data;
        }
    }
}
