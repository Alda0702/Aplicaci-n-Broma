using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicación_Broma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblTexto_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("SU DISPOSITIVO SERA FORMATEADO EN 5 MINUTOS.");
        }

        private void btnCancelar_MouseHover(object sender, EventArgs e)
        {
            Random random = new Random();
            int randomx = random.Next(0, this.ClientSize.Width - btnCancelar.Width);
            int randomy = random.Next(0, this.ClientSize.Height - btnCancelar.Height);

            btnCancelar.Location = new Point(randomx, randomy);

        }
    }
}
