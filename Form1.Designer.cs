namespace Elevator
{
    partial class Form1
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
            this.btn_andar1 = new System.Windows.Forms.Button();
            this.btn_andar2 = new System.Windows.Forms.Button();
            this.btn_andar3 = new System.Windows.Forms.Button();
            this.btn_andar4 = new System.Windows.Forms.Button();
            this.btn_andar5 = new System.Windows.Forms.Button();
            this.btn_andar6 = new System.Windows.Forms.Button();
            this.btn_andar7 = new System.Windows.Forms.Button();
            this.lbl_info = new System.Windows.Forms.Label();
            this.vScrollBar = new System.Windows.Forms.VScrollBar();
            this.backgroundProcess = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // btn_andar1
            // 
            this.btn_andar1.Location = new System.Drawing.Point(37, 280);
            this.btn_andar1.Name = "btn_andar1";
            this.btn_andar1.Size = new System.Drawing.Size(97, 35);
            this.btn_andar1.TabIndex = 1;
            this.btn_andar1.Text = "1° andar";
            this.btn_andar1.UseVisualStyleBackColor = true;
            this.btn_andar1.Click += new System.EventHandler(this.btn_andar1_Click);
            // 
            // btn_andar2
            // 
            this.btn_andar2.Location = new System.Drawing.Point(37, 239);
            this.btn_andar2.Name = "btn_andar2";
            this.btn_andar2.Size = new System.Drawing.Size(97, 35);
            this.btn_andar2.TabIndex = 2;
            this.btn_andar2.Text = "2° andar";
            this.btn_andar2.UseVisualStyleBackColor = true;
            this.btn_andar2.Click += new System.EventHandler(this.btn_andar2_Click);
            // 
            // btn_andar3
            // 
            this.btn_andar3.Location = new System.Drawing.Point(37, 198);
            this.btn_andar3.Name = "btn_andar3";
            this.btn_andar3.Size = new System.Drawing.Size(97, 35);
            this.btn_andar3.TabIndex = 3;
            this.btn_andar3.Text = "3° andar";
            this.btn_andar3.UseVisualStyleBackColor = true;
            this.btn_andar3.Click += new System.EventHandler(this.btn_andar3_Click);
            // 
            // btn_andar4
            // 
            this.btn_andar4.Location = new System.Drawing.Point(37, 157);
            this.btn_andar4.Name = "btn_andar4";
            this.btn_andar4.Size = new System.Drawing.Size(97, 35);
            this.btn_andar4.TabIndex = 4;
            this.btn_andar4.Text = "4° andar";
            this.btn_andar4.UseVisualStyleBackColor = true;
            this.btn_andar4.Click += new System.EventHandler(this.btn_andar4_Click);
            // 
            // btn_andar5
            // 
            this.btn_andar5.Location = new System.Drawing.Point(37, 116);
            this.btn_andar5.Name = "btn_andar5";
            this.btn_andar5.Size = new System.Drawing.Size(97, 35);
            this.btn_andar5.TabIndex = 5;
            this.btn_andar5.Text = "5° andar";
            this.btn_andar5.UseVisualStyleBackColor = true;
            this.btn_andar5.Click += new System.EventHandler(this.btn_andar5_Click);
            // 
            // btn_andar6
            // 
            this.btn_andar6.Location = new System.Drawing.Point(37, 75);
            this.btn_andar6.Name = "btn_andar6";
            this.btn_andar6.Size = new System.Drawing.Size(97, 35);
            this.btn_andar6.TabIndex = 6;
            this.btn_andar6.Text = "6° andar";
            this.btn_andar6.UseVisualStyleBackColor = true;
            this.btn_andar6.Click += new System.EventHandler(this.btn_andar6_Click);
            // 
            // btn_andar7
            // 
            this.btn_andar7.Location = new System.Drawing.Point(37, 34);
            this.btn_andar7.Name = "btn_andar7";
            this.btn_andar7.Size = new System.Drawing.Size(97, 35);
            this.btn_andar7.TabIndex = 7;
            this.btn_andar7.Text = "7° andar";
            this.btn_andar7.UseVisualStyleBackColor = true;
            this.btn_andar7.Click += new System.EventHandler(this.btn_andar7_Click);
            // 
            // lbl_info
            // 
            this.lbl_info.AutoSize = true;
            this.lbl_info.Location = new System.Drawing.Point(233, 34);
            this.lbl_info.Name = "lbl_info";
            this.lbl_info.Size = new System.Drawing.Size(0, 16);
            this.lbl_info.TabIndex = 8;
            // 
            // vScrollBar
            // 
            this.vScrollBar.Location = new System.Drawing.Point(180, 9);
            this.vScrollBar.Name = "vScrollBar";
            this.vScrollBar.Size = new System.Drawing.Size(35, 325);
            this.vScrollBar.TabIndex = 9;
            // 
            // backgroundWorker1
            // 
            this.backgroundProcess.WorkerReportsProgress = true;
            this.backgroundProcess.WorkerSupportsCancellation = true;
            this.backgroundProcess.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundProcess.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 343);
            this.Controls.Add(this.vScrollBar);
            this.Controls.Add(this.lbl_info);
            this.Controls.Add(this.btn_andar7);
            this.Controls.Add(this.btn_andar6);
            this.Controls.Add(this.btn_andar5);
            this.Controls.Add(this.btn_andar4);
            this.Controls.Add(this.btn_andar3);
            this.Controls.Add(this.btn_andar2);
            this.Controls.Add(this.btn_andar1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_andar1;
        private System.Windows.Forms.Button btn_andar2;
        private System.Windows.Forms.Button btn_andar3;
        private System.Windows.Forms.Button btn_andar4;
        private System.Windows.Forms.Button btn_andar5;
        private System.Windows.Forms.Button btn_andar6;
        private System.Windows.Forms.Button btn_andar7;
        private System.Windows.Forms.Label lbl_info;
        private System.Windows.Forms.VScrollBar vScrollBar;
        private System.Windows.Forms.Timer timer;
        private System.ComponentModel.BackgroundWorker backgroundProcess;
    }
}

