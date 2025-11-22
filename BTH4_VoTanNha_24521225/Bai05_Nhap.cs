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
    public partial class Bai05_Nhap : Form
    {
        private Bai05 formA;
        public Bai05_Nhap(Bai05 f)
        {
            InitializeComponent();
            this.formA = f;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(txtMSSV.Text=="" ||  txtTen.Text=="" || txtDTB.Text == "" || cBKhoa.Text=="")
            {
                MessageBox.Show("Hãy nhập đủ thông tin");
                return;
            }
            if (!int.TryParse(txtMSSV.Text, out int a))
            {
                MessageBox.Show("MSSV phải là số");
                return;
            }

            if (!float.TryParse(txtDTB.Text, out float n))
            {
                MessageBox.Show("Điểm Tb phải là số");
                return;
            }
            else if(n<0 || n > 10)
            {
                MessageBox.Show("Điểm TB phải từ 0 đến 10");
                return;
            }
            foreach (ListViewItem i in formA.l)
            {
                if (i.SubItems[2].Text == txtMSSV.Text)
                {
                    MessageBox.Show("Đã tồn tại MSSV vừa nhập");
                    return;
                }
            }
            ListViewItem item = new ListViewItem("");
            item.SubItems.Add((formA.l.Count+1).ToString());
            item.SubItems.Add(txtMSSV.Text);
            item.SubItems.Add(txtTen.Text);
            item.SubItems.Add(cBKhoa.Text);
            item.SubItems.Add(txtDTB.Text);
            formA.lvSinhVien.Items.Add(item);
            formA.l.Add(item);
            txtMSSV.Text = "";
            txtDTB.Text = "";
            txtTen.Text = "";
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Bai05_Nhap_Resize(object sender, EventArgs e)
        {
            pnlMain.Location = new Point((ClientSize.Width - pnlMain.Width) / 2, (ClientSize.Height - pnlMain.Height) / 2);
        }
    }
}
