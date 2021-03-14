
using System.Drawing;

namespace WindowsForms_Task2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ConnectLbl = new System.Windows.Forms.Label();
            this.PageGrpBx = new System.Windows.Forms.GroupBox();
            this.InvisibleEyeLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DescriptionRchTxtBx = new System.Windows.Forms.RichTextBox();
            this.DescriptionLbl = new System.Windows.Forms.Label();
            this.ForgotPassLbl = new System.Windows.Forms.Label();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.BirthDayPicker = new System.Windows.Forms.DateTimePicker();
            this.BirthDayLbl = new System.Windows.Forms.Label();
            this.GenderLbl = new System.Windows.Forms.Label();
            this.PasswordLbl = new System.Windows.Forms.Label();
            this.UsernameLbl = new System.Windows.Forms.Label();
            this.FemaleRdBtn = new System.Windows.Forms.RadioButton();
            this.MaleRdBtn = new System.Windows.Forms.RadioButton();
            this.PasswordTxtBx = new System.Windows.Forms.TextBox();
            this.UsernameTxtBx = new System.Windows.Forms.TextBox();
            this.fbLbl = new System.Windows.Forms.PictureBox();
            this.CreatePageLnkLbl = new System.Windows.Forms.LinkLabel();
            this.HelperLbl = new System.Windows.Forms.Label();
            this.PageGrpBx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fbLbl)).BeginInit();
            this.SuspendLayout();
            // 
            // ConnectLbl
            // 
            this.ConnectLbl.BackColor = System.Drawing.Color.White;
            this.ConnectLbl.Location = new System.Drawing.Point(47, 202);
            this.ConnectLbl.Name = "ConnectLbl";
            this.ConnectLbl.Size = new System.Drawing.Size(254, 44);
            this.ConnectLbl.TabIndex = 6;
            this.ConnectLbl.Text = "Connect with friends and the world around you on Facebook.";
            // 
            // PageGrpBx
            // 
            this.PageGrpBx.BackColor = System.Drawing.Color.White;
            this.PageGrpBx.Controls.Add(this.InvisibleEyeLbl);
            this.PageGrpBx.Controls.Add(this.label1);
            this.PageGrpBx.Controls.Add(this.DescriptionRchTxtBx);
            this.PageGrpBx.Controls.Add(this.DescriptionLbl);
            this.PageGrpBx.Controls.Add(this.ForgotPassLbl);
            this.PageGrpBx.Controls.Add(this.UpdateBtn);
            this.PageGrpBx.Controls.Add(this.LoginBtn);
            this.PageGrpBx.Controls.Add(this.BirthDayPicker);
            this.PageGrpBx.Controls.Add(this.BirthDayLbl);
            this.PageGrpBx.Controls.Add(this.GenderLbl);
            this.PageGrpBx.Controls.Add(this.PasswordLbl);
            this.PageGrpBx.Controls.Add(this.UsernameLbl);
            this.PageGrpBx.Controls.Add(this.FemaleRdBtn);
            this.PageGrpBx.Controls.Add(this.MaleRdBtn);
            this.PageGrpBx.Controls.Add(this.PasswordTxtBx);
            this.PageGrpBx.Controls.Add(this.UsernameTxtBx);
            this.PageGrpBx.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PageGrpBx.Location = new System.Drawing.Point(455, 42);
            this.PageGrpBx.Name = "PageGrpBx";
            this.PageGrpBx.Size = new System.Drawing.Size(320, 396);
            this.PageGrpBx.TabIndex = 7;
            this.PageGrpBx.TabStop = false;
            this.PageGrpBx.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // InvisibleEyeLbl
            // 
            this.InvisibleEyeLbl.Image = global::WindowsForms_Task2.Properties.Resources.invisible_eye;
            this.InvisibleEyeLbl.Location = new System.Drawing.Point(255, 73);
            this.InvisibleEyeLbl.Name = "InvisibleEyeLbl";
            this.InvisibleEyeLbl.Size = new System.Drawing.Size(30, 20);
            this.InvisibleEyeLbl.TabIndex = 17;
            this.InvisibleEyeLbl.Click += new System.EventHandler(this.InvisibleEyeLbl_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Image = global::WindowsForms_Task2.Properties.Resources.invisible_eye;
            this.label1.Location = new System.Drawing.Point(269, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 8;
            // 
            // DescriptionRchTxtBx
            // 
            this.DescriptionRchTxtBx.Location = new System.Drawing.Point(118, 202);
            this.DescriptionRchTxtBx.Name = "DescriptionRchTxtBx";
            this.DescriptionRchTxtBx.Size = new System.Drawing.Size(147, 39);
            this.DescriptionRchTxtBx.TabIndex = 16;
            this.DescriptionRchTxtBx.Text = "";
            // 
            // DescriptionLbl
            // 
            this.DescriptionLbl.AutoSize = true;
            this.DescriptionLbl.Location = new System.Drawing.Point(3, 205);
            this.DescriptionLbl.Name = "DescriptionLbl";
            this.DescriptionLbl.Size = new System.Drawing.Size(60, 13);
            this.DescriptionLbl.TabIndex = 15;
            this.DescriptionLbl.Text = "Description";
            // 
            // ForgotPassLbl
            // 
            this.ForgotPassLbl.AutoSize = true;
            this.ForgotPassLbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForgotPassLbl.Location = new System.Drawing.Point(115, 365);
            this.ForgotPassLbl.Name = "ForgotPassLbl";
            this.ForgotPassLbl.Size = new System.Drawing.Size(95, 13);
            this.ForgotPassLbl.TabIndex = 14;
            this.ForgotPassLbl.Text = "Forgot Password ?";
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.BackColor = System.Drawing.Color.Chartreuse;
            this.UpdateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UpdateBtn.ForeColor = System.Drawing.Color.White;
            this.UpdateBtn.Location = new System.Drawing.Point(21, 313);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(273, 33);
            this.UpdateBtn.TabIndex = 13;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = false;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // LoginBtn
            // 
            this.LoginBtn.BackColor = System.Drawing.Color.LightSeaGreen;
            this.LoginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginBtn.ForeColor = System.Drawing.Color.White;
            this.LoginBtn.Location = new System.Drawing.Point(21, 269);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(273, 38);
            this.LoginBtn.TabIndex = 12;
            this.LoginBtn.Text = "Log In";
            this.LoginBtn.UseVisualStyleBackColor = false;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // BirthDayPicker
            // 
            this.BirthDayPicker.Location = new System.Drawing.Point(85, 162);
            this.BirthDayPicker.MaxDate = new System.DateTime(2021, 12, 31, 0, 0, 0, 0);
            this.BirthDayPicker.MinDate = new System.DateTime(1920, 1, 1, 0, 0, 0, 0);
            this.BirthDayPicker.Name = "BirthDayPicker";
            this.BirthDayPicker.Size = new System.Drawing.Size(200, 20);
            this.BirthDayPicker.TabIndex = 11;
            // 
            // BirthDayLbl
            // 
            this.BirthDayLbl.AutoSize = true;
            this.BirthDayLbl.Location = new System.Drawing.Point(3, 162);
            this.BirthDayLbl.Name = "BirthDayLbl";
            this.BirthDayLbl.Size = new System.Drawing.Size(50, 13);
            this.BirthDayLbl.TabIndex = 10;
            this.BirthDayLbl.Text = "Birth Day";
            // 
            // GenderLbl
            // 
            this.GenderLbl.AutoSize = true;
            this.GenderLbl.Location = new System.Drawing.Point(3, 115);
            this.GenderLbl.Name = "GenderLbl";
            this.GenderLbl.Size = new System.Drawing.Size(42, 13);
            this.GenderLbl.TabIndex = 9;
            this.GenderLbl.Text = "Gender";
            // 
            // PasswordLbl
            // 
            this.PasswordLbl.AutoSize = true;
            this.PasswordLbl.Location = new System.Drawing.Point(3, 73);
            this.PasswordLbl.Name = "PasswordLbl";
            this.PasswordLbl.Size = new System.Drawing.Size(53, 13);
            this.PasswordLbl.TabIndex = 7;
            this.PasswordLbl.Text = "Password";
            // 
            // UsernameLbl
            // 
            this.UsernameLbl.AutoSize = true;
            this.UsernameLbl.Location = new System.Drawing.Point(3, 34);
            this.UsernameLbl.Name = "UsernameLbl";
            this.UsernameLbl.Size = new System.Drawing.Size(60, 13);
            this.UsernameLbl.TabIndex = 6;
            this.UsernameLbl.Text = "User Name";
            // 
            // FemaleRdBtn
            // 
            this.FemaleRdBtn.AutoSize = true;
            this.FemaleRdBtn.Location = new System.Drawing.Point(190, 115);
            this.FemaleRdBtn.Name = "FemaleRdBtn";
            this.FemaleRdBtn.Size = new System.Drawing.Size(59, 17);
            this.FemaleRdBtn.TabIndex = 5;
            this.FemaleRdBtn.TabStop = true;
            this.FemaleRdBtn.Text = "Female";
            this.FemaleRdBtn.UseVisualStyleBackColor = true;
            // 
            // MaleRdBtn
            // 
            this.MaleRdBtn.AutoSize = true;
            this.MaleRdBtn.Location = new System.Drawing.Point(136, 115);
            this.MaleRdBtn.Name = "MaleRdBtn";
            this.MaleRdBtn.Size = new System.Drawing.Size(48, 17);
            this.MaleRdBtn.TabIndex = 4;
            this.MaleRdBtn.TabStop = true;
            this.MaleRdBtn.Text = "Male";
            this.MaleRdBtn.UseVisualStyleBackColor = true;
            // 
            // PasswordTxtBx
            // 
            this.PasswordTxtBx.Location = new System.Drawing.Point(136, 73);
            this.PasswordTxtBx.MaxLength = 200;
            this.PasswordTxtBx.Name = "PasswordTxtBx";
            this.PasswordTxtBx.PasswordChar = '*';
            this.PasswordTxtBx.Size = new System.Drawing.Size(113, 20);
            this.PasswordTxtBx.TabIndex = 1;
            this.PasswordTxtBx.TextChanged += new System.EventHandler(this.PasswordTxtBx_Enter);
            // 
            // UsernameTxtBx
            // 
            this.UsernameTxtBx.Location = new System.Drawing.Point(136, 34);
            this.UsernameTxtBx.MaxLength = 200;
            this.UsernameTxtBx.Name = "UsernameTxtBx";
            this.UsernameTxtBx.Size = new System.Drawing.Size(113, 20);
            this.UsernameTxtBx.TabIndex = 0;
            this.UsernameTxtBx.TextChanged += new System.EventHandler(this.UsernameTxtBx_TextChanged);
            // 
            // fbLbl
            // 
            this.fbLbl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fbLbl.Image = ((System.Drawing.Image)(resources.GetObject("fbLbl.Image")));
            this.fbLbl.Location = new System.Drawing.Point(35, 134);
            this.fbLbl.Name = "fbLbl";
            this.fbLbl.Padding = new System.Windows.Forms.Padding(2, 5, 10, 0);
            this.fbLbl.Size = new System.Drawing.Size(254, 65);
            this.fbLbl.TabIndex = 4;
            this.fbLbl.TabStop = false;
            // 
            // CreatePageLnkLbl
            // 
            this.CreatePageLnkLbl.AutoSize = true;
            this.CreatePageLnkLbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CreatePageLnkLbl.Location = new System.Drawing.Point(497, 451);
            this.CreatePageLnkLbl.Name = "CreatePageLnkLbl";
            this.CreatePageLnkLbl.Size = new System.Drawing.Size(75, 13);
            this.CreatePageLnkLbl.TabIndex = 18;
            this.CreatePageLnkLbl.TabStop = true;
            this.CreatePageLnkLbl.Text = "Create a Page";
            this.CreatePageLnkLbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CreatePageLnkLbl_LinkClicked);
            this.CreatePageLnkLbl.MouseHover += new System.EventHandler(this.CreatePageLnkLbl_MouseHover);
            // 
            // HelperLbl
            // 
            this.HelperLbl.AutoSize = true;
            this.HelperLbl.Location = new System.Drawing.Point(583, 451);
            this.HelperLbl.Name = "HelperLbl";
            this.HelperLbl.Size = new System.Drawing.Size(159, 13);
            this.HelperLbl.TabIndex = 19;
            this.HelperLbl.Text = "for a celebrity, band or business.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 473);
            this.Controls.Add(this.HelperLbl);
            this.Controls.Add(this.CreatePageLnkLbl);
            this.Controls.Add(this.PageGrpBx);
            this.Controls.Add(this.ConnectLbl);
            this.Controls.Add(this.fbLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Facebook";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PageGrpBx.ResumeLayout(false);
            this.PageGrpBx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fbLbl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox fbLbl;
        private System.Windows.Forms.Label ConnectLbl;
        private System.Windows.Forms.GroupBox PageGrpBx;
        private System.Windows.Forms.TextBox PasswordTxtBx;
        private System.Windows.Forms.TextBox UsernameTxtBx;
        private System.Windows.Forms.Label GenderLbl;
        private System.Windows.Forms.Label PasswordLbl;
        private System.Windows.Forms.Label UsernameLbl;
        private System.Windows.Forms.RadioButton FemaleRdBtn;
        private System.Windows.Forms.RadioButton MaleRdBtn;
        private System.Windows.Forms.DateTimePicker BirthDayPicker;
        private System.Windows.Forms.Label BirthDayLbl;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.Label ForgotPassLbl;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.RichTextBox DescriptionRchTxtBx;
        private System.Windows.Forms.Label DescriptionLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label InvisibleEyeLbl;
        private System.Windows.Forms.LinkLabel CreatePageLnkLbl;
        private System.Windows.Forms.Label HelperLbl;
    }
}

