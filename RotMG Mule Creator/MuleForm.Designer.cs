namespace RotMG_Mule_Creator
{
    partial class MuleForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MuleForm));
            this.create_mules = new System.Windows.Forms.Button();
            this.frontMail = new System.Windows.Forms.TextBox();
            this.domain = new System.Windows.Forms.TextBox();
            this.amount_box = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.tb_status = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_save = new System.Windows.Forms.CheckBox();
            this.muleformat = new System.Windows.Forms.CheckBox();
            this.open_acc_folder = new System.Windows.Forms.Button();
            this.btn_about = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label7 = new System.Windows.Forms.Label();
            this.counter = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.amount_box)).BeginInit();
            this.SuspendLayout();
            // 
            // create_mules
            // 
            this.create_mules.Location = new System.Drawing.Point(12, 406);
            this.create_mules.Name = "create_mules";
            this.create_mules.Size = new System.Drawing.Size(123, 23);
            this.create_mules.TabIndex = 0;
            this.create_mules.TabStop = false;
            this.create_mules.Text = "Create me dat mules!!!";
            this.create_mules.UseVisualStyleBackColor = true;
            this.create_mules.Click += new System.EventHandler(this.create_mules_Click);
            // 
            // frontMail
            // 
            this.frontMail.Location = new System.Drawing.Point(85, 9);
            this.frontMail.Name = "frontMail";
            this.frontMail.Size = new System.Drawing.Size(265, 20);
            this.frontMail.TabIndex = 1;
            this.frontMail.TabStop = false;
            this.frontMail.Text = "MyMule";
            // 
            // domain
            // 
            this.domain.Location = new System.Drawing.Point(85, 34);
            this.domain.Name = "domain";
            this.domain.Size = new System.Drawing.Size(265, 20);
            this.domain.TabIndex = 2;
            this.domain.TabStop = false;
            this.domain.Text = "YourDomain.com";
            // 
            // amount_box
            // 
            this.amount_box.Location = new System.Drawing.Point(416, 61);
            this.amount_box.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.amount_box.Name = "amount_box";
            this.amount_box.Size = new System.Drawing.Size(103, 20);
            this.amount_box.TabIndex = 3;
            this.amount_box.TabStop = false;
            this.amount_box.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.amount_box.ValueChanged += new System.EventHandler(this.amount_box_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(356, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "the \"@\" will be placed automaticly";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "E-Mail Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Domain:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(356, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Amount:";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(85, 60);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(265, 20);
            this.password.TabIndex = 9;
            this.password.TabStop = false;
            this.password.Text = "YourPassword";
            // 
            // tb_status
            // 
            this.tb_status.Location = new System.Drawing.Point(12, 109);
            this.tb_status.Multiline = true;
            this.tb_status.Name = "tb_status";
            this.tb_status.ReadOnly = true;
            this.tb_status.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tb_status.Size = new System.Drawing.Size(507, 291);
            this.tb_status.TabIndex = 10;
            this.tb_status.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Your Mules:";
            // 
            // cb_save
            // 
            this.cb_save.AutoSize = true;
            this.cb_save.Location = new System.Drawing.Point(141, 410);
            this.cb_save.Name = "cb_save";
            this.cb_save.Size = new System.Drawing.Size(95, 17);
            this.cb_save.TabIndex = 13;
            this.cb_save.TabStop = false;
            this.cb_save.Text = "Save in .txt file";
            this.cb_save.UseVisualStyleBackColor = true;
            // 
            // muleformat
            // 
            this.muleformat.AutoSize = true;
            this.muleformat.Location = new System.Drawing.Point(242, 410);
            this.muleformat.Name = "muleformat";
            this.muleformat.Size = new System.Drawing.Size(149, 17);
            this.muleformat.TabIndex = 14;
            this.muleformat.TabStop = false;
            this.muleformat.Text = "Save as Muledump format";
            this.muleformat.UseVisualStyleBackColor = true;
            // 
            // open_acc_folder
            // 
            this.open_acc_folder.Location = new System.Drawing.Point(359, 32);
            this.open_acc_folder.Name = "open_acc_folder";
            this.open_acc_folder.Size = new System.Drawing.Size(160, 23);
            this.open_acc_folder.TabIndex = 15;
            this.open_acc_folder.TabStop = false;
            this.open_acc_folder.Text = "Open Account Folder";
            this.open_acc_folder.UseVisualStyleBackColor = true;
            this.open_acc_folder.Click += new System.EventHandler(this.open_acc_folder_Click);
            // 
            // btn_about
            // 
            this.btn_about.Location = new System.Drawing.Point(444, 406);
            this.btn_about.Name = "btn_about";
            this.btn_about.Size = new System.Drawing.Size(75, 23);
            this.btn_about.TabIndex = 16;
            this.btn_about.TabStop = false;
            this.btn_about.Text = "About";
            this.btn_about.UseVisualStyleBackColor = true;
            this.btn_about.Click += new System.EventHandler(this.btn_about_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(84, 435);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(351, 23);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 438);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "Progress:";
            // 
            // counter
            // 
            this.counter.AutoSize = true;
            this.counter.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.counter.Location = new System.Drawing.Point(441, 440);
            this.counter.Name = "counter";
            this.counter.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.counter.Size = new System.Drawing.Size(44, 13);
            this.counter.TabIndex = 19;
            this.counter.Text = "Counter";
            // 
            // MuleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 463);
            this.Controls.Add(this.counter);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btn_about);
            this.Controls.Add(this.open_acc_folder);
            this.Controls.Add(this.muleformat);
            this.Controls.Add(this.cb_save);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_status);
            this.Controls.Add(this.password);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.amount_box);
            this.Controls.Add(this.domain);
            this.Controls.Add(this.frontMail);
            this.Controls.Add(this.create_mules);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(486, 418);
            this.Name = "MuleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RotMG Mule Maker by ossimc82";
            ((System.ComponentModel.ISupportInitialize)(this.amount_box)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button create_mules;
        private System.Windows.Forms.NumericUpDown amount_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button open_acc_folder;
        private System.Windows.Forms.TextBox tb_status;
        private System.Windows.Forms.TextBox frontMail;
        private System.Windows.Forms.TextBox domain;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.CheckBox cb_save;
        private System.Windows.Forms.CheckBox muleformat;
        private System.Windows.Forms.Button btn_about;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label counter;
    }
}

