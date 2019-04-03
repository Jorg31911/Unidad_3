using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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
            datos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            datos.Rows.Clear();
            datos.AllowUserToAddRows = false;

            if(File.Exists(path))
            {
                StreamReader streamReader = new StreamReader(path, Encoding.Default);
                string text;

                while((text = streamReader.ReadLine()) != null)
                {
                    string[] array = text.Split('|');
                    datos.Rows.Add(array);
                }

                streamReader.Close();
            }
            else
            {
                File.Create(path);            }
        }
        private void Campeonato_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void add_Click(object sender, EventArgs e)
        {
            string msg = "";

            if(textBox2.Text.Length <3 || textBox2.Text.Length > 50)
            {
                msg += "El nombre debe estar comprendido entre 3 y 50 caracteres";
            }

            DateTime dateTimePicker1 = new DateTime(dateInicio.Value.Year, dateInicio.Value.Month, dateInicio.Value.Day, 0, 0, 0);
            DateTime dateTimePicker2 = new DateTime(dateFin.Value.Year, dateFin.Value.Month, dateFin.Value.Day, 0, 0, 0);
       if(DateTime.Compare(dateTimePicker1, dateTimePicker2)>=0)
       {
                msg += "La fecha Inicio debe ser menor a la fecha final";
       }
       if(msg.Length > 0)
       {
                MessageBox.Show(msg, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
       }
       else
       {
                //Crea un objeto de tipo campeonato
                Campeonato campeonato = new Campeonato();
                campeonato.d= new Random().Next(1,1000);//Se genera un Id Aleatorio 
                campeonato.Name = textBox2.Text; //Caja de texto
                campeonato.Fecha_inicio = dateInicio.Value;//Inicio
                campeonato.Fecha_Fin = dateFin.Value;//Fin

                string[] array = campeonato.ToString().Split(new char[] { '|' });
                datos.Rows.Add(array);
                AddRecordFile(campeonato);//Lo agrega al archivo un objeto
                msg = "Registro agregado exitosamente";
                MessageBox.Show(msg, "Agrega un campeonato", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
       }

        private void AddRecordFile(Campeonato campeonato)
        {
            StreamWriter writer = new StreamWriter(path, true);

            writer.WriteLine(campeonato.ToString());
            writer.Close();
        }

     
    }
}
