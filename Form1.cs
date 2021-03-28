using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad_Integradora_2_Problema_2
{
    public partial class Form1 : Form
    {
        string[,] Empleados = new string[100,2];
        int contador = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Empleados[contador, 0] = txtNombre.Text;
            Empleados[contador, 1] = txtAntiguedad.Text;
            contador++;
            MessageBox.Show("Empleado Registrado");
            txtNombre.Text = string.Empty;
            txtAntiguedad.Text = string.Empty;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int menor = 0, entre = 0, mayor = 0;
            string personasMenor = string.Empty, personasEntre = string.Empty, personasMayor = string.Empty;
            for (int i = 0; i < contador; i++)
            {
                int antiguedad = Convert.ToInt32(Empleados[i, 1]);
                if (antiguedad <= 1)
                {
                    menor++;
                    personasMenor = string.Format("{0}, {1} ", personasMenor, Empleados[i, 0]);
                }
                else if (antiguedad > 1 && antiguedad < 5)
                {
                    entre++;
                    personasEntre = string.Format("{0}, {1} ", personasEntre ,Empleados[i, 0]);
                }
                else if (antiguedad >= 5)
                {
                    mayor++;
                    personasMayor = string.Format("{0}, {1} ", personasMayor, Empleados[i, 0]);
                }
            }
            lblMenor.Text = string.Format("{0}  {1}", menor.ToString(), personasMenor);
            lblEntre.Text = string.Format("{0}  {1}", entre.ToString(), personasEntre);
            lblMayor.Text = string.Format("{0}  {1}", mayor.ToString(), personasMayor);
        }
    }
}
