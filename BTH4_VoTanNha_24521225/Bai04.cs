using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTH4_VoTanNha_24521225
{
    public partial class Bai04 : Form
    {
        private string currentFilePath;
        public Bai04()
        {
            InitializeComponent();
            toolCbFont.Text = "Tahoma";
            toolCbSize.Text = "14";
            InstalledFontCollection fontCollection = new InstalledFontCollection();
            foreach (FontFamily fontFamily in fontCollection.Families)
                toolCbFont.Items.Add(fontFamily.Name);
            currentFilePath = null;
        }

        private void địnhDạngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                toolCbFont.Text = fontDialog1.Font.Name;
                toolCbSize.Text = fontDialog1.Font.Size.ToString();
                if (fontDialog1.Font.Italic == true)
                {
                    toolBtnItalic.Checked=true;
                }
                if (fontDialog1.Font.Bold == true)
                {
                    toolBtnBold.Checked=true;
                }
                if (fontDialog1.Font.Underline == true)
                {
                    toolBtnUnderline.Checked=true;
                }
                rTBSoanThao.Font= fontDialog1.Font;
            }
        }
        private void toolBtnBold_Click(object sender, EventArgs e)
        {
            if (rTBSoanThao.SelectionFont == null)
                return;
            FontStyle newStyle = rTBSoanThao.SelectionFont.Style ^ FontStyle.Bold;
            rTBSoanThao.SelectionFont = new Font(rTBSoanThao.SelectionFont, newStyle);

        }

        private void toolBtnItalic_Click(object sender, EventArgs e)
        {
            if (rTBSoanThao.SelectionFont == null)
                return;
            FontStyle newStyle = rTBSoanThao.SelectionFont.Style ^ FontStyle.Italic;
            rTBSoanThao.SelectionFont = new Font(rTBSoanThao.SelectionFont, newStyle);
        }

        private void toolBtnUnderline_Click(object sender, EventArgs e)
        {
            if (rTBSoanThao.SelectionFont == null)
                return;
            FontStyle newStyle = rTBSoanThao.SelectionFont.Style ^ FontStyle.Underline;
            rTBSoanThao.SelectionFont = new Font(rTBSoanThao.SelectionFont, newStyle);
        }

        private void lưuNộiDungVănBảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (currentFilePath != null)
            {
                if (Path.GetExtension(currentFilePath).ToLower() == ".txt")
                {
                    rTBSoanThao.SaveFile(currentFilePath, RichTextBoxStreamType.PlainText);
                }
                else
                {
                    rTBSoanThao.SaveFile(currentFilePath, RichTextBoxStreamType.RichText);
                }
                MessageBox.Show("Lưu văn bản thành công!");
                return;
            }
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Rich Text files (*.rtf)|*.rtf";
            DialogResult result = saveFileDialog.ShowDialog();
            if(result== DialogResult.OK)
            {
                rTBSoanThao.SaveFile(saveFileDialog.FileName,RichTextBoxStreamType.RichText);
                currentFilePath = saveFileDialog.FileName;
            }
        }
        private void cbFont_Font()
        {

            InstalledFontCollection font = new InstalledFontCollection();
            foreach(FontFamily f in font.Families)
            {
                if (f.Name == toolCbFont.Text)
                {
                    rTBSoanThao.Font = new Font(f, rTBSoanThao.Font.Size, rTBSoanThao.Font.Style);
                    return;
                }
            }
            toolCbFont.Text=rTBSoanThao.Font.Name;
            MessageBox.Show("Font không hợp lệ");
        }
        private void cbSize_Size()
        {
            if (int.TryParse(toolCbSize.Text, out int tmp))
            {
                if (8 <= tmp && tmp <= 72)
                {
                    rTBSoanThao.Font = new Font(rTBSoanThao.Font.FontFamily, tmp);
                }
                else
                {
                    toolCbSize.Text = rTBSoanThao.Font.Size.ToString();
                    
                }
            }
            else
            {
                MessageBox.Show("Kích thước chữ không hợp lệ");
            }
        }
       

        private void toolcbSize_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) cbSize_Size();
        }

        private void toolCbFont_Leave(object sender, EventArgs e)
        {
            cbFont_Font();
        }

        private void toolCbFont_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) cbFont_Font();
        }

        private void toolCbSize_Leave(object sender, EventArgs e)
        {
            cbSize_Size();
        }

        private void tạoVănBảnMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rTBSoanThao.Text = "";
            rTBSoanThao.Font = new Font("Tahoma", 14F);
            toolCbFont.Text = "Tahoma";
            toolCbSize.Text = "14";
            currentFilePath = null;
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Tập tin văn bản (*.txt,*.rtf)|*.txt;*.rtf";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                currentFilePath = openFileDialog.FileName;
                string path = openFileDialog.FileName;
                string extension = System.IO.Path.GetExtension(path).ToLower();
                if (extension == ".rtf")
                    rTBSoanThao.LoadFile(path, RichTextBoxStreamType.RichText);
                else
                    rTBSoanThao.LoadFile(path, RichTextBoxStreamType.PlainText);
            }
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát",
                                                    "Thoát",
                                                   MessageBoxButtons.YesNo,
                                                   MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
