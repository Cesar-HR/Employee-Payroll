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
    public partial class FrmPlanilla : Form
    {
        public FrmPlanilla()
        {
            InitializeComponent();
        }

        private void FrmPlanilla_Load(object sender, EventArgs e)
        {
            ShowListaPersona();
        }

        /**Método ShowListaPersona() */
        private void ShowListaPersona()
        {
            PersonaDao ListaPersona = new PersonaDao();
            dataGridPlanilla.DataSource = ListaPersona.GetListaPersona();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int? id = GetId();

            if(id != null)
            {
                FrmEditar editar = new FrmEditar(id);
                editar.ShowDialog();
                ShowListaPersona();
            }
        }

        /**Helper GetId() */
        #region HELPER
        private int? GetId()
        {
            try
            {
                return int.Parse(dataGridPlanilla.Rows[dataGridPlanilla.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch
            {
                return null;
            }
        }
        #endregion

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int? id = GetId();

            try
            {
                if (id != null)
                {
                    PersonaDao personaDao = new PersonaDao();
                    
                    /**Eliminar persona */
                    DialogResult resultado = new DialogResult();
                    Color color = Color.FromArgb(227, 76, 94);
                    Image imagen = Image.FromFile("D:/Github/Crud-Personas/Mantenimiento de personas/Capa Presentacion/Recursos/trash-icon.png");
                    Form notificacion = new FrmNotificacion("ALERTA", "¿Seguro desea eliminar la información?", color, imagen);
                    resultado = notificacion.ShowDialog();

                    if (resultado == DialogResult.OK)
                    {
                        personaDao.DeletePersona((int)id);

                        Color colorGreen = Color.FromArgb(32, 194, 133);
                        Image imagenSuccess = Image.FromFile("D:/Github/Crud-Personas/Mantenimiento de personas/Capa Presentacion/Recursos/success-icon.png");
                        Form notificacionOk = new FrmAlerta("SUCCESS", "Se eliminó exitosamente", colorGreen, imagenSuccess);
                        notificacionOk.ShowDialog();
                        ShowListaPersona();
                    }

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocurrió un problema al eliminar la información: " + ex.Message);
            }
        }
    }
}
