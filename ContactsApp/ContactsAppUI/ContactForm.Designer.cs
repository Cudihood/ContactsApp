
namespace ContactsAppUI
{
    partial class ContactForm
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
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Okbutton = new System.Windows.Forms.Button();
            this.RevokeButton = new System.Windows.Forms.Button();
            this.SurnameTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.NumberTextBox = new System.Windows.Forms.TextBox();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(58, 281);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 25);
            this.label7.TabIndex = 27;
            this.label7.Text = "ID ВКонтакте:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 181);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(189, 25);
            this.label6.TabIndex = 25;
            this.label6.Text = "Номер телефона:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(138, 231);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 25);
            this.label5.TabIndex = 24;
            this.label5.Text = "E-mail:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 133);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 25);
            this.label4.TabIndex = 23;
            this.label4.Text = "Дата рождения:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(150, 81);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 25);
            this.label3.TabIndex = 22;
            this.label3.Text = "Имя:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 25);
            this.label2.TabIndex = 21;
            this.label2.Text = "Фамилия:";
            // 
            // Okbutton
            // 
            this.Okbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Okbutton.Location = new System.Drawing.Point(507, 334);
            this.Okbutton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Okbutton.Name = "Okbutton";
            this.Okbutton.Size = new System.Drawing.Size(176, 48);
            this.Okbutton.TabIndex = 28;
            this.Okbutton.Text = "ОК";
            this.Okbutton.UseVisualStyleBackColor = true;
            this.Okbutton.Click += new System.EventHandler(this.Okbutton_Click);
            // 
            // RevokeButton
            // 
            this.RevokeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RevokeButton.Location = new System.Drawing.Point(695, 334);
            this.RevokeButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.RevokeButton.Name = "RevokeButton";
            this.RevokeButton.Size = new System.Drawing.Size(176, 48);
            this.RevokeButton.TabIndex = 29;
            this.RevokeButton.Text = "Отмена";
            this.RevokeButton.UseVisualStyleBackColor = true;
            this.RevokeButton.Click += new System.EventHandler(this.RevokeButton_Click);
            // 
            // SurnameTextBox
            // 
            this.SurnameTextBox.Location = new System.Drawing.Point(226, 25);
            this.SurnameTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.SurnameTextBox.Name = "SurnameTextBox";
            this.SurnameTextBox.Size = new System.Drawing.Size(645, 31);
            this.SurnameTextBox.TabIndex = 30;
            this.SurnameTextBox.TextChanged += new System.EventHandler(this.SurnameTextBox_TextChanged);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(226, 75);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(645, 31);
            this.NameTextBox.TabIndex = 31;
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // DateTimePicker
            // 
            this.DateTimePicker.Location = new System.Drawing.Point(226, 125);
            this.DateTimePicker.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.DateTimePicker.Name = "DateTimePicker";
            this.DateTimePicker.Size = new System.Drawing.Size(296, 31);
            this.DateTimePicker.TabIndex = 32;
            this.DateTimePicker.Value = new System.DateTime(2021, 3, 9, 0, 0, 0, 0);
            // 
            // NumberTextBox
            // 
            this.NumberTextBox.Location = new System.Drawing.Point(226, 175);
            this.NumberTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.NumberTextBox.Name = "NumberTextBox";
            this.NumberTextBox.Size = new System.Drawing.Size(645, 31);
            this.NumberTextBox.TabIndex = 33;
            this.NumberTextBox.TextChanged += new System.EventHandler(this.NumberTextBox_TextChanged);
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(226, 225);
            this.EmailTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(645, 31);
            this.EmailTextBox.TabIndex = 34;
            this.EmailTextBox.TextChanged += new System.EventHandler(this.EmailTextBox_TextChanged);
            // 
            // IdTextBox
            // 
            this.IdTextBox.Location = new System.Drawing.Point(226, 275);
            this.IdTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new System.Drawing.Size(645, 31);
            this.IdTextBox.TabIndex = 35;
            this.IdTextBox.TextChanged += new System.EventHandler(this.IdTextBox_TextChanged);
            // 
            // ContactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 405);
            this.Controls.Add(this.IdTextBox);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.NumberTextBox);
            this.Controls.Add(this.DateTimePicker);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.SurnameTextBox);
            this.Controls.Add(this.RevokeButton);
            this.Controls.Add(this.Okbutton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ContactForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Создать/Редактировать Контакт";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Okbutton;
        private System.Windows.Forms.Button RevokeButton;
        private System.Windows.Forms.TextBox SurnameTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.DateTimePicker DateTimePicker;
        private System.Windows.Forms.TextBox NumberTextBox;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.TextBox IdTextBox;
    }
}