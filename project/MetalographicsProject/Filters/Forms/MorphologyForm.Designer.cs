namespace MetalographicsProject.Filters.Forms {
    partial class MorphologyForm {
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
            this.closeRB = new System.Windows.Forms.RadioButton();
            this.openRB = new System.Windows.Forms.RadioButton();
            this.dilateRB = new System.Windows.Forms.RadioButton();
            this.erodeRB = new System.Windows.Forms.RadioButton();
            this.applyButton = new System.Windows.Forms.Button();
            this.previewPictureBox = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.noneRB = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.previewPictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.closeRB);
            this.groupBox1.Controls.Add(this.openRB);
            this.groupBox1.Controls.Add(this.dilateRB);
            this.groupBox1.Controls.Add(this.noneRB);
            this.groupBox1.Controls.Add(this.erodeRB);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(93, 145);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Тип фильтра";
            // 
            // closeRB
            // 
            this.closeRB.AutoSize = true;
            this.closeRB.Location = new System.Drawing.Point(6, 120);
            this.closeRB.Name = "closeRB";
            this.closeRB.Size = new System.Drawing.Size(51, 17);
            this.closeRB.TabIndex = 0;
            this.closeRB.TabStop = true;
            this.closeRB.Text = "Close";
            this.closeRB.UseVisualStyleBackColor = true;
            this.closeRB.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // openRB
            // 
            this.openRB.AutoSize = true;
            this.openRB.Location = new System.Drawing.Point(6, 97);
            this.openRB.Name = "openRB";
            this.openRB.Size = new System.Drawing.Size(51, 17);
            this.openRB.TabIndex = 0;
            this.openRB.TabStop = true;
            this.openRB.Text = "Open";
            this.openRB.UseVisualStyleBackColor = true;
            this.openRB.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // dilateRB
            // 
            this.dilateRB.AutoSize = true;
            this.dilateRB.Location = new System.Drawing.Point(6, 74);
            this.dilateRB.Name = "dilateRB";
            this.dilateRB.Size = new System.Drawing.Size(52, 17);
            this.dilateRB.TabIndex = 0;
            this.dilateRB.TabStop = true;
            this.dilateRB.Text = "Dilate";
            this.dilateRB.UseVisualStyleBackColor = true;
            this.dilateRB.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // erodeRB
            // 
            this.erodeRB.AutoSize = true;
            this.erodeRB.Location = new System.Drawing.Point(6, 51);
            this.erodeRB.Name = "erodeRB";
            this.erodeRB.Size = new System.Drawing.Size(53, 17);
            this.erodeRB.TabIndex = 0;
            this.erodeRB.TabStop = true;
            this.erodeRB.Text = "Erode";
            this.erodeRB.UseVisualStyleBackColor = true;
            this.erodeRB.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // applyButton
            // 
            this.applyButton.Location = new System.Drawing.Point(14, 154);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(75, 23);
            this.applyButton.TabIndex = 3;
            this.applyButton.Text = "Применить";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // previewPictureBox
            // 
            this.previewPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.previewPictureBox.Location = new System.Drawing.Point(110, 3);
            this.previewPictureBox.Name = "previewPictureBox";
            this.previewPictureBox.Size = new System.Drawing.Size(622, 508);
            this.previewPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.previewPictureBox.TabIndex = 4;
            this.previewPictureBox.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.applyButton);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(101, 213);
            this.panel1.TabIndex = 5;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.previewPictureBox, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(735, 514);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // noneRB
            // 
            this.noneRB.AutoSize = true;
            this.noneRB.Location = new System.Drawing.Point(6, 19);
            this.noneRB.Name = "noneRB";
            this.noneRB.Size = new System.Drawing.Size(44, 17);
            this.noneRB.TabIndex = 0;
            this.noneRB.TabStop = true;
            this.noneRB.Text = "Нет";
            this.noneRB.UseVisualStyleBackColor = true;
            this.noneRB.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // MorphologyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 514);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MorphologyForm";
            this.Text = "Морфологические фильтры";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.previewPictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton closeRB;
        private System.Windows.Forms.RadioButton openRB;
        private System.Windows.Forms.RadioButton dilateRB;
        private System.Windows.Forms.RadioButton erodeRB;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.PictureBox previewPictureBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RadioButton noneRB;
    }
}