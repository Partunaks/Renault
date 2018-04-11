namespace MessageSender
{
    partial class AnalysisApp
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnalysisApp));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.GetData = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.UserName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.IPN1 = new System.Windows.Forms.TextBox();
            this.PCModel = new System.Windows.Forms.TextBox();
            this.SerialNum1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PCName1 = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Accept = new System.Windows.Forms.Button();
            this.FindPC = new System.Windows.Forms.Button();
            this.IPN2 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.Room = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Building = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.PCModel2 = new System.Windows.Forms.TextBox();
            this.SerialNum2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.PCName2 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.emailbox = new System.Windows.Forms.ComboBox();
            this.StatusBox = new System.Windows.Forms.ComboBox();
            this.SendMsg = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(523, 498);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.emailbox);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.pictureBox2);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.UserName);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.IPN1);
            this.tabPage1.Controls.Add(this.PCModel);
            this.tabPage1.Controls.Add(this.SerialNum1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.PCName1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(515, 472);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Оформление пропуска";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(245, 250);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(267, 219);
            this.pictureBox2.TabIndex = 25;
            this.pictureBox2.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SendMsg);
            this.groupBox2.Controls.Add(this.GetData);
            this.groupBox2.Location = new System.Drawing.Point(304, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            // 
            // GetData
            // 
            this.GetData.Location = new System.Drawing.Point(28, 19);
            this.GetData.Name = "GetData";
            this.GetData.Size = new System.Drawing.Size(150, 23);
            this.GetData.TabIndex = 13;
            this.GetData.Text = "Получить данные";
            this.GetData.UseVisualStyleBackColor = true;
            this.GetData.Click += new System.EventHandler(this.GetData_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Ф.И пользователя:";
            // 
            // UserName
            // 
            this.UserName.Location = new System.Drawing.Point(13, 164);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(183, 20);
            this.UserName.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 342);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "IPN пользователя:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Модель компьютера:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Серийный номер:";
            // 
            // IPN1
            // 
            this.IPN1.Location = new System.Drawing.Point(13, 358);
            this.IPN1.Name = "IPN1";
            this.IPN1.ReadOnly = true;
            this.IPN1.Size = new System.Drawing.Size(157, 20);
            this.IPN1.TabIndex = 17;
            // 
            // PCModel
            // 
            this.PCModel.Location = new System.Drawing.Point(13, 294);
            this.PCModel.Name = "PCModel";
            this.PCModel.ReadOnly = true;
            this.PCModel.Size = new System.Drawing.Size(226, 20);
            this.PCModel.TabIndex = 16;
            // 
            // SerialNum1
            // 
            this.SerialNum1.Location = new System.Drawing.Point(13, 233);
            this.SerialNum1.Name = "SerialNum1";
            this.SerialNum1.ReadOnly = true;
            this.SerialNum1.Size = new System.Drawing.Size(157, 20);
            this.SerialNum1.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Имя ПК:";
            // 
            // PCName1
            // 
            this.PCName1.Location = new System.Drawing.Point(13, 31);
            this.PCName1.Name = "PCName1";
            this.PCName1.Size = new System.Drawing.Size(183, 20);
            this.PCName1.TabIndex = 12;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.StatusBox);
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.IPN2);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.Room);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.Building);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.PCModel2);
            this.tabPage2.Controls.Add(this.SerialNum2);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.PCName2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(515, 472);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Привязка/Отвязка";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(246, 248);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(258, 216);
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Accept);
            this.groupBox1.Controls.Add(this.FindPC);
            this.groupBox1.Location = new System.Drawing.Point(304, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            // 
            // Accept
            // 
            this.Accept.Enabled = false;
            this.Accept.Location = new System.Drawing.Point(25, 67);
            this.Accept.Name = "Accept";
            this.Accept.Size = new System.Drawing.Size(151, 23);
            this.Accept.TabIndex = 31;
            this.Accept.Text = "Принять изменения";
            this.Accept.UseVisualStyleBackColor = true;
            this.Accept.Click += new System.EventHandler(this.Accept_Click);
            // 
            // FindPC
            // 
            this.FindPC.Location = new System.Drawing.Point(25, 22);
            this.FindPC.Name = "FindPC";
            this.FindPC.Size = new System.Drawing.Size(151, 23);
            this.FindPC.TabIndex = 30;
            this.FindPC.Text = "Найти компьютер";
            this.FindPC.UseVisualStyleBackColor = true;
            this.FindPC.Click += new System.EventHandler(this.FindPC_Click);
            // 
            // IPN2
            // 
            this.IPN2.Location = new System.Drawing.Point(9, 413);
            this.IPN2.Name = "IPN2";
            this.IPN2.Size = new System.Drawing.Size(100, 20);
            this.IPN2.TabIndex = 33;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 397);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(102, 13);
            this.label12.TabIndex = 32;
            this.label12.Text = "IPN рользователя:";
            // 
            // Room
            // 
            this.Room.Location = new System.Drawing.Point(9, 348);
            this.Room.Name = "Room";
            this.Room.Size = new System.Drawing.Size(100, 20);
            this.Room.TabIndex = 29;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 332);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "Комната:";
            // 
            // Building
            // 
            this.Building.Location = new System.Drawing.Point(6, 280);
            this.Building.Name = "Building";
            this.Building.Size = new System.Drawing.Size(100, 20);
            this.Building.TabIndex = 27;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 264);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "Здание:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 197);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Статус:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Модель компьютера:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Серийный номер:";
            // 
            // PCModel2
            // 
            this.PCModel2.Location = new System.Drawing.Point(6, 152);
            this.PCModel2.Name = "PCModel2";
            this.PCModel2.Size = new System.Drawing.Size(238, 20);
            this.PCModel2.TabIndex = 21;
            // 
            // SerialNum2
            // 
            this.SerialNum2.Location = new System.Drawing.Point(6, 91);
            this.SerialNum2.Name = "SerialNum2";
            this.SerialNum2.Size = new System.Drawing.Size(157, 20);
            this.SerialNum2.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Имя компьютера:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // PCName2
            // 
            this.PCName2.Location = new System.Drawing.Point(6, 31);
            this.PCName2.Name = "PCName2";
            this.PCName2.Size = new System.Drawing.Size(104, 20);
            this.PCName2.TabIndex = 0;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(260, 137);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "E-mail:";
            // 
            // emailbox
            // 
            this.emailbox.FormattingEnabled = true;
            this.emailbox.Location = new System.Drawing.Point(263, 163);
            this.emailbox.Name = "emailbox";
            this.emailbox.Size = new System.Drawing.Size(219, 21);
            this.emailbox.TabIndex = 27;
            // 
            // StatusBox
            // 
            this.StatusBox.FormattingEnabled = true;
            this.StatusBox.Location = new System.Drawing.Point(8, 213);
            this.StatusBox.Name = "StatusBox";
            this.StatusBox.Size = new System.Drawing.Size(121, 21);
            this.StatusBox.TabIndex = 37;
            // 
            // SendMsg
            // 
            this.SendMsg.Enabled = false;
            this.SendMsg.Location = new System.Drawing.Point(28, 67);
            this.SendMsg.Name = "SendMsg";
            this.SendMsg.Size = new System.Drawing.Size(150, 23);
            this.SendMsg.TabIndex = 14;
            this.SendMsg.Text = "Отправить сообщение";
            this.SendMsg.UseVisualStyleBackColor = true;
            this.SendMsg.Click += new System.EventHandler(this.SendMsg_Click_1);
            // 
            // AnalysisApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 494);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AnalysisApp";
            this.Text = "AnalysisApp";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox UserName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox IPN1;
        private System.Windows.Forms.TextBox PCModel;
        private System.Windows.Forms.TextBox SerialNum1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button GetData;
        private System.Windows.Forms.TextBox PCName1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox IPN2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button Accept;
        private System.Windows.Forms.Button FindPC;
        private System.Windows.Forms.TextBox Room;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox Building;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox PCModel2;
        private System.Windows.Forms.TextBox SerialNum2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox PCName2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox emailbox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox StatusBox;
        private System.Windows.Forms.Button SendMsg;
    }
}

