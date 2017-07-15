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
    public partial class ThietBi : Form
    {
        
        public ThietBi()
        {
            InitializeComponent();
        }
        ThietBi2 newthietbi = new ThietBi2();


        private void ThietBi_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = newthietbi.hienthi();
            dtgThietBi.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            newthietbi.delete(txtMaThietBi.Text);
            ThietBi_Load(sender, e);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
           newthietbi.sua(txtTenThietBi.Text,txtMaThietBi.Text);
          ThietBi_Load(sender, e);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            newthietbi.them(txtMaThietBi.Text, txtTenThietBi.Text);
            ThietBi_Load(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
