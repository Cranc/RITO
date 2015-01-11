
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RITO_JASON_WRAPPER;

namespace RITO
{
    public partial class RITO : Form
    {
        private
        string summoner_Name;
        long summoner_id;
        int profile_Icon_ID;
        MyJasonWrapper JW;
        public RITO()
        {
            InitializeComponent();
            JW = null;
        }

        private void buttonManualUpdate_Click(object sender, EventArgs e)
        {
            summoner_Name = this.textBoxSummoner.Text.ToString();
            if (JW == null)
            {
                JW = new MyJasonWrapper(summoner_Name);

            }
            MainUpdate();
        }

        private void MainUpdate()
        {
            progressBarUpdate.Value = 0;
            progressBarUpdate.Step = 20;
            profile_Icon_ID = JW.GetProfileIconIdWrapper();
            progressBarUpdate.PerformStep();
            progressBarUpdate.Update();
            progressBarUpdate.PerformStep();
            summoner_id = JW.GetSummonerIdWrapper();
            progressBarUpdate.PerformStep();
            LoadUnrankedImage();
            progressBarUpdate.PerformStep();
            progressBarUpdate.PerformStep();
        }

        private void LoadUnrankedImage()
        {
            try
            {
                Bitmap image1 = (Bitmap)Image.FromFile(Global.UNRANKED_PNG_PATH, true);
                /*
                TextureBrush texture = new TextureBrush(image1);
                texture.WrapMode = System.Drawing.Drawing2D.WrapMode.Tile;
                Graphics formGraphics = this.CreateGraphics();
                formGraphics.FillEllipse(texture,
                    new RectangleF(90.0F, 110.0F, 100, 100));
                formGraphics.Dispose();
                */
                int width = 0;
                int height = 0;
                try
                {
                    width = Convert.ToInt32(pictureBoxLeague.Width.ToString());
                    height = Convert.ToInt32(pictureBoxLeague.Height.ToString());
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Input string is not a sequence of digits. Unranked image was not loaded!");
                    return;
                }
                image1 = resizeImage(image1, width, height);
                pictureBoxLeague.Image = image1;
            }
            catch (System.IO.FileNotFoundException)
            {
                MessageBox.Show("There was an error opening the bitmap." +
                    "Please check the path.");
            }
        }

        private static Bitmap resizeImage(Bitmap imgToResize, int width, int height)
        {
            return (new Bitmap(imgToResize, width, height));
        }
    }
}
