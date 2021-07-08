using Microsoft.SharePoint.Client;
using SP_Signup.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace SP_Signup
{
    public partial class DetailItem : System.Windows.Forms.Form
    {
        private static string ID_Item = "";
        FileCollection files = null;
        ClientContext context = null;
        string Title = "";
        public DetailItem()
        {
            InitializeComponent();
        }

        private void DetailItem_Load(object sender, EventArgs e)
        {
            ID_Item = ItemList.ID_Item;
            context = new ClientContext(Global_Variables._Url);
            SecureString passWord = new SecureString();
            foreach (char c in Global_Variables._Password.ToCharArray()) passWord.AppendChar(c);
            context.Credentials = new SharePointOnlineCredentials(Global_Variables._Username, passWord);
            // Assume the web has a list named "Announcements".
            List announcementsList = context.Web.Lists.GetByTitle(Global_Variables._TitleList);

            // This creates a CamlQuery that has a RowLimit of 100, and also specifies Scope="RecursiveAll"
            // so that it grabs all list items, regardless of the folder they are in.

            ListItem listItem = announcementsList.GetItemById(ID_Item);
            // Retrieve all items in the ListItemCollection from List.GetItems(Query).
            context.Load(listItem);
            context.ExecuteQuery();
            List<Result> listResult = new List<Result>();
            {
                //if (listItem["Attachments"].ToString().ToLower().Equals("false"))
                //{
                //    continue;
                //}
                // We have all the list item data. For example, Title.
                Result obj = new Result();
                obj.Title = Title = listItem["Title"].ToString();
                obj.OData_x54c1__x002e__x002e__x002e__x00 = listItem["_x54c1__x002e__x002e__x002e__x00"] == null ? "NULL" : listItem["_x54c1__x002e__x002e__x002e__x00"].ToString();
                obj.OData__x4f1a__x793e__x540d_ = listItem["_x4f1a__x793e__x540d_"] == null ? "NULL" : listItem["_x4f1a__x793e__x540d_"].ToString();

                obj.OData__x54c1__x756a_ = listItem["_x54c1__x756a_"] == null ? "NULL" : listItem["_x54c1__x756a_"].ToString();
                obj.OData__x578b__x540d__x79f0_ = listItem["_x578b__x540d__x79f0_"] == null ? "NULL" : listItem["_x578b__x540d__x79f0_"].ToString();
                obj.OData__x5de5__x6570_ = listItem["_x5de5__x6570_"] == null ? "NULL" : listItem["_x5de5__x6570_"].ToString();

                obj.OData__x65b0__x8a2d_ = listItem["_x65b0__x8a2d_"] == null ? "NULL" : listItem["_x65b0__x8a2d_"].ToString();
                obj.OData__x8eca__x7cfb_ = listItem["_x8eca__x7cfb_"] == null ? "NULL" : listItem["_x8eca__x7cfb_"].ToString();
                obj.Modified = (DateTime)listItem["Modified"];
                bool isAttach = false;
                Boolean.TryParse(listItem["Attachments"].ToString(), out isAttach);
                obj.Attachments = isAttach;
                obj.ID = (int)listItem["ID"];
                listResult.Add(obj);
            }

            #region mapping view
            txtOData_x54c1__x002e__x002e__x002e__x00.Text = listResult.FirstOrDefault().OData_x54c1__x002e__x002e__x002e__x00;
            txtOData__x4f1a__x793e__x540d_.Text = listResult.FirstOrDefault().OData__x4f1a__x793e__x540d_;
            txtOData__x54c1__x756a_.Text = listResult.FirstOrDefault().OData__x54c1__x756a_;
            txtOData__x578b__x540d__x79f0_.Text = listResult.FirstOrDefault().OData__x578b__x540d__x79f0_;
            txtOData__x5de5__x6570_.Text = listResult.FirstOrDefault().OData__x5de5__x6570_;
            txtOData__x65b0__x8a2d_.Text = listResult.FirstOrDefault().OData__x65b0__x8a2d_;
            txtOData__x7d0d__x671f_.Text = listResult.FirstOrDefault().OData__x7d0d__x671f_;
            txtOData__x8eca__x7cfb_.Text = listResult.FirstOrDefault().OData__x8eca__x7cfb_;
            txtOData__x9032__x884c__x8005_.Text = listResult.FirstOrDefault().OData__x9032__x884c__x8005_;
            txtTitle.Text = listResult.FirstOrDefault().Title;
            cbAttachment.Checked = listResult.FirstOrDefault().Attachments;
            //check attachment exist
            if (!cbAttachment.Checked)
            {
                btn_Download.Enabled = false;
            }
            else
            {
                #region get attachment
                files = CommonServices.GetAttachments(context, announcementsList, listItem);
                foreach (Microsoft.SharePoint.Client.File f in files)
                {
                    rbListDownload.Text += f.Name + "\n";
                }
                rbListDownload.Enabled = false;
                #endregion
            }
            #endregion
        }
        public void GetItemDetail()
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            btn_Download.Enabled = false;
            foreach (Microsoft.SharePoint.Client.File f in files)
            {
                CommonServices.Download(f.ServerRelativeUrl, Title, context, f.Name);
            }
            btn_Download.Enabled = true;

        }
    }
}
