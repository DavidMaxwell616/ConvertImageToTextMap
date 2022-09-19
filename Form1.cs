using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace convertImageToTextMap
{
    public partial class Form1 : Form
    {
        int TileWidth = 8;
        int TileHeight = 8;
        int NumColumns = 64;
        int NumRows = 57;
        Bitmap img;

        public Form1()
        {
            InitializeComponent();
            //1598x1494
            tileSizeX.Text = TileWidth.ToString();
            tileSizeY.Text = TileHeight.ToString();
            Columns.Text = NumColumns.ToString();
            Rows.Text = NumRows.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //columns = 43
            //rows = 41
            string imgString = String.Empty;
            for (var y = 0; y < NumRows-2; y++)
                {
            for (var x = 0; x < NumColumns-2; x ++)
                {
                var xpxl = (x * TileWidth)+16;
                var ypxl = (y * TileHeight)+16;
                var pxl = img.GetPixel(xpxl, ypxl);
                if (pxl.Name == "ff000000" || pxl.Name == "ff808080")
                        imgString += "X";
                    else
                        imgString += " ";
             for (int xx = x * TileWidth; xx < x * TileWidth + TileWidth; xx++)
            {
                for (int yy = y * TileHeight; yy < y * TileHeight + TileHeight; yy++)
                {
                    Color col = System.Drawing.ColorTranslator.FromHtml("#AAFF0000");
                    img.SetPixel(xx, yy, col);
                }
               }
                    Application.DoEvents();
                }
                imgString += "\r\n";
            }
            textOutput.Text = imgString;
            Image.Refresh();
        }
        public Bitmap CreateNonIndexedImage(Image src)
        {
            Bitmap newBmp = new Bitmap(src.Width, src.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);

            using (Graphics gfx = Graphics.FromImage(newBmp))
            {
                gfx.DrawImage(src, 0, 0);
            }

            return newBmp;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = @"C:\Users\maxxd\source\repos\";
                openFileDialog.Filter = "png files (*.png)|*.png|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    var filePath = openFileDialog.FileName;


                    img  = new Bitmap(filePath);
                    imageWidth.Text = img.Width.ToString();
                    imageHeight.Text = img.Height.ToString();
                    Image.Image = img;
                    img = CreateNonIndexedImage(img);
                }
            }

 
        }
    }
}
