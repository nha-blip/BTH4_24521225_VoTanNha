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
    public partial class Bai03 : Form
    {
        public Bai03()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Bạn có chắc muốn thoát",
                                            "Thoát",
                                            MessageBoxButtons.YesNo,
                                            MessageBoxIcon.Question);
            if(DialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Media Files|*.avi;*.mpeg;*.wav;*.midi;*.mp4;*.mp3";
            DialogResult result= openFileDialog.ShowDialog();
            if(result==DialogResult.OK)
            {
                axWMP.URL = openFileDialog.FileName;
                axWMP.Ctlcontrols.play();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string ngay = DateTime.Now.ToString("dd/MM/yyyy");
            string gio = DateTime.Now.ToString("hh:mm:ss tt");

            tSSLTime.Text =$"Hôm nay là ngày {ngay} - Bây giờ là {gio}";
            
        }
    }
}
