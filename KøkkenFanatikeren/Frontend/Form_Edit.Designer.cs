namespace KøkkenFanatikeren.Frontend
{
    partial class Form_Edit
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_EditCusPhoneNum = new System.Windows.Forms.TextBox();
            this.tb_EditCusName = new System.Windows.Forms.TextBox();
            this.tb_EditCusID = new System.Windows.Forms.TextBox();
            this.tb_EditCusEmail = new System.Windows.Forms.TextBox();
            this.B_SaveExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Full name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Email ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Phone number";
            // 
            // tb_EditCusPhoneNum
            // 
            this.tb_EditCusPhoneNum.Location = new System.Drawing.Point(114, 66);
            this.tb_EditCusPhoneNum.Name = "tb_EditCusPhoneNum";
            this.tb_EditCusPhoneNum.Size = new System.Drawing.Size(175, 22);
            this.tb_EditCusPhoneNum.TabIndex = 4;
            // 
            // tb_EditCusName
            // 
            this.tb_EditCusName.Location = new System.Drawing.Point(114, 38);
            this.tb_EditCusName.Name = "tb_EditCusName";
            this.tb_EditCusName.Size = new System.Drawing.Size(175, 22);
            this.tb_EditCusName.TabIndex = 5;
            // 
            // tb_EditCusID
            // 
            this.tb_EditCusID.Location = new System.Drawing.Point(114, 10);
            this.tb_EditCusID.Name = "tb_EditCusID";
            this.tb_EditCusID.Size = new System.Drawing.Size(175, 22);
            this.tb_EditCusID.TabIndex = 6;
            // 
            // tb_EditCusEmail
            // 
            this.tb_EditCusEmail.Location = new System.Drawing.Point(114, 94);
            this.tb_EditCusEmail.Name = "tb_EditCusEmail";
            this.tb_EditCusEmail.Size = new System.Drawing.Size(175, 22);
            this.tb_EditCusEmail.TabIndex = 7;
            // 
            // B_SaveExit
            // 
            this.B_SaveExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.B_SaveExit.Location = new System.Drawing.Point(207, 202);
            this.B_SaveExit.Name = "B_SaveExit";
            this.B_SaveExit.Size = new System.Drawing.Size(100, 37);
            this.B_SaveExit.TabIndex = 8;
            this.B_SaveExit.Text = "Save && Exit";
            this.B_SaveExit.UseVisualStyleBackColor = true;
            this.B_SaveExit.Click += new System.EventHandler(this.SaveExit_Click);
            // 
            // Form_Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 251);
            this.Controls.Add(this.B_SaveExit);
            this.Controls.Add(this.tb_EditCusEmail);
            this.Controls.Add(this.tb_EditCusID);
            this.Controls.Add(this.tb_EditCusName);
            this.Controls.Add(this.tb_EditCusPhoneNum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_Edit";
            this.Text = "Form_EditCustomer";
            this.Load += new System.EventHandler(this.Form_EditCustomer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_EditCusPhoneNum;
        private System.Windows.Forms.TextBox tb_EditCusName;
        private System.Windows.Forms.TextBox tb_EditCusID;
        private System.Windows.Forms.TextBox tb_EditCusEmail;
        public System.Windows.Forms.Button B_SaveExit;
    }
}