using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;


namespace QuanLyPhongHop
{
  
    public partial class ThanhVien : Form
    {
        public ThanhVien()
        {
            InitializeComponent();
        }
        ThanhVien2 newthanhvien = new ThanhVien2();

        private void ThanhVien_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = newthanhvien.hienthi();
            dtgThanhVien.DataSource = dt;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            newthanhvien.delete(txtMaThanhVien.Text);
            ThanhVien_Load(sender, e);
        }
        

        private void btnSua_Click(object sender, EventArgs e)
        {

            //newthanhvien.sua(txtTenThanhVien.Text, gioitinh, txtDiaChi.Text, txtEmail.Text, txtSDT.Text, txtMaThanhVien.Text);
            ThanhVien_Load(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        } 
        
        






    }
}
