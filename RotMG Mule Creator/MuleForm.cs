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
        int i = 0;
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
            catch (Exception ex)
            {
                this.cb_save.Enabled = false;
                this.muleformat.Enabled = false;
                this.open_acc_folder.Enabled = false;
                MessageBox.Show("Failed to create MuleMaker folder, do you run it as Administrator?\nTell it ossimc82:\n\n" + ex.ToString(), "Failed to create folder", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            InitializeComponent();

            this.counter.Text = string.Format("{0} / {1}", i, Convert.ToInt32(amount_box.Value));
            this.progressBar1.Maximum = Convert.ToInt32(amount_box.Value);
        }

        private void create_mules_Click(object sender, EventArgs e)
        {
            this.tb_status.Clear();
            this.progressBar1.Value = 0;
            this.progressBar1.Minimum = 0;
            this.progressBar1.Maximum = Convert.ToInt32(amount_box.Value);
            this.counter.Text = string.Format("{0} / {1}", 0, Convert.ToInt32(amount_box.Value));

            if (Convert.ToInt32(amount_box.Value) >= 500)
            {
                DialogResult drg = MessageBox.Show("This can take a while, do you want continue?", "This will take a while", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (drg == System.Windows.Forms.DialogResult.Yes)
                    CreateMule(Convert.ToInt32(amount_box.Value));
            }
            else
            {
                CreateMule(Convert.ToInt32(amount_box.Value));
            }
        }

        void CreateMule(int count)
        {
            fails = 0;
            success = 0;

            for (i = 1; i <= count; i++)
            {
                this.progressBar1.Increment(1);
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
                        if (cb_save.Checked)
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
                    }
                    else if (status.Contains("<Error>"))
                    {
                        status = status.Replace("<Error>", "");
                        status = status.Replace("</Error>", "");
                        fails++;
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
                tb_status.Text = tb_status.Text + frontMail.Text + i.ToString() + "@" + domain.Text + " - Password: " + password.Text + "   -   " + status + @"
";
                tb_status.Update();
                counter.Text = string.Format("{0} / {1}", i, count);
            }
            MessageBox.Show(string.Format("{0} Mules Successful Created\n{1} Mules failed to create!", success, fails), "Summary!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void open_acc_folder_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\RotMG Mule Maker");
            }
            catch
            {
                MessageBox.Show("Can't open MuleMaker folder", "Failed to open folder", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_about_Click(object sender, EventArgs e)
        {
            new About().Show();
        }

        private void amount_box_ValueChanged(object sender, EventArgs e)
        {
            i = 0;
            this.counter.Text = string.Format("{0} / {1}", i, Convert.ToInt32(amount_box.Value));
        }
    }
}
