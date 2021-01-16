namespace MyGyM.Forms
{
    partial class frm_AddNewMember
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_AddNewMember));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_FName = new System.Windows.Forms.TextBox();
            this.txt_LName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Phone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_AddImage = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            this.ofd_Image = new System.Windows.Forms.OpenFileDialog();
            this.txt_JMBG = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pb_Image = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(228, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "First name";
            // 
            // txt_FName
            // 
            this.txt_FName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_FName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_FName.Location = new System.Drawing.Point(354, 91);
            this.txt_FName.Name = "txt_FName";
            this.txt_FName.Size = new System.Drawing.Size(176, 30);
            this.txt_FName.TabIndex = 1;
            // 
            // txt_LName
            // 
            this.txt_LName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_LName.Location = new System.Drawing.Point(354, 149);
            this.txt_LName.Name = "txt_LName";
            this.txt_LName.Size = new System.Drawing.Size(176, 30);
            this.txt_LName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(228, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last name";
            // 
            // txt_Phone
            // 
            this.txt_Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Phone.Location = new System.Drawing.Point(354, 208);
            this.txt_Phone.Name = "txt_Phone";
            this.txt_Phone.Size = new System.Drawing.Size(176, 30);
            this.txt_Phone.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(228, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Phone";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txt_Email
            // 
            this.txt_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Email.Location = new System.Drawing.Point(354, 266);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(176, 30);
            this.txt_Email.TabIndex = 7;
            this.txt_Email.Leave += new System.EventHandler(this.txt_Email_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(228, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Email";
            // 
            // btn_AddImage
            // 
            this.btn_AddImage.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_AddImage.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_AddImage.Location = new System.Drawing.Point(12, 206);
            this.btn_AddImage.Name = "btn_AddImage";
            this.btn_AddImage.Size = new System.Drawing.Size(149, 32);
            this.btn_AddImage.TabIndex = 14;
            this.btn_AddImage.Text = "Add Image";
            this.btn_AddImage.UseVisualStyleBackColor = false;
            this.btn_AddImage.Click += new System.EventHandler(this.btn_AddImage_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Save.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Save.Location = new System.Drawing.Point(410, 320);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(120, 32);
            this.btn_Save.TabIndex = 15;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // ofd_Image
            // 
            this.ofd_Image.FileName = "openFileDialog1";
            // 
            // txt_JMBG
            // 
            this.txt_JMBG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_JMBG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_JMBG.Location = new System.Drawing.Point(354, 33);
            this.txt_JMBG.Name = "txt_JMBG";
            this.txt_JMBG.Size = new System.Drawing.Size(176, 30);
            this.txt_JMBG.TabIndex = 17;
            this.txt_JMBG.TextChanged += new System.EventHandler(this.txt_JMBG_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(228, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 25);
            this.label7.TabIndex = 16;
            this.label7.Text = "JMBG";
            // 
            // pb_Image
            // 
            this.pb_Image.BackgroundImage = global::MyGyM.Properties.Resources.unnamed;
            this.pb_Image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_Image.Location = new System.Drawing.Point(12, 33);
            this.pb_Image.Name = "pb_Image";
            this.pb_Image.Size = new System.Drawing.Size(149, 150);
            this.pb_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Image.TabIndex = 12;
            this.pb_Image.TabStop = false;
            // 
            // frm_AddNewMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(549, 385);
            this.Controls.Add(this.txt_JMBG);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_AddImage);
            this.Controls.Add(this.pb_Image);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Phone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_LName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_FName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_AddNewMember";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add new";
            this.Load += new System.EventHandler(this.frm_AddNewMember_Load);
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_FName;
        private System.Windows.Forms.TextBox txt_LName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Phone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pb_Image;
        private System.Windows.Forms.Button btn_AddImage;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.ErrorProvider err;
        private System.Windows.Forms.OpenFileDialog ofd_Image;
        private System.Windows.Forms.TextBox txt_JMBG;
        private System.Windows.Forms.Label label7;
    }
}