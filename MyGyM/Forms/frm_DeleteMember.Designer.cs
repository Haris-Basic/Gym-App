namespace MyGyM.Forms
{
    partial class frm_DeleteMember
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_DeleteMember));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.dgv_Members = new System.Windows.Forms.DataGridView();
            this.FName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Members)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(29, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Search ID:";
            // 
            // txt_Search
            // 
            this.txt_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Search.Location = new System.Drawing.Point(243, 32);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(457, 34);
            this.txt_Search.TabIndex = 6;
            this.txt_Search.TextChanged += new System.EventHandler(this.txt_Search_TextChanged);
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Delete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.ForeColor = System.Drawing.Color.Maroon;
            this.btn_Delete.Location = new System.Drawing.Point(959, 23);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(128, 43);
            this.btn_Delete.TabIndex = 5;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // dgv_Members
            // 
            this.dgv_Members.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dgv_Members.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Members.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Members.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FName,
            this.ID,
            this.LName,
            this.BDate,
            this.Phone});
            this.dgv_Members.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgv_Members.Location = new System.Drawing.Point(34, 100);
            this.dgv_Members.Name = "dgv_Members";
            this.dgv_Members.ReadOnly = true;
            this.dgv_Members.RowHeadersWidth = 51;
            this.dgv_Members.RowTemplate.Height = 24;
            this.dgv_Members.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Members.Size = new System.Drawing.Size(1053, 249);
            this.dgv_Members.TabIndex = 4;
            this.dgv_Members.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Members_CellContentClick);
            // 
            // FName
            // 
            this.FName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FName.DataPropertyName = "FName";
            this.FName.HeaderText = "First Name";
            this.FName.MinimumWidth = 6;
            this.FName.Name = "FName";
            this.FName.ReadOnly = true;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "JMBG";
            this.ID.HeaderText = "ID/JMBG";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 125;
            // 
            // LName
            // 
            this.LName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LName.DataPropertyName = "LName";
            this.LName.HeaderText = "Last Name";
            this.LName.MinimumWidth = 6;
            this.LName.Name = "LName";
            this.LName.ReadOnly = true;
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
            // frm_DeleteMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(1116, 375);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.dgv_Members);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_DeleteMember";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delete member";
            this.Load += new System.EventHandler(this.frm_DeleteMember_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Members)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.DataGridView dgv_Members;
        private System.Windows.Forms.DataGridViewTextBoxColumn FName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn LName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
    }
}