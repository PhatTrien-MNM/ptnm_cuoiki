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
    public partial class Phong : Form
    {
        public Phong()
        {
            InitializeComponent();
        }
       Phong2 newphong = new Phong2();
        private void Phong_Load(object sender, EventArgs e)
        {
          DataTable dt = new DataTable();
          dt = newphong.hienthiphong();
          dtgPhong.DataSource = dt;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            newphong.delete(txtMaPhong.Text);
            Phong_Load(sender, e);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            newphong.sua(txtTang.Text,txtKichCo.Text,txtMaPhong.Text);
            Phong_Load(sender, e);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            newphong.them(txtMaPhong.Text, txtTang.Text, txtKichCo.Text);
            Phong_Load(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       



    }
}
