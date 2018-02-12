using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Peer2Peer
{
    public partial class Peer2Peer : Form
    {
        public Peer2Peer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login_Screen login = new Login_Screen();
            login.ShowDialog();
        }
    }
}
