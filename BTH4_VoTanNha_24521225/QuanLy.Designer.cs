namespace BTH4_VoTanNha_24521225
{
    partial class QuanLy
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
            this.pnlMain = new System.Windows.Forms.Panel();
            this.btnRun = new System.Windows.Forms.Button();
            this.cbChoose = new System.Windows.Forms.ComboBox();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.btnRun);
            this.pnlMain.Controls.Add(this.cbChoose);
            this.pnlMain.Location = new System.Drawing.Point(303, 154);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(200, 100);
            this.pnlMain.TabIndex = 0;
            // 
            // btnRun
            // 
            this.btnRun.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRun.Location = new System.Drawing.Point(59, 59);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 38);
            this.btnRun.TabIndex = 1;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // cbChoose
            // 
            this.cbChoose.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbChoose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbChoose.FormattingEnabled = true;
            this.cbChoose.Items.AddRange(new object[] {
            "Bai03",
            "Bai04",
            "Bai05",
            "Bai06"});
            this.cbChoose.Location = new System.Drawing.Point(40, 19);
            this.cbChoose.Name = "cbChoose";
            this.cbChoose.Size = new System.Drawing.Size(121, 28);
            this.cbChoose.TabIndex = 0;
            // 
            // QuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlMain);
            this.Name = "QuanLy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuanLy";
            this.Resize += new System.EventHandler(this.QuanLy_Resize);
            this.pnlMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.ComboBox cbChoose;
    }
}