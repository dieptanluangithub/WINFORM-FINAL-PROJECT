
namespace _WINFORM_QUẢN_LÝ_THƯ_VIỆN
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sÁCHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mƯỢNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tRẢToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.IndianRed;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sÁCHToolStripMenuItem,
            this.mƯỢNToolStripMenuItem,
            this.tRẢToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(21, 151);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(204, 27);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sÁCHToolStripMenuItem
            // 
            this.sÁCHToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sÁCHToolStripMenuItem.Name = "sÁCHToolStripMenuItem";
            this.sÁCHToolStripMenuItem.Size = new System.Drawing.Size(64, 23);
            this.sÁCHToolStripMenuItem.Text = "SÁCH";
            // 
            // mƯỢNToolStripMenuItem
            // 
            this.mƯỢNToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mƯỢNToolStripMenuItem.Name = "mƯỢNToolStripMenuItem";
            this.mƯỢNToolStripMenuItem.Size = new System.Drawing.Size(74, 23);
            this.mƯỢNToolStripMenuItem.Text = "MƯỢN";
            // 
            // tRẢToolStripMenuItem
            // 
            this.tRẢToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tRẢToolStripMenuItem.Name = "tRẢToolStripMenuItem";
            this.tRẢToolStripMenuItem.Size = new System.Drawing.Size(54, 23);
            this.tRẢToolStripMenuItem.Text = "TRẢ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::_WINFORM_QUẢN_LÝ_THƯ_VIỆN.Properties.Resources.Artboard_1_4x;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(919, 133);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(914, 508);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sÁCHToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mƯỢNToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tRẢToolStripMenuItem;
    }
}