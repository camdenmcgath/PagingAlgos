namespace PagingAlgos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnFIFO = new System.Windows.Forms.RadioButton();
            this.btnOptimal = new System.Windows.Forms.RadioButton();
            this.btnLRU = new System.Windows.Forms.RadioButton();
            this.btnLFU = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statlblPageFaultCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.dgvResults = new System.Windows.Forms.DataGridView();
            this.btnRun = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFIFO
            // 
            this.btnFIFO.AutoSize = true;
            this.btnFIFO.Location = new System.Drawing.Point(41, 73);
            this.btnFIFO.Name = "btnFIFO";
            this.btnFIFO.Size = new System.Drawing.Size(49, 19);
            this.btnFIFO.TabIndex = 0;
            this.btnFIFO.TabStop = true;
            this.btnFIFO.Text = "FIFO";
            this.btnFIFO.UseVisualStyleBackColor = true;
            // 
            // btnOptimal
            // 
            this.btnOptimal.AutoSize = true;
            this.btnOptimal.Location = new System.Drawing.Point(41, 110);
            this.btnOptimal.Name = "btnOptimal";
            this.btnOptimal.Size = new System.Drawing.Size(68, 19);
            this.btnOptimal.TabIndex = 1;
            this.btnOptimal.TabStop = true;
            this.btnOptimal.Text = "Optimal";
            this.btnOptimal.UseVisualStyleBackColor = true;
            // 
            // btnLRU
            // 
            this.btnLRU.AutoSize = true;
            this.btnLRU.Location = new System.Drawing.Point(41, 145);
            this.btnLRU.Name = "btnLRU";
            this.btnLRU.Size = new System.Drawing.Size(46, 19);
            this.btnLRU.TabIndex = 2;
            this.btnLRU.TabStop = true;
            this.btnLRU.Text = "LRU";
            this.btnLRU.UseVisualStyleBackColor = true;
            // 
            // btnLFU
            // 
            this.btnLFU.AutoSize = true;
            this.btnLFU.Location = new System.Drawing.Point(41, 181);
            this.btnLFU.Name = "btnLFU";
            this.btnLFU.Size = new System.Drawing.Size(45, 19);
            this.btnLFU.TabIndex = 3;
            this.btnLFU.TabStop = true;
            this.btnLFU.Text = "LFU";
            this.btnLFU.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Paging Algorithms";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statlblPageFaultCount});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statlblPageFaultCount
            // 
            this.statlblPageFaultCount.Name = "statlblPageFaultCount";
            this.statlblPageFaultCount.Size = new System.Drawing.Size(118, 17);
            this.statlblPageFaultCount.Text = "toolStripStatusLabel1";
            // 
            // dgvResults
            // 
            this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResults.Location = new System.Drawing.Point(216, 24);
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.RowTemplate.Height = 25;
            this.dgvResults.Size = new System.Drawing.Size(552, 368);
            this.dgvResults.TabIndex = 7;
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(31, 228);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 23);
            this.btnRun.TabIndex = 8;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 404);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "* -1 in a page denotes a null page";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.dgvResults);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLFU);
            this.Controls.Add(this.btnLRU);
            this.Controls.Add(this.btnOptimal);
            this.Controls.Add(this.btnFIFO);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RadioButton btnFIFO;
        private RadioButton btnOptimal;
        private RadioButton btnLRU;
        private RadioButton btnLFU;
        private Label label1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel statlblPageFaultCount;
        private DataGridView dgvResults;
        private Button btnRun;
        private Label label2;
    }
}