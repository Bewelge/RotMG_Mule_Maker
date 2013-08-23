using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Diagnostics;

namespace RotMG_Mule_Creator
{
    public partial class MuleForm : Form
    {
        int i = 1;
        int fails = 0;
        int success = 0;
        string status;

        public MuleForm()
        {
            try
            {
                var dir = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\RotMG Mule Maker";
                if (!System.IO.Directory.Exists(dir))
                {
                    Directory.CreateDirectory(dir);
                }
            }
            catch
            {
                MessageBox.Show("Failed to create MuleMaker folder, do your run it as admin?", "Failed to create folder", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            InitializeComponent();
        }

        private void create_mules_Click(object sender, EventArgs e)
        {
            CreateMule(Convert.ToInt32(amount_box.Value));
        }

        void CreateMule(int count)
        {
            fails = 0;
            success = 0;

            for (i = 1; i <= count; i++)
            {
                try
                {
                    WebRequest webRequest = (WebRequest)WebRequest.Create("https://realmofthemadgod.appspot.com/account/register?guid=DDDDDDDD30A5B289EA856859A8&newGUID=" + frontMail.Text + i + "@" + domain.Text + "&ignore=7915&newPassword=" + password.Text + "&isAgeVerified=1");
                    webRequest.Timeout = 10000;     // 10 secs = 10000 ms
                    WebResponse webResponse = (WebResponse)webRequest.GetResponse();
                    StreamReader responseStream = new StreamReader(webResponse.GetResponseStream());

                    status = responseStream.ReadToEnd();

                    if (status.Contains("<Success/>"))
                    {
                        status = "Success";
                        success++;
                        if (cb_desktop.Checked)
                        {
                            using (System.IO.StreamWriter writer = new System.IO.StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\RotMG Mule Maker\Accounts.txt", true))
                            {
                                writer.WriteLine("[" + DateTime.Now + "]  -  " + frontMail.Text + i.ToString() + "@" + domain.Text + " - Password: " + password.Text + "   -   " + status);
                            }
                        }
                        if (muleformat.Checked)
                        {
                            using (System.IO.StreamWriter writer = new System.IO.StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\RotMG Mule Maker\MuleFormatAccounts.txt", true))
                            {
                                writer.WriteLine("'" + frontMail.Text + i.ToString() + "@" + domain.Text + "': " + "'" + password.Text + "',");
                            }
                        }
                        tb_status.Text = tb_status.Text + frontMail.Text + i.ToString() + "@" + domain.Text + " - Password: " + password.Text + "   -   " + status + @"
";
                    }
                    else if (status.Contains("<Error>"))
                    {
                        fails++;
                        tb_status.Text = tb_status.Text + frontMail.Text + i.ToString() + "@" + domain.Text + " - Password: " + password.Text + "   -   " + status + @"
";
                        using (System.IO.StreamWriter writer = new System.IO.StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\RotMG Mule Maker\AccountErrors.txt", true))
                        {
                            writer.WriteLine("[" + DateTime.Now + "]  -  " + frontMail.Text + i.ToString() + "@" + domain.Text + " - Password: " + password.Text + "   -   " + status);
                        }
                    }
                }
                catch (Exception ex)
                {
                    tb_status.Text = "[" + DateTime.Now + "] " + tb_status.Text + frontMail.Text + i.ToString() + "@" + domain.Text + " - Password: " + password.Text + "   -   " + ex.Message;
                    using (System.IO.StreamWriter writer = new System.IO.StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\RotMG Mule Maker\ErrorLog.txt", true))
                    {
                        writer.WriteLine("[" + DateTime.Now + "]  -  " + frontMail.Text + i.ToString() + "@" + domain.Text + " - Password: " + password.Text + @"   -   
" + ex);
                    }
                }
            }
            MessageBox.Show(string.Format("{0} Mules Successful Created\n{1} Mules failed to create!", success, fails), "Summary!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void open_acc_folder_Click(object sender, EventArgs e)
        {
            var dir = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\RotMG Mule Maker";
            if (!System.IO.Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
            Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\RotMG Mule Maker");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new About().Show();
        }
    }
}
