using System.Windows.Forms;

namespace BTH4_VoTanNha_24521225
{
    partial class Bai04
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tạoVănBảnMớiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lưuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lưuNộiDungVănBảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.địnhDạngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolBtnNew = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolBtnSave = new System.Windows.Forms.ToolStripButton();
            this.toolCbFont = new System.Windows.Forms.ToolStripComboBox();
            this.toolCbSize = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolBtnBold = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolBtnItalic = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolBtnUnderline = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.rTBSoanThao = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.địnhDạngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tạoVănBảnMớiToolStripMenuItem,
            this.lưuToolStripMenuItem,
            this.lưuNộiDungVănBảnToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.hệThốngToolStripMenuItem.Text = "Hệ Thống";
            // 
            // tạoVănBảnMớiToolStripMenuItem
            // 
            this.tạoVănBảnMớiToolStripMenuItem.Image = global::BTH4_VoTanNha_24521225.Properties.Resources.post_add_24dp_000000_FILL0_wght400_GRAD0_opsz24;
            this.tạoVănBảnMớiToolStripMenuItem.Name = "tạoVănBảnMớiToolStripMenuItem";
            this.tạoVănBảnMớiToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.tạoVănBảnMớiToolStripMenuItem.Size = new System.Drawing.Size(285, 26);
            this.tạoVănBảnMớiToolStripMenuItem.Text = "Tạo văn bản mới";
            this.tạoVănBảnMớiToolStripMenuItem.Click += new System.EventHandler(this.tạoVănBảnMớiToolStripMenuItem_Click);
            // 
            // lưuToolStripMenuItem
            // 
            this.lưuToolStripMenuItem.Image = global::BTH4_VoTanNha_24521225.Properties.Resources.folder_open_24dp_000000_FILL0_wght400_GRAD0_opsz24;
            this.lưuToolStripMenuItem.Name = "lưuToolStripMenuItem";
            this.lưuToolStripMenuItem.Size = new System.Drawing.Size(285, 26);
            this.lưuToolStripMenuItem.Text = "Mở tệp tin";
            this.lưuToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // lưuNộiDungVănBảnToolStripMenuItem
            // 
            this.lưuNộiDungVănBảnToolStripMenuItem.Image = global::BTH4_VoTanNha_24521225.Properties.Resources.save_24dp_000000_FILL0_wght400_GRAD0_opsz24;
            this.lưuNộiDungVănBảnToolStripMenuItem.Name = "lưuNộiDungVănBảnToolStripMenuItem";
            this.lưuNộiDungVănBảnToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.lưuNộiDungVănBảnToolStripMenuItem.Size = new System.Drawing.Size(285, 26);
            this.lưuNộiDungVănBảnToolStripMenuItem.Text = "Lưu nội dung văn bản";
            this.lưuNộiDungVănBảnToolStripMenuItem.Click += new System.EventHandler(this.lưuNộiDungVănBảnToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(285, 26);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // địnhDạngToolStripMenuItem
            // 
            this.địnhDạngToolStripMenuItem.Name = "địnhDạngToolStripMenuItem";
            this.địnhDạngToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.địnhDạngToolStripMenuItem.Text = "Định Dạng";
            this.địnhDạngToolStripMenuItem.Click += new System.EventHandler(this.địnhDạngToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBtnNew,
            this.toolStripSeparator2,
            this.toolBtnSave,
            this.toolCbFont,
            this.toolCbSize,
            this.toolStripSeparator5,
            this.toolBtnBold,
            this.toolStripSeparator1,
            this.toolBtnItalic,
            this.toolStripSeparator3,
            this.toolBtnUnderline,
            this.toolStripSeparator4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 28);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolBtnNew
            // 
            this.toolBtnNew.BackColor = System.Drawing.SystemColors.Window;
            this.toolBtnNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnNew.Image = global::BTH4_VoTanNha_24521225.Properties.Resources.post_add_24dp_000000_FILL0_wght400_GRAD0_opsz24;
            this.toolBtnNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnNew.Name = "toolBtnNew";
            this.toolBtnNew.Size = new System.Drawing.Size(29, 25);
            this.toolBtnNew.Text = "toolStripButton1";
            this.toolBtnNew.Click += new System.EventHandler(this.tạoVănBảnMớiToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 28);
            // 
            // toolBtnSave
            // 
            this.toolBtnSave.BackColor = System.Drawing.SystemColors.Window;
            this.toolBtnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnSave.Image = global::BTH4_VoTanNha_24521225.Properties.Resources.save_24dp_000000_FILL0_wght400_GRAD0_opsz24;
            this.toolBtnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnSave.Name = "toolBtnSave";
            this.toolBtnSave.Size = new System.Drawing.Size(29, 25);
            this.toolBtnSave.Text = "toolStripButton2";
            this.toolBtnSave.Click += new System.EventHandler(this.lưuNộiDungVănBảnToolStripMenuItem_Click);
            // 
            // toolCbFont
            // 
            this.toolCbFont.Name = "toolCbFont";
            this.toolCbFont.Size = new System.Drawing.Size(200, 28);
            this.toolCbFont.Leave += new System.EventHandler(this.toolCbFont_Leave);
            this.toolCbFont.KeyDown += new System.Windows.Forms.KeyEventHandler(this.toolCbFont_KeyDown);
            // 
            // toolCbSize
            // 
            this.toolCbSize.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12 ",
            "14",
            "16",
            "18",
            "20",
            "22",
            "24",
            "26",
            "28",
            "36",
            "48",
            "72"});
            this.toolCbSize.Name = "toolCbSize";
            this.toolCbSize.Size = new System.Drawing.Size(121, 28);
            this.toolCbSize.Leave += new System.EventHandler(this.toolCbSize_Leave);
            this.toolCbSize.KeyDown += new System.Windows.Forms.KeyEventHandler(this.toolcbSize_KeyDown);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 28);
            // 
            // toolBtnBold
            // 
            this.toolBtnBold.BackColor = System.Drawing.SystemColors.Window;
            this.toolBtnBold.CheckOnClick = true;
            this.toolBtnBold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnBold.Image = global::BTH4_VoTanNha_24521225.Properties.Resources.format_bold_24dp_000000_FILL0_wght400_GRAD0_opsz24;
            this.toolBtnBold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnBold.Name = "toolBtnBold";
            this.toolBtnBold.Size = new System.Drawing.Size(29, 25);
            this.toolBtnBold.Text = "toolStripButton3";
            this.toolBtnBold.Click += new System.EventHandler(this.toolBtnBold_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 28);
            // 
            // toolBtnItalic
            // 
            this.toolBtnItalic.BackColor = System.Drawing.SystemColors.Window;
            this.toolBtnItalic.CheckOnClick = true;
            this.toolBtnItalic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnItalic.Image = global::BTH4_VoTanNha_24521225.Properties.Resources.format_italic_24dp_000000_FILL0_wght400_GRAD0_opsz24;
            this.toolBtnItalic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnItalic.Name = "toolBtnItalic";
            this.toolBtnItalic.Size = new System.Drawing.Size(29, 25);
            this.toolBtnItalic.Text = "toolStripButton4";
            this.toolBtnItalic.Click += new System.EventHandler(this.toolBtnItalic_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 28);
            // 
            // toolBtnUnderline
            // 
            this.toolBtnUnderline.BackColor = System.Drawing.SystemColors.Window;
            this.toolBtnUnderline.CheckOnClick = true;
            this.toolBtnUnderline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnUnderline.Image = global::BTH4_VoTanNha_24521225.Properties.Resources.format_underlined_24dp_000000_FILL0_wght400_GRAD0_opsz24;
            this.toolBtnUnderline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnUnderline.Name = "toolBtnUnderline";
            this.toolBtnUnderline.Size = new System.Drawing.Size(29, 25);
            this.toolBtnUnderline.Text = "toolStripButton5";
            this.toolBtnUnderline.Click += new System.EventHandler(this.toolBtnUnderline_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 28);
            // 
            // rTBSoanThao
            // 
            this.rTBSoanThao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rTBSoanThao.BackColor = System.Drawing.SystemColors.Window;
            this.rTBSoanThao.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rTBSoanThao.Location = new System.Drawing.Point(0, 59);
            this.rTBSoanThao.Name = "rTBSoanThao";
            this.rTBSoanThao.Size = new System.Drawing.Size(800, 390);
            this.rTBSoanThao.TabIndex = 3;
            this.rTBSoanThao.Text = "";
            // 
            // Bai04
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rTBSoanThao);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Bai04";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Soạn thảo văn bản";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem địnhDạngToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolBtnNew;
        private System.Windows.Forms.ToolStripButton toolBtnSave;
        private System.Windows.Forms.ToolStripComboBox toolCbFont;
        private System.Windows.Forms.ToolStripComboBox toolCbSize;
        private System.Windows.Forms.ToolStripButton toolBtnBold;
        private System.Windows.Forms.ToolStripButton toolBtnItalic;
        private System.Windows.Forms.ToolStripButton toolBtnUnderline;
        private System.Windows.Forms.ToolStripMenuItem tạoVănBảnMớiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lưuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lưuNộiDungVănBảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.RichTextBox rTBSoanThao;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
    }
}