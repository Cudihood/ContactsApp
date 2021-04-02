
namespace ContactsAppUI
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddContactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditContactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FindTextBox = new System.Windows.Forms.TextBox();
            this.ContactsListBox = new System.Windows.Forms.ListBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.DateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SurnameTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.NumberTextBox = new System.Windows.Forms.TextBox();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.BirthdayPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.BirthdayTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.BirthdayPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Find:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Margin = new System.Windows.Forms.Padding(3);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(733, 27);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.toolStripMenuItem1.Margin = new System.Windows.Forms.Padding(3);
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(48, 19);
            this.toolStripMenuItem1.Text = "Файл";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Margin = new System.Windows.Forms.Padding(3);
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.exitToolStripMenuItem.Text = "Выход";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddContactToolStripMenuItem,
            this.EditContactToolStripMenuItem,
            this.DeleteToolStripMenuItem});
            this.editToolStripMenuItem.Margin = new System.Windows.Forms.Padding(3);
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(99, 19);
            this.editToolStripMenuItem.Text = "Редактировать";
            // 
            // AddContactToolStripMenuItem
            // 
            this.AddContactToolStripMenuItem.Margin = new System.Windows.Forms.Padding(3);
            this.AddContactToolStripMenuItem.Name = "AddContactToolStripMenuItem";
            this.AddContactToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.AddContactToolStripMenuItem.Text = "Создать новый контакт";
            this.AddContactToolStripMenuItem.Click += new System.EventHandler(this.AddContactToolStripMenuItem_Click);
            // 
            // EditContactToolStripMenuItem
            // 
            this.EditContactToolStripMenuItem.Margin = new System.Windows.Forms.Padding(3);
            this.EditContactToolStripMenuItem.Name = "EditContactToolStripMenuItem";
            this.EditContactToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.EditContactToolStripMenuItem.Text = "Редактировать текущий контакт";
            this.EditContactToolStripMenuItem.Click += new System.EventHandler(this.EditContactToolStripMenuItem_Click);
            // 
            // DeleteToolStripMenuItem
            // 
            this.DeleteToolStripMenuItem.Margin = new System.Windows.Forms.Padding(3);
            this.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
            this.DeleteToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.DeleteToolStripMenuItem.Text = "Удалить текущий контакт";
            this.DeleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutToolStripMenuItem});
            this.helpToolStripMenuItem.Margin = new System.Windows.Forms.Padding(3);
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(68, 19);
            this.helpToolStripMenuItem.Text = "Помощь";
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Margin = new System.Windows.Forms.Padding(3);
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.AboutToolStripMenuItem.Text = "О программе";
            this.AboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // FindTextBox
            // 
            this.FindTextBox.Location = new System.Drawing.Point(76, 33);
            this.FindTextBox.Name = "FindTextBox";
            this.FindTextBox.Size = new System.Drawing.Size(187, 20);
            this.FindTextBox.TabIndex = 0;
            this.FindTextBox.TextChanged += new System.EventHandler(this.FindTextBox_TextChanged);
            // 
            // ContactsListBox
            // 
            this.ContactsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ContactsListBox.FormattingEnabled = true;
            this.ContactsListBox.IntegralHeight = false;
            this.ContactsListBox.Location = new System.Drawing.Point(12, 59);
            this.ContactsListBox.Name = "ContactsListBox";
            this.ContactsListBox.ScrollAlwaysVisible = true;
            this.ContactsListBox.Size = new System.Drawing.Size(251, 349);
            this.ContactsListBox.TabIndex = 3;
            this.ContactsListBox.SelectedIndexChanged += new System.EventHandler(this.ContactsListBox_SelectedIndexChanged);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DeleteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.DeleteButton.FlatAppearance.BorderSize = 0;
            this.DeleteButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.DeleteButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Image = ((System.Drawing.Image)(resources.GetObject("DeleteButton.Image")));
            this.DeleteButton.Location = new System.Drawing.Point(74, 414);
            this.DeleteButton.MaximumSize = new System.Drawing.Size(25, 26);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(25, 26);
            this.DeleteButton.TabIndex = 18;
            this.DeleteButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EditButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.EditButton.FlatAppearance.BorderSize = 0;
            this.EditButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.EditButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditButton.Image = ((System.Drawing.Image)(resources.GetObject("EditButton.Image")));
            this.EditButton.Location = new System.Drawing.Point(43, 414);
            this.EditButton.MaximumSize = new System.Drawing.Size(25, 26);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(25, 26);
            this.EditButton.TabIndex = 17;
            this.EditButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.AddButton.FlatAppearance.BorderSize = 0;
            this.AddButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.AddButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Image = ((System.Drawing.Image)(resources.GetObject("AddButton.Image")));
            this.AddButton.Location = new System.Drawing.Point(12, 414);
            this.AddButton.MaximumSize = new System.Drawing.Size(25, 26);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(25, 26);
            this.AddButton.TabIndex = 16;
            this.AddButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DateTimePicker1
            // 
            this.DateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.DateTimePicker1.Enabled = false;
            this.DateTimePicker1.Location = new System.Drawing.Point(389, 104);
            this.DateTimePicker1.Name = "DateTimePicker1";
            this.DateTimePicker1.Size = new System.Drawing.Size(137, 20);
            this.DateTimePicker1.TabIndex = 44;
            this.DateTimePicker1.Value = new System.DateTime(2021, 3, 17, 0, 0, 0, 0);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(305, 185);
            this.label7.Margin = new System.Windows.Forms.Padding(3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 41;
            this.label7.Text = "ID ВКонтакте:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(287, 133);
            this.label6.Margin = new System.Windows.Forms.Padding(3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 40;
            this.label6.Text = "Номер телефона:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(345, 159);
            this.label5.Margin = new System.Windows.Forms.Padding(3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "E-mail:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(294, 108);
            this.label4.Margin = new System.Windows.Forms.Padding(3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "Дата рождения:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(351, 81);
            this.label3.Margin = new System.Windows.Forms.Padding(3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Имя:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(324, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Фамилия:";
            // 
            // SurnameTextBox
            // 
            this.SurnameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.SurnameTextBox.Location = new System.Drawing.Point(389, 52);
            this.SurnameTextBox.Name = "SurnameTextBox";
            this.SurnameTextBox.ReadOnly = true;
            this.SurnameTextBox.Size = new System.Drawing.Size(332, 20);
            this.SurnameTextBox.TabIndex = 45;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.NameTextBox.Location = new System.Drawing.Point(389, 78);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.ReadOnly = true;
            this.NameTextBox.Size = new System.Drawing.Size(332, 20);
            this.NameTextBox.TabIndex = 46;
            // 
            // NumberTextBox
            // 
            this.NumberTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.NumberTextBox.Location = new System.Drawing.Point(389, 130);
            this.NumberTextBox.Name = "NumberTextBox";
            this.NumberTextBox.ReadOnly = true;
            this.NumberTextBox.Size = new System.Drawing.Size(332, 20);
            this.NumberTextBox.TabIndex = 47;
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.EmailTextBox.Location = new System.Drawing.Point(389, 156);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.ReadOnly = true;
            this.EmailTextBox.Size = new System.Drawing.Size(332, 20);
            this.EmailTextBox.TabIndex = 48;
            // 
            // IdTextBox
            // 
            this.IdTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.IdTextBox.Location = new System.Drawing.Point(389, 182);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.ReadOnly = true;
            this.IdTextBox.Size = new System.Drawing.Size(332, 20);
            this.IdTextBox.TabIndex = 49;
            // 
            // BirthdayPanel
            // 
            this.BirthdayPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BirthdayPanel.BackColor = System.Drawing.Color.MediumPurple;
            this.BirthdayPanel.Controls.Add(this.pictureBox1);
            this.BirthdayPanel.Controls.Add(this.label8);
            this.BirthdayPanel.Controls.Add(this.BirthdayTextBox);
            this.BirthdayPanel.Location = new System.Drawing.Point(290, 346);
            this.BirthdayPanel.Name = "BirthdayPanel";
            this.BirthdayPanel.Size = new System.Drawing.Size(442, 105);
            this.BirthdayPanel.TabIndex = 50;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(12, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(82, 37);
            this.label8.Margin = new System.Windows.Forms.Padding(3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Сегодня день рождения:";
            // 
            // BirthdayTextBox
            // 
            this.BirthdayTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BirthdayTextBox.BackColor = System.Drawing.Color.MediumPurple;
            this.BirthdayTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BirthdayTextBox.Location = new System.Drawing.Point(85, 56);
            this.BirthdayTextBox.Name = "BirthdayTextBox";
            this.BirthdayTextBox.ReadOnly = true;
            this.BirthdayTextBox.Size = new System.Drawing.Size(246, 13);
            this.BirthdayTextBox.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 452);
            this.Controls.Add(this.BirthdayPanel);
            this.Controls.Add(this.IdTextBox);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.NumberTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.SurnameTextBox);
            this.Controls.Add(this.DateTimePicker1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.ContactsListBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FindTextBox);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Контакты";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Contacts_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.BirthdayPanel.ResumeLayout(false);
            this.BirthdayPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddContactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditContactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
        private System.Windows.Forms.TextBox FindTextBox;
        private System.Windows.Forms.ListBox ContactsListBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.DateTimePicker DateTimePicker1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SurnameTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox NumberTextBox;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.Panel BirthdayPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox BirthdayTextBox;
    }
}