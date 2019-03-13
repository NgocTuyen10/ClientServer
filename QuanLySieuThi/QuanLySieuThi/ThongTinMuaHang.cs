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
    public partial class ThongTinMuaHang : Form
    {
        public ThongTinMuaHang()
        {
            InitializeComponent();
        }

        private void ThongTinMuaHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ThucTapCSDL2DataSet1.In_ThongTinMuaHang' table. You can move, or remove it, as needed.
           // this.In_ThongTinMuaHangTableAdapter.Fill(this.ThucTapCSDL2DataSet1.In_ThongTinMuaHang,KhachHang.maKH);

//            this.reportViewer1.RefreshReport();
        }
    }
}
