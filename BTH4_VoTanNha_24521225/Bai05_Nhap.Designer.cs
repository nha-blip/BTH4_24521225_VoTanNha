namespace BTH4_VoTanNha_24521225
{
    partial class Bai05_Nhap
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
            this.lblMSSV = new System.Windows.Forms.Label();
            this.lblTen = new System.Windows.Forms.Label();
            this.lblDTB = new System.Windows.Forms.Label();
            this.lblKhoa = new System.Windows.Forms.Label();
            this.txtMSSV = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtDTB = new System.Windows.Forms.TextBox();
            this.cBKhoa = new System.Windows.Forms.ComboBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMSSV
            // 
            this.lblMSSV.AutoSize = true;
            this.lblMSSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMSSV.Location = new System.Drawing.Point(62, 42);
            this.lblMSSV.Name = "lblMSSV";
            this.lblMSSV.Size = new System.Drawing.Size(90, 22);
            this.lblMSSV.TabIndex = 0;
            this.lblMSSV.Text = "Mã Số SV";
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTen.Location = new System.Drawing.Point(62, 82);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(124, 22);
            this.lblTen.TabIndex = 1;
            this.lblTen.Text = "Tên Sinh Viên";
            // 
            // lblDTB
            // 
            this.lblDTB.AutoSize = true;
            this.lblDTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDTB.Location = new System.Drawing.Point(62, 164);
            this.lblDTB.Name = "lblDTB";
            this.lblDTB.Size = new System.Drawing.Size(80, 22);
            this.lblDTB.TabIndex = 2;
            this.lblDTB.Text = "Điểm TB";
            // 
            // lblKhoa
            // 
            this.lblKhoa.AutoSize = true;
            this.lblKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKhoa.Location = new System.Drawing.Point(62, 123);
            this.lblKhoa.Name = "lblKhoa";
            this.lblKhoa.Size = new System.Drawing.Size(52, 22);
            this.lblKhoa.TabIndex = 3;
            this.lblKhoa.Text = "Khoa";
            // 
            // txtMSSV
            // 
            this.txtMSSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMSSV.Location = new System.Drawing.Point(203, 42);
            this.txtMSSV.Name = "txtMSSV";
            this.txtMSSV.Size = new System.Drawing.Size(252, 28);
            this.txtMSSV.TabIndex = 4;
            // 
            // txtTen
            // 
            this.txtTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen.Location = new System.Drawing.Point(203, 76);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(252, 28);
            this.txtTen.TabIndex = 5;
            // 
            // txtDTB
            // 
            this.txtDTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDTB.Location = new System.Drawing.Point(203, 158);
            this.txtDTB.Name = "txtDTB";
            this.txtDTB.Size = new System.Drawing.Size(252, 28);
            this.txtDTB.TabIndex = 6;
            // 
            // cBKhoa
            // 
            this.cBKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBKhoa.FormattingEnabled = true;
            this.cBKhoa.Items.AddRange(new object[] {
            "Kỹ thuật phần mềm",
            "Công nghệ thông tin",
            "Khoa học máy tính",
            "Trí tuệ nhân tạo",
            "Thương mại điện tử",
            "Kỹ thuật máy tính"});
            this.cBKhoa.Location = new System.Drawing.Point(203, 110);
            this.cBKhoa.Name = "cBKhoa";
            this.cBKhoa.Size = new System.Drawing.Size(252, 30);
            this.cBKhoa.TabIndex = 7;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(156, 217);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(110, 49);
            this.btnThem.TabIndex = 8;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(328, 217);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(110, 49);
            this.btnThoat.TabIndex = 9;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.lblMSSV);
            this.pnlMain.Controls.Add(this.txtTen);
            this.pnlMain.Controls.Add(this.txtDTB);
            this.pnlMain.Controls.Add(this.btnThoat);
            this.pnlMain.Controls.Add(this.cBKhoa);
            this.pnlMain.Controls.Add(this.lblKhoa);
            this.pnlMain.Controls.Add(this.lblTen);
            this.pnlMain.Controls.Add(this.lblDTB);
            this.pnlMain.Controls.Add(this.txtMSSV);
            this.pnlMain.Controls.Add(this.btnThem);
            this.pnlMain.Location = new System.Drawing.Point(138, 79);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(525, 292);
            this.pnlMain.TabIndex = 10;
            // 
            // Bai05_Nhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlMain);
            this.Name = "Bai05_Nhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm sinh viên";
            this.Resize += new System.EventHandler(this.Bai05_Nhap_Resize);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblMSSV;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.Label lblDTB;
        private System.Windows.Forms.Label lblKhoa;
        private System.Windows.Forms.TextBox txtMSSV;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtDTB;
        private System.Windows.Forms.ComboBox cBKhoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Panel pnlMain;
    }
}