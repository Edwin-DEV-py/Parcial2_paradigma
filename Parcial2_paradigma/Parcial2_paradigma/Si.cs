using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Parcial2_paradigma
{
    public partial class Si : Form
    {
        SqlConnection conexion = new SqlConnection("Server=LAPTOP-5I9GTG2B; DataBase=Parcial2; Integrated Security= True");
        public Si()
        {
            InitializeComponent();
        }

        private void hora_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            hora.Text = DateTime.Now.ToString("h:mm");
        }

        private void BtnParquearSi_Click(object sender, EventArgs e)
        {
            string Cedula = "1733363833";
            string Placa = "May004";
            string Cedula2 = "1111111111";
            string Placa2 = "Abr018";

            if ((CedulaSi.Text == Cedula && PlacaSi.Text == Placa)||(CedulaSi.Text == Cedula2 && PlacaSi.Text == Placa2))
            {
                string query = "INSERT INTO Parqueadero (Cedula,Placa,Tipo_Vehiculo,tiempo_entrada) VALUES (@cedula,@placa,@tipo_vehiculo,@tiempo_entrada)";
                conexion.Open();
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@cedula",CedulaSi.Text);
                comando.Parameters.AddWithValue("@placa", PlacaSi.Text);
                comando.Parameters.AddWithValue("@tipo_vehiculo", combovehiculoSi.Text);
                Factura ventana5 = new Factura();
                ventana5.Show();
                this.Hide();
            }
        }
    }
}
