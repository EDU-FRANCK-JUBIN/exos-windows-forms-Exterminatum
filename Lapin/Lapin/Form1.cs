using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lapin
{
    public partial class Form1 : Form
    {
        public List<PictureBox>listeImage = new List<PictureBox>();

        public Form1()
        {
            InitializeComponent();
            listeImage.Add(pictureBox1);
            listeImage.Add(pictureBox2);
            listeImage.Add(pictureBox3);
            listeImage.Add(pictureBox4);
            listeImage.Add(pictureBox5);
            listeImage.Add(pictureBox6);
            listeImage.Add(pictureBox7);
            listeImage.Add(pictureBox8);
            listeImage.Add(pictureBox9);

        }
        public void SwapImages (int image1, int image2)
        {
            PictureBox buffer = new PictureBox();
            buffer.Location = listeImage[image1].Location;
            buffer.Tag = listeImage[image1].Tag;
            buffer.BackgroundImage = listeImage[image1].BackgroundImage;
            listeImage[image1].BackgroundImage = listeImage[image2].BackgroundImage;
            listeImage[image1].Tag = listeImage[image2].Tag;
            listeImage[image2].BackgroundImage = buffer.BackgroundImage;
            listeImage[image2].Tag = buffer.Tag;
            
        }
        public void CheckSwapimages(PictureBox originalbox)
        {
            int index = listeImage.FindIndex(PictureBox => PictureBox.Name == originalbox.Name); // On a fait plus propre
            if (index > 0)
            {
                if (listeImage[index - 1].Tag == "black")
                {
                    SwapImages(index, index - 1);
                }
            }
            if (index < 8)
            {
                if (listeImage[index + 1].Tag == "black")
                {
                    SwapImages(index, index + 1);
                }
            }
            if (index > 2)
            {
                if (listeImage[index - 3].Tag == "black")
                {
                    SwapImages(index, index - 3);
                }
            }
             if (index < 6) { 
            if (listeImage[index + 3].Tag == "black")
            {
                SwapImages(index, index + 3);
            }
        }
        }
  

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            CheckSwapimages(pictureBox8);
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            CheckSwapimages(pictureBox1);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            CheckSwapimages(pictureBox6);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            CheckSwapimages(pictureBox5);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            CheckSwapimages(pictureBox4);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            CheckSwapimages(pictureBox3);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            CheckSwapimages(pictureBox2);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            CheckSwapimages(pictureBox7);
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            CheckSwapimages(pictureBox9);
        }
    }
}
