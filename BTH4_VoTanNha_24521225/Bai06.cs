using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BTH4_VoTanNha_24521225
{
    public partial class Bai06 : Form
    {
        public Bai06()
        {
            InitializeComponent();
        }

        private void btnSource_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Tất cả file|*.*";
            DialogResult result = ofd.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtSource.Text = ofd.FileName;
            }
        }

        private void btnDestination_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fd= new FolderBrowserDialog();
            DialogResult result=fd.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtDestination.Text = fd.SelectedPath;
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            string source=txtSource.Text;
            string destination=txtDestination.Text;
            if (!File.Exists(source))
            {
                MessageBox.Show("File nguồn không tồn tại!");
                return;
            }

            if (!Directory.Exists(destination))
            {
                MessageBox.Show("Thư mục đích không tồn tại!");
                return;
            }
            destination=Path.Combine(txtDestination.Text,Path.GetFileName(txtSource.Text));
            File.Copy(source, destination,true);
            progressBar1.Value = 0;
            timer1.Start();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if (progressBar1.Value == 100)
            {
                progressBar1.Value = 0;
                timer1.Stop();
                MessageBox.Show("Sao chép thành công");                
            }
            else
            {
                progressBar1.Value += 1;
            }
                
        }

        private void Bai06_Resize(object sender, EventArgs e)
        {
            pnlMain.Location= new Point((ClientSize.Width-pnlMain.Width)/2,(ClientSize.Height-pnlMain.Height)/2);
        }

        private void progressBar1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(progressBar1, progressBar1.Value + "% hoàn thành");
        }
    }
}
