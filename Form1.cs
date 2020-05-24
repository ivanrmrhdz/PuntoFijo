using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using org.mariuszgromada.math.mxparser;


namespace PuntoFijo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //el metodo llena la tabla
        private void llenarTabla(int n, double x, double gx, string ER)
        {
            dgvTabla_resultados.Rows.Add(n,x, gx, ER);   
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtFx.Text = "e^(-x)-x";
            txtGx.Text = "e^(-x)";
            txtMaxi.Text = "10";
            txtTolerancia.Text = "0.5";
            txtVi.Text = "2";
        }

        private void btnAyuda_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.btnAyuda, "Información");
        }

        private void btnLimpiar_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.btnAyuda, "Limpiar Texto");
        }

        private void btnCheck_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.btnAyuda, "Realizar Operación");
        }

        private void btnSalir_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.btnAyuda, "Salir del Programa");
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back);

        }
      
        //Validacion de numeros enteros
        private void KeyPressSoloNumerosEnteros(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
        //Validacion de Decimales
        private void KeyPressDecimales(object sender, KeyPressEventArgs e)
        {
            // permite del 0 al 9, backspace, y punto decimal
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
                return;
            }

            // comprueba que solo sea un decimal
            if (e.KeyChar == 46)
            {
                if ((sender as TextBox).Text.IndexOf(e.KeyChar) != -1)
                    e.Handled = true;
            }
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close(); //cierro la ventana
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {

            if(string.IsNullOrEmpty(txtFx.Text) || string.IsNullOrEmpty(txtGx.Text) || string.IsNullOrEmpty(txtMaxi.Text)
                || string.IsNullOrEmpty(txtTolerancia.Text) || string.IsNullOrEmpty(txtVi.Text))
            {

                MessageBox.Show("Tiene Campos Vacios", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                Validaciones();
               
            }
           
        }

        void Validaciones()
        {
            string _Fx = txtFx.Text;
            string _Gx = txtGx.Text;
          
            //Se valida que al evaluar las funciones retornen un valor numerico double 
            if (double.IsNaN(eFuncion(_Fx, "1")) || double.IsNaN(eFuncion(_Gx, "1")))
            {
                //si la funcion es inválida muestra el mensaje
                MessageBox.Show("Funciones No Validas, revise la seccion de Información", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                //si las funciones son válidas se ejecuta el siguiente codigo

                double valini = float.Parse(txtVi.Text);
                double tol = float.Parse(txtTolerancia.Text);
                int maxI = int.Parse(txtMaxi.Text);

                string _dxGx = "der("+_Gx+", x)";
                double dxGx = eFuncion(_dxGx ,txtVi.Text);//Se evalua la derivada de g(x)
                //se evalua si la funcion es divergente
                if (dxGx<1 && dxGx>-1)
                {
                    PuntoFijo(valini, tol, maxI);
                }
                else
                {
                    MessageBox.Show("La derivada de la funcion nos dice que divergera!. Elija otro punto inicial, o utilice otro método.", "La prueba de punto fijo divergera!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
            }

        }

        void PuntoFijo(double valorInicial, double tolerancia, int iteracionesMax)
        {
            chart1.Series["Gx"].Points.Clear();
            chart1.Series["Identidad"].Points.Clear();
            chart1.Titles.Clear();

            int n = 0;
            double x = valorInicial;
            double x_anterior = 0;
            double porcentaje = 100;

            //si hay error se agrega a la tabla

            dgvTabla_resultados.Rows.Clear();

            do
            {
                x_anterior = x;//se guarda el valor actual de x

                x = eFuncion(txtGx.Text, x.ToString());//evaluando la funcion para obtener el nuevo valor de x
                n++;//se suma al contador de iteraciones

                if (n > 1)
                {
                    porcentaje = Math.Abs(((x - x_anterior) / x) * 100);//Valor absoluto del porcentaje de error

                    
                    llenarTabla(n, x_anterior, x, porcentaje.ToString()); //lleno la tabla
                }
                else
                {
                    llenarTabla(n, x_anterior, x, " - "); //lleno la tabla
                }

               

            } while (n <= iteracionesMax && porcentaje>tolerancia);

            double xResult = x;

            if (eFuncion(txtFx.Text, x.ToString())<=-0.01 || eFuncion(txtFx.Text, x.ToString())>= 0.01)
            // si no se llega ni cerca de un cero, entonces mostramos una alerta
            {
                MessageBox.Show("No se encuentra ninguna raiz en el intervalo dado!\n"
                    +"Revise la Grafica para escoger otro Valor Inicial", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               
                String titulo = "Se presenta la grafica de g(x) = " + txtGx.Text;
                chart1.Titles.Add(titulo);
                for (double i = -6.0; i < 6.0; i += 0.5)
                {


                    x = eFuncion(txtGx.Text, i.ToString());//se evalua la funcion en el intervalo definido para graficar -10.0 hasta 10.0
                    chart1.Series["Gx"].Points.AddXY(i, x);
                    chart1.Series["Identidad"].Points.AddXY(i, i);

                }
            }
            else
            {
                String titulo = "Se presenta la grafica de g(x) = "+txtGx.Text;
                chart1.Titles.Add(titulo);
                for (double i = -6.0; i < 6.0; i += 0.5)
                {

                     x = eFuncion(txtGx.Text, i.ToString());//se evalua la funcion en el intervalo definido para graficar -10.0 hasta 10.0
                    chart1.Series["Gx"].Points.AddXY(i, x);
                    chart1.Series["Identidad"].Points.AddXY(i, i);
                    
                }
             
                // si se llego cerca de cero, se generan los resultados 

                MessageBox.Show("El programa encontró resultados con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                lbRaiz.Text = xResult.ToString();
                lbER.Text = porcentaje.ToString();
                lbIteraciones.Text = n.ToString();
                lbFuncion.Text = txtFx.Text;

            }


        }

        public double eFuncion(string funcion, string argumento)
        {
            double resultado = 0;
            // usando mathparse evaluamos la funcion con el valor de x
            Argument x = new Argument("x = "+ argumento);//valor de x
            Expression Gx = new Expression(funcion, x);//se evalua la funcion
            resultado = Gx.calculate();//se asigna el resultado


            return resultado;
        } 

        public void limpiarLabels()
        {
            lbRaiz.Text = "Ninguno";
            lbER.Text = "Ninguno";
            lbIteraciones.Text = "Ninguna"; ;
            lbFuncion.Text = "Ninguna";

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dgvTabla_resultados.Rows.Clear();
            txtFx.Text = null;
            txtGx.Text = null;
            txtMaxi.Text = null;
            txtTolerancia.Text = null;
            txtVi.Text = null;
            limpiarLabels();
            txtFx.Focus();
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {

            Informacion2 i = new Informacion2();
            i.ShowDialog();
            


        }

        private void txtFx_TextChanged(object sender, EventArgs e)
        {
           /* chart1.Series["Gx"].Points.Clear();
            chart1.Series["Identidad"].Points.Clear();
            chart1.Titles.Clear();*/
        }
    }
  
}
