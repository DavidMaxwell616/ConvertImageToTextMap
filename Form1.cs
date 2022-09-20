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

        int NumColumns = 64;
        int NumRows = 57;
        Bitmap img;
        Bitmap img2;

        public Form1()
        {
            InitializeComponent();
            Columns.Text = NumColumns.ToString();
            Rows.Text = NumRows.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //columns = 43
            //rows = 41
            var TileWidth = Convert.ToInt32(tileSizeX.Text);
            var TileHeight = Convert.ToInt32(tileSizeY.Text);
            string imgString = String.Empty;
            for (var y = 0; y < NumRows; y++)
                {
            for (var x = 0; x < NumColumns; x ++)
                {
                var xpxl = (x * TileWidth)+(TileWidth/2);
                var ypxl = (y * TileHeight)+(TileHeight/2);
                var pxl = img.GetPixel(xpxl, ypxl);
                if (pxl.Name == "ff000000" || pxl.Name == "ff808080")
                        imgString += "0";
                    else
                        imgString += "1";
             for (int xx = x * TileWidth; xx < x * TileWidth + TileWidth; xx++)
            {
                for (int yy = y * TileHeight; yy < y * TileHeight + TileHeight; yy++)
                {
                    Color col = System.Drawing.ColorTranslator.FromHtml("#AAFF0000");
                    img2.SetPixel(xx, yy, col);
                }
               }
                    Application.DoEvents();
                }
                imgString += "\r\n";
            }
            textOutput.Text = imgString;
            Image.Image = img2;
            Image.Refresh();
        }
        public Bitmap CreateNonIndexedImage(Image src)
        {
            Bitmap newBmp = new Bitmap(src.Width, src.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            imageWidth.Text = src.Width.ToString();
            imageHeight.Text = src.Height.ToString();
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
                    img = new Bitmap(filePath);
                    Image.Image = img;
                    img2 = new Bitmap(filePath);
                    img2 = CreateNonIndexedImage(img2);
                    imageWidth.Text = img.Width.ToString();
                    imageHeight.Text = img.Height.ToString();
                    tileSizeX.Text = (img.Width/NumColumns).ToString();
                    tileSizeY.Text = (img.Height / NumRows).ToString();
                }
            }

 
        }
    }
}
