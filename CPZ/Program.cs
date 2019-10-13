using System;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace CPZ
{
    static class Program
    {

        static ApplicationContext _mainContext = new ApplicationContext();

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            if (!Directory.Exists(Required.DataFolder))
            {
                Required.Deploy();
            }

            if (!File.Exists(Required.Serial))
            {
                _mainContext.MainForm = new WizardForm();
            }
            else
            {
                _mainContext.MainForm = new LoginForm(LoginType.Login);
            }
            
            Application.Run(_mainContext);
        }
        private static void form_FormClosed(object sender, FormClosedEventArgs e)
        {
            SaveSettings();
        }
        internal static void SaveSettings()
        {
            MemoryStream ms = new MemoryStream();
            BinaryFormatter bf = new BinaryFormatter();

            bf.Serialize(ms, MainForm.Accounts);
            byte[] bytes = ms.ToArray();

            try
            {
                File.WriteAllBytes(Required.Data, bytes);
            }
            finally
            {
                bytes = null;
                ms = null;
            }
        }

        internal static void SetMainForm(Form form)
        {
            _mainContext.MainForm = form;
        }

        internal static void ShowMainForm()
        {
            _mainContext.MainForm.Show();
        }

    }
}
