namespace Capa_Presentacion
{
    partial class FrmRegistro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblPaterno = new System.Windows.Forms.Label();
            this.lblMaterno = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblNacimiento = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblEstadoCivil = new System.Windows.Forms.Label();
            this.rbtnSoltero = new System.Windows.Forms.RadioButton();
            this.rbtnCasado = new System.Windows.Forms.RadioButton();
            this.rbtnViudo = new System.Windows.Forms.RadioButton();
            this.rbtnDivorciado = new System.Windows.Forms.RadioButton();
            this.txtNombre = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.txtPaterno = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.txtMaterno = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.txtDireccion = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.txtDni = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.lblEdadCalc = new System.Windows.Forms.Label();
            this.dtpNacimiento = new System.Windows.Forms.DateTimePicker();
            this.btnAgregar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(243)))), ((int)(((byte)(239)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(770, 54);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "AGREGAR NUEVA PERSONA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(76)))), ((int)(((byte)(94)))));
            this.label2.Location = new System.Drawing.Point(30, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "*campos obligatorios";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(30, 107);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(56, 14);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(327, 107);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(30, 14);
            this.lblDni.TabIndex = 3;
            this.lblDni.Text = "DNI";
            // 
            // lblPaterno
            // 
            this.lblPaterno.AutoSize = true;
            this.lblPaterno.Location = new System.Drawing.Point(30, 203);
            this.lblPaterno.Name = "lblPaterno";
            this.lblPaterno.Size = new System.Drawing.Size(110, 14);
            this.lblPaterno.TabIndex = 4;
            this.lblPaterno.Text = "Apellido Paterno";
            // 
            // lblMaterno
            // 
            this.lblMaterno.AutoSize = true;
            this.lblMaterno.Location = new System.Drawing.Point(327, 203);
            this.lblMaterno.Name = "lblMaterno";
            this.lblMaterno.Size = new System.Drawing.Size(112, 14);
            this.lblMaterno.TabIndex = 5;
            this.lblMaterno.Text = "Apellido Materno";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(30, 293);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(63, 14);
            this.lblDireccion.TabIndex = 6;
            this.lblDireccion.Text = "Dirección";
            // 
            // lblNacimiento
            // 
            this.lblNacimiento.AutoSize = true;
            this.lblNacimiento.Location = new System.Drawing.Point(30, 379);
            this.lblNacimiento.Name = "lblNacimiento";
            this.lblNacimiento.Size = new System.Drawing.Size(137, 14);
            this.lblNacimiento.TabIndex = 7;
            this.lblNacimiento.Text = "Fecha de Nacimiento";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(327, 380);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(39, 14);
            this.lblEdad.TabIndex = 8;
            this.lblEdad.Text = "Edad";
            // 
            // lblEstadoCivil
            // 
            this.lblEstadoCivil.AutoSize = true;
            this.lblEstadoCivil.Location = new System.Drawing.Point(605, 107);
            this.lblEstadoCivil.Name = "lblEstadoCivil";
            this.lblEstadoCivil.Size = new System.Drawing.Size(80, 14);
            this.lblEstadoCivil.TabIndex = 9;
            this.lblEstadoCivil.Text = "Estado Civil";
            // 
            // rbtnSoltero
            // 
            this.rbtnSoltero.AutoSize = true;
            this.rbtnSoltero.Location = new System.Drawing.Point(608, 136);
            this.rbtnSoltero.Name = "rbtnSoltero";
            this.rbtnSoltero.Size = new System.Drawing.Size(88, 18);
            this.rbtnSoltero.TabIndex = 6;
            this.rbtnSoltero.TabStop = true;
            this.rbtnSoltero.Text = "Soltera(o)";
            this.rbtnSoltero.UseVisualStyleBackColor = true;
            // 
            // rbtnCasado
            // 
            this.rbtnCasado.AutoSize = true;
            this.rbtnCasado.Location = new System.Drawing.Point(608, 160);
            this.rbtnCasado.Name = "rbtnCasado";
            this.rbtnCasado.Size = new System.Drawing.Size(91, 18);
            this.rbtnCasado.TabIndex = 7;
            this.rbtnCasado.TabStop = true;
            this.rbtnCasado.Text = "Casada(o)";
            this.rbtnCasado.UseVisualStyleBackColor = true;
            // 
            // rbtnViudo
            // 
            this.rbtnViudo.AutoSize = true;
            this.rbtnViudo.Location = new System.Drawing.Point(608, 184);
            this.rbtnViudo.Name = "rbtnViudo";
            this.rbtnViudo.Size = new System.Drawing.Size(78, 18);
            this.rbtnViudo.TabIndex = 8;
            this.rbtnViudo.TabStop = true;
            this.rbtnViudo.Text = "Viuda(o)";
            this.rbtnViudo.UseVisualStyleBackColor = true;
            // 
            // rbtnDivorciado
            // 
            this.rbtnDivorciado.AutoSize = true;
            this.rbtnDivorciado.Location = new System.Drawing.Point(608, 208);
            this.rbtnDivorciado.Name = "rbtnDivorciado";
            this.rbtnDivorciado.Size = new System.Drawing.Size(108, 18);
            this.rbtnDivorciado.TabIndex = 9;
            this.rbtnDivorciado.TabStop = true;
            this.rbtnDivorciado.Text = "Divorciada(o)";
            this.rbtnDivorciado.UseVisualStyleBackColor = true;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.White;
            this.txtNombre.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(253)))));
            this.txtNombre.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtNombre.Location = new System.Drawing.Point(33, 136);
            this.txtNombre.MaxLength = 100;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(203, 22);
            this.txtNombre.TabIndex = 1;
            // 
            // txtPaterno
            // 
            this.txtPaterno.BackColor = System.Drawing.Color.White;
            this.txtPaterno.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(253)))));
            this.txtPaterno.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtPaterno.Location = new System.Drawing.Point(33, 230);
            this.txtPaterno.MaxLength = 100;
            this.txtPaterno.Name = "txtPaterno";
            this.txtPaterno.Size = new System.Drawing.Size(203, 22);
            this.txtPaterno.TabIndex = 3;
            // 
            // txtMaterno
            // 
            this.txtMaterno.BackColor = System.Drawing.Color.White;
            this.txtMaterno.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(253)))));
            this.txtMaterno.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtMaterno.Location = new System.Drawing.Point(330, 230);
            this.txtMaterno.MaxLength = 100;
            this.txtMaterno.Name = "txtMaterno";
            this.txtMaterno.Size = new System.Drawing.Size(203, 22);
            this.txtMaterno.TabIndex = 4;
            // 
            // txtDireccion
            // 
            this.txtDireccion.BackColor = System.Drawing.Color.White;
            this.txtDireccion.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(253)))));
            this.txtDireccion.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtDireccion.Location = new System.Drawing.Point(33, 319);
            this.txtDireccion.MaxLength = 200;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(500, 22);
            this.txtDireccion.TabIndex = 5;
            // 
            // txtDni
            // 
            this.txtDni.BackColor = System.Drawing.Color.White;
            this.txtDni.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(253)))));
            this.txtDni.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtDni.Location = new System.Drawing.Point(330, 136);
            this.txtDni.MaxLength = 8;
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(106, 22);
            this.txtDni.TabIndex = 2;
            // 
            // lblEdadCalc
            // 
            this.lblEdadCalc.Enabled = false;
            this.lblEdadCalc.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdadCalc.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblEdadCalc.Location = new System.Drawing.Point(327, 406);
            this.lblEdadCalc.Name = "lblEdadCalc";
            this.lblEdadCalc.Size = new System.Drawing.Size(206, 25);
            this.lblEdadCalc.TabIndex = 19;
            this.lblEdadCalc.Text = "Edad";
            this.lblEdadCalc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpNacimiento
            // 
            this.dtpNacimiento.CalendarMonthBackground = System.Drawing.Color.White;
            this.dtpNacimiento.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(253)))));
            this.dtpNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNacimiento.Location = new System.Drawing.Point(33, 409);
            this.dtpNacimiento.Name = "dtpNacimiento";
            this.dtpNacimiento.Size = new System.Drawing.Size(203, 22);
            this.dtpNacimiento.TabIndex = 10;
            this.dtpNacimiento.ValueChanged += new System.EventHandler(this.dtpNacimiento_ValueChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(194)))), ((int)(((byte)(133)))));
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(194)))), ((int)(((byte)(133)))));
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregar.BorderRadius = 5;
            this.btnAgregar.ButtonText = "AGREGAR";
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.DisabledColor = System.Drawing.Color.Gray;
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnAgregar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAgregar.Iconimage = null;
            this.btnAgregar.Iconimage_right = null;
            this.btnAgregar.Iconimage_right_Selected = null;
            this.btnAgregar.Iconimage_Selected = null;
            this.btnAgregar.IconMarginLeft = 0;
            this.btnAgregar.IconMarginRight = 0;
            this.btnAgregar.IconRightVisible = true;
            this.btnAgregar.IconRightZoom = 0D;
            this.btnAgregar.IconVisible = true;
            this.btnAgregar.IconZoom = 90D;
            this.btnAgregar.IsTab = false;
            this.btnAgregar.Location = new System.Drawing.Point(586, 450);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(194)))), ((int)(((byte)(133)))));
            this.btnAgregar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(194)))), ((int)(((byte)(133)))));
            this.btnAgregar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAgregar.selected = false;
            this.btnAgregar.Size = new System.Drawing.Size(130, 40);
            this.btnAgregar.TabIndex = 11;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAgregar.Textcolor = System.Drawing.Color.White;
            this.btnAgregar.TextFont = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // FrmRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(770, 520);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dtpNacimiento);
            this.Controls.Add(this.lblEdadCalc);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtMaterno);
            this.Controls.Add(this.txtPaterno);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.rbtnDivorciado);
            this.Controls.Add(this.rbtnViudo);
            this.Controls.Add(this.rbtnCasado);
            this.Controls.Add(this.rbtnSoltero);
            this.Controls.Add(this.lblEstadoCivil);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.lblNacimiento);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblMaterno);
            this.Controls.Add(this.lblPaterno);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmRegistro";
            this.Text = "Registro";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblPaterno;
        private System.Windows.Forms.Label lblMaterno;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblNacimiento;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblEstadoCivil;
        private System.Windows.Forms.RadioButton rbtnSoltero;
        private System.Windows.Forms.RadioButton rbtnCasado;
        private System.Windows.Forms.RadioButton rbtnViudo;
        private System.Windows.Forms.RadioButton rbtnDivorciado;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtNombre;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtPaterno;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtMaterno;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtDireccion;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtDni;
        private System.Windows.Forms.Label lblEdadCalc;
        private System.Windows.Forms.DateTimePicker dtpNacimiento;
        private Bunifu.Framework.UI.BunifuFlatButton btnAgregar;
    }
}