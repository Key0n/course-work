using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Compression;
using System.Security;

namespace CPZ
{
    public partial class LoginForm : Form
    {
        LoginType _type;
        bool _showPassword = false;

        internal LoginForm(LoginType type, FormWindowState state = FormWindowState.Normal)
        {
            InitializeComponent();

            if (state == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = state;
            }

            _type = type;
        }

        private void Login()
        {
            if ((!string.IsNullOrEmpty(txtPassword.Text)) && (File.Exists(Required.Serial)))
            {
                string hashed = Encryption.HashKey(txtPassword.Text);
                string stored = File.ReadAllText(Required.Serial);

                if (hashed == stored)
                {
                    switch (_type)
                    {
                        case LoginType.Login:
                            Program.SetMainForm(new MainForm(Encryption.ToSecureString(txtPassword.Text)));
                            this.Close();
                            Program.ShowMainForm();
                            break;

                        case LoginType.Authorize:
                            this.DialogResult = DialogResult.Yes;
                            this.Close();
                            break;

                        case LoginType.Remove:
                            this.DialogResult = DialogResult.Yes;
                            this.Close();
                            break;
                    }

                    txtPassword.Text = string.Empty;
                    hashed = string.Empty;
                    stored = string.Empty;
                }
                else
                {
                    MessageBox.Show("The password you provided is incorrect!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (_showPassword)
            {
                txtPassword.UseSystemPasswordChar = true;
                _showPassword = false;
                return;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = false;
                _showPassword = true;
                return;
            }
        }
    }
}
