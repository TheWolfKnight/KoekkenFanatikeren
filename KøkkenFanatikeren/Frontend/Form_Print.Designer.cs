
namespace KøkkenFanatikeren.Frontend
{
    partial class Form_Print
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
            this.tb_From = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_To = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_Print = new System.Windows.Forms.Button();
            this.cb_Completed = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_From
            // 
            this.tb_From.Location = new System.Drawing.Point(12, 72);
            this.tb_From.Name = "tb_From";
            this.tb_From.Size = new System.Drawing.Size(149, 22);
            this.tb_From.TabIndex = 0;
            this.tb_From.TextChanged += new System.EventHandler(this.tb_From_Change);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fra:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Til:";
            // 
            // tb_To
            // 
            this.tb_To.Location = new System.Drawing.Point(12, 128);
            this.tb_To.Name = "tb_To";
            this.tb_To.Size = new System.Drawing.Size(149, 22);
            this.tb_To.TabIndex = 2;
            this.tb_To.TextChanged += new System.EventHandler(this.tb_To_Change);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "DD-MM-YYYY";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(321, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(467, 419);
            this.dataGridView1.TabIndex = 5;
            // 
            // btn_Print
            // 
            this.btn_Print.Location = new System.Drawing.Point(76, 317);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(75, 23);
            this.btn_Print.TabIndex = 6;
            this.btn_Print.Text = "Print";
            this.btn_Print.UseVisualStyleBackColor = true;
            // 
            // cb_Completed
            // 
            this.cb_Completed.AutoSize = true;
            this.cb_Completed.Location = new System.Drawing.Point(12, 171);
            this.cb_Completed.Name = "cb_Completed";
            this.cb_Completed.Size = new System.Drawing.Size(146, 21);
            this.cb_Completed.TabIndex = 7;
            this.cb_Completed.Text = "Tillad ikke færdige";
            this.cb_Completed.UseVisualStyleBackColor = true;
            // 
            // Form_Print
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cb_Completed);
            this.Controls.Add(this.btn_Print);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_To);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_From);
            this.Name = "Form_Print";
            this.Text = "Print";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_From;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_To;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_Print;
        private System.Windows.Forms.CheckBox cb_Completed;
    }
}