using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ping_gönderme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Ping p = new Ping();
        private int sayac;
        private string durum = "";
        private string adress = "";
        private string zaman = "";
        private string sonuc = "";
        private long pingAdet = 10;

        private void Form1_Load(object sender, EventArgs e)
        {

        }
       

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.CheckState == CheckState.Checked)
            {
                pingAdet = 9999999999;
                sayı.Text = "9999999999";
                sayı.Enabled = false;

            }
            else
            {
                sayı.Text = "10";
                pingAdet= Convert.ToInt32(sayı);
                sayı.Enabled = true;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add(adres.Text + "Adresine Ping işlemi Başlıyor...");
            listBox1.Items.Add("--------------" + Environment.NewLine);
            sayac = 0;
            timer1.Interval= Convert.ToInt32(hız.Text);
            pingAdet = Convert.ToInt64(sayı.Text);
            timer1.Enabled = true;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            if (sayac >= pingAdet)
            {

               listBox1.Items.Add("--------------" + Environment.NewLine);
                listBox1.Items.Add(sonuc + Environment.NewLine);
                listBox1.Items.Add("--------------" + Environment.NewLine);
                timer1.Stop();
                timer1.Enabled = false;

            }
            else
            {
                try
                {
                    PingReply reply = p.Send(adres.Text);
                    durum = reply.Status.ToString();
                    adress = reply.Address.ToString();
                    zaman = reply.RoundtripTime.ToString();
                    listBox1.Items.Add(string.Format("Sonuç : {0} {1} -> {2} ms.", durum, adress, zaman + Environment.NewLine));
                    sonuc = "Ping başarı ile tamamlandı";

                }
                catch (PingException)
                {
                    listBox1.Items.Add("Bilinen böyle bir ana bilgisayar yok" + Environment.NewLine);
                    sonuc = "Bir veya daha fazla Ping denemesi başarısız oldu";
                }
                catch (NullReferenceException)
                {
                    listBox1.Items.Add("Ping Atılamadı. Adres yanlış olabilir." + Environment.NewLine);
                    sonuc= "Bir veya daha fazla Ping denemesi başarısız oldu";
                }
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string path = @"C:\\PingLog.txt";
            new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write).Close();

            int sayac = 0;
            while (true)
            {
                if (sayac >= listBox1.Items.Count)
                {
                    Process.Start(path);
                    return;
                }
                File.AppendAllText(path, listBox1.Items[sayac].ToString());
                sayac++;
            }





        }

        private void button3_Click(object sender, EventArgs e)
        {
            pingAdet = 1;
        }
    }
}
