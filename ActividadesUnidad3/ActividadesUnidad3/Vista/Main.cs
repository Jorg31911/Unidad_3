using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ActividadesUnidad3.Vista
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        


     
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Campeonato x = new Campeonato();
            x.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Jornada x = new Jornada();
            x.Show();
            this.Hide();
        }
    }
}
