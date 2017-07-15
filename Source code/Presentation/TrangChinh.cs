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
using System.Data;


namespace QuanLyPhongHop
{
    public partial class TrangChinh : Form
    {
        public TrangChinh()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void quảnLýThànhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThanhVien newthanhvien = new ThanhVien();
            newthanhvien.Show();
        }

        private void quảnLýNgườiDùngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NguoiDung newNguoiDung = new NguoiDung();
            newNguoiDung.Show();
        }

        private void phòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Phong newPhong = new Phong();
            newPhong.Show();
        }

        private void thiếtBịToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThietBi newThietBi = new ThietBi();
            newThietBi.Show();
        }

        private void phòngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ThietBiPhong  newThietBiphong = new ThietBiPhong();
            newThietBiphong.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult hoi;
            hoi = MessageBox.Show(" Bạn có chắc chắn muốn thoát ?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (hoi == DialogResult.Yes)
            {
                this.Close();
            }
        }
        
    }
}
