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
    public partial class Iniciar_Sesion : Form
    {
        public Iniciar_Sesion()
        {
            InitializeComponent();
        }


              

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-EKNJVJF\MSSQLSERVER02;Initial Catalog=Hotel;Integrated Security=True");
        public void logear(string USUARIO, string CONTRASEÑA) {


            try
            {

                con.Open();

                SqlCommand cmd = new SqlCommand("SELECT TIPO_USUARIO FROM USUARIO WHERE USUARIO = '" + USUARIO + "' AND CONTRASEÑA = " + CONTRASEÑA, con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count == 1)
                {

                    if (dt.Rows[0].ItemArray[0].ToString() == "ADMINISTRADOR")
                    {
                        new Menu_Administrador(dt.Rows[0][0].ToString()).Show();
                    }
                    else if (dt.Rows[0].ItemArray[0].ToString() == "RECEPCIONISTA")
                    {
                        new Menu_Recepcionista(dt.Rows[0][0].ToString()).Show();

                    }
                    else if (dt.Rows[0].ItemArray[0].ToString() == "COCINA")
                    {
                        new Menu_Cocinero(dt.Rows[0][0].ToString()).Show();
                    }
                    else if (dt.Rows[0].ItemArray[0].ToString() == "AUXILIAR")
                    {
                        new Menu_Recepcionista(dt.Rows[0][0].ToString()).Show();


                    }

                }
                else
                {
                    MessageBox.Show("Usuario y/o Cointraseña Incorrecta");
                }

            }

            catch
            {

            }
            finally
            {
                con.Close();

            }
            }


        private void button2_Click(object sender, EventArgs e)
        {
          
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            logear(this.textBox1.Text, this.textBox2.Text);

        
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-EKNJVJF\MSSQLSERVER02;Initial Catalog=Hotel;Integrated Security=True");
                con.Open();
                string CADENA = "INSERT INTO CONTROL_JORNADA  (ID_CONTROL_JORNADA,FECHA_SESION,HORA_SESION,USUARIO_CONTROL,CONTRASEÑA_CONTROL)  VALUES(@ID_CONTROL_JORNADA,@FECHA_SESION,@HORA_SESION,@USUARIO_CONTROL,@CONTRASEÑA_CONTROL)";
                SqlCommand comando = new SqlCommand(CADENA, con);
                comando.Parameters.AddWithValue("@ID_CONTROL_JORNADA", txtID.Text);
                comando.Parameters.AddWithValue("@FECHA_SESION", txtFecha.Text);
                comando.Parameters.AddWithValue("@HORA_SESION", txtHora.Text);
                comando.Parameters.AddWithValue("@USUARIO_CONTROL", textBox1.Text);
                comando.Parameters.AddWithValue("@CONTRASEÑA_CONTROL", textBox2.Text);
 
                comando.ExecuteNonQuery();

                this.txtID.Clear();
                this.txtFecha.Clear();
                this.txtHora.Clear();
                this.textBox1.Clear();
                this.textBox2.Clear();



              

             con.Close();
            
            }
         

       
          
     
        DateTime hoy = DateTime.Now;
        private void button2_Click_1(object sender, EventArgs e)
        {
            txtFecha.Text = hoy.ToLongDateString();
            txtHora.Text = hoy.ToShortTimeString();
        }

        private void Iniciar_Sesion_Load(object sender, EventArgs e)
        {

        }

     
    }
}
