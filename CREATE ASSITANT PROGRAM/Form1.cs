using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CREATE_ASSITANT_PROGRAM
{
    public partial class LoginMain : Form
    {
        public LoginMain()
        {
            InitializeComponent();
        }

        String CodeSend;

        private void button2_Click(object sender, EventArgs e)
        {
            Botscreen BS = new Botscreen();
            BS.Show();
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
    }
}
