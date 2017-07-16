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
    public partial class ThietBiPhong : Form
    {
        public ThietBiPhong()
        {
            InitializeComponent();
        }
        ThietBiPhong2 newthietbiphong = new ThietBiPhong2();
        private void ThietBiPhong_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = newthietbiphong.hienthi();
            dtgThietBiPhong.DataSource = dt;


            DataTable dk = new DataTable();
            dk = newthietbiphong.combox();
            cbbMaPhong.DisplayMember = "maphong";
            cbbMaPhong.ValueMember = "maphong";
            cbbMaPhong.DataSource = dk;


            DataTable db = new DataTable();
            db = newthietbiphong.comboxTB();
            cbbMaThietBi.DisplayMember = "matb";
            cbbMaThietBi.ValueMember = "matb";
            cbbMaThietBi.DataSource = db;
        }

      

        private void btnThem_Click(object sender, EventArgs e)
        {
            newthietbiphong.them(txtMaTBP.Text, cbbMaThietBi.Text, cbbMaPhong.Text, int.Parse(txtSoLuong.Text), txtDonViTinh.Text);
            ThietBiPhong_Load(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            newthietbiphong.delete(cbbMaThietBi.Text);
            ThietBiPhong_Load(sender, e);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            newthietbiphong.sua( cbbMaThietBi.Text,cbbMaPhong.Text, int.Parse(txtSoLuong.Text), txtDonViTinh.Text,txtMaTBP.Text);
            ThietBiPhong_Load(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
