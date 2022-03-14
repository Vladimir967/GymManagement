using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymProj
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddMember addMember = new AddMember();
            addMember.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ViewMembers view = new ViewMembers();
            view.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UpdateDelete ud = new UpdateDelete();
            ud.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Sear pay = new Sear();
            pay.Show();
            this.Hide();
        }
    }
}
