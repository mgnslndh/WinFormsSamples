using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Paint(object sender, PaintEventArgs e)
        {
            using (var bitmap = new Bitmap(pictureBox1.Image))
            {
                var textSize = TextRenderer.MeasureText(e.Graphics, label1.Text, label1.Font, label1.Size, TextFormatFlags.WordBreak);

                var x = textSize.Width / 2 - bitmap.Width / 2;
                var y = pictureBox2.Height / 2 - bitmap.Height / 2;

                e.Graphics.DrawImage(bitmap, x,y);
            }
        }
    }
}
