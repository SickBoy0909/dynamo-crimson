using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Contra_TextChanged(object sender, EventArgs e)
        {

        }

        private void Inicio_Click(object sender, EventArgs e)
        {
            if(usuario.Text == "juancho" & contra.Text == "123tamarindo")
            {
                MessageBox.Show("Bienvenido");
                this.Close();
            }
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hasta la proxima");
            this.Close();

        }
    }
}
