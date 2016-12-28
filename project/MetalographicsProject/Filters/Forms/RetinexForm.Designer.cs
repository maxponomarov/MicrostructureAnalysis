namespace MetalographicsProject.Filters.Forms {
    partial class RetinexForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.previewPB = new System.Windows.Forms.PictureBox();
            this.valueTB = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.applyButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.valueUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.previewPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valueTB)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.valueUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // previewPB
            // 
            this.previewPB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.previewPB.Location = new System.Drawing.Point(3, 71);
            this.previewPB.Name = "previewPB";
            this.previewPB.Size = new System.Drawing.Size(487, 399);
            this.previewPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.previewPB.TabIndex = 0;
            this.previewPB.TabStop = false;
            // 
            // valueTB
            // 
            this.valueTB.LargeChange = 10;
            this.valueTB.Location = new System.Drawing.Point(6, 16);
            this.valueTB.Maximum = 255;
            this.valueTB.Minimum = 1;
            this.valueTB.Name = "valueTB";
            this.valueTB.Size = new System.Drawing.Size(387, 45);
            this.valueTB.TabIndex = 1;
            this.valueTB.Value = 1;
            this.valueTB.Scroll += new System.EventHandler(this.valueTB_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Значение";
            // 
            // applyButton
            // 
            this.applyButton.Location = new System.Drawing.Point(399, 16);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(75, 23);
            this.applyButton.TabIndex = 3;
            this.applyButton.Text = "Применить";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.previewPB, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(493, 473);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.valueUpDown);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.applyButton);
            this.panel1.Controls.Add(this.valueTB);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(483, 62);
            this.panel1.TabIndex = 0;
            // 
            // valueUpDown
            // 
            this.valueUpDown.Location = new System.Drawing.Point(64, 3);
            this.valueUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.valueUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.valueUpDown.Name = "valueUpDown";
            this.valueUpDown.Size = new System.Drawing.Size(51, 20);
            this.valueUpDown.TabIndex = 4;
            this.valueUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.valueUpDown.ValueChanged += new System.EventHandler(this.valueUpDown_ValueChanged);
            // 
            // RetinexForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 473);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(509, 512);
            this.Name = "RetinexForm";
            this.Text = "RetinexForm";
            ((System.ComponentModel.ISupportInitialize)(this.previewPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valueTB)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.valueUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox previewPB;
        private System.Windows.Forms.TrackBar valueTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown valueUpDown;
    }
}