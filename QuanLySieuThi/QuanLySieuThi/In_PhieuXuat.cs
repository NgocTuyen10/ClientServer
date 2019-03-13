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
    public partial class In_PhieuXuat : Form
    {
        public In_PhieuXuat()
        {
            InitializeComponent();
        }

        private void In_PhieuXuat_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ThucTapCSDL2DataSet4.In_PhieuXuat' table. You can move, or remove it, as needed.
            this.In_PhieuXuatTableAdapter.Fill(this.ThucTapCSDL2DataSet4.In_PhieuXuat,XuatHang.maPhieuXuat);

            this.reportViewer1.RefreshReport();
        }
    }
}
