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
using libreria;

namespace FactuxD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();



        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                string CMD = string.Format("Select * FROM Usuarios WHERE account ='{0}' and password='{1}'", txtNomAcc.Text.Trim(), txtPass.Text.Trim());

                DataSet DS = Utilidades.Ejecutar(CMD);

                /*funciona como una matriz*/
                string cuenta = DS.Tables[0].Rows[0]["account"].ToString().Trim();

                string contra = DS.Tables[0].Rows[0]["password"].ToString().Trim();

                if (cuenta == txtNomAcc.Text.Trim() && contra == txtPass.Text.Trim())
                {
                    MessageBox.Show("Se ha iniciado sesión");
                }

            }

            catch (Exception error)
            {
                MessageBox.Show("Error: Usuario o contraseña incorrecta " + error.Message);

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

