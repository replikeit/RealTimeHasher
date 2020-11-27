using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Encrypter.BlockHashed += EncrypterOnBlockHashed;
            Encrypter.AllFileHashed += EncrypterOnAllFileHashed;
        }

        private void EncrypterOnAllFileHashed(double readTime, double sha256Time, double khaTime)
        {
            KHATimeLabel.Text = $"{khaTime.ToString("##.00")} kb/ms";
            SHA256TimeLabel.Text = $"{sha256Time.ToString("##.00")} kb/ms";
            ReadBlockTimeLabel.Text = $"{readTime.ToString("##.00")} kb/ms";
        }

        private void EncrypterOnBlockHashed(string kha, string sha256)
        {
            KHATextBox.AppendText(kha);
            SHA256TextBox.AppendText(sha256);
        }


        private async void DoEncryptButton_Click(object sender, EventArgs e)
        {
            try
            {
                KHATextBox.Clear();
                SHA256TextBox.Clear();
                Stopwatch sw = new Stopwatch();
                sw.Start();
                var stream = TextLoader.GetStream(DomenTextBox.Text, out long len);
                await Encrypter.Encrypt(stream, len);
                sw.Stop();
                TotalTimeLabel.Text = $"{sw.ElapsedMilliseconds} ms";
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
