using CREATE_ASSITANT_PROGRAM.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CREATE_ASSITANT_PROGRAM
{
    public partial class LoginMain : Form
    {

        public LoginMain()
        {
            InitializeComponent();
            Thread CT = new Thread(CheckText);
            CT.Start();
        }
        private void CheckText()
        {
            while (true)
            {
                if(BotTalkSystem.SendText == "Test")
                {
                    Console.Beep();
                    Console.Beep();
                    STARTSOUND1(@"F:\Program Files\CREATE ASSITANT PROGRAM\CREATE ASSITANT PROGRAM\sound\BOTSOUNDTEST\สวัสดีค่ะมาสเตอร์.wav");
                    BotTalkSystem.SendText = null;
                }
            }
        }


        String CodeSend;


        WMPLib.WindowsMediaPlayer STARTSOUNDFIRST;
        public void STARTSOUND1(string url)
        {
            STARTSOUNDFIRST = new WMPLib.WindowsMediaPlayer();
            STARTSOUNDFIRST.URL = url;
            STARTSOUNDFIRST.controls.play();
            STARTSOUNDFIRST.settings.volume = 5;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Botscreen BS = new Botscreen();
            BS.Show();
            MessageBox.Show("สวัสดีค่ะ Master."); //เส่นเสียง
            Thread BTS = new Thread(BotTalkSystem.BTS);
            BTS.Start();
            STARTSOUND1(@"F:\Program Files\CREATE ASSITANT PROGRAM\CREATE ASSITANT PROGRAM\sound\BOTSOUNDTEST\สวัสดีค่ะมาสเตอร์.wav");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (USERNAMETEXT.Text == "AdminCode" && PASSWORDTEXT.Text == "74122541")
            {
                USERNAMETEXT.ForeColor = Color.Green;
                Console.Beep();
                PASSWORDTEXT.ForeColor = Color.Green;
                Console.Beep();
                MessageBox.Show("Welcome Admin");
                MainMenu ADMINSIZEOPEN = new MainMenu();
                CodeSend = USERNAMETEXT.Text;
                this.Hide();

            }
            if (USERNAMETEXT.Text == "Member" && PASSWORDTEXT.Text == "Pass")
            {
                USERNAMETEXT.ForeColor = Color.Green;
                Console.Beep();
                PASSWORDTEXT.ForeColor = Color.Green;
                Console.Beep();
                MessageBox.Show("Welcome Member");
                MainMenu MainMenu = new MainMenu();
                CodeSend = USERNAMETEXT.Text;
                this.Hide();
            }
        }

        private void LoginMain_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Lime;
            this.TransparencyKey = Color.Lime;
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void Memberb_Click(object sender, EventArgs e)
        {

        }

        private void PASSWORDTEXT_TextChanged(object sender, EventArgs e)
        {

        }

        private void USERNAMETEXT_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
