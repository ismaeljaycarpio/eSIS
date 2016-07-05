using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Text;

namespace eSIS.App_Code
{
    public class Helpers
    {
        /// <summary>
        /// Show Bootstrap Modal Dialog
        /// </summary>
        /// <param name="control">input 'this' to refer to the Control</param>
        /// <param name="pageObj">input 'this' to refer to the Page Object</param>
        /// <param name="modalId">Id of the div</param>
        /// <param name="isOpen">Value whether to show/hide the modal dialog</param>
        public static void Modal(Control control, Page pageObj, string modalId, bool isOpen)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(@"<script type='text/javascript'>");

            if (isOpen)
            {
                sb.Append("$('#" + modalId + "').modal('show');");
            }
            else
            {
                sb.Append("$('#" + modalId + "').modal('hide');");
            }
            sb.Append(@"</script>");
            ScriptManager.RegisterClientScriptBlock(control,
                pageObj.GetType(),
                Guid.NewGuid().ToString(),
                sb.ToString(),
                false);
        }
    }
}