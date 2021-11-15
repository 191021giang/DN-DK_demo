using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ĐangNhap_DangKy
{
    public partial class FormDN : Form
    {
        public FormDN()
        {
            InitializeComponent();
        }

        private void btAdmin_Click(object sender, EventArgs e)
        {
            FormDNAdmin dlg2 = new FormDNAdmin();
            dlg2.ShowDialog();
        }

        private void btUser_Click(object sender, EventArgs e)
        {
            FormDNUser dlg2 = new FormDNUser();
            dlg2.ShowDialog();
        }

        private void btThoatDN_Click(object sender, EventArgs e)
        {
        
        DialogResult dg = MessageBox.Show("Bạn có muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
                Application.Exit();
        }

        private void btDangKy_Click(object sender, EventArgs e)
        {
            FormDK dlg2 = new FormDK();
            dlg2.ShowDialog();
        }
    }
}