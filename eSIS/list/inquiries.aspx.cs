using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace eSIS.list
{
    public partial class inquiries : System.Web.UI.Page
    {
        string strSearch = String.Empty;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {

        }

        protected void InqDataSource_Selecting(object sender, LinqDataSourceSelectEventArgs e)
        {
            using(var q = new dbSISEntities())
            {
                strSearch = txtSearch.Text.Trim();
                e.Result = q.Inquiries.Where
                    (s => s.InquiryID.ToString().Contains(strSearch) ||
                    s.LastName.Contains(strSearch) ||
                    s.FirstName.Contains(strSearch) ||
                    s.MiddleName.Contains(strSearch) ||
                    s.Company.Contains(strSearch) ||
                    s.ContactNumber.Contains(strSearch) ||
                    s.Email.Contains(strSearch) ||
                    s.CompanyDesignation.Contains(strSearch) ||
                    s.InquiryType.InquiryTypeName.Contains(strSearch) ||
                    s.Details.Contains(strSearch) ||
                    s.PendingTask.Contains(strSearch) ||
                    s.Status.Contains(strSearch)
                    ).ToList();
            }
        }
    }
}