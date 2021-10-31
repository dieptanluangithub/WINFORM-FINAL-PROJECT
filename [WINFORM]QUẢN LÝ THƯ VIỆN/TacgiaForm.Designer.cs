
namespace _WINFORM_QUẢN_LÝ_THƯ_VIỆN
{
    partial class TacgiaForm
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
            System.Windows.Forms.Label label11;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TacgiaForm));
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Textbox_que = new System.Windows.Forms.TextBox();
            this.Textbox_name = new System.Windows.Forms.TextBox();
            this.Textbox_ID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DGV_tacgia = new System.Windows.Forms.DataGridView();
            this.tacgiaidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tacgianameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tacgiaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLTVDataSet3 = new _WINFORM_QUẢN_LÝ_THƯ_VIỆN.QLTVDataSet3();
            this.Textbox_Search = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.bt_add = new System.Windows.Forms.Button();
            this.bt_edit = new System.Windows.Forms.Button();
            this.bt_delete = new System.Windows.Forms.Button();
            this.bt_reset = new System.Windows.Forms.Button();
            this.bt_search = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.tacgiaTableAdapter = new _WINFORM_QUẢN_LÝ_THƯ_VIỆN.QLTVDataSet3TableAdapters.tacgiaTableAdapter();
            this.bt_them = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_tacgia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tacgiaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTVDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // label11
            // 
            label11.BackColor = System.Drawing.Color.OrangeRed;
            label11.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            label11.Font = new System.Drawing.Font("SVN-Genica Pro", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            label11.Location = new System.Drawing.Point(0, 0);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(936, 44);
            label11.TabIndex = 60;
            label11.Text = "QUẢN LÝ DANH MỤC TÁC GIẢ";
            label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(144, 259);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(226, 29);
            this.dateTimePicker1.TabIndex = 58;
            // 
            // Textbox_que
            // 
            this.Textbox_que.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Textbox_que.Location = new System.Drawing.Point(144, 213);
            this.Textbox_que.Name = "Textbox_que";
            this.Textbox_que.Size = new System.Drawing.Size(226, 29);
            this.Textbox_que.TabIndex = 57;
            // 
            // Textbox_name
            // 
            this.Textbox_name.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Textbox_name.Location = new System.Drawing.Point(144, 167);
            this.Textbox_name.Name = "Textbox_name";
            this.Textbox_name.Size = new System.Drawing.Size(226, 29);
            this.Textbox_name.TabIndex = 56;
            // 
            // Textbox_ID
            // 
            this.Textbox_ID.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Textbox_ID.Location = new System.Drawing.Point(144, 120);
            this.Textbox_ID.Name = "Textbox_ID";
            this.Textbox_ID.Size = new System.Drawing.Size(226, 29);
            this.Textbox_ID.TabIndex = 55;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Crimson;
            this.label4.Location = new System.Drawing.Point(32, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 24);
            this.label4.TabIndex = 54;
            this.label4.Text = "Năm sinh:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(29, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 24);
            this.label3.TabIndex = 53;
            this.label3.Text = "Quê quán:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(16, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 24);
            this.label2.TabIndex = 52;
            this.label2.Text = "Tên tác giả:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(20, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 24);
            this.label1.TabIndex = 51;
            this.label1.Text = "Mã tác giả:";
            // 
            // DGV_tacgia
            // 
            this.DGV_tacgia.AutoGenerateColumns = false;
            this.DGV_tacgia.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DGV_tacgia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_tacgia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tacgiaidDataGridViewTextBoxColumn,
            this.tacgianameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.bdateDataGridViewTextBoxColumn});
            this.DGV_tacgia.DataSource = this.tacgiaBindingSource;
            this.DGV_tacgia.Location = new System.Drawing.Point(393, 101);
            this.DGV_tacgia.Name = "DGV_tacgia";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_tacgia.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DGV_tacgia.RowHeadersVisible = false;
            this.DGV_tacgia.Size = new System.Drawing.Size(532, 324);
            this.DGV_tacgia.TabIndex = 59;
            this.DGV_tacgia.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_tacgia_CellClick);
            this.DGV_tacgia.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_tacgia_CellDoubleClick);
            // 
            // tacgiaidDataGridViewTextBoxColumn
            // 
            this.tacgiaidDataGridViewTextBoxColumn.DataPropertyName = "tacgia_id";
            this.tacgiaidDataGridViewTextBoxColumn.HeaderText = "ID TÁC GIẢ";
            this.tacgiaidDataGridViewTextBoxColumn.Name = "tacgiaidDataGridViewTextBoxColumn";
            // 
            // tacgianameDataGridViewTextBoxColumn
            // 
            this.tacgianameDataGridViewTextBoxColumn.DataPropertyName = "tacgia_name";
            this.tacgianameDataGridViewTextBoxColumn.HeaderText = "TÊN TÁC GIẢ";
            this.tacgianameDataGridViewTextBoxColumn.Name = "tacgianameDataGridViewTextBoxColumn";
            this.tacgianameDataGridViewTextBoxColumn.Width = 170;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "ĐỊA CHỈ";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.Width = 120;
            // 
            // bdateDataGridViewTextBoxColumn
            // 
            this.bdateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bdateDataGridViewTextBoxColumn.DataPropertyName = "Bdate";
            this.bdateDataGridViewTextBoxColumn.HeaderText = "NĂM SINH";
            this.bdateDataGridViewTextBoxColumn.Name = "bdateDataGridViewTextBoxColumn";
            // 
            // tacgiaBindingSource
            // 
            this.tacgiaBindingSource.DataMember = "tacgia";
            this.tacgiaBindingSource.DataSource = this.qLTVDataSet3;
            // 
            // qLTVDataSet3
            // 
            this.qLTVDataSet3.DataSetName = "QLTVDataSet3";
            this.qLTVDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Textbox_Search
            // 
            this.Textbox_Search.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Textbox_Search.Location = new System.Drawing.Point(548, 56);
            this.Textbox_Search.Name = "Textbox_Search";
            this.Textbox_Search.Size = new System.Drawing.Size(262, 29);
            this.Textbox_Search.TabIndex = 66;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label10.Location = new System.Drawing.Point(387, 58);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(165, 24);
            this.label10.TabIndex = 65;
            this.label10.Text = "Tìm kiếm tác giả:";
            // 
            // bt_add
            // 
            this.bt_add.BackColor = System.Drawing.Color.OrangeRed;
            this.bt_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_add.Font = new System.Drawing.Font("UTM Akashi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_add.ForeColor = System.Drawing.Color.Transparent;
            this.bt_add.Location = new System.Drawing.Point(79, 367);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(106, 35);
            this.bt_add.TabIndex = 68;
            this.bt_add.Text = "LƯU";
            this.bt_add.UseVisualStyleBackColor = false;
            this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
            // 
            // bt_edit
            // 
            this.bt_edit.BackColor = System.Drawing.Color.OrangeRed;
            this.bt_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_edit.Font = new System.Drawing.Font("UTM Akashi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_edit.ForeColor = System.Drawing.Color.Transparent;
            this.bt_edit.Location = new System.Drawing.Point(144, 307);
            this.bt_edit.Name = "bt_edit";
            this.bt_edit.Size = new System.Drawing.Size(106, 35);
            this.bt_edit.TabIndex = 69;
            this.bt_edit.Text = "CHỈNH SỬA";
            this.bt_edit.UseVisualStyleBackColor = false;
            this.bt_edit.Click += new System.EventHandler(this.bt_edit_Click);
            // 
            // bt_delete
            // 
            this.bt_delete.BackColor = System.Drawing.Color.OrangeRed;
            this.bt_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_delete.Font = new System.Drawing.Font("UTM Akashi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_delete.ForeColor = System.Drawing.Color.Transparent;
            this.bt_delete.Location = new System.Drawing.Point(264, 307);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.Size = new System.Drawing.Size(106, 35);
            this.bt_delete.TabIndex = 70;
            this.bt_delete.Text = "XÓA";
            this.bt_delete.UseVisualStyleBackColor = false;
            this.bt_delete.Click += new System.EventHandler(this.bt_delete_Click);
            // 
            // bt_reset
            // 
            this.bt_reset.BackColor = System.Drawing.Color.OrangeRed;
            this.bt_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_reset.Font = new System.Drawing.Font("UTM Akashi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_reset.ForeColor = System.Drawing.Color.Transparent;
            this.bt_reset.Location = new System.Drawing.Point(607, 431);
            this.bt_reset.Name = "bt_reset";
            this.bt_reset.Size = new System.Drawing.Size(106, 35);
            this.bt_reset.TabIndex = 71;
            this.bt_reset.Text = "RESET";
            this.bt_reset.UseVisualStyleBackColor = false;
            this.bt_reset.Click += new System.EventHandler(this.bt_reset_Click);
            // 
            // bt_search
            // 
            this.bt_search.BackColor = System.Drawing.Color.OrangeRed;
            this.bt_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_search.Font = new System.Drawing.Font("UTM Akashi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_search.ForeColor = System.Drawing.Color.Transparent;
            this.bt_search.Location = new System.Drawing.Point(816, 53);
            this.bt_search.Name = "bt_search";
            this.bt_search.Size = new System.Drawing.Size(106, 35);
            this.bt_search.TabIndex = 72;
            this.bt_search.Text = "TÌM KIẾM";
            this.bt_search.UseVisualStyleBackColor = false;
            this.bt_search.Click += new System.EventHandler(this.bt_search_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Maroon;
            this.pictureBox4.BackgroundImage = global::_WINFORM_QUẢN_LÝ_THƯ_VIỆN.Properties.Resources.delete_208px;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.Location = new System.Drawing.Point(906, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(30, 30);
            this.pictureBox4.TabIndex = 73;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // tacgiaTableAdapter
            // 
            this.tacgiaTableAdapter.ClearBeforeFill = true;
            // 
            // bt_them
            // 
            this.bt_them.BackColor = System.Drawing.Color.OrangeRed;
            this.bt_them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_them.Font = new System.Drawing.Font("UTM Akashi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_them.ForeColor = System.Drawing.Color.Transparent;
            this.bt_them.Location = new System.Drawing.Point(26, 307);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(106, 35);
            this.bt_them.TabIndex = 74;
            this.bt_them.Text = "THÊM";
            this.bt_them.UseVisualStyleBackColor = false;
            this.bt_them.Click += new System.EventHandler(this.bt_them_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.OrangeRed;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("UTM Akashi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(199, 367);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 35);
            this.button1.TabIndex = 75;
            this.button1.Text = "QUAY LẠI";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TacgiaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(935, 485);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bt_them);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.bt_search);
            this.Controls.Add(this.bt_reset);
            this.Controls.Add(this.bt_delete);
            this.Controls.Add(this.bt_edit);
            this.Controls.Add(this.bt_add);
            this.Controls.Add(this.Textbox_Search);
            this.Controls.Add(this.label10);
            this.Controls.Add(label11);
            this.Controls.Add(this.DGV_tacgia);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Textbox_que);
            this.Controls.Add(this.Textbox_name);
            this.Controls.Add(this.Textbox_ID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TacgiaForm";
            this.Text = "TacgiaForm";
            this.Load += new System.EventHandler(this.TacgiaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_tacgia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tacgiaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTVDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox Textbox_que;
        public System.Windows.Forms.TextBox Textbox_name;
        public System.Windows.Forms.TextBox Textbox_ID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGV_tacgia;
        public System.Windows.Forms.TextBox Textbox_Search;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button bt_add;
        private System.Windows.Forms.Button bt_edit;
        private System.Windows.Forms.Button bt_delete;
        private System.Windows.Forms.Button bt_reset;
        private System.Windows.Forms.Button bt_search;
        private System.Windows.Forms.PictureBox pictureBox4;
        private QLTVDataSet3 qLTVDataSet3;
        private System.Windows.Forms.BindingSource tacgiaBindingSource;
        private QLTVDataSet3TableAdapters.tacgiaTableAdapter tacgiaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tacgiaidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tacgianameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button bt_them;
        private System.Windows.Forms.Button button1;
    }
}