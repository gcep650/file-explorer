namespace MyExplorer
{
    partial class FileExInfo
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
            this.iconBox = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.readL = new System.Windows.Forms.Label();
            this.dateL = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.typeL = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nameL = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureContents = new System.Windows.Forms.PictureBox();
            this.fileText = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.iconBox)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureContents)).BeginInit();
            this.SuspendLayout();
            // 
            // iconBox
            // 
            this.iconBox.Location = new System.Drawing.Point(12, 13);
            this.iconBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.iconBox.Name = "iconBox";
            this.iconBox.Size = new System.Drawing.Size(105, 105);
            this.iconBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconBox.TabIndex = 1;
            this.iconBox.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.97749F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.02251F));
            this.tableLayoutPanel1.Controls.Add(this.readL, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.dateL, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.typeL, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.nameL, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(123, 13);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(364, 161);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // readL
            // 
            this.readL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.readL.Location = new System.Drawing.Point(137, 120);
            this.readL.Name = "readL";
            this.readL.Size = new System.Drawing.Size(224, 41);
            this.readL.TabIndex = 6;
            this.readL.Text = "No";
            this.readL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dateL
            // 
            this.dateL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateL.Location = new System.Drawing.Point(137, 80);
            this.dateL.Name = "dateL";
            this.dateL.Size = new System.Drawing.Size(224, 40);
            this.dateL.TabIndex = 5;
            this.dateL.Text = "1/1/20";
            this.dateL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 41);
            this.label5.TabIndex = 4;
            this.label5.Text = "Read only?";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 40);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date modified:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // typeL
            // 
            this.typeL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.typeL.Location = new System.Drawing.Point(137, 40);
            this.typeL.Name = "typeL";
            this.typeL.Size = new System.Drawing.Size(224, 40);
            this.typeL.TabIndex = 1;
            this.typeL.Text = "File";
            this.typeL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "File type:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 40);
            this.label7.TabIndex = 7;
            this.label7.Text = "File name:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nameL
            // 
            this.nameL.AutoSize = true;
            this.nameL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nameL.Location = new System.Drawing.Point(137, 0);
            this.nameL.Name = "nameL";
            this.nameL.Size = new System.Drawing.Size(224, 40);
            this.nameL.TabIndex = 8;
            this.nameL.Text = "file";
            this.nameL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureContents);
            this.groupBox1.Controls.Add(this.fileText);
            this.groupBox1.Location = new System.Drawing.Point(493, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(367, 164);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Contents";
            // 
            // pictureContents
            // 
            this.pictureContents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureContents.Location = new System.Drawing.Point(3, 21);
            this.pictureContents.Name = "pictureContents";
            this.pictureContents.Size = new System.Drawing.Size(361, 140);
            this.pictureContents.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureContents.TabIndex = 2;
            this.pictureContents.TabStop = false;
            // 
            // fileText
            // 
            this.fileText.BackColor = System.Drawing.Color.White;
            this.fileText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fileText.Location = new System.Drawing.Point(3, 21);
            this.fileText.Multiline = true;
            this.fileText.Name = "fileText";
            this.fileText.ReadOnly = true;
            this.fileText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.fileText.Size = new System.Drawing.Size(361, 140);
            this.fileText.TabIndex = 0;
            this.fileText.WordWrap = false;
            // 
            // FileExInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 189);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.iconBox);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FileExInfo";
            this.Text = "FileExInfo";
            ((System.ComponentModel.ISupportInitialize)(this.iconBox)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureContents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox iconBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label readL;
        private System.Windows.Forms.Label dateL;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label typeL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox fileText;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label nameL;
        private System.Windows.Forms.PictureBox pictureContents;
    }
}