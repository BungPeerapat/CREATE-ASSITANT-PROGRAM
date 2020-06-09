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
    public partial class Botscreen : Form
    {
        string closeform = "ON";
         public Botscreen()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(1050, 380);
            DelayForStop3s();
            Task.Delay(3000);
            Console.Beep();
            Task.Delay(3000);
            Console.Beep();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Lime;
            this.TransparencyKey = Color.Lime;
            this.FormBorderStyle = FormBorderStyle.None;
        }
        
        async internal static void DelayForStop3s()
        {
            await Task.Delay(3000);
            Shutdown();
        }
         
        public static void Shutdown()
        {
         Botscreen.ActiveForm.Hide();
        }
    }
}
