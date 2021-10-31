using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _WINFORM_QUẢN_LÝ_THƯ_VIỆN
{
    public partial class AddStudentForm : Form
    {
        public AddStudentForm()
        {
            InitializeComponent();
        }
        STUDENT std = new STUDENT();
        MY_DB mydb = new MY_DB();
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bt_uploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png,*.gif)|*.jpg;*.png,*.gif";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                pb1.Image = Image.FromFile(opf.FileName);
            }
        }

        private void AddStudentForm_Load(object sender, EventArgs e)
        {
            DONVI dv = new DONVI();
            Combo_Donvi.DataSource = dv.getDonvi();
            Combo_Donvi.DisplayMember = "donvi_name";
            Combo_Donvi.ValueMember = "Id";
            Combo_Donvi.SelectedItem = null;

            
        }
        bool verif()
        {
            if ((Textbox_Fname.Text.Trim() == "")
                || (Textbox_Lname.Text.Trim() == "")
                || (Textbox_Phone.Text.Trim() == "")
                || (Textbox_Address.Text.Trim() == "")
                || (Textbox_Email.Text.Trim() == "")
                || (Textbox_ID.Text.Trim() == "")
                || (pb1.Image == null))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void bt_add_Click(object sender, EventArgs e)
        {
            int cID = Convert.ToInt32(Textbox_ID.Text);
            string fname = Textbox_Fname.Text;
            string lname = Textbox_Lname.Text;
            DateTime BDate = dateTimePicker1.Value.Date;
            string Gender = "Male";
            if (Radiobt_Female.Checked)
            {
                Gender = "Female";
            }
            int donvi = Convert.ToInt32(Combo_Donvi.SelectedValue);
            string address = Textbox_Address.Text;
            string phone = Textbox_Phone.Text;

            string email = Textbox_Email.Text;
            MemoryStream pic = new MemoryStream();
            int born_year = dateTimePicker1.Value.Year;
            int this_year = DateTime.Now.Year;
            pb1.Image.Save(pic, pb1.Image.RawFormat);
            if ((((this_year - born_year) < 15) || ((this_year - born_year) > 80)))
            {
                MessageBox.Show("The Student Age Must Be Between 15 and 30 year", "Invalid Birth Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (verif())
            {
                if (!std.CheckStudent(Convert.ToInt32(Textbox_ID.Text)))
                {
                    if (std.insertStd(cID,fname,lname,BDate,Gender,donvi,address,phone,email,pic))
                    {
                        MessageBox.Show("New Contact Added", "Add Contact", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error", "Add Contact", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("This ID Already Exists, Try Another One", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else
            {
                MessageBox.Show("Empty Fields", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }



        }
    }
}
