using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DiscussionForum.DataAccess;
using System.Collections.Specialized;

namespace DiscussionForum
{
    public partial class DeleteRecord : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                delgrid.DataSource = DBHelper.GetData();
                delgrid.DataBind();
                //   btnDelete.Attributes.Add("onclick",
                //          "return confirm('Are you sure you want to delete selected item(s) ?');");

            }

        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            StringCollection sc = new StringCollection();

            string id = string.Empty;

            for (int i = 0; i < delgrid.Rows.Count; i++)
            {

                CheckBox cb = (CheckBox)delgrid.Rows[i].Cells[0].FindControl("CheckBox1");

                if (cb != null)
                {

                    if (cb.Checked)
                    {

                        id = delgrid.Rows[i].Cells[1].Text;

                        sc.Add(id);

                    }

                }

            }
            deleterecords dl = new deleterecords();

           dl.DeleteRecords(sc);

            //BindGridView();
          delgrid.DataSource = DBHelper.GetData();
           delgrid.DataBind();
        }

        protected void btnDelete_Click1(object sender, EventArgs e)
        {

        }
    }
}

