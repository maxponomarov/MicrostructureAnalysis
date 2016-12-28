namespace MetalographicsProject.Filters.Forms {
    partial class EdgeDetectorForm {
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cannyRB = new System.Windows.Forms.RadioButton();
            this.sobelRB = new System.Windows.Forms.RadioButton();
            this.differenceRB = new System.Windows.Forms.RadioButton();
            this.homogenityRB = new System.Windows.Forms.RadioButton();
            this.noFilterCB = new System.Windows.Forms.CheckBox();
            this.applyFilter = new System.Windows.Forms.Button();
            this.previewPB = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.previewPB)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cannyRB);
            this.groupBox1.Controls.Add(this.sobelRB);
            this.groupBox1.Controls.Add(this.differenceRB);
            this.groupBox1.Controls.Add(this.homogenityRB);
            this.groupBox1.Location = new System.Drawing.Point(100, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(301, 50);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Фильтр";
            // 
            // cannyRB
            // 
            this.cannyRB.AutoSize = true;
            this.cannyRB.Location = new System.Drawing.Point(231, 19);
            this.cannyRB.Name = "cannyRB";
            this.cannyRB.Size = new System.Drawing.Size(55, 17);
            this.cannyRB.TabIndex = 0;
            this.cannyRB.TabStop = true;
            this.cannyRB.Text = "Canny";
            this.cannyRB.UseVisualStyleBackColor = true;
            this.cannyRB.CheckedChanged += new System.EventHandler(this.RB_CheckedChanged);
            // 
            // sobelRB
            // 
            this.sobelRB.AutoSize = true;
            this.sobelRB.Location = new System.Drawing.Point(173, 19);
            this.sobelRB.Name = "sobelRB";
            this.sobelRB.Size = new System.Drawing.Size(52, 17);
            this.sobelRB.TabIndex = 0;
            this.sobelRB.TabStop = true;
            this.sobelRB.Text = "Sobel";
            this.sobelRB.UseVisualStyleBackColor = true;
            this.sobelRB.CheckedChanged += new System.EventHandler(this.RB_CheckedChanged);
            // 
            // differenceRB
            // 
            this.differenceRB.AutoSize = true;
            this.differenceRB.Location = new System.Drawing.Point(93, 19);
            this.differenceRB.Name = "differenceRB";
            this.differenceRB.Size = new System.Drawing.Size(74, 17);
            this.differenceRB.TabIndex = 0;
            this.differenceRB.TabStop = true;
            this.differenceRB.Text = "Difference";
            this.differenceRB.UseVisualStyleBackColor = true;
            this.differenceRB.CheckedChanged += new System.EventHandler(this.RB_CheckedChanged);
            // 
            // homogenityRB
            // 
            this.homogenityRB.AutoSize = true;
            this.homogenityRB.Location = new System.Drawing.Point(6, 19);
            this.homogenityRB.Name = "homogenityRB";
            this.homogenityRB.Size = new System.Drawing.Size(81, 17);
            this.homogenityRB.TabIndex = 0;
            this.homogenityRB.TabStop = true;
            this.homogenityRB.Text = "Homogenity";
            this.homogenityRB.UseVisualStyleBackColor = true;
            this.homogenityRB.CheckedChanged += new System.EventHandler(this.RB_CheckedChanged);
            // 
            // noFilterCB
            // 
            this.noFilterCB.AutoSize = true;
            this.noFilterCB.Location = new System.Drawing.Point(6, 9);
            this.noFilterCB.Name = "noFilterCB";
            this.noFilterCB.Size = new System.Drawing.Size(91, 17);
            this.noFilterCB.TabIndex = 1;
            this.noFilterCB.Text = "Без фильтра";
            this.noFilterCB.UseVisualStyleBackColor = true;
            this.noFilterCB.CheckedChanged += new System.EventHandler(this.noFilterCB_CheckedChanged);
            // 
            // applyFilter
            // 
            this.applyFilter.Location = new System.Drawing.Point(11, 35);
            this.applyFilter.Name = "applyFilter";
            this.applyFilter.Size = new System.Drawing.Size(75, 23);
            this.applyFilter.TabIndex = 2;
            this.applyFilter.Text = "Применить";
            this.applyFilter.UseVisualStyleBackColor = true;
            this.applyFilter.Click += new System.EventHandler(this.applyFilter_Click);
            // 
            // previewPB
            // 
            this.previewPB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.previewPB.Location = new System.Drawing.Point(3, 71);
            this.previewPB.Name = "previewPB";
            this.previewPB.Size = new System.Drawing.Size(517, 429);
            this.previewPB.TabIndex = 3;
            this.previewPB.TabStop = false;
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(523, 503);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.noFilterCB);
            this.panel1.Controls.Add(this.applyFilter);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(421, 62);
            this.panel1.TabIndex = 0;
            // 
            // EdgeDetectorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 503);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "EdgeDetectorForm";
            this.Text = "EdgeDetectorForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.previewPB)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton cannyRB;
        private System.Windows.Forms.RadioButton sobelRB;
        private System.Windows.Forms.RadioButton differenceRB;
        private System.Windows.Forms.RadioButton homogenityRB;
        private System.Windows.Forms.CheckBox noFilterCB;
        private System.Windows.Forms.Button applyFilter;
        private System.Windows.Forms.PictureBox previewPB;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
    }
}