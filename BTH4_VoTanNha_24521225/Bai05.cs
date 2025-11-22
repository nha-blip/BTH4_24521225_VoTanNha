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
    
    public partial class Bai05 : Form
    {
        public List<ListViewItem> l;
        public Bai05()
        {
            InitializeComponent();
            l=new List<ListViewItem>();
        }

        private void Bai05_Resize(object sender, EventArgs e)
        {
            lvSinhVien.Columns[0].Width = lvSinhVien.Size.Width / 13;
            lvSinhVien.Columns[1].Width = lvSinhVien.Size.Width * 2 / 13;
            lvSinhVien.Columns[2].Width = lvSinhVien.Size.Width * 2 / 13;            
            lvSinhVien.Columns[3].Width = lvSinhVien.Size.Width * 3 / 13;
            lvSinhVien.Columns[4].Width = lvSinhVien.Size.Width * 3 / 13;
            lvSinhVien.Columns[5].Width = lvSinhVien.Size.Width * 2 / 13;
        }

        private void thêmMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bai05_Nhap f = new Bai05_Nhap(this);
            f.Show();
        }

        private void toolStripTxtSearch_TextChanged(object sender, EventArgs e)
        {
            lvSinhVien.Items.Clear();
            string filter = toolStripTxtSearch.Text;
            if (string.IsNullOrEmpty(filter))
            {
                lvSinhVien.Items.AddRange(l.ToArray());
                return;
            }
            foreach (ListViewItem item in l)
            {
                if(item.SubItems[3].Text.IndexOf(filter, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    lvSinhVien.Items.Add(item);
                }
            }
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Thoát",
                                                    "Bạn có chắc muốn thoát",
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
