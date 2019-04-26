using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace Assignment1SD210.Models.ActionFilter
{
    public class ActionFilterLog
    {
        public int Id { get; set; }
        public string ActionName { get; set; }
        public string ControllerName { get; set; }
        public Stopwatch ExecutionTime { get; set; }
    }
}