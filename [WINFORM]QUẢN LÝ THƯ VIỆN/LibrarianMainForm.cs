using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _WINFORM_QUẢN_LÝ_THƯ_VIỆN
{
    public partial class LibrarianMainForm : Form
    {
        public LibrarianMainForm()
        {
            InitializeComponent();
        }
        private void đỘCGIẢToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DocgiaForm doc = new DocgiaForm();
            
            this.Visible = false;
            doc.ShowDialog();
            this.Visible = true;
        }

        private void tÁCGIẢToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TacgiaForm tg = new TacgiaForm();
            
            this.Visible = false;
            tg.ShowDialog();
            this.Visible = true;
        }

        private void nHÀXUẤTBẢNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NXBForm nxb = new NXBForm();
            
            this.Visible = false;
            nxb.ShowDialog();
            this.Visible = true;
        }

        private void sÁCHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SachForm s = new SachForm();
            this.Visible = false;
            s.ShowDialog();
            this.Visible = true;
        }

        private void nHÂNVIÊNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NhanvienForm nv = new NhanvienForm();
            this.Visible = false;
            nv.ShowDialog();
            this.Visible = true;
        }

        private void mƯỢNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MuonForm muon = new MuonForm();
            this.Visible = false;
            muon.ShowDialog();
            this.Visible = true;
        }

        private void tRẢToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChomuonForm cm = new ChomuonForm();
            this.Visible = false;
            cm.ShowDialog();
            this.Visible = true;
        }

        private void tHỐNGKÊToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongKeForm thong = new ThongKeForm();
            this.Visible = false;
            thong.ShowDialog();
            this.Visible = true;
        }

        private void sÁCHMƯỢNNHIỀUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SachmuonnhieuForm nhieu = new SachmuonnhieuForm();
            this.Visible = false;
            nhieu.ShowDialog();
            this.Visible = true;
        }
    }
}
