
namespace _WINFORM_QUẢN_LÝ_THƯ_VIỆN
{
    partial class ThongKeForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.groupBox_Group = new System.Windows.Forms.GroupBox();
            this.label_AllUser = new System.Windows.Forms.Label();
            this.label_FilterUser = new System.Windows.Forms.Label();
            this.comboBox_FilterGroup = new System.Windows.Forms.ComboBox();
            this.DGV_TKNguoi = new System.Windows.Forms.DataGridView();
            this.groupBox_Book = new System.Windows.Forms.GroupBox();
            this.dataGridView_StatisticBook = new System.Windows.Forms.DataGridView();
            this.label_AllBook = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_FilterBook = new System.Windows.Forms.ComboBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox_Group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_TKNguoi)).BeginInit();
            this.groupBox_Book.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_StatisticBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_Group
            // 
            this.groupBox_Group.Controls.Add(this.chart1);
            this.groupBox_Group.Controls.Add(this.DGV_TKNguoi);
            this.groupBox_Group.Controls.Add(this.label_AllUser);
            this.groupBox_Group.Controls.Add(this.label_FilterUser);
            this.groupBox_Group.Controls.Add(this.comboBox_FilterGroup);
            this.groupBox_Group.Font = new System.Drawing.Font("iCielBC Cubano Normal", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_Group.ForeColor = System.Drawing.Color.OrangeRed;
            this.groupBox_Group.Location = new System.Drawing.Point(9, 0);
            this.groupBox_Group.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox_Group.Name = "groupBox_Group";
            this.groupBox_Group.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox_Group.Size = new System.Drawing.Size(1053, 324);
            this.groupBox_Group.TabIndex = 1;
            this.groupBox_Group.TabStop = false;
            this.groupBox_Group.Text = "NHÂN SỰ";
            // 
            // label_AllUser
            // 
            this.label_AllUser.AutoSize = true;
            this.label_AllUser.Font = new System.Drawing.Font("iCielBC Cubano Normal", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_AllUser.ForeColor = System.Drawing.Color.DarkBlue;
            this.label_AllUser.Location = new System.Drawing.Point(68, 51);
            this.label_AllUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_AllUser.Name = "label_AllUser";
            this.label_AllUser.Size = new System.Drawing.Size(239, 23);
            this.label_AllUser.TabIndex = 3;
            this.label_AllUser.Text = "Tổng số người sử dụng:";
            // 
            // label_FilterUser
            // 
            this.label_FilterUser.AutoSize = true;
            this.label_FilterUser.Font = new System.Drawing.Font("iCielBC Cubano Normal", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_FilterUser.Location = new System.Drawing.Point(548, 51);
            this.label_FilterUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_FilterUser.Name = "label_FilterUser";
            this.label_FilterUser.Size = new System.Drawing.Size(159, 23);
            this.label_FilterUser.TabIndex = 1;
            this.label_FilterUser.Text = "Thống kê theo:";
            // 
            // comboBox_FilterGroup
            // 
            this.comboBox_FilterGroup.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_FilterGroup.FormattingEnabled = true;
            this.comboBox_FilterGroup.Location = new System.Drawing.Point(709, 49);
            this.comboBox_FilterGroup.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_FilterGroup.Name = "comboBox_FilterGroup";
            this.comboBox_FilterGroup.Size = new System.Drawing.Size(324, 26);
            this.comboBox_FilterGroup.TabIndex = 0;
            this.comboBox_FilterGroup.TextChanged += new System.EventHandler(this.comboBox_FilterGroup_TextChanged);
            // 
            // DGV_TKNguoi
            // 
            this.DGV_TKNguoi.BackgroundColor = System.Drawing.Color.White;
            this.DGV_TKNguoi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGV_TKNguoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_TKNguoi.Location = new System.Drawing.Point(20, 90);
            this.DGV_TKNguoi.Name = "DGV_TKNguoi";
            this.DGV_TKNguoi.RowHeadersVisible = false;
            this.DGV_TKNguoi.Size = new System.Drawing.Size(631, 217);
            this.DGV_TKNguoi.TabIndex = 4;
            // 
            // groupBox_Book
            // 
            this.groupBox_Book.Controls.Add(this.chart2);
            this.groupBox_Book.Controls.Add(this.dataGridView_StatisticBook);
            this.groupBox_Book.Controls.Add(this.label_AllBook);
            this.groupBox_Book.Controls.Add(this.label2);
            this.groupBox_Book.Controls.Add(this.comboBox_FilterBook);
            this.groupBox_Book.Font = new System.Drawing.Font("iCielBC Cubano Normal", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_Book.ForeColor = System.Drawing.Color.Crimson;
            this.groupBox_Book.Location = new System.Drawing.Point(9, 325);
            this.groupBox_Book.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox_Book.Name = "groupBox_Book";
            this.groupBox_Book.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox_Book.Size = new System.Drawing.Size(1053, 423);
            this.groupBox_Book.TabIndex = 2;
            this.groupBox_Book.TabStop = false;
            this.groupBox_Book.Text = "SỐ LƯỢNG SÁCH";
            // 
            // dataGridView_StatisticBook
            // 
            this.dataGridView_StatisticBook.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_StatisticBook.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_StatisticBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_StatisticBook.Location = new System.Drawing.Point(9, 90);
            this.dataGridView_StatisticBook.Name = "dataGridView_StatisticBook";
            this.dataGridView_StatisticBook.RowHeadersVisible = false;
            this.dataGridView_StatisticBook.Size = new System.Drawing.Size(666, 322);
            this.dataGridView_StatisticBook.TabIndex = 4;
            // 
            // label_AllBook
            // 
            this.label_AllBook.AutoSize = true;
            this.label_AllBook.Font = new System.Drawing.Font("iCielBC Cubano Normal", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_AllBook.ForeColor = System.Drawing.Color.Green;
            this.label_AllBook.Location = new System.Drawing.Point(68, 51);
            this.label_AllBook.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_AllBook.Name = "label_AllBook";
            this.label_AllBook.Size = new System.Drawing.Size(342, 23);
            this.label_AllBook.TabIndex = 3;
            this.label_AllBook.Text = "TỔNG SỐ LƯỢNG SÁCH CỦA THƯ VIỆN:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("iCielBC Cubano Normal", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(548, 51);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Thống kê theo:";
            // 
            // comboBox_FilterBook
            // 
            this.comboBox_FilterBook.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_FilterBook.FormattingEnabled = true;
            this.comboBox_FilterBook.Location = new System.Drawing.Point(709, 49);
            this.comboBox_FilterBook.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_FilterBook.Name = "comboBox_FilterBook";
            this.comboBox_FilterBook.Size = new System.Drawing.Size(324, 26);
            this.comboBox_FilterBook.TabIndex = 0;
            this.comboBox_FilterBook.TextChanged += new System.EventHandler(this.comboBox_FilterBook_TextChanged);
            // 
            // chart1
            // 
            chartArea1.BackColor = System.Drawing.Color.PowderBlue;
            chartArea1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.VerticalCenter;
            chartArea1.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.BackwardDiagonal;
            chartArea1.BackSecondaryColor = System.Drawing.Color.White;
            chartArea1.BorderColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            chartArea1.ShadowColor = System.Drawing.Color.DimGray;
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend1.IsTextAutoFit = false;
            legend1.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Row;
            legend1.Name = "Sách";
            legend1.TitleForeColor = System.Drawing.Color.DarkRed;
            legend1.TitleSeparatorColor = System.Drawing.Color.White;
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(655, 80);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series1.ChartArea = "ChartArea1";
            series1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.Legend = "Sách";
            series1.Name = "Người";
            series1.YValuesPerPoint = 4;
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(395, 244);
            this.chart1.TabIndex = 121;
            this.chart1.Text = "chart1";
            title1.BackColor = System.Drawing.Color.White;
            title1.Font = new System.Drawing.Font("iCielBC Cubano Normal", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.ForeColor = System.Drawing.Color.OrangeRed;
            title1.Name = "Sách";
            title1.Text = "BIỂU ĐỒ THỐNG KÊ";
            this.chart1.Titles.Add(title1);
            // 
            // chart2
            // 
            chartArea2.BackColor = System.Drawing.Color.White;
            chartArea2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.VerticalCenter;
            chartArea2.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.BackwardDiagonal;
            chartArea2.BackSecondaryColor = System.Drawing.Color.White;
            chartArea2.BorderColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "ChartArea1";
            chartArea2.ShadowColor = System.Drawing.Color.DimGray;
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend2.IsTextAutoFit = false;
            legend2.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Row;
            legend2.Name = "Sách";
            legend2.TitleForeColor = System.Drawing.Color.DarkRed;
            legend2.TitleSeparatorColor = System.Drawing.Color.White;
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(671, 104);
            this.chart2.Name = "chart2";
            series2.ChartArea = "ChartArea1";
            series2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series2.Legend = "Sách";
            series2.Name = "Sách";
            series2.YValuesPerPoint = 4;
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(395, 291);
            this.chart2.TabIndex = 122;
            this.chart2.Text = "chart2";
            title2.BackColor = System.Drawing.Color.White;
            title2.Font = new System.Drawing.Font("iCielBC Cubano Normal", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title2.ForeColor = System.Drawing.Color.OrangeRed;
            title2.Name = "Sách";
            title2.Text = "BIỂU ĐỒ THỐNG KÊ";
            this.chart2.Titles.Add(title2);
            // 
            // ThongKeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1069, 749);
            this.Controls.Add(this.groupBox_Book);
            this.Controls.Add(this.groupBox_Group);
            this.Name = "ThongKeForm";
            this.Text = "ThongKeForm";
            this.Load += new System.EventHandler(this.ThongKeForm_Load);
            this.groupBox_Group.ResumeLayout(false);
            this.groupBox_Group.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_TKNguoi)).EndInit();
            this.groupBox_Book.ResumeLayout(false);
            this.groupBox_Book.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_StatisticBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_Group;
        private System.Windows.Forms.Label label_AllUser;
        private System.Windows.Forms.Label label_FilterUser;
        private System.Windows.Forms.ComboBox comboBox_FilterGroup;
        private System.Windows.Forms.DataGridView DGV_TKNguoi;
        private System.Windows.Forms.GroupBox groupBox_Book;
        private System.Windows.Forms.DataGridView dataGridView_StatisticBook;
        private System.Windows.Forms.Label label_AllBook;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_FilterBook;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
    }
}