using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTH4_VoTanNha_24521225
{
    public partial class QuanLy : Form
    {
        public QuanLy()
        {
            InitializeComponent();
            pnlMain.Location = new Point((ClientSize.Width - pnlMain.Width) / 2, (ClientSize.Height - pnlMain.Height) / 2);
        }

        private void QuanLy_Resize(object sender, EventArgs e)
        {
            pnlMain.Location = new Point((ClientSize.Width - pnlMain.Width) / 2, (ClientSize.Height - pnlMain.Height) / 2);
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            switch (cbChoose.Text)
            {
                case "Bai03":
                    Bai03 bai3 = new Bai03();
                    bai3.Show();
                    break;

                case "Bai04":
                    Bai04 bai4 = new Bai04();
                    bai4.Show();
                    break;

                case "Bai05":
                    Bai05 bai5 = new Bai05();
                    bai5.Show();
                    break;

                case "Bai06":
                    Bai06 bai6 = new Bai06();
                    bai6.Show();
                    break;

                default:
                    MessageBox.Show("Vui lòng chọn bài!");
                    break;
            }

        }
    }
}
