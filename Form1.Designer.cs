
namespace convertImageToTextMap
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
            this.Image = new System.Windows.Forms.PictureBox();
            this.textOutput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tileSizeX = new System.Windows.Forms.TextBox();
            this.tileSizeY = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Columns = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Rows = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.imageWidth = new System.Windows.Forms.TextBox();
            this.imageHeight = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Image)).BeginInit();
            this.SuspendLayout();
            // 
            // Image
            // 
            this.Image.Location = new System.Drawing.Point(13, 13);
            this.Image.Name = "Image";
            this.Image.Size = new System.Drawing.Size(361, 306);
            this.Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Image.TabIndex = 0;
            this.Image.TabStop = false;
            // 
            // textOutput
            // 
            this.textOutput.Location = new System.Drawing.Point(381, 13);
            this.textOutput.Multiline = true;
            this.textOutput.Name = "textOutput";
            this.textOutput.Size = new System.Drawing.Size(419, 306);
            this.textOutput.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(213, 332);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tie Size X";
            // 
            // tileSizeX
            // 
            this.tileSizeX.Location = new System.Drawing.Point(274, 328);
            this.tileSizeX.Name = "tileSizeX";
            this.tileSizeX.Size = new System.Drawing.Size(100, 20);
            this.tileSizeX.TabIndex = 3;
            // 
            // tileSizeY
            // 
            this.tileSizeY.Location = new System.Drawing.Point(274, 360);
            this.tileSizeY.Name = "tileSizeY";
            this.tileSizeY.Size = new System.Drawing.Size(100, 20);
            this.tileSizeY.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(213, 363);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tie Size Y";
            // 
            // Columns
            // 
            this.Columns.Location = new System.Drawing.Point(460, 328);
            this.Columns.Name = "Columns";
            this.Columns.Size = new System.Drawing.Size(100, 20);
            this.Columns.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(407, 331);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Columns";
            // 
            // Rows
            // 
            this.Rows.Location = new System.Drawing.Point(460, 360);
            this.Rows.Name = "Rows";
            this.Rows.Size = new System.Drawing.Size(100, 20);
            this.Rows.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(420, 363);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Rows";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(647, 347);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Convert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(728, 347);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 331);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Image Width";
            // 
            // imageWidth
            // 
            this.imageWidth.Location = new System.Drawing.Point(85, 325);
            this.imageWidth.Name = "imageWidth";
            this.imageWidth.Size = new System.Drawing.Size(100, 20);
            this.imageWidth.TabIndex = 13;
            // 
            // imageHeight
            // 
            this.imageHeight.Location = new System.Drawing.Point(85, 360);
            this.imageHeight.Name = "imageHeight";
            this.imageHeight.Size = new System.Drawing.Size(100, 20);
            this.imageHeight.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 363);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Image Height";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(566, 347);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 16;
            this.button3.Text = "Load";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 392);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.imageHeight);
            this.Controls.Add(this.imageWidth);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Rows);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Columns);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tileSizeY);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tileSizeX);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textOutput);
            this.Controls.Add(this.Image);
            this.Name = "Form1";
            this.Text = "Convert Image To Text Map";
            ((System.ComponentModel.ISupportInitialize)(this.Image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Image;
        private System.Windows.Forms.TextBox textOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tileSizeX;
        private System.Windows.Forms.TextBox tileSizeY;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Columns;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Rows;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox imageWidth;
        private System.Windows.Forms.TextBox imageHeight;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button3;
    }
}

