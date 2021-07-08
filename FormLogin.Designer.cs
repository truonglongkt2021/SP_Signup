
namespace SP_Signup
{
    partial class FormLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grAcc = new System.Windows.Forms.GroupBox();
            this.txtSPApi = new System.Windows.Forms.TextBox();
            this.btnclose = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbListItem = new System.Windows.Forms.ComboBox();
            this.btnGetList = new System.Windows.Forms.Button();
            this.grAcc.SuspendLayout();
            this.SuspendLayout();
            // 
            // grAcc
            // 
            this.grAcc.BackColor = System.Drawing.SystemColors.Info;
            this.grAcc.Controls.Add(this.btnGetList);
            this.grAcc.Controls.Add(this.cbListItem);
            this.grAcc.Controls.Add(this.label3);
            this.grAcc.Controls.Add(this.txtSPApi);
            this.grAcc.Controls.Add(this.btnclose);
            this.grAcc.Controls.Add(this.label2);
            this.grAcc.Controls.Add(this.btnLogin);
            this.grAcc.Controls.Add(this.txtpass);
            this.grAcc.Controls.Add(this.txtuser);
            this.grAcc.Controls.Add(this.label1);
            this.grAcc.Controls.Add(this.label6);
            this.grAcc.Location = new System.Drawing.Point(11, 11);
            this.grAcc.Margin = new System.Windows.Forms.Padding(2);
            this.grAcc.Name = "grAcc";
            this.grAcc.Padding = new System.Windows.Forms.Padding(2);
            this.grAcc.Size = new System.Drawing.Size(637, 216);
            this.grAcc.TabIndex = 30;
            this.grAcc.TabStop = false;
            this.grAcc.Text = "Your Account";
            this.grAcc.Enter += new System.EventHandler(this.grAcc_Enter);
            // 
            // txtSPApi
            // 
            this.txtSPApi.Location = new System.Drawing.Point(146, 41);
            this.txtSPApi.Margin = new System.Windows.Forms.Padding(2);
            this.txtSPApi.Name = "txtSPApi";
            this.txtSPApi.Size = new System.Drawing.Size(195, 20);
            this.txtSPApi.TabIndex = 13;
            this.txtSPApi.Text = "https://datadesign.sharepoint.com/sites/WSS-TEST";
            // 
            // btnclose
            // 
            this.btnclose.Location = new System.Drawing.Point(445, 163);
            this.btnclose.Margin = new System.Windows.Forms.Padding(2);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(82, 33);
            this.btnclose.TabIndex = 12;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "SharePoint API URL";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Enabled = false;
            this.btnLogin.Location = new System.Drawing.Point(531, 163);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(82, 33);
            this.btnLogin.TabIndex = 9;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(146, 123);
            this.txtpass.Margin = new System.Windows.Forms.Padding(2);
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = '*';
            this.txtpass.Size = new System.Drawing.Size(195, 20);
            this.txtpass.TabIndex = 8;
            this.txtpass.Text = "zaq@1234";
            // 
            // txtuser
            // 
            this.txtuser.Location = new System.Drawing.Point(146, 82);
            this.txtuser.Margin = new System.Windows.Forms.Padding(2);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(195, 20);
            this.txtuser.TabIndex = 7;
            this.txtuser.Text = "truonglong@datadesign.vn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 126);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 85);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Email Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(359, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "List Item";
            // 
            // cbListItem
            // 
            this.cbListItem.FormattingEnabled = true;
            this.cbListItem.Location = new System.Drawing.Point(411, 44);
            this.cbListItem.Name = "cbListItem";
            this.cbListItem.Size = new System.Drawing.Size(202, 21);
            this.cbListItem.TabIndex = 15;
            this.cbListItem.SelectedIndexChanged += new System.EventHandler(this.cbListItem_SelectedIndexChanged);
            // 
            // btnGetList
            // 
            this.btnGetList.Location = new System.Drawing.Point(411, 82);
            this.btnGetList.Name = "btnGetList";
            this.btnGetList.Size = new System.Drawing.Size(202, 26);
            this.btnGetList.TabIndex = 16;
            this.btnGetList.Text = "Get List";
            this.btnGetList.UseVisualStyleBackColor = true;
            this.btnGetList.Click += new System.EventHandler(this.btnGetList_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 238);
            this.Controls.Add(this.grAcc);
            this.Name = "FormLogin";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grAcc.ResumeLayout(false);
            this.grAcc.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grAcc;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSPApi;
        private System.Windows.Forms.Button btnGetList;
        private System.Windows.Forms.ComboBox cbListItem;
        private System.Windows.Forms.Label label3;
    }
}

