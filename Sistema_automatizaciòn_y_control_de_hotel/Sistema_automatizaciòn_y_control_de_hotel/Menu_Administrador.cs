using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_automatizaciòn_y_control_de_hotel
{
    public partial class Menu_Administrador : Form
    {
        public  Menu_Administrador(string NOMBRE)
        {
            InitializeComponent();
            lblMensajeAdmin.Text = NOMBRE;
        }

        public Menu_Administrador()
        {
            InitializeComponent();
        }

        private void Menu_Administrador_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           Form Registrar_us = new Registrar_Usuario();
           Registrar_us.Show();
          


        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form Registrar_cli = new Registrar_pasajero();
            Registrar_cli.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form Control = new Control_Jornada();
            Control.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form cocina = new  Menu_Cocinero();
            cocina.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
          
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form rec = new Menu_Recepcionista();
            rec.Show();
        }
       
    }
}
