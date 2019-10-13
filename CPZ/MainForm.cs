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
using System.Runtime.Serialization.Formatters.Binary;
using System.Security;
using System.Net;
using System.Diagnostics;

namespace CPZ
{
    public partial class MainForm : Form
    {
        bool IsDialogOpen = false;

        internal static List<Account> Accounts = new List<Account>();
        internal static SecureString Key;

        Encryption _encrypt = new Encryption();

        string _temp = string.Empty;
        string _term = string.Empty;

        public MainForm(SecureString key)
        {
            InitializeComponent();

            DeserializeAccounts();
            Key = key;
            this.Text = string.Format("[{0} аккаунтов]", Accounts.Count);
        }

        private void Search()
        {
            if (string.IsNullOrEmpty(txtSearch.Text))
            {
                LoadAccounts();
            }
            else
            {
                _term = txtSearch.Text.Trim().ToLowerInvariant();
                AccountView.Nodes.Clear();
                foreach (Account la in Accounts)
                {
                    _temp = _encrypt.Decrypt(Encryption.ToInsecureString(Key), la.Name());
                    if (_temp.ToLowerInvariant().Contains(_term))
                    {
                        TreeNode node = new TreeNode(_encrypt.Decrypt(Encryption.ToInsecureString(Key), la.Name()));
                        node.Nodes.Add("Логин: ");
                        node.Nodes.Add("Пароль: ");
                        AccountView.Nodes.Add(node);
                    }
                }
            }
        }
        private void Modify()
        {
            if (AccountView.SelectedNode != null)
            {
                if (Authorize(LoginType.Authorize, true))
                {
                    if (AccountView.SelectedNode.Parent == null)
                    {
                        NewForm f = new NewForm(NewType.Modify, AccountView.SelectedNode.Text);
                        IsDialogOpen = true;
                        f.ShowDialog();
                        IsDialogOpen = false;
                    }
                    else
                    {
                        NewForm f = new NewForm(NewType.Modify, AccountView.SelectedNode.Parent.Text);
                        IsDialogOpen = true;
                        f.ShowDialog();
                        IsDialogOpen = false;
                    }

                    LoadAccounts();
                    Program.SaveSettings();
                }
            }
        }

        private bool Authorize(LoginType type, bool simple = false)
        {
            bool result = false;

            if (simple)
            {
                return true;
            }

            IsDialogOpen = true;
            DialogResult dr = MessageBox.Show("Вы уверены что хотите сделать это?", "Удалить аккаунт?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            IsDialogOpen = false;

            if (dr == DialogResult.Yes)
            {
                result = true;
            }
            else
            {
                result = false;
            }

            return result;
        }

        private void Remove()
        {
            if (AccountView.SelectedNode != null)
            {
                if (Authorize(LoginType.Remove))
                {
                    string name = string.Empty;

                    if (AccountView.SelectedNode.Parent == null)
                    {
                        name = AccountView.SelectedNode.Text;
                    }
                    else
                    {
                        name = AccountView.SelectedNode.Parent.Text;
                    }

                    int i = Accounts.FindIndex(x => x.Name() == _encrypt.Encrypt(Encryption.ToInsecureString(Key), name));
                    if (i > -1) { Accounts.RemoveAt(i); }

                    LoadAccounts();
                }
            }
        }

        private void DeserializeAccounts()
        {
            try
            {
                if (File.Exists(Required.Data))
                {
                    byte[] bytes = File.ReadAllBytes(Required.Data);

                    MemoryStream ms = new MemoryStream(bytes);
                    BinaryFormatter bf = new BinaryFormatter();

                    Accounts = (List<Account>)bf.Deserialize(ms);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadAccounts()
        {
            AccountView.Nodes.Clear();

            foreach (Account x in Accounts)
            {
                TreeNode node = new TreeNode(_encrypt.Decrypt(Encryption.ToInsecureString(Key), x.Name()));
                node.Nodes.Add("Логин: ");
                node.Nodes.Add("Пароль: ");
                AccountView.Nodes.Add(node);
            }

            txtSearch.Clear();
            this.Text = string.Format("Пароли [{0} аккаунтов]", Accounts.Count);

            AccountView.Sort();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            LoadAccounts();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            NewForm f = new NewForm(NewType.New);
            IsDialogOpen = true;
            f.ShowDialog(this);
            IsDialogOpen = false;
            LoadAccounts();

            Program.SaveSettings();
        }

        private void AccountView_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            if (Authorize(LoginType.Authorize, true))
            {
                Account account = Accounts.Find(x => x.Name() == _encrypt.Encrypt(Encryption.ToInsecureString(Key), e.Node.Text));

                if (account != null)
                {
                    e.Node.Nodes[0].Text = "Логин: " + _encrypt.Decrypt(Encryption.ToInsecureString(Key), account.Email());
                    e.Node.Nodes[1].Text = "Пароль: " + _encrypt.Decrypt(Encryption.ToInsecureString(Key), account.Password());
                }

                account = null;
                this.Cursor = Cursors.Default;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void AccountView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button.Equals(MouseButtons.Right))
            {
                AccountView.SelectedNode = e.Node;
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            Modify();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            Remove();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Clipboard.Clear();
            }
            catch { }
        }
    }
}
