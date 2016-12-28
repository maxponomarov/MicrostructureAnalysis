namespace MetalographicsProject.Forms {
    partial class MeasureForm {
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
            this.measureDGV = new System.Windows.Forms.DataGridView();
            this.deleteLinkLabel = new System.Windows.Forms.LinkLabel();
            this.addLinkLabel = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.IDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImageSizeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ScaleColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.measureDGV)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // measureDGV
            // 
            this.measureDGV.AllowUserToAddRows = false;
            this.measureDGV.AllowUserToDeleteRows = false;
            this.measureDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.measureDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.measureDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDColumn,
            this.ImageSizeColumn,
            this.ScaleColumn});
            this.measureDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.measureDGV.Location = new System.Drawing.Point(3, 28);
            this.measureDGV.Name = "measureDGV";
            this.measureDGV.ReadOnly = true;
            this.measureDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.measureDGV.Size = new System.Drawing.Size(268, 220);
            this.measureDGV.TabIndex = 0;
            this.measureDGV.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.measureDGV_CellContentDoubleClick);
            // 
            // deleteLinkLabel
            // 
            this.deleteLinkLabel.AutoSize = true;
            this.deleteLinkLabel.Location = new System.Drawing.Point(215, 3);
            this.deleteLinkLabel.Name = "deleteLinkLabel";
            this.deleteLinkLabel.Size = new System.Drawing.Size(50, 13);
            this.deleteLinkLabel.TabIndex = 1;
            this.deleteLinkLabel.TabStop = true;
            this.deleteLinkLabel.Text = "Удалить";
            this.deleteLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.deleteLinkLabel_LinkClicked);
            // 
            // addLinkLabel
            // 
            this.addLinkLabel.AutoSize = true;
            this.addLinkLabel.Location = new System.Drawing.Point(3, 3);
            this.addLinkLabel.Name = "addLinkLabel";
            this.addLinkLabel.Size = new System.Drawing.Size(57, 13);
            this.addLinkLabel.TabIndex = 1;
            this.addLinkLabel.TabStop = true;
            this.addLinkLabel.Text = "Добавить";
            this.addLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.addLinkLabel_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.addLinkLabel);
            this.panel1.Controls.Add(this.deleteLinkLabel);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(268, 19);
            this.panel1.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.measureDGV, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(274, 251);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // IDColumn
            // 
            this.IDColumn.HeaderText = "ID";
            this.IDColumn.Name = "IDColumn";
            this.IDColumn.ReadOnly = true;
            this.IDColumn.Visible = false;
            // 
            // ImageSizeColumn
            // 
            this.ImageSizeColumn.HeaderText = "Image Size";
            this.ImageSizeColumn.Name = "ImageSizeColumn";
            this.ImageSizeColumn.ReadOnly = true;
            // 
            // ScaleColumn
            // 
            this.ScaleColumn.HeaderText = "Scale";
            this.ScaleColumn.Name = "ScaleColumn";
            this.ScaleColumn.ReadOnly = true;
            // 
            // MeasureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 251);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MeasureForm";
            this.Text = "Выставить масштаб";
            ((System.ComponentModel.ISupportInitialize)(this.measureDGV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView measureDGV;
        private System.Windows.Forms.LinkLabel deleteLinkLabel;
        private System.Windows.Forms.LinkLabel addLinkLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImageSizeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ScaleColumn;
    }
}