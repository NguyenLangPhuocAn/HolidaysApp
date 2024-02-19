namespace HolidaysApp
{
    partial class FrmHolidays
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
            this.Pn_Top = new System.Windows.Forms.Panel();
            this.Btn_Close = new System.Windows.Forms.Button();
            this.Lb_tittle = new System.Windows.Forms.Label();
            this.Pn_Body = new System.Windows.Forms.Panel();
            this.Txt_ID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Dgv_Holiday = new System.Windows.Forms.DataGridView();
            this.Pn_Button = new System.Windows.Forms.Panel();
            this.Btn_Search = new System.Windows.Forms.Button();
            this.Btn_Modify = new System.Windows.Forms.Button();
            this.Btn_Delete = new System.Windows.Forms.Button();
            this.Btn_Add = new System.Windows.Forms.Button();
            this.Txt_Remark = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Txt_NameVi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_NameEn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_NameGroup = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Dtp_Date = new System.Windows.Forms.DateTimePicker();
            this.Lb_Id = new System.Windows.Forms.Label();
            this.Pn_Top.SuspendLayout();
            this.Pn_Body.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Holiday)).BeginInit();
            this.Pn_Button.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pn_Top
            // 
            this.Pn_Top.BackColor = System.Drawing.Color.AliceBlue;
            this.Pn_Top.Controls.Add(this.Btn_Close);
            this.Pn_Top.Controls.Add(this.Lb_tittle);
            this.Pn_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pn_Top.Location = new System.Drawing.Point(0, 0);
            this.Pn_Top.Name = "Pn_Top";
            this.Pn_Top.Size = new System.Drawing.Size(1089, 39);
            this.Pn_Top.TabIndex = 0;
            // 
            // Btn_Close
            // 
            this.Btn_Close.FlatAppearance.BorderSize = 0;
            this.Btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.Btn_Close.ForeColor = System.Drawing.Color.Red;
            this.Btn_Close.Location = new System.Drawing.Point(1002, 3);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Size = new System.Drawing.Size(75, 23);
            this.Btn_Close.TabIndex = 1;
            this.Btn_Close.Text = "X";
            this.Btn_Close.UseVisualStyleBackColor = true;
            this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // Lb_tittle
            // 
            this.Lb_tittle.AutoSize = true;
            this.Lb_tittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.Lb_tittle.ForeColor = System.Drawing.Color.Red;
            this.Lb_tittle.Location = new System.Drawing.Point(311, 9);
            this.Lb_tittle.Name = "Lb_tittle";
            this.Lb_tittle.Size = new System.Drawing.Size(218, 26);
            this.Lb_tittle.TabIndex = 0;
            this.Lb_tittle.Text = "Holiday Management";
            // 
            // Pn_Body
            // 
            this.Pn_Body.BackColor = System.Drawing.Color.AliceBlue;
            this.Pn_Body.Controls.Add(this.Txt_ID);
            this.Pn_Body.Controls.Add(this.label5);
            this.Pn_Body.Controls.Add(this.Dgv_Holiday);
            this.Pn_Body.Controls.Add(this.Pn_Button);
            this.Pn_Body.Controls.Add(this.Txt_Remark);
            this.Pn_Body.Controls.Add(this.label4);
            this.Pn_Body.Controls.Add(this.Txt_NameVi);
            this.Pn_Body.Controls.Add(this.label3);
            this.Pn_Body.Controls.Add(this.Txt_NameEn);
            this.Pn_Body.Controls.Add(this.label2);
            this.Pn_Body.Controls.Add(this.Txt_NameGroup);
            this.Pn_Body.Controls.Add(this.label1);
            this.Pn_Body.Controls.Add(this.Dtp_Date);
            this.Pn_Body.Controls.Add(this.Lb_Id);
            this.Pn_Body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pn_Body.Location = new System.Drawing.Point(0, 39);
            this.Pn_Body.Name = "Pn_Body";
            this.Pn_Body.Size = new System.Drawing.Size(1089, 561);
            this.Pn_Body.TabIndex = 1;
            // 
            // Txt_ID
            // 
            this.Txt_ID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_ID.Location = new System.Drawing.Point(206, 13);
            this.Txt_ID.Name = "Txt_ID";
            this.Txt_ID.Size = new System.Drawing.Size(871, 20);
            this.Txt_ID.TabIndex = 13;
            this.Txt_ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_ID_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label5.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.label5.Location = new System.Drawing.Point(170, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 24);
            this.label5.TabIndex = 12;
            this.label5.Text = "Id:";
            // 
            // Dgv_Holiday
            // 
            this.Dgv_Holiday.AllowUserToAddRows = false;
            this.Dgv_Holiday.AllowUserToDeleteRows = false;
            this.Dgv_Holiday.AllowUserToResizeRows = false;
            this.Dgv_Holiday.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_Holiday.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Holiday.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Dgv_Holiday.Location = new System.Drawing.Point(0, 386);
            this.Dgv_Holiday.Name = "Dgv_Holiday";
            this.Dgv_Holiday.ReadOnly = true;
            this.Dgv_Holiday.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_Holiday.Size = new System.Drawing.Size(1089, 175);
            this.Dgv_Holiday.TabIndex = 11;
            this.Dgv_Holiday.SelectionChanged += new System.EventHandler(this.Dgv_Holiday_SelectionChanged);
            // 
            // Pn_Button
            // 
            this.Pn_Button.Controls.Add(this.Btn_Search);
            this.Pn_Button.Controls.Add(this.Btn_Modify);
            this.Pn_Button.Controls.Add(this.Btn_Delete);
            this.Pn_Button.Controls.Add(this.Btn_Add);
            this.Pn_Button.Location = new System.Drawing.Point(0, 280);
            this.Pn_Button.Name = "Pn_Button";
            this.Pn_Button.Size = new System.Drawing.Size(1089, 100);
            this.Pn_Button.TabIndex = 10;
            // 
            // Btn_Search
            // 
            this.Btn_Search.BackColor = System.Drawing.Color.DarkOrange;
            this.Btn_Search.Dock = System.Windows.Forms.DockStyle.Left;
            this.Btn_Search.FlatAppearance.BorderSize = 0;
            this.Btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.Btn_Search.ForeColor = System.Drawing.Color.Black;
            this.Btn_Search.Location = new System.Drawing.Point(765, 0);
            this.Btn_Search.Name = "Btn_Search";
            this.Btn_Search.Size = new System.Drawing.Size(324, 100);
            this.Btn_Search.TabIndex = 3;
            this.Btn_Search.Text = "Search";
            this.Btn_Search.UseVisualStyleBackColor = false;
            this.Btn_Search.Click += new System.EventHandler(this.Btn_Search_Click);
            // 
            // Btn_Modify
            // 
            this.Btn_Modify.BackColor = System.Drawing.Color.Gold;
            this.Btn_Modify.Dock = System.Windows.Forms.DockStyle.Left;
            this.Btn_Modify.FlatAppearance.BorderSize = 0;
            this.Btn_Modify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Modify.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.Btn_Modify.ForeColor = System.Drawing.Color.Black;
            this.Btn_Modify.Location = new System.Drawing.Point(442, 0);
            this.Btn_Modify.Name = "Btn_Modify";
            this.Btn_Modify.Size = new System.Drawing.Size(323, 100);
            this.Btn_Modify.TabIndex = 2;
            this.Btn_Modify.Text = "Modify";
            this.Btn_Modify.UseVisualStyleBackColor = false;
            this.Btn_Modify.Click += new System.EventHandler(this.Btn_Modify_Click);
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.BackColor = System.Drawing.Color.DarkRed;
            this.Btn_Delete.Dock = System.Windows.Forms.DockStyle.Left;
            this.Btn_Delete.FlatAppearance.BorderSize = 0;
            this.Btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.Btn_Delete.ForeColor = System.Drawing.Color.SandyBrown;
            this.Btn_Delete.Location = new System.Drawing.Point(221, 0);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(221, 100);
            this.Btn_Delete.TabIndex = 1;
            this.Btn_Delete.Text = "Delete";
            this.Btn_Delete.UseVisualStyleBackColor = false;
            this.Btn_Delete.Click += new System.EventHandler(this.Btn_Delete_Click);
            // 
            // Btn_Add
            // 
            this.Btn_Add.BackColor = System.Drawing.Color.GreenYellow;
            this.Btn_Add.Dock = System.Windows.Forms.DockStyle.Left;
            this.Btn_Add.FlatAppearance.BorderSize = 0;
            this.Btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.Btn_Add.ForeColor = System.Drawing.Color.Black;
            this.Btn_Add.Location = new System.Drawing.Point(0, 0);
            this.Btn_Add.Name = "Btn_Add";
            this.Btn_Add.Size = new System.Drawing.Size(221, 100);
            this.Btn_Add.TabIndex = 0;
            this.Btn_Add.Text = "Add";
            this.Btn_Add.UseVisualStyleBackColor = false;
            this.Btn_Add.Click += new System.EventHandler(this.Btn_Add_Click);
            // 
            // Txt_Remark
            // 
            this.Txt_Remark.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_Remark.Location = new System.Drawing.Point(206, 211);
            this.Txt_Remark.MaxLength = 55;
            this.Txt_Remark.Name = "Txt_Remark";
            this.Txt_Remark.Size = new System.Drawing.Size(871, 58);
            this.Txt_Remark.TabIndex = 9;
            this.Txt_Remark.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label4.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.label4.Location = new System.Drawing.Point(120, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Remark:";
            // 
            // Txt_NameVi
            // 
            this.Txt_NameVi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_NameVi.Location = new System.Drawing.Point(206, 166);
            this.Txt_NameVi.MaxLength = 55;
            this.Txt_NameVi.Name = "Txt_NameVi";
            this.Txt_NameVi.Size = new System.Drawing.Size(871, 20);
            this.Txt_NameVi.TabIndex = 7;
            this.Txt_NameVi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Name_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label3.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.label3.Location = new System.Drawing.Point(44, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Holiday Name Vi:";
            // 
            // Txt_NameEn
            // 
            this.Txt_NameEn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_NameEn.Location = new System.Drawing.Point(206, 122);
            this.Txt_NameEn.MaxLength = 55;
            this.Txt_NameEn.Name = "Txt_NameEn";
            this.Txt_NameEn.Size = new System.Drawing.Size(871, 20);
            this.Txt_NameEn.TabIndex = 5;
            this.Txt_NameEn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Name_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label2.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.label2.Location = new System.Drawing.Point(37, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Holiday Name En:";
            // 
            // Txt_NameGroup
            // 
            this.Txt_NameGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_NameGroup.Location = new System.Drawing.Point(206, 81);
            this.Txt_NameGroup.MaxLength = 45;
            this.Txt_NameGroup.Name = "Txt_NameGroup";
            this.Txt_NameGroup.Size = new System.Drawing.Size(871, 20);
            this.Txt_NameGroup.TabIndex = 3;
            this.Txt_NameGroup.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Name_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.label1.Location = new System.Drawing.Point(8, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Holiday Name Group:";
            // 
            // Dtp_Date
            // 
            this.Dtp_Date.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dtp_Date.Location = new System.Drawing.Point(206, 43);
            this.Dtp_Date.Name = "Dtp_Date";
            this.Dtp_Date.Size = new System.Drawing.Size(871, 20);
            this.Dtp_Date.TabIndex = 1;
            // 
            // Lb_Id
            // 
            this.Lb_Id.AutoSize = true;
            this.Lb_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.Lb_Id.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.Lb_Id.Location = new System.Drawing.Point(79, 39);
            this.Lb_Id.Name = "Lb_Id";
            this.Lb_Id.Size = new System.Drawing.Size(121, 24);
            this.Lb_Id.TabIndex = 0;
            this.Lb_Id.Text = "Holiday Date:";
            // 
            // FrmHolidays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 600);
            this.ControlBox = false;
            this.Controls.Add(this.Pn_Body);
            this.Controls.Add(this.Pn_Top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmHolidays";
            this.Text = "HolidaysApp";
            this.Pn_Top.ResumeLayout(false);
            this.Pn_Top.PerformLayout();
            this.Pn_Body.ResumeLayout(false);
            this.Pn_Body.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Holiday)).EndInit();
            this.Pn_Button.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pn_Top;
        private System.Windows.Forms.Label Lb_tittle;
        private System.Windows.Forms.Panel Pn_Body;
        private System.Windows.Forms.DataGridView Dgv_Holiday;
        private System.Windows.Forms.Panel Pn_Button;
        private System.Windows.Forms.Button Btn_Search;
        private System.Windows.Forms.Button Btn_Modify;
        private System.Windows.Forms.Button Btn_Delete;
        private System.Windows.Forms.Button Btn_Add;
        private System.Windows.Forms.RichTextBox Txt_Remark;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txt_NameVi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_NameEn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_NameGroup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker Dtp_Date;
        private System.Windows.Forms.Label Lb_Id;
        private System.Windows.Forms.Button Btn_Close;
        private System.Windows.Forms.TextBox Txt_ID;
        private System.Windows.Forms.Label label5;
    }
}

