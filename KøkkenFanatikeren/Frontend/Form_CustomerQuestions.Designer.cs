
namespace KøkkenFanatikeren.Frontend
{
    partial class Form_CustomerQuestions
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
            this.btn_Submit = new System.Windows.Forms.Button();
            this.btn_PrevQuest = new System.Windows.Forms.Button();
            this.lb_Question = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Submit
            // 
            this.btn_Submit.Location = new System.Drawing.Point(302, 317);
            this.btn_Submit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(98, 38);
            this.btn_Submit.TabIndex = 0;
            this.btn_Submit.Text = "Næste spørgsmål";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // btn_PrevQuest
            // 
            this.btn_PrevQuest.Location = new System.Drawing.Point(200, 317);
            this.btn_PrevQuest.Margin = new System.Windows.Forms.Padding(2);
            this.btn_PrevQuest.Name = "btn_PrevQuest";
            this.btn_PrevQuest.Size = new System.Drawing.Size(98, 38);
            this.btn_PrevQuest.TabIndex = 1;
            this.btn_PrevQuest.Text = "Forige spørgsmål";
            this.btn_PrevQuest.UseVisualStyleBackColor = true;
            // 
            // lb_Question
            // 
            this.lb_Question.AutoSize = true;
            this.lb_Question.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lb_Question.Location = new System.Drawing.Point(308, 21);
            this.lb_Question.Name = "lb_Question";
            this.lb_Question.Size = new System.Drawing.Size(52, 25);
            this.lb_Question.TabIndex = 2;
            this.lb_Question.Text = "TBD";
            // 
            // Form_CustomerQuestions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.lb_Question);
            this.Controls.Add(this.btn_PrevQuest);
            this.Controls.Add(this.btn_Submit);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form_CustomerQuestions";
            this.Text = "Kunde Spørsmål";
            this.Load += new System.EventHandler(this.Form_CustomerQuestions_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.Button btn_PrevQuest;
        public System.Windows.Forms.Label lb_Question;
    }
}