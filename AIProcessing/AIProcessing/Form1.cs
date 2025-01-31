using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.UI;
using Microsoft.CognitiveServices.Speech;


namespace AIProcessing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void TrackBarIslem_Scroll(object sender, EventArgs e)
        {
            if(TrackBarProcess.Value == 0)
            {
                MessageBox.Show("Görüntü işleme başlıyor");
                IslemTipiLabel.Text = "Görüntü işleme";

                try
                {
                    OpenFileDialog ofd = new OpenFileDialog();
                    ofd.Filter = "Resim Dosyaları|*.jpeg;*.png;*.jpg";

                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        Image<Bgr, byte> img = new Image<Bgr, byte>(ofd.FileName);
                        Image<Gray, byte> grayImg = img.Convert<Gray, byte>();
                        PictureBox picBox = new PictureBox
                        {
                            Image = grayImg.ToBitmap(),
                            Dock = DockStyle.Fill,
                            SizeMode = PictureBoxSizeMode.Zoom
                        };
                        Form form = new Form
                        {
                            Text = "Gri Tonda Görüntü",
                            AutoSize = true,
                            AutoSizeMode = AutoSizeMode.GrowAndShrink
                        };

                        form.Controls.Add(picBox);
                        form.ShowDialog();
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show($"Görüntü işleme sırasında bir hata oluştu.\nDetay: {ex}");
                }
                
            }
            else if(TrackBarProcess.Value == 1)
            {
                MessageBox.Show("Ses işleme başlıyor");
                IslemTipiLabel.Text = "Ses işleme";

                try
                {
                    var config = SpeechConfig.FromSubscription("YOUR_SUB_KEY", "YOUR_REGİON");
                    var recognizer = new SpeechRecognizer(config);

                    var result = await recognizer.RecognizeOnceAsync();

                    if (result.Reason == ResultReason.RecognizedSpeech)
                    {
                        MessageBox.Show($"Tanınan Ses: {result.Text}");
                    }
                    else if (result.Reason == ResultReason.NoMatch)
                    {
                        MessageBox.Show("Ses Tanınamadı");
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show($"Ses işleme sırasında hata oluştu.\nDetay: {ex}");
                }
                
                
            }
        }
    }
}
