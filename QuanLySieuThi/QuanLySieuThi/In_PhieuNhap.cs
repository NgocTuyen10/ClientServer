using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySieuThi
{
    public partial class In_PhieuNhap : Form
    {
        public In_PhieuNhap()
        {
            InitializeComponent();
        }

        private void In_PhieuNhap_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ThucTapCSDL2DataSet3.In_PhieuNhap' table. You can move, or remove it, as needed.
            this.In_PhieuNhapTableAdapter.Fill(this.ThucTapCSDL2DataSet3.In_PhieuNhap,NhapHang.maPhieuNhap);

            this.reportViewer1.RefreshReport();
        }
    }
}
