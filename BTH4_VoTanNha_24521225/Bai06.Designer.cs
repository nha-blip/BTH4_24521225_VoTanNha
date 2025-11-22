namespace BTH4_VoTanNha_24521225
{
    partial class Bai06
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
            this.components = new System.ComponentModel.Container();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.gBPath = new System.Windows.Forms.GroupBox();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnDestination = new System.Windows.Forms.Button();
            this.btnSource = new System.Windows.Forms.Button();
            this.txtDestination = new System.Windows.Forms.TextBox();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.lblDestination = new System.Windows.Forms.Label();
            this.lblSource = new System.Windows.Forms.Label();
            this.gBprogress = new System.Windows.Forms.GroupBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlMain = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.gBPath.SuspendLayout();
            this.gBprogress.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(68, 43);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(792, 23);
            this.progressBar1.TabIndex = 0;
            this.progressBar1.MouseHover += new System.EventHandler(this.progressBar1_MouseHover);
            // 
            // gBPath
            // 
            this.gBPath.Controls.Add(this.btnCopy);
            this.gBPath.Controls.Add(this.btnDestination);
            this.gBPath.Controls.Add(this.btnSource);
            this.gBPath.Controls.Add(this.txtDestination);
            this.gBPath.Controls.Add(this.txtSource);
            this.gBPath.Controls.Add(this.lblDestination);
            this.gBPath.Controls.Add(this.lblSource);
            this.gBPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBPath.Location = new System.Drawing.Point(30, 30);
            this.gBPath.Name = "gBPath";
            this.gBPath.Size = new System.Drawing.Size(956, 201);
            this.gBPath.TabIndex = 1;
            this.gBPath.TabStop = false;
            this.gBPath.Text = "Sao chép tập tin";
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(456, 135);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(115, 35);
            this.btnCopy.TabIndex = 6;
            this.btnCopy.Text = "Sao chép";
            this.toolTip1.SetToolTip(this.btnCopy, "Bắt đầu sao chép file");
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnDestination
            // 
            this.btnDestination.Location = new System.Drawing.Point(785, 98);
            this.btnDestination.Name = "btnDestination";
            this.btnDestination.Size = new System.Drawing.Size(75, 28);
            this.btnDestination.TabIndex = 5;
            this.btnDestination.Text = "...";
            this.toolTip1.SetToolTip(this.btnDestination, "Chọn nơi lưu file đích");
            this.btnDestination.UseVisualStyleBackColor = true;
            this.btnDestination.Click += new System.EventHandler(this.btnDestination_Click);
            // 
            // btnSource
            // 
            this.btnSource.Location = new System.Drawing.Point(785, 65);
            this.btnSource.Name = "btnSource";
            this.btnSource.Size = new System.Drawing.Size(75, 27);
            this.btnSource.TabIndex = 4;
            this.btnSource.Text = "...";
            this.toolTip1.SetToolTip(this.btnSource, "Chọn file nguồn cần sao chép");
            this.btnSource.UseVisualStyleBackColor = true;
            this.btnSource.Click += new System.EventHandler(this.btnSource_Click);
            // 
            // txtDestination
            // 
            this.txtDestination.Location = new System.Drawing.Point(277, 102);
            this.txtDestination.Name = "txtDestination";
            this.txtDestination.Size = new System.Drawing.Size(481, 27);
            this.txtDestination.TabIndex = 3;
            // 
            // txtSource
            // 
            this.txtSource.Location = new System.Drawing.Point(277, 65);
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(481, 27);
            this.txtSource.TabIndex = 2;
            // 
            // lblDestination
            // 
            this.lblDestination.AutoSize = true;
            this.lblDestination.Location = new System.Drawing.Point(22, 109);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(190, 20);
            this.lblDestination.TabIndex = 1;
            this.lblDestination.Text = "Đường dẫn thư mục đích";
            // 
            // lblSource
            // 
            this.lblSource.AutoSize = true;
            this.lblSource.Location = new System.Drawing.Point(22, 65);
            this.lblSource.Name = "lblSource";
            this.lblSource.Size = new System.Drawing.Size(204, 20);
            this.lblSource.TabIndex = 0;
            this.lblSource.Text = "Đường dẫn thư mục nguồn";
            // 
            // gBprogress
            // 
            this.gBprogress.Controls.Add(this.progressBar1);
            this.gBprogress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBprogress.Location = new System.Drawing.Point(30, 260);
            this.gBprogress.Name = "gBprogress";
            this.gBprogress.Size = new System.Drawing.Size(956, 100);
            this.gBprogress.TabIndex = 2;
            this.gBprogress.TabStop = false;
            this.gBprogress.Text = "Tiến trình sao chép";
            // 
            // timer1
            // 
            this.timer1.Interval = 25;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.gBprogress);
            this.pnlMain.Controls.Add(this.gBPath);
            this.pnlMain.Location = new System.Drawing.Point(38, 28);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1031, 394);
            this.pnlMain.TabIndex = 3;
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // Bai06
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 450);
            this.Controls.Add(this.pnlMain);
            this.Name = "Bai06";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bai06";
            this.Resize += new System.EventHandler(this.Bai06_Resize);
            this.gBPath.ResumeLayout(false);
            this.gBPath.PerformLayout();
            this.gBprogress.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.GroupBox gBPath;
        private System.Windows.Forms.GroupBox gBprogress;
        private System.Windows.Forms.Label lblDestination;
        private System.Windows.Forms.Label lblSource;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnDestination;
        private System.Windows.Forms.Button btnSource;
        private System.Windows.Forms.TextBox txtDestination;
        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}