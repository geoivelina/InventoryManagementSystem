namespace InventoryManagementSystem
{
    partial class IMSForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ManageUsersHeadPanel = new System.Windows.Forms.Panel();
            this.UsersClose = new System.Windows.Forms.Label();
            this.ManageUsersLable = new System.Windows.Forms.Label();
            this.UsersIMSLable = new System.Windows.Forms.Label();
            this.UserNameTextBox = new System.Windows.Forms.TextBox();
            this.UserNameLable = new System.Windows.Forms.Label();
            this.FullNameLable = new System.Windows.Forms.Label();
            this.FullNameTextBox = new System.Windows.Forms.TextBox();
            this.PasswordLable = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.PhoneNumberLable = new System.Windows.Forms.Label();
            this.PhoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.AddUserBtn = new System.Windows.Forms.Button();
            this.EditUserBtn = new System.Windows.Forms.Button();
            this.DeleteUserBtn = new System.Windows.Forms.Button();
            this.ManageUsersHomeBtn = new System.Windows.Forms.Button();
            this.UsersForm = new System.Windows.Forms.DataGridView();
            this.ManageUsersFooterPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ManageUsersHeadPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsersForm)).BeginInit();
            this.SuspendLayout();
            // 
            // ManageUsersHeadPanel
            // 
            this.ManageUsersHeadPanel.BackColor = System.Drawing.Color.IndianRed;
            this.ManageUsersHeadPanel.Controls.Add(this.UsersClose);
            this.ManageUsersHeadPanel.Controls.Add(this.ManageUsersLable);
            this.ManageUsersHeadPanel.Controls.Add(this.UsersIMSLable);
            this.ManageUsersHeadPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ManageUsersHeadPanel.Location = new System.Drawing.Point(0, 0);
            this.ManageUsersHeadPanel.Name = "ManageUsersHeadPanel";
            this.ManageUsersHeadPanel.Size = new System.Drawing.Size(1337, 116);
            this.ManageUsersHeadPanel.TabIndex = 0;
            // 
            // UsersClose
            // 
            this.UsersClose.AutoSize = true;
            this.UsersClose.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UsersClose.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsersClose.ForeColor = System.Drawing.Color.White;
            this.UsersClose.Location = new System.Drawing.Point(1285, 9);
            this.UsersClose.Name = "UsersClose";
            this.UsersClose.Size = new System.Drawing.Size(42, 36);
            this.UsersClose.TabIndex = 2;
            this.UsersClose.Text = "X";
            this.UsersClose.Click += new System.EventHandler(this.Close_Click);
            // 
            // ManageUsersLable
            // 
            this.ManageUsersLable.AutoSize = true;
            this.ManageUsersLable.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManageUsersLable.ForeColor = System.Drawing.Color.White;
            this.ManageUsersLable.Location = new System.Drawing.Point(521, 68);
            this.ManageUsersLable.Name = "ManageUsersLable";
            this.ManageUsersLable.Size = new System.Drawing.Size(212, 34);
            this.ManageUsersLable.TabIndex = 1;
            this.ManageUsersLable.Text = "Manage Users";
            // 
            // UsersIMSLable
            // 
            this.UsersIMSLable.AutoSize = true;
            this.UsersIMSLable.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsersIMSLable.ForeColor = System.Drawing.Color.White;
            this.UsersIMSLable.Location = new System.Drawing.Point(297, 14);
            this.UsersIMSLable.Name = "UsersIMSLable";
            this.UsersIMSLable.Size = new System.Drawing.Size(716, 41);
            this.UsersIMSLable.TabIndex = 0;
            this.UsersIMSLable.Text = "INVENTORY MANAGEMENT SYSTEM";
            // 
            // UserNameTextBox
            // 
            this.UserNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UserNameTextBox.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameTextBox.ForeColor = System.Drawing.Color.IndianRed;
            this.UserNameTextBox.Location = new System.Drawing.Point(248, 222);
            this.UserNameTextBox.Name = "UserNameTextBox";
            this.UserNameTextBox.Size = new System.Drawing.Size(194, 36);
            this.UserNameTextBox.TabIndex = 1;
            // 
            // UserNameLable
            // 
            this.UserNameLable.AutoSize = true;
            this.UserNameLable.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameLable.ForeColor = System.Drawing.Color.IndianRed;
            this.UserNameLable.Location = new System.Drawing.Point(41, 222);
            this.UserNameLable.Name = "UserNameLable";
            this.UserNameLable.Size = new System.Drawing.Size(135, 30);
            this.UserNameLable.TabIndex = 2;
            this.UserNameLable.Text = "UserName:";
            // 
            // FullNameLable
            // 
            this.FullNameLable.AutoSize = true;
            this.FullNameLable.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FullNameLable.ForeColor = System.Drawing.Color.IndianRed;
            this.FullNameLable.Location = new System.Drawing.Point(41, 309);
            this.FullNameLable.Name = "FullNameLable";
            this.FullNameLable.Size = new System.Drawing.Size(133, 30);
            this.FullNameLable.TabIndex = 4;
            this.FullNameLable.Text = "FullName:";
            // 
            // FullNameTextBox
            // 
            this.FullNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FullNameTextBox.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FullNameTextBox.ForeColor = System.Drawing.Color.IndianRed;
            this.FullNameTextBox.Location = new System.Drawing.Point(249, 308);
            this.FullNameTextBox.Name = "FullNameTextBox";
            this.FullNameTextBox.Size = new System.Drawing.Size(194, 36);
            this.FullNameTextBox.TabIndex = 3;
            // 
            // PasswordLable
            // 
            this.PasswordLable.AutoSize = true;
            this.PasswordLable.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLable.ForeColor = System.Drawing.Color.IndianRed;
            this.PasswordLable.Location = new System.Drawing.Point(41, 404);
            this.PasswordLable.Name = "PasswordLable";
            this.PasswordLable.Size = new System.Drawing.Size(126, 30);
            this.PasswordLable.TabIndex = 6;
            this.PasswordLable.Text = "Password:";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PasswordTextBox.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTextBox.ForeColor = System.Drawing.Color.IndianRed;
            this.PasswordTextBox.Location = new System.Drawing.Point(249, 400);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(194, 36);
            this.PasswordTextBox.TabIndex = 5;
            // 
            // PhoneNumberLable
            // 
            this.PhoneNumberLable.AutoSize = true;
            this.PhoneNumberLable.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneNumberLable.ForeColor = System.Drawing.Color.IndianRed;
            this.PhoneNumberLable.Location = new System.Drawing.Point(41, 496);
            this.PhoneNumberLable.Name = "PhoneNumberLable";
            this.PhoneNumberLable.Size = new System.Drawing.Size(182, 30);
            this.PhoneNumberLable.TabIndex = 8;
            this.PhoneNumberLable.Text = "PhoneNumber:";
            // 
            // PhoneNumberTextBox
            // 
            this.PhoneNumberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PhoneNumberTextBox.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneNumberTextBox.ForeColor = System.Drawing.Color.IndianRed;
            this.PhoneNumberTextBox.Location = new System.Drawing.Point(249, 492);
            this.PhoneNumberTextBox.Name = "PhoneNumberTextBox";
            this.PhoneNumberTextBox.Size = new System.Drawing.Size(194, 36);
            this.PhoneNumberTextBox.TabIndex = 7;
            // 
            // AddUserBtn
            // 
            this.AddUserBtn.BackColor = System.Drawing.Color.IndianRed;
            this.AddUserBtn.FlatAppearance.BorderSize = 0;
            this.AddUserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddUserBtn.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddUserBtn.ForeColor = System.Drawing.Color.White;
            this.AddUserBtn.Location = new System.Drawing.Point(75, 604);
            this.AddUserBtn.Name = "AddUserBtn";
            this.AddUserBtn.Size = new System.Drawing.Size(101, 45);
            this.AddUserBtn.TabIndex = 9;
            this.AddUserBtn.Text = "Add";
            this.AddUserBtn.UseVisualStyleBackColor = false;
            this.AddUserBtn.Click += new System.EventHandler(this.AddUserBtn_Click);
            // 
            // EditUserBtn
            // 
            this.EditUserBtn.BackColor = System.Drawing.Color.IndianRed;
            this.EditUserBtn.FlatAppearance.BorderSize = 0;
            this.EditUserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditUserBtn.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditUserBtn.ForeColor = System.Drawing.Color.White;
            this.EditUserBtn.Location = new System.Drawing.Point(194, 604);
            this.EditUserBtn.Name = "EditUserBtn";
            this.EditUserBtn.Size = new System.Drawing.Size(101, 45);
            this.EditUserBtn.TabIndex = 10;
            this.EditUserBtn.Text = "Edit";
            this.EditUserBtn.UseVisualStyleBackColor = false;
            this.EditUserBtn.Click += new System.EventHandler(this.EditUserBtn_Click);
            // 
            // DeleteUserBtn
            // 
            this.DeleteUserBtn.BackColor = System.Drawing.Color.IndianRed;
            this.DeleteUserBtn.FlatAppearance.BorderSize = 0;
            this.DeleteUserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteUserBtn.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteUserBtn.ForeColor = System.Drawing.Color.White;
            this.DeleteUserBtn.Location = new System.Drawing.Point(314, 604);
            this.DeleteUserBtn.Name = "DeleteUserBtn";
            this.DeleteUserBtn.Size = new System.Drawing.Size(101, 45);
            this.DeleteUserBtn.TabIndex = 11;
            this.DeleteUserBtn.Text = "Delete";
            this.DeleteUserBtn.UseVisualStyleBackColor = false;
            this.DeleteUserBtn.Click += new System.EventHandler(this.DeleteUserBtn_Click);
            // 
            // ManageUsersHomeBtn
            // 
            this.ManageUsersHomeBtn.BackColor = System.Drawing.Color.IndianRed;
            this.ManageUsersHomeBtn.FlatAppearance.BorderSize = 0;
            this.ManageUsersHomeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ManageUsersHomeBtn.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManageUsersHomeBtn.ForeColor = System.Drawing.Color.White;
            this.ManageUsersHomeBtn.Location = new System.Drawing.Point(194, 675);
            this.ManageUsersHomeBtn.Name = "ManageUsersHomeBtn";
            this.ManageUsersHomeBtn.Size = new System.Drawing.Size(101, 45);
            this.ManageUsersHomeBtn.TabIndex = 12;
            this.ManageUsersHomeBtn.Text = "Home";
            this.ManageUsersHomeBtn.UseVisualStyleBackColor = false;
            // 
            // UsersForm
            // 
            this.UsersForm.BackgroundColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UsersForm.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.UsersForm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Salmon;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.UsersForm.DefaultCellStyle = dataGridViewCellStyle6;
            this.UsersForm.GridColor = System.Drawing.Color.LightGray;
            this.UsersForm.Location = new System.Drawing.Point(495, 210);
            this.UsersForm.Name = "UsersForm";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UsersForm.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.UsersForm.RowHeadersWidth = 51;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            this.UsersForm.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.UsersForm.RowTemplate.Height = 24;
            this.UsersForm.Size = new System.Drawing.Size(766, 510);
            this.UsersForm.TabIndex = 13;
            this.UsersForm.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UsersDataGrid_CellContentClick);
            // 
            // ManageUsersFooterPanel
            // 
            this.ManageUsersFooterPanel.BackColor = System.Drawing.Color.IndianRed;
            this.ManageUsersFooterPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ManageUsersFooterPanel.Location = new System.Drawing.Point(0, 827);
            this.ManageUsersFooterPanel.Name = "ManageUsersFooterPanel";
            this.ManageUsersFooterPanel.Size = new System.Drawing.Size(1337, 54);
            this.ManageUsersFooterPanel.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(756, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 34);
            this.label1.TabIndex = 15;
            this.label1.Text = "Users List";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.IndianRed;
            this.label2.Location = new System.Drawing.Point(149, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 34);
            this.label2.TabIndex = 16;
            this.label2.Text = "User Data";
            // 
            // IMSForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1337, 881);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ManageUsersFooterPanel);
            this.Controls.Add(this.UsersForm);
            this.Controls.Add(this.ManageUsersHomeBtn);
            this.Controls.Add(this.DeleteUserBtn);
            this.Controls.Add(this.EditUserBtn);
            this.Controls.Add(this.AddUserBtn);
            this.Controls.Add(this.PhoneNumberLable);
            this.Controls.Add(this.PhoneNumberTextBox);
            this.Controls.Add(this.PasswordLable);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.FullNameLable);
            this.Controls.Add(this.FullNameTextBox);
            this.Controls.Add(this.UserNameLable);
            this.Controls.Add(this.UserNameTextBox);
            this.Controls.Add(this.ManageUsersHeadPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IMSForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.IMSForm_Load);
            this.ManageUsersHeadPanel.ResumeLayout(false);
            this.ManageUsersHeadPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsersForm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel ManageUsersHeadPanel;
        private System.Windows.Forms.Label UsersIMSLable;
        private System.Windows.Forms.Label ManageUsersLable;
        private System.Windows.Forms.TextBox UserNameTextBox;
        private System.Windows.Forms.Label UserNameLable;
        private System.Windows.Forms.Label FullNameLable;
        private System.Windows.Forms.TextBox FullNameTextBox;
        private System.Windows.Forms.Label PasswordLable;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label PhoneNumberLable;
        private System.Windows.Forms.TextBox PhoneNumberTextBox;
        private System.Windows.Forms.Button AddUserBtn;
        private System.Windows.Forms.Button EditUserBtn;
        private System.Windows.Forms.Button DeleteUserBtn;
        private System.Windows.Forms.Button ManageUsersHomeBtn;
        private System.Windows.Forms.DataGridView UsersForm;
        private System.Windows.Forms.Panel ManageUsersFooterPanel;
        private System.Windows.Forms.Label UsersClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}