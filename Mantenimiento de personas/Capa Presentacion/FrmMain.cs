using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Capa_Presentacion
{
    public partial class FrmMain : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
            (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
            );

        public FrmMain()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15));
            pnlNav.Height = btnRegistro.Height;
            pnlNav.Top = btnRegistro.Top;
            pnlNav.BackColor = Color.FromArgb(33, 33, 32);
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            /**Efecto pnlNav */
            pnlNav.Height = btnRegistro.Height;
            pnlNav.Top = btnRegistro.Top;
            pnlNav.Left = btnRegistro.Left;
            btnRegistro.BackColor = Color.FromArgb(255, 255, 255);
            pnlNav.BackColor = Color.FromArgb(0, 126, 249);

            OpenFormOnWrapper(new FrmRegistro());
        }

        private void btnPlanilla_Click(object sender, EventArgs e)
        {
            /**Efecto pnlNav */
            pnlNav.Height = btnPlanilla.Height;
            pnlNav.Top = btnPlanilla.Top;
            btnPlanilla.BackColor = Color.FromArgb(255, 255, 255);
            pnlNav.BackColor = Color.FromArgb(0, 126, 249);

            OpenFormOnWrapper(new FrmPlanilla());
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            /**Efecto pnlNav */
            pnlNav.Height = btnExit.Height;
            pnlNav.Top = btnExit.Top;
            btnExit.BackColor = Color.FromArgb(255, 255, 255);
            pnlNav.BackColor = Color.FromArgb(0, 126, 249);

            /**Finalizar programa */
            DialogResult resultado = new DialogResult();
            Color color = Color.FromArgb(227, 76, 94);
            Image imagen = Image.FromFile("D:/Github/Crud-Personas/Mantenimiento de personas/Capa Presentacion/Recursos/exclamacion-icon.png");
            Form notificacion = new FrmNotificacion("ALERTA", "¿Seguro desea finalizar el programa?", color, imagen);
            resultado = notificacion.ShowDialog();

            if (resultado == DialogResult.OK)
                Application.Exit();
        }

        private void btnRegistro_Leave(object sender, EventArgs e)
        {
            btnRegistro.BackColor = Color.FromArgb(33, 33, 32);
        }

        private void btnPlanilla_Leave(object sender, EventArgs e)
        {
            btnPlanilla.BackColor = Color.FromArgb(33, 33, 32);
        }

        private void btnExit_Leave(object sender, EventArgs e)
        {
            btnExit.BackColor = Color.FromArgb(33, 33, 32);
        }

        /**Método OpenFormOnWrapper() */
        private new Form ActiveForm = null;

        private void OpenFormOnWrapper(Form FormHijo)
        {
            if (ActiveForm != null)
            {
                ActiveForm.Close();
            }

            ActiveForm = FormHijo;
            FormHijo.TopLevel = false;
            FormHijo.Dock = DockStyle.Fill;
            pnlWrapper.Controls.Add(FormHijo);
            pnlWrapper.Tag = FormHijo;
            FormHijo.BringToFront();
            FormHijo.Show();
        }
    }
}
