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

namespace Sistema_automatizaciòn_y_control_de_hotel
{
    public partial class Termino : Form
    {
        public Termino()
        {
            InitializeComponent();
        }

        DateTime hoy = DateTime.Now;
        private void button1_Click(object sender, EventArgs e)
        {
            txtTermino.Text = hoy.ToShortTimeString();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-EKNJVJF\MSSQLSERVER02;Initial Catalog=Hotel;Integrated Security=True");

        private void button2_Click(object sender, EventArgs e)
        {
            string query = "UPDATE CONTROL_JORNADA SET HORA_TERMINO = @HORA_TERMINO  WHERE ID_CONTROL_JORNADA=@ID_CONTROL_JORNADA";
            con.Open();
            SqlCommand comando = new SqlCommand(query, con);
            comando.Parameters.AddWithValue("@ID_CONTROL_JORNADA", textBox1.Text);
            comando.Parameters.AddWithValue("@HORA_TERMINO",txtTermino.Text);
            comando.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("!Que Tenga buen Dia¡");

            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Termino_Load(object sender, EventArgs e)
        {

        }

        private void txtTermino_TextChanged(object sender, EventArgs e)
        {
          
        }

 
    }
}
