using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assignment1SD210.Models.ActionFilter
{
    public class Question1 : ActionFilterAttribute
    {
        private ApplicationDbContext DbContext { get; set; }

        public Question1()
        {
            DbContext = new ApplicationDbContext();
        }

        public Stopwatch Stopwatch { get; set; }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            var myLog = new ActionFilterLog();

            myLog.ActionName = filterContext
                .ActionDescriptor
                .ActionName;

            myLog.ControllerName = filterContext
                .ActionDescriptor
                .ControllerDescriptor
                .ControllerName;

            //myLog.ExecutionTime = filterContext
            //    .ActionDescriptor
            //    .

            DbContext.ActionFilterLogs.Add(myLog);
            DbContext.SaveChanges();
        }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            Stopwatch = new Stopwatch();
            Stopwatch.Start();
        }

        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            Stopwatch.Stop();
            CreateLog(filterContext.Result.ToString(), filterContext.Controller.ViewBag(), Stopwatch.ElapsedMilliseconds);
        }

        private void CreateLog(string v, dynamic dynamic, long elapsedMilliseconds)
        {
            throw new NotImplementedException();
        }

        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {

        }

        private void CreateLog(string actionName, string controllerName, Stopwatch executionTime)
        {
            var myLog = new ActionFilterLog();
            myLog.ActionName = actionName;
            myLog.ControllerName = controllerName;
            myLog.ExecutionTime = executionTime;
            DbContext.ActionFilterLogs.Add(myLog);
            DbContext.SaveChanges();
        }
    }
}