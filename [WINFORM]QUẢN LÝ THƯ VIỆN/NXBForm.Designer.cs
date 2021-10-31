
namespace _WINFORM_QUẢN_LÝ_THƯ_VIỆN
{
    partial class NXBForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NXBForm));
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.bt_search = new System.Windows.Forms.Button();
            this.bt_reset = new System.Windows.Forms.Button();
            this.bt_delete = new System.Windows.Forms.Button();
            this.bt_edit = new System.Windows.Forms.Button();
            this.bt_add = new System.Windows.Forms.Button();
            this.Textbox_Search = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.DGV_NXB = new System.Windows.Forms.DataGridView();
            this.nxbidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nxbnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nxbBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLTVDataSet4 = new _WINFORM_QUẢN_LÝ_THƯ_VIỆN.QLTVDataSet4();
            this.Textbox_que = new System.Windows.Forms.TextBox();
            this.Textbox_name = new System.Windows.Forms.TextBox();
            this.Textbox_ID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Textbox_sdt = new System.Windows.Forms.TextBox();
            this.Textbox_email = new System.Windows.Forms.TextBox();
            this.nxbTableAdapter = new _WINFORM_QUẢN_LÝ_THƯ_VIỆN.QLTVDataSet4TableAdapters.nxbTableAdapter();
            this.bt_them = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_NXB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nxbBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTVDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // label11
            // 
            label11.BackColor = System.Drawing.Color.Orange;
            label11.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            label11.Font = new System.Drawing.Font("SVN-Genica Pro", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            label11.Location = new System.Drawing.Point(1, 0);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(1187, 44);
            label11.TabIndex = 83;
            label11.Text = "QUẢN LÝ DANH MỤC NHÀ XUẤT BẢN";
            label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Maroon;
            this.pictureBox4.BackgroundImage = global::_WINFORM_QUẢN_LÝ_THƯ_VIỆN.Properties.Resources.delete_208px;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.Location = new System.Drawing.Point(1158, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(30, 30);
            this.pictureBox4.TabIndex = 91;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // bt_search
            // 
            this.bt_search.BackColor = System.Drawing.Color.OrangeRed;
            this.bt_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_search.Font = new System.Drawing.Font("UTM Akashi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_search.ForeColor = System.Drawing.Color.Transparent;
            this.bt_search.Location = new System.Drawing.Point(1006, 77);
            this.bt_search.Name = "bt_search";
            this.bt_search.Size = new System.Drawing.Size(106, 35);
            this.bt_search.TabIndex = 90;
            this.bt_search.Text = "TÌM KIẾM";
            this.bt_search.UseVisualStyleBackColor = false;
            this.bt_search.Click += new System.EventHandler(this.bt_search_Click);
            // 
            // bt_reset
            // 
            this.bt_reset.BackColor = System.Drawing.Color.OrangeRed;
            this.bt_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_reset.Font = new System.Drawing.Font("UTM Akashi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_reset.ForeColor = System.Drawing.Color.Transparent;
            this.bt_reset.Location = new System.Drawing.Point(742, 460);
            this.bt_reset.Name = "bt_reset";
            this.bt_reset.Size = new System.Drawing.Size(106, 35);
            this.bt_reset.TabIndex = 89;
            this.bt_reset.Text = "RESET";
            this.bt_reset.UseVisualStyleBackColor = false;
            this.bt_reset.Click += new System.EventHandler(this.bt_reset_Click);
            // 
            // bt_delete
            // 
            this.bt_delete.BackColor = System.Drawing.Color.OrangeRed;
            this.bt_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_delete.Font = new System.Drawing.Font("UTM Akashi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_delete.ForeColor = System.Drawing.Color.Transparent;
            this.bt_delete.Location = new System.Drawing.Point(287, 384);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.Size = new System.Drawing.Size(106, 35);
            this.bt_delete.TabIndex = 88;
            this.bt_delete.Text = "XÓA";
            this.bt_delete.UseVisualStyleBackColor = false;
            this.bt_delete.Click += new System.EventHandler(this.bt_delete_Click);
            // 
            // bt_edit
            // 
            this.bt_edit.BackColor = System.Drawing.Color.OrangeRed;
            this.bt_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_edit.Font = new System.Drawing.Font("UTM Akashi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_edit.ForeColor = System.Drawing.Color.Transparent;
            this.bt_edit.Location = new System.Drawing.Point(156, 384);
            this.bt_edit.Name = "bt_edit";
            this.bt_edit.Size = new System.Drawing.Size(106, 35);
            this.bt_edit.TabIndex = 87;
            this.bt_edit.Text = "CHỈNH SỬA";
            this.bt_edit.UseVisualStyleBackColor = false;
            this.bt_edit.Click += new System.EventHandler(this.bt_edit_Click);
            // 
            // bt_add
            // 
            this.bt_add.BackColor = System.Drawing.Color.OrangeRed;
            this.bt_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_add.Font = new System.Drawing.Font("UTM Akashi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_add.ForeColor = System.Drawing.Color.Transparent;
            this.bt_add.Location = new System.Drawing.Point(84, 445);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(106, 35);
            this.bt_add.TabIndex = 86;
            this.bt_add.Text = "LƯU";
            this.bt_add.UseVisualStyleBackColor = false;
            this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
            // 
            // Textbox_Search
            // 
            this.Textbox_Search.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Textbox_Search.Location = new System.Drawing.Point(593, 81);
            this.Textbox_Search.Name = "Textbox_Search";
            this.Textbox_Search.Size = new System.Drawing.Size(381, 29);
            this.Textbox_Search.TabIndex = 85;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(437, 84);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(150, 24);
            this.label10.TabIndex = 84;
            this.label10.Text = "Tìm kiếm NXB:";
            // 
            // DGV_NXB
            // 
            this.DGV_NXB.AutoGenerateColumns = false;
            this.DGV_NXB.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DGV_NXB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_NXB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nxbidDataGridViewTextBoxColumn,
            this.nxbnameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.DGV_NXB.DataSource = this.nxbBindingSource;
            this.DGV_NXB.Location = new System.Drawing.Point(413, 130);
            this.DGV_NXB.Name = "DGV_NXB";
            this.DGV_NXB.RowHeadersVisible = false;
            this.DGV_NXB.Size = new System.Drawing.Size(759, 324);
            this.DGV_NXB.TabIndex = 82;
            this.DGV_NXB.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_NXB_CellClick);
            // 
            // nxbidDataGridViewTextBoxColumn
            // 
            this.nxbidDataGridViewTextBoxColumn.DataPropertyName = "nxb_id";
            this.nxbidDataGridViewTextBoxColumn.HeaderText = "ID NXB";
            this.nxbidDataGridViewTextBoxColumn.Name = "nxbidDataGridViewTextBoxColumn";
            this.nxbidDataGridViewTextBoxColumn.Width = 70;
            // 
            // nxbnameDataGridViewTextBoxColumn
            // 
            this.nxbnameDataGridViewTextBoxColumn.DataPropertyName = "nxb_name";
            this.nxbnameDataGridViewTextBoxColumn.HeaderText = "TÊN NXB";
            this.nxbnameDataGridViewTextBoxColumn.Name = "nxbnameDataGridViewTextBoxColumn";
            this.nxbnameDataGridViewTextBoxColumn.Width = 170;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "ĐỊA CHỈ";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.Width = 150;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "SỐ ĐIỆN THOẠI";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.Width = 150;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "EMAIL";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 200;
            // 
            // nxbBindingSource
            // 
            this.nxbBindingSource.DataMember = "nxb";
            this.nxbBindingSource.DataSource = this.qLTVDataSet4;
            // 
            // qLTVDataSet4
            // 
            this.qLTVDataSet4.DataSetName = "QLTVDataSet4";
            this.qLTVDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Textbox_que
            // 
            this.Textbox_que.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Textbox_que.Location = new System.Drawing.Point(167, 237);
            this.Textbox_que.Name = "Textbox_que";
            this.Textbox_que.Size = new System.Drawing.Size(226, 29);
            this.Textbox_que.TabIndex = 80;
            // 
            // Textbox_name
            // 
            this.Textbox_name.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Textbox_name.Location = new System.Drawing.Point(167, 191);
            this.Textbox_name.Name = "Textbox_name";
            this.Textbox_name.Size = new System.Drawing.Size(226, 29);
            this.Textbox_name.TabIndex = 79;
            // 
            // Textbox_ID
            // 
            this.Textbox_ID.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Textbox_ID.Location = new System.Drawing.Point(167, 144);
            this.Textbox_ID.Name = "Textbox_ID";
            this.Textbox_ID.Size = new System.Drawing.Size(226, 29);
            this.Textbox_ID.TabIndex = 78;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Orange;
            this.label4.Location = new System.Drawing.Point(8, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 24);
            this.label4.TabIndex = 77;
            this.label4.Text = "Số điện thoại:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Orange;
            this.label3.Location = new System.Drawing.Point(62, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 24);
            this.label3.TabIndex = 76;
            this.label3.Text = "Địa chỉ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Orange;
            this.label2.Location = new System.Drawing.Point(40, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 24);
            this.label2.TabIndex = 75;
            this.label2.Text = "Tên NXB:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(44, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 24);
            this.label1.TabIndex = 74;
            this.label1.Text = "Mã NXB:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Orange;
            this.label5.Location = new System.Drawing.Point(72, 324);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 24);
            this.label5.TabIndex = 92;
            this.label5.Text = "Email:";
            // 
            // Textbox_sdt
            // 
            this.Textbox_sdt.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Textbox_sdt.Location = new System.Drawing.Point(167, 279);
            this.Textbox_sdt.Name = "Textbox_sdt";
            this.Textbox_sdt.Size = new System.Drawing.Size(226, 29);
            this.Textbox_sdt.TabIndex = 93;
            // 
            // Textbox_email
            // 
            this.Textbox_email.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Textbox_email.Location = new System.Drawing.Point(167, 322);
            this.Textbox_email.Name = "Textbox_email";
            this.Textbox_email.Size = new System.Drawing.Size(226, 29);
            this.Textbox_email.TabIndex = 94;
            // 
            // nxbTableAdapter
            // 
            this.nxbTableAdapter.ClearBeforeFill = true;
            // 
            // bt_them
            // 
            this.bt_them.BackColor = System.Drawing.Color.OrangeRed;
            this.bt_them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_them.Font = new System.Drawing.Font("UTM Akashi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_them.ForeColor = System.Drawing.Color.Transparent;
            this.bt_them.Location = new System.Drawing.Point(12, 384);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(106, 35);
            this.bt_them.TabIndex = 95;
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
            this.button1.Location = new System.Drawing.Point(228, 445);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 35);
            this.button1.TabIndex = 96;
            this.button1.Text = "QUAY LẠI";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // NXBForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1188, 507);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bt_them);
            this.Controls.Add(this.Textbox_email);
            this.Controls.Add(this.Textbox_sdt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.bt_search);
            this.Controls.Add(this.bt_reset);
            this.Controls.Add(this.bt_delete);
            this.Controls.Add(this.bt_edit);
            this.Controls.Add(this.bt_add);
            this.Controls.Add(this.Textbox_Search);
            this.Controls.Add(this.label10);
            this.Controls.Add(label11);
            this.Controls.Add(this.DGV_NXB);
            this.Controls.Add(this.Textbox_que);
            this.Controls.Add(this.Textbox_name);
            this.Controls.Add(this.Textbox_ID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NXBForm";
            this.Text = "NXBForm";
            this.Load += new System.EventHandler(this.NXBForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_NXB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nxbBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTVDataSet4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button bt_search;
        private System.Windows.Forms.Button bt_reset;
        private System.Windows.Forms.Button bt_delete;
        private System.Windows.Forms.Button bt_edit;
        private System.Windows.Forms.Button bt_add;
        public System.Windows.Forms.TextBox Textbox_Search;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView DGV_NXB;
        private System.Windows.Forms.TextBox Textbox_que;
        public System.Windows.Forms.TextBox Textbox_name;
        public System.Windows.Forms.TextBox Textbox_ID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Textbox_sdt;
        private System.Windows.Forms.TextBox Textbox_email;
        private QLTVDataSet4 qLTVDataSet4;
        private System.Windows.Forms.BindingSource nxbBindingSource;
        private QLTVDataSet4TableAdapters.nxbTableAdapter nxbTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nxbidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nxbnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button bt_them;
        private System.Windows.Forms.Button button1;
    }
}