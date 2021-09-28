using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using System.IO;

namespace _00Comenzando
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Instituto insti = new Instituto();

        private void label1_Click(object sender, EventArgs e)
        {
            //boxPersonas.Items.AddRange(insti.Personas.ToArray());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbTransporte.Items.AddRange(Enum.GetNames(typeof(Persona.Transporte)));
            insti.IniciarInstituto();
            UpdateBoxPersonas();
            
        }

        private void On(object sender, EventArgs e)
        {
            Persona selected = (Persona)boxPersonas.SelectedItem;
            labelNombreContent.Text = selected.Nombre;
            labelTransporteContent.Text = selected.Movilidad.ToString();
            labelDistanciaContent.Text = selected.Distancia.ToString();
        }

        private void BntAdd_Click(object sender, EventArgs e)
        {
            if (cmbTransporte.SelectedItem != null)
            {
                string resultado = insti.AddPersonaBtn(txtNombre.Text, txtDistancia.Text, cmbTransporte.SelectedItem.ToString());
                txtResultado.Text = resultado;
                UpdateBoxPersonas();
            }
            else
            {
                txtResultado.Text = "Error al elegir transporte";
            }
        }

        private void UpdateBoxPersonas()
        {
            List<string> errores = new List<string>();
            boxPersonas.Items.Clear();
            boxPersonas.Items.AddRange(insti.LeerPersonasDeFichero(out errores).ToArray());
            foreach(string s in errores)
            {
                Console.WriteLine(s);
            }
            
        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            lblResultadoBorrar.Text = insti.Quitar(txtBorrar.Text);
            UpdateBoxPersonas();
        }
    }
}
