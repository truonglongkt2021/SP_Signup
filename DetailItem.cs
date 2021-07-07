﻿using Microsoft.SharePoint.Client;
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
        public DetailItem()
        {
            InitializeComponent();
        }

        private void DetailItem_Load(object sender, EventArgs e)
        {
            ID_Item = ItemList.ID_Item;
            var a = 1;

                Global_Variables._Password = "zaq@1234";
                ClientContext context = new ClientContext("https://datadesign.sharepoint.com/sites/WSS-TEST");
                SecureString passWord = new SecureString();
                foreach (char c in Global_Variables._Password.ToCharArray()) passWord.AppendChar(c);
                context.Credentials = new SharePointOnlineCredentials("truonglong@datadesign.vn", passWord);
                // Assume the web has a list named "Announcements".
                List announcementsList = context.Web.Lists.GetByTitle(@"旧図エクスポート");

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
                    obj.Title = listItem["Title"].ToString();
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
                var source = new BindingSource();
                source.DataSource = listResult;
                dataGridView2.DataSource = source;
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
    }
}
