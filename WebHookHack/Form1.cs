using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Net.Http;
using System.Windows.Forms;


namespace WebHookHack
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      
        private void button2_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            this.textBox2.Text = "";
            this.textBox3.Text = "";
            this.textBox4.Text = "";
            this.Log.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tStartDDS();
        }
        private void オート_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.trackBar1.Value; ++i)
            {
                tStartDDS();
            }
        }
        private void tStartDDS()
        {
            string text = this.textBox1.Text;

            try
            {
                HttpClient httpClient = new HttpClient();
                Dictionary<string, string> nameValueCollection = new Dictionary<string, string>
                {
                    {"content",this.textBox4.Text} , {"username",this.textBox2.Text} , {"avatar_url",this.textBox3.Text}
                };
                httpClient.PostAsync(text, new FormUrlEncodedContent(nameValueCollection)).GetAwaiter().GetResult();
                this.Log.Text = "送信完了。";
            }
            catch
            {
                this.Log.Text = "正しいWebHookを入力して下さい。";
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.textBox4.Text = "@everyone";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.textBox4.Text = "@here";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
           
        }

   

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }
    }
}
