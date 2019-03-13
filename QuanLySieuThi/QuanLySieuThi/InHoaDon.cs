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
    public partial class InHoaDon : Form
    {
        public InHoaDon()
        {
            InitializeComponent();
        }

        private void InHoaDon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ThucTapCSDL2DataSet.In_HoaDon2' table. You can move, or remove it, as needed.
            this.In_HoaDon2TableAdapter.Fill(this.ThucTapCSDL2DataSet.In_HoaDon2,HoaDon.maHD);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
