using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntoFijo
{
    public partial class Ventana_de_Ayuda : Form
    {
        public Ventana_de_Ayuda()
        {
            InitializeComponent();
        }

        private void Ventana_de_Ayuda_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
