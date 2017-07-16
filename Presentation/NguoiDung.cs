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
    public partial class NguoiDung : Form
    {
        public NguoiDung()
        {
            InitializeComponent();
        }
        NguoiDung2 newnguoidung = new NguoiDung2();

        private void NguoiDung_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = newnguoidung.hienthi();
            dtgNguoiDung.DataSource = dt;

            DataTable dk = new DataTable();
            dk = newnguoidung.combox();
            CboMaPhong.DisplayMember = "maphong";
            CboMaPhong.ValueMember = "maphong";
            CboMaPhong.DataSource = dk;



        }

        private void button3_Click(object sender, EventArgs e)
        {
            newnguoidung.delete(txtMaNguoiDung.Text);
            NguoiDung_Load(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}
