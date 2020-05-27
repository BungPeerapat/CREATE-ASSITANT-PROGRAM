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
        public Botscreen()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Lime;
            this.TransparencyKey = Color.Lime;
            this.FormBorderStyle = FormBorderStyle.None;
        }
    }
}
