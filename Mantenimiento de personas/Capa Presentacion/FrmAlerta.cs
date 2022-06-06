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
    public partial class FrmAlerta : Form
    {
        public FrmAlerta(String titulo, String mensaje, Color color, Image imagen)
        {
            InitializeComponent();

            lblTitulo.Text = titulo;
            lblMensaje.Text = mensaje;
            pnlColor.BackColor = color;
            pboxAlerta.Image = imagen;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void RealeseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void pboxAlerta_MouseDown(object sender, MouseEventArgs e)
        {
            RealeseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pnlContainer_MouseDown(object sender, MouseEventArgs e)
        {
            RealeseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
