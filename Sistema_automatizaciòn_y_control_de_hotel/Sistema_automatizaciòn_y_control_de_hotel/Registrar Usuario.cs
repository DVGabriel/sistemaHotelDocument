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
    public partial class Registrar_Usuario : Form

    {
        public Registrar_Usuario()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InitializeComponent();
            Form volver  = new  Menu_Administrador();
            volver.Show();

        }

        private void Registrar_Usuario_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-EKNJVJF\MSSQLSERVER02;Initial Catalog=Hotel;Integrated Security=True");
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select isnull(max(cast(ID_USUARIO as varchar)),0)+1 from USUARIO", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            textBox3.Text = dt.Rows[0][0].ToString();
            this.ActiveControl = textBox1;
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-EKNJVJF\MSSQLSERVER02;Initial Catalog=Hotel;Integrated Security=True");
            con.Open();
            string CADENA = "INSERT INTO USUARIO (ID_USUARIO,NOMBRE,TIPO_USUARIO,USUARIO,CONTRASEÑA)  VALUES(@ID_USUARIO,@NOMBRE,@TIPO_USUARIO,@USUARIO,@CONTRASEÑA)";
            SqlCommand comando = new SqlCommand(CADENA, con);
            comando.Parameters.AddWithValue("@NOMBRE", textBox1.Text);
            comando.Parameters.AddWithValue("@USUARIO", textBox6.Text);
            comando.Parameters.AddWithValue("@CONTRASEÑA", textBox2.Text);
            comando.Parameters.AddWithValue("@TIPO_USUARIO", textBox5.Text);
            comando.Parameters.AddWithValue("@ID_USUARIO", textBox3.Text);
            comando.ExecuteNonQuery();
            MessageBox.Show("Datos registrados");
            con.Close();
            this.textBox3.Clear();
            this.textBox2.Clear();
            this.textBox6.Clear();
            this.textBox1.Clear();
            this.textBox5.Clear();
           
        } 
        

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-EKNJVJF\MSSQLSERVER02;Initial Catalog=Hotel;Integrated Security=True");
            con.Open();
            int flag = 0;
            string cadena ="Delete from USUARIO where USUARIO ='"+textBox6.Text+"'";
            SqlCommand comando = new SqlCommand(cadena,con);
            flag = comando.ExecuteNonQuery();

            if (flag == 1)
            {

                MessageBox.Show("Datos Eliminados");
            }
            else {
                MessageBox.Show("No existe ese usuario");
            
            }
            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-EKNJVJF\MSSQLSERVER02;Initial Catalog=Hotel;Integrated Security=True");
            con.Open();
            SqlCommand comando = new SqlCommand("select ID_USUARIO , NOMBRE ,TIPO_USUARIO,USUARIO,CONTRASEÑA  from USUARIO  ", con);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView1.DataSource = tabla;

            con.Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-EKNJVJF\MSSQLSERVER02;Initial Catalog=Hotel;Integrated Security=True");
            con.Open();
            int flag = 0;
            string cadena = "update USUARIO SET  NOMBRE='" + textBox1.Text + "',TIPO_USUARIO='" + textBox5.Text + "',CONTRASEÑA='" + textBox2.Text + "' where USUARIO='" + textBox6.Text + "'"; 
            SqlCommand comando = new SqlCommand(cadena, con);
            flag = comando.ExecuteNonQuery();

            if (flag == 1) {
                MessageBox.Show("Actualizado");

            }
                else{
                        MessageBox.Show("no se encontro registro");

        }
            con.Close();
            }

        private void button1_Click_1(object sender, EventArgs e)
        {
          

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        }

      
    }
