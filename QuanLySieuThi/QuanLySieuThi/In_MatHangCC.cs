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
    public partial class In_MatHangCC : Form
    {
        public In_MatHangCC()
        {
            InitializeComponent();
        }

        private void In_MatHangCC_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ThucTapCSDL2DataSet2.In_MatHangCC' table. You can move, or remove it, as needed.
            this.In_MatHangCCTableAdapter.Fill(this.ThucTapCSDL2DataSet2.In_MatHangCC,NhaCC.maNCC_Report);

            this.reportViewer1.RefreshReport();
        }
    }
}
