using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SP_Signup
{
    public partial class DetailItem : Form
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
        }
        public void GetItemDetail()
        {
            
        }
    }
}
