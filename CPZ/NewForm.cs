using System;
using System.Windows.Forms;

namespace CPZ
{
    public partial class NewForm : Form
    {
        Encryption encrypt = new Encryption();

        NewType _type;
        string _name;

        bool _showPassword = false;

        internal NewForm(NewType type, string info = null)
        {
            InitializeComponent();
            _type = type;
            _name = info;

            switch (_type)
            {
                case NewType.Modify:
                    btnOk.Text = "Сохранить";
                    if (!string.IsNullOrEmpty(info))
                    {
                        this.Text = string.Format("Изменить аккаунт - {0}", info);
                    }
                    else
                    {
                        this.Text = "Добавить новый аккаунт...";
                    }
                    
                    int i = MainForm.Accounts.FindIndex(x => x.Name() == encrypt.Encrypt(Encryption.ToInsecureString(MainForm.Key), _name));
                    
                    if (i > -1)
                    {
                        txtName.Text = encrypt.Decrypt(Encryption.ToInsecureString(MainForm.Key), MainForm.Accounts[i].Name());
                        txtMail.Text = encrypt.Decrypt(Encryption.ToInsecureString(MainForm.Key), MainForm.Accounts[i].Email());
                        txtPassword.Text = encrypt.Decrypt(Encryption.ToInsecureString(MainForm.Key), MainForm.Accounts[i].Password());
                        txtNote.Text = encrypt.Decrypt(Encryption.ToInsecureString(MainForm.Key), MainForm.Accounts[i].Note());
                    }

                    break;
            }
        }

        private void Save()
        {
            if (!string.IsNullOrEmpty(txtName.Text) && !string.IsNullOrEmpty(txtMail.Text) && !string.IsNullOrEmpty(txtPassword.Text))
            {
                switch (_type)
                {
                    case NewType.Modify:
                        int i = MainForm.Accounts.FindIndex(x => x.Name() == encrypt.Encrypt(Encryption.ToInsecureString(MainForm.Key), _name));
                        if (i > -1) { MainForm.Accounts.RemoveAt(i); }
                        break;
                }

                Account account = new Account(encrypt.Encrypt(Encryption.ToInsecureString(MainForm.Key), txtName.Text), encrypt.Encrypt(Encryption.ToInsecureString(MainForm.Key), txtMail.Text), encrypt.Encrypt(Encryption.ToInsecureString(MainForm.Key), txtPassword.Text), encrypt.Encrypt(Encryption.ToInsecureString(MainForm.Key), txtNote.Text));
                MainForm.Accounts.Add(account);

                txtName.Text = string.Empty;
                txtMail.Text = string.Empty;
                txtPassword.Text = string.Empty;
                txtNote.Text = string.Empty;
                account = null;

                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NewForm_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Save();
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

        private void button1_Click(object sender, EventArgs e)
        {
            txtPassword.Text = Encryption.GenerateRandomPassword(32);
        }

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Save();
            }
        }
    }
}
