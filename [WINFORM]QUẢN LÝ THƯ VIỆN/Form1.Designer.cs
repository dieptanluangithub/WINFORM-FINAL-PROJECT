
namespace _WINFORM_QUẢN_LÝ_THƯ_VIỆN
{
    partial class TrasachForm
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
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton_nguyên = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.Label_thoihan = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.OrangeRed;
            this.label11.Font = new System.Drawing.Font("SVN-Genica Pro", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(-5, 1);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(540, 43);
            this.label11.TabIndex = 61;
            this.label11.Text = "TÌNH TRẠNG TRẢ SÁCH";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(27, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 24);
            this.label3.TabIndex = 91;
            this.label3.Text = "Tình trạng sách khi trả:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(27, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 24);
            this.label2.TabIndex = 90;
            this.label2.Text = "Thời hạn trả sách:";
            // 
            // radioButton_nguyên
            // 
            this.radioButton_nguyên.AutoSize = true;
            this.radioButton_nguyên.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_nguyên.ForeColor = System.Drawing.SystemColors.InfoText;
            this.radioButton_nguyên.Location = new System.Drawing.Point(251, 146);
            this.radioButton_nguyên.Name = "radioButton_nguyên";
            this.radioButton_nguyên.Size = new System.Drawing.Size(133, 28);
            this.radioButton_nguyên.TabIndex = 92;
            this.radioButton_nguyên.TabStop = true;
            this.radioButton_nguyên.Text = "Nguyên vẹn";
            this.radioButton_nguyên.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.radioButton2.Location = new System.Drawing.Point(401, 146);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(106, 28);
            this.radioButton2.TabIndex = 93;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Hư hỏng";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // Label_thoihan
            // 
            this.Label_thoihan.BackColor = System.Drawing.Color.Transparent;
            this.Label_thoihan.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_thoihan.ForeColor = System.Drawing.Color.Black;
            this.Label_thoihan.Location = new System.Drawing.Point(205, 85);
            this.Label_thoihan.Name = "Label_thoihan";
            this.Label_thoihan.Size = new System.Drawing.Size(250, 36);
            this.Label_thoihan.TabIndex = 94;
            this.Label_thoihan.Text = "Xin chào: Thiện Tâm";
            this.Label_thoihan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TrasachForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(533, 316);
            this.Controls.Add(this.Label_thoihan);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton_nguyên);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label11);
            this.Name = "TrasachForm";
            this.Text = "TRẢ SÁCH";
            this.Load += new System.EventHandler(this.TrasachForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButton_nguyên;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label Label_thoihan;
    }
}