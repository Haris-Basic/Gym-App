namespace MyGyM.Forms
{
    partial class frm_AddPayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_AddPayment));
            this.txt_Member = new System.Windows.Forms.TextBox();
            this.txt_Amount = new System.Windows.Forms.TextBox();
            this.dtp_DateOfPayment = new System.Windows.Forms.DateTimePicker();
            this.btn_AddPayment = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgv_Payment = new System.Windows.Forms.DataGridView();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Currency_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_Currency = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Payment)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Member
            // 
            this.txt_Member.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Member.Location = new System.Drawing.Point(22, 44);
            this.txt_Member.Name = "txt_Member";
            this.txt_Member.ReadOnly = true;
            this.txt_Member.Size = new System.Drawing.Size(434, 30);
            this.txt_Member.TabIndex = 2;
            this.txt_Member.TextChanged += new System.EventHandler(this.txt_Member_TextChanged);
            // 
            // txt_Amount
            // 
            this.txt_Amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Amount.Location = new System.Drawing.Point(22, 116);
            this.txt_Amount.Name = "txt_Amount";
            this.txt_Amount.ReadOnly = true;
            this.txt_Amount.Size = new System.Drawing.Size(87, 30);
            this.txt_Amount.TabIndex = 3;
            this.txt_Amount.TextChanged += new System.EventHandler(this.txt_Amount_TextChanged);
            // 
            // dtp_DateOfPayment
            // 
            this.dtp_DateOfPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_DateOfPayment.Location = new System.Drawing.Point(22, 190);
            this.dtp_DateOfPayment.Name = "dtp_DateOfPayment";
            this.dtp_DateOfPayment.Size = new System.Drawing.Size(434, 30);
            this.dtp_DateOfPayment.TabIndex = 4;
            // 
            // btn_AddPayment
            // 
            this.btn_AddPayment.BackColor = System.Drawing.Color.Silver;
            this.btn_AddPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddPayment.ForeColor = System.Drawing.Color.Maroon;
            this.btn_AddPayment.Location = new System.Drawing.Point(285, 272);
            this.btn_AddPayment.Name = "btn_AddPayment";
            this.btn_AddPayment.Size = new System.Drawing.Size(171, 34);
            this.btn_AddPayment.TabIndex = 5;
            this.btn_AddPayment.Text = "Save";
            this.btn_AddPayment.UseVisualStyleBackColor = false;
            this.btn_AddPayment.Click += new System.EventHandler(this.btn_AddPayment_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(18, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Member:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(18, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Amount:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(22, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Date:";
            // 
            // dgv_Payment
            // 
            this.dgv_Payment.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dgv_Payment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Payment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.Amount,
            this.Currency_});
            this.dgv_Payment.Location = new System.Drawing.Point(22, 327);
            this.dgv_Payment.Name = "dgv_Payment";
            this.dgv_Payment.RowHeadersWidth = 51;
            this.dgv_Payment.RowTemplate.Height = 24;
            this.dgv_Payment.Size = new System.Drawing.Size(434, 257);
            this.dgv_Payment.TabIndex = 12;
            this.dgv_Payment.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Payment_CellContentClick);
            // 
            // Date
            // 
            this.Date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "Date";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            // 
            // Amount
            // 
            this.Amount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Amount.DataPropertyName = "Amount";
            this.Amount.HeaderText = "Amount";
            this.Amount.MinimumWidth = 6;
            this.Amount.Name = "Amount";
            // 
            // Currency_
            // 
            this.Currency_.DataPropertyName = "Currency";
            this.Currency_.HeaderText = "Currency";
            this.Currency_.MinimumWidth = 6;
            this.Currency_.Name = "Currency_";
            this.Currency_.Width = 125;
            // 
            // txt_Currency
            // 
            this.txt_Currency.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Currency.Location = new System.Drawing.Point(132, 116);
            this.txt_Currency.Name = "txt_Currency";
            this.txt_Currency.ReadOnly = true;
            this.txt_Currency.Size = new System.Drawing.Size(87, 30);
            this.txt_Currency.TabIndex = 15;
            // 
            // frm_AddPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(471, 597);
            this.Controls.Add(this.txt_Currency);
            this.Controls.Add(this.dgv_Payment);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_AddPayment);
            this.Controls.Add(this.dtp_DateOfPayment);
            this.Controls.Add(this.txt_Amount);
            this.Controls.Add(this.txt_Member);
            this.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_AddPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add payment";
            this.Load += new System.EventHandler(this.frm_AddPayment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Payment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_Member;
        private System.Windows.Forms.TextBox txt_Amount;
        private System.Windows.Forms.DateTimePicker dtp_DateOfPayment;
        private System.Windows.Forms.Button btn_AddPayment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgv_Payment;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Currency_;
        private System.Windows.Forms.TextBox txt_Currency;
    }
}