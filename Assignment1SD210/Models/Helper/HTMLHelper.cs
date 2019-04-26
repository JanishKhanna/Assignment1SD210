using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assignment1SD210.Models.Helper
{
    public static class HTMLHelper
    {
        public static string MyButton(this HtmlHelper html)
        {
            return "<button type='button' class='btn btn-primary'>Open</button>";
        }

        public static MvcHtmlString MySpecialTextBoxTwo(this HtmlHelper html)
        {
            return MvcHtmlString.Create(
                "<input type='text' class='my-special-class'/>");
        }
    }
   
}