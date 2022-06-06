using Capa_Presentacion.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Presentacion
{
    public partial class FrmRegistro : Form
    {
        public FrmRegistro()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            /**Variables & Objetos */
            PersonaDao persona = new PersonaDao();
            String estadoCivil = GetEstadoCivil();

            try
            {
                if (txtNombre.Text == "" || txtDni.Text == "" || txtPaterno.Text == "" || txtMaterno.Text == "" || txtDireccion.Text == "" || estadoCivil == null)
                {
                    /**Validar campos vacíos */
                    Color color = Color.FromArgb(227, 76, 94);
                    Image imagen = Image.FromFile("D:/Github/Crud-Personas/Mantenimiento de personas/Capa Presentacion/Recursos/exclamacion-icon.png");
                    Form notificacion = new FrmAlerta("ALERTA", "Debe completar todos los campos vacíos", color, imagen);
                    notificacion.ShowDialog();
                }
                else
                {
                    persona.AddPersona(txtNombre.Text, txtPaterno.Text, txtMaterno.Text, txtDni.Text, estadoCivil, txtDireccion.Text, dtpNacimiento.Value, int.Parse(lblEdadCalc.Text));

                    Color color = Color.FromArgb(32, 194, 133);
                    Image imagen = Image.FromFile("D:/Github/Crud-Personas/Mantenimiento de personas/Capa Presentacion/Recursos/success-icon.png");
                    Form notificacion = new FrmAlerta("SUCCESS", "Se registró exitosamente", color, imagen);
                    notificacion.ShowDialog();

                    ClearFields();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocurrió un problema al registrar la información" + ex.Message);
            }
        }

        /**Método ClearFields() */
        private void ClearFields()
        {
            txtNombre.Clear();
            txtDni.Clear();
            txtPaterno.Clear();
            txtMaterno.Clear();
            txtDireccion.Clear();
            dtpNacimiento.Value = DateTime.Today;
            lblEdad.Text = "Edad";
            rbtnSoltero.Checked = false;
            rbtnCasado.Checked = false;
            rbtnViudo.Checked = false;
            rbtnDivorciado.Checked = false;
        }

        /**Método GetEstadoCivil() */
        private String GetEstadoCivil()
        {
            if (rbtnSoltero.Checked == true)
                return "Soltero";
            else if (rbtnCasado.Checked == true)
                return "Casado";
            else if (rbtnViudo.Checked == true)
                return "Viudo";
            else if (rbtnDivorciado.Checked == true)
                return "Divorciado";
            else
                return null;
        }

        private void dtpNacimiento_ValueChanged(object sender, EventArgs e)
        {
            DateTime FechaActual = DateTime.Today;
            int edad = 0;

            edad = FechaActual.Year - dtpNacimiento.Value.Year;

            if (FechaActual < dtpNacimiento.Value.AddYears(edad))
                edad--;

            lblEdadCalc.Text = edad.ToString();
        }
    }
}
