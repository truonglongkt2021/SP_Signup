using Microsoft.SharePoint.Client;
using SP_Signup.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SP_Signup
{
    public partial class FormLogin : System.Windows.Forms.Form
    {
        public FormLogin()
        {
            //hgf
            //gfgfgf
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //txtSPApi.Text = Global_Variables._Url = @"https://datadesign.sharepoint.com/sites/WSS-TEST";
            //txtuser.Text = Global_Variables._Username = @"truonglong@datadesign.vn";
            //txtpass.Text = Global_Variables._Password = @"";
            txtSPApi.Text = Global_Variables._Url;
            txtuser.Text = Global_Variables._Username;
            txtpass.Text = Global_Variables._Password;
        }

        private void grAcc_Enter(object sender, EventArgs e)
        {

        }

        private void cbbChangeConnect_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (checkNull())
            {
                btnLogin.Enabled = false;
                btnclose.Enabled = false;
                Global_Variables._Url = txtSPApi.Text;
                Global_Variables._Username = txtuser.Text;
                Global_Variables._Password = txtpass.Text;
                ItemList c = new ItemList();
                this.Hide();
                c.ShowDialog();
                this.Close();
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {

        }

        private void btnGetList_Click(object sender, EventArgs e)
        {
            if (checkNull())
            {
                GetList();
                btnLogin.Enabled = true;
            }
        }
        private bool checkNull()
        {
            if (txtSPApi.Text == "" || txtuser.Text == "" || txtpass.Text == "")
            {
                MessageBox.Show("Please enter URL, Username and Password first", "Field Cannot be Blank",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                Global_Variables._Url = txtSPApi.Text;
                Global_Variables._Username = txtuser.Text;
                Global_Variables._Password = txtpass.Text;
                return true;
            }
        }
        private void GetList()
        {
            if (checkNull())
            {
                btnGetList.Enabled = false;
                ClientContext context = new ClientContext(Global_Variables._Url);
                SecureString passWord = new SecureString();
                foreach (char c in Global_Variables._Password.ToCharArray()) passWord.AppendChar(c);
                context.Credentials = new SharePointOnlineCredentials(Global_Variables._Username, passWord);
                // Assume the web has a list named "Announcements".
                var collList = context.Web.Lists;
                context.Load(
                    collList,
                    lists => lists.Where(
                        list => list.Hidden == false).Include(
                        list => list.Title));
                context.ExecuteQuery();
                Global_Variables.ListTitle = collList;
                List<ListItemSharepoint> ListItemView = new List<ListItemSharepoint>();
                foreach (List oList in context.Web.Lists)
                {
                    ListItemSharepoint obj = new ListItemSharepoint();
                    obj.Name = oList.Title;
                    obj.Value = oList.Title;
                    ListItemView.Add(obj);
                }
                cbListItem.DataSource = ListItemView;
                cbListItem.DisplayMember = "Name";
                cbListItem.ValueMember = "Value";
                //cbListItem.DisplayMember = Global_Variables._TitleList;
                //cbListItem.ValueMember = Global_Variables._TitleList;
                btnGetList.Enabled = true;

            }
        }

        private void cbListItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cmb = (ComboBox)sender;
            Global_Variables._TitleList = cmb.SelectedValue.ToString();
        }
    }

}
