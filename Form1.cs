using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pictureBox2.Controls.Add(pictureBox1);
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Controls.Add(pB_drink1);
            pictureBox1.Controls.Add(pB_drink2);
            pictureBox1.Controls.Add(pB_drink3);
            pB_drink1.BackColor = Color.Transparent;
            pB_drink2.BackColor = Color.Transparent;
            pB_drink3.BackColor = Color.Transparent;
            Client client = new Client();
        }

        private void pB_drink1_Click(object sender, EventArgs e)
        {
            Client client = new Client();
            client
        }
    }
}
