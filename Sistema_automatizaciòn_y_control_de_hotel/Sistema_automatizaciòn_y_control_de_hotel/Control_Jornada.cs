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
    public partial class Control_Jornada : Form
    {
        public Control_Jornada()
        {
            InitializeComponent();
        }

      

        private void button3_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-EKNJVJF\MSSQLSERVER02;Initial Catalog=Hotel;Integrated Security=True");
            con.Open();
            SqlCommand comando = new SqlCommand("Select ID_CONTROL_JORNADA,FECHA_SESION,HORA_SESION,HORA_TERMINO, USUARIO_CONTROL FROM CONTROL_JORNADA",con);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView1.DataSource = tabla;
        
            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form menu = new Menu_Administrador();
            menu.Show();

            this.Close();
        }

        private void Control_Jornada_Load(object sender, EventArgs e)
        {

        }
    }
}
   