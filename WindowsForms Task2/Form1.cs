using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_Task2
{
    public partial class Form1 : Form
    {
        private readonly Label label = new Label
        {
            Visible = false,
            AutoSize = true,
            BackColor = Color.White,
            ForeColor = Color.Red
        };

        private bool _isInvisible = true;
        private bool _isUpdating = false;
        private string _currentUserName = default;
        private bool _isDefaultValuesSet = false;
        public Form1()
        {
            InitializeComponent();
            PageGrpBx.Controls.Add(label);            

            BackColor = ColorTranslator.FromHtml("#f0f2f5");
            ConnectLbl.BackColor = ColorTranslator.FromHtml("#f0f2f5");
            ConnectLbl.Font = new Font("SFProDisplay-Regular, Helvetica, Arial, sans-serif", 10, FontStyle.Regular);

            CreatePageLnkLbl.LinkColor = ColorTranslator.FromHtml("#1c1e21");            
            CreatePageLnkLbl.Font = new Font("SFProText-Semibold, Helvetica, Arial, sans-serif", 8, FontStyle.Bold);
            CreatePageLnkLbl.LinkBehavior = LinkBehavior.NeverUnderline;

            HelperLbl.ForeColor = ColorTranslator.FromHtml("#1c1e21");
            HelperLbl.Font = new Font("SFProText - Semibold, Helvetica, Arial, sans - serif", 8, FontStyle.Regular);

            UsernameLbl.Font = new Font("inherit", 10, FontStyle.Regular);
            PasswordLbl.Font = new Font("inherit", 10, FontStyle.Regular);
            GenderLbl.Font = new Font("inherit", 10, FontStyle.Regular);
            BirthDayLbl.Font = new Font("inherit", 10, FontStyle.Regular);

            LoginBtn.BackColor = ColorTranslator.FromHtml("#1877f2");
            LoginBtn.Font = new Font("inherit", 10, FontStyle.Regular);

            ForgotPassLbl.ForeColor = ColorTranslator.FromHtml("#1877f2");
            ForgotPassLbl.Font = new Font("inherit", 7, FontStyle.Regular);

            UpdateBtn.Font = new Font("inherit", 10, FontStyle.Regular);
            UpdateBtn.BackColor = ColorTranslator.FromHtml("#36a420");

            DescriptionLbl.Font = new Font("inherit", 10, FontStyle.Regular);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }        

        private void SetDefaultValuesForTextBoxes()
        {
            _isDefaultValuesSet = true;
            UsernameTxtBx.Text = "";
            PasswordTxtBx.Text = "";
            BirthDayPicker.Value = DateTime.Now;
            DescriptionRchTxtBx.Text = "";

            if (MaleRdBtn.Checked)
                MaleRdBtn.Checked = false;

            if (FemaleRdBtn.Checked)
                FemaleRdBtn.Checked = false;


        }

        private void ShowLabelInfo(Point point, string message)
        {            
            label.Visible = true;
            label.Location = point;
            label.Text = message;
        }
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            label.ForeColor = Color.Red;            
            if (Verify.IsUsernameExist(UsernameTxtBx.Text) && !_isUpdating || (_isUpdating && UsernameTxtBx.Text != _currentUserName 
                && Verify.IsUsernameExist(UsernameTxtBx.Text)))
            {
                ShowLabelInfo(new Point(135, 57), "* This User Name already exist.");
            }
            else
            {
                if (string.IsNullOrWhiteSpace(UsernameTxtBx.Text))
                {
                    ShowLabelInfo(new Point(135, 57), "* Username is null or white space.");
                }
                else if (string.IsNullOrWhiteSpace(PasswordTxtBx.Text))
                {
                    ShowLabelInfo(new Point(135, 92), "* Password is null or white space.");
                }
                else if (MaleRdBtn.Checked == false && FemaleRdBtn.Checked == false)
                {
                    ShowLabelInfo(new Point(153, 135), "* Choose one of this options.");
                }
                else if (DateTime.Now.Year - BirthDayPicker.Value.Year < 18)
                {
                    ShowLabelInfo(new Point(82, 185), "* Birthday must be more than 17.");
                }
                else
                {
                    if(_isUpdating)
                    {
                        _isUpdating = false;
                        if(_currentUserName != UsernameTxtBx.Text)
                        {
                            File.Delete($"Database/{_currentUserName}.json");
                        }
                        UpdateBtn.Visible = true;
                        ForgotPassLbl.Visible = true;
                    }

                    label.Visible = false;
                    string gender = (MaleRdBtn.Checked) ? "Male" : "Female";
                    User user = new User(UsernameTxtBx.Text, PasswordTxtBx.Text.GetHashCode().ToString(), gender, BirthDayPicker.Value, DescriptionRchTxtBx.Text);
                    SetDefaultValuesForTextBoxes();
                    JsonFileHelper.JSONSerialization(user);

                    MessageBox.Show("Operation Successfully done", "Facebook ©");

                    LoginBtn.Text = "Log In";
                    LoginBtn.BackColor = ColorTranslator.FromHtml("#1877f2");
                    
                    SetPasswordInvisible();

                }

            }


        }

        private void SetUserDatasToTextBoxes(User user)
        {
            UsernameTxtBx.Text = user.Username;            
            BirthDayPicker.Value = user.BirthDay;
            DescriptionRchTxtBx.Text = user.Description;

            if(user.Gender == "Male")            
                MaleRdBtn.Checked = true;
            else            
                FemaleRdBtn.Checked = true;
        }
        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            label.ForeColor = Color.Red;
            label.Visible = false;
            if(Verify.IsUsernameExist(UsernameTxtBx.Text))
            {
                User user = null;
                JsonFileHelper.JSONDeSerialization(ref user, $"Database/{UsernameTxtBx.Text}.json");

                if (PasswordTxtBx.Text.GetHashCode().ToString() != user.Password)
                {
                    SetDefaultValuesForTextBoxes();
                    MessageBox.Show("Incorrect Credentials!");
                }
                else
                {
                    UpdateBtn.Visible = false;
                    ForgotPassLbl.Visible = false;
                    LoginBtn.BackColor = ColorTranslator.FromHtml("#36a420");
                    LoginBtn.Text = "Save";

                    _isUpdating = true;
                    _currentUserName = user.Username;
                    SetUserDatasToTextBoxes(user);
                }
            }
            else
            {
                SetDefaultValuesForTextBoxes();
                MessageBox.Show("Incorrect Credentials Follow this Steps => (You must enter your username and password to continue updating)", "Facebook", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }

        }

        private void UsernameTxtBx_TextChanged(object sender, EventArgs e)
        {
        }

        private void SetPasswordInvisible()
        {
            InvisibleEyeLbl.Image = new Bitmap("../../Photos/invisible eye.png");
            PasswordTxtBx.PasswordChar = '*';
            _isInvisible = true;
        }

        private void SetPasswordVisible()
        {
            InvisibleEyeLbl.Image = new Bitmap("../../Photos/visible eye.png");
            PasswordTxtBx.PasswordChar = default;
            _isInvisible = false;
        }
        private void InvisibleEyeLbl_Click(object sender, EventArgs e)
        {
            if(_isInvisible)
            {
                SetPasswordVisible();
            }
            else
            {
                SetPasswordInvisible();
            }

        }

        private void CreatePageLnkLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/");
        }

        private void CreatePageLnkLbl_MouseHover(object sender, EventArgs e)
        {
            CreatePageLnkLbl.LinkBehavior = LinkBehavior.HoverUnderline;
        }

        private void PasswordTxtBx_Enter(object sender, EventArgs e)
        {
            if((!_isDefaultValuesSet) && (!_isUpdating))
            {
                if (PasswordTxtBx.Text.Length < 8)
                {
                    label.ForeColor = Color.Red;
                    ShowLabelInfo(new Point(135, 92), "Password is weak.");
                }
                else if (PasswordTxtBx.Text.Length >= 8 && PasswordTxtBx.Text.Length < 12)
                {
                    label.ForeColor = ColorTranslator.FromHtml("#CC5803");                    
                    ShowLabelInfo(new Point(135, 92), "Password is normal.");
                }
                else
                {
                    label.ForeColor = Color.Green;
                    ShowLabelInfo(new Point(135, 92), "Password is strong.");
                }
            }
            _isDefaultValuesSet = false;
        }           

    }
}
