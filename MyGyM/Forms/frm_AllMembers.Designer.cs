namespace MyGyM.Forms
{
    partial class frm_AllMembers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_AllMembers));
            this.dgv_Members = new System.Windows.Forms.DataGridView();
            this.FName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddPayment = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Print = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_AddNew = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Members)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Members
            // 
            this.dgv_Members.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dgv_Members.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Members.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Members.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FName,
            this.LName,
            this.BDate,
            this.Phone,
            this.Email,
            this.StartDate,
            this.AddPayment,
            this.Print});
            this.dgv_Members.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgv_Members.Location = new System.Drawing.Point(37, 125);
            this.dgv_Members.Name = "dgv_Members";
            this.dgv_Members.ReadOnly = true;
            this.dgv_Members.RowHeadersWidth = 51;
            this.dgv_Members.RowTemplate.Height = 24;
            this.dgv_Members.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Members.Size = new System.Drawing.Size(1053, 291);
            this.dgv_Members.TabIndex = 0;
            this.dgv_Members.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Members_CellContentClick);
            this.dgv_Members.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgv_Members_MouseClick);
            // 
            // FName
            // 
            this.FName.DataPropertyName = "FName";
            this.FName.HeaderText = "First Name";
            this.FName.MinimumWidth = 6;
            this.FName.Name = "FName";
            this.FName.ReadOnly = true;
            this.FName.Width = 125;
            // 
            // LName
            // 
            this.LName.DataPropertyName = "LName";
            this.LName.HeaderText = "Last Name";
            this.LName.MinimumWidth = 6;
            this.LName.Name = "LName";
            this.LName.ReadOnly = true;
            this.LName.Width = 125;
            // 
            // BDate
            // 
            this.BDate.DataPropertyName = "BDate";
            this.BDate.HeaderText = "Birth date";
            this.BDate.MinimumWidth = 6;
            this.BDate.Name = "BDate";
            this.BDate.ReadOnly = true;
            this.BDate.Width = 125;
            // 
            // Phone
            // 
            this.Phone.DataPropertyName = "Phone";
            this.Phone.HeaderText = "Phone";
            this.Phone.MinimumWidth = 6;
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            this.Phone.Width = 125;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 125;
            // 
            // StartDate
            // 
            this.StartDate.DataPropertyName = "StartDate";
            this.StartDate.HeaderText = "Start date";
            this.StartDate.MinimumWidth = 6;
            this.StartDate.Name = "StartDate";
            this.StartDate.ReadOnly = true;
            this.StartDate.Width = 125;
            // 
            // AddPayment
            // 
            this.AddPayment.HeaderText = "Add Payment";
            this.AddPayment.MinimumWidth = 6;
            this.AddPayment.Name = "AddPayment";
            this.AddPayment.ReadOnly = true;
            this.AddPayment.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.AddPayment.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.AddPayment.Text = "Add Payment";
            this.AddPayment.UseColumnTextForButtonValue = true;
            this.AddPayment.Width = 125;
            // 
            // Print
            // 
            this.Print.HeaderText = "Print";
            this.Print.MinimumWidth = 6;
            this.Print.Name = "Print";
            this.Print.ReadOnly = true;
            this.Print.Text = "Print";
            this.Print.UseColumnTextForButtonValue = true;
            this.Print.Width = 125;
            // 
            // txt_Search
            // 
            this.txt_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Search.Location = new System.Drawing.Point(159, 57);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(457, 34);
            this.txt_Search.TabIndex = 2;
            this.txt_Search.TextChanged += new System.EventHandler(this.txt_Search_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(32, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_AddNew
            // 
            this.btn_AddNew.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_AddNew.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddNew.ForeColor = System.Drawing.Color.Maroon;
            this.btn_AddNew.Location = new System.Drawing.Point(962, 48);
            this.btn_AddNew.Name = "btn_AddNew";
            this.btn_AddNew.Size = new System.Drawing.Size(128, 43);
            this.btn_AddNew.TabIndex = 1;
            this.btn_AddNew.Text = "Add new";
            this.btn_AddNew.UseVisualStyleBackColor = false;
            this.btn_AddNew.Click += new System.EventHandler(this.btn_AddNew_Click);
            // 
            // frm_AllMembers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1127, 454);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.btn_AddNew);
            this.Controls.Add(this.dgv_Members);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_AllMembers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "All members";
            this.Load += new System.EventHandler(this.frm_AllMembers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Members)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Members;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_AddNew;
        private System.Windows.Forms.DataGridViewTextBoxColumn FName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartDate;
        private System.Windows.Forms.DataGridViewButtonColumn AddPayment;
        private System.Windows.Forms.DataGridViewButtonColumn Print;
    }
}