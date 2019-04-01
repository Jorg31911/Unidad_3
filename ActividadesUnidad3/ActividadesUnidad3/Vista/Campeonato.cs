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
    public partial class Campeonato : Form
    {
        private string path = "C:\\Users\\LAB02-06\\Documents\\Visual Studio 2015\\campeonato.txt";
        public Campeonato()
        {
            InitializeComponent();
        }

       
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Main x = new Main();
            x.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Jornada x = new Jornada();
            x.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Main x = new Main();
            x.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Jornada x = new Jornada();
            x.Show();
            this.Hide();
        }
        private void LoadGrid()
        {
            datos.SelectionMode = DataGridViewSelectionMode.FullColumnSelect;
            datos.Rows.Clear();
            datos.AllowUserToAddRows = false;
        }
       
    }
}
