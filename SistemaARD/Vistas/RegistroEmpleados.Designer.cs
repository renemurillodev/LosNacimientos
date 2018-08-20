namespace SistemaARD.Vistas
{
    partial class RegistroEmpleados
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
            this.lblNombres = new System.Windows.Forms.Label();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.lblDui = new System.Windows.Forms.Label();
            this.lblNit = new System.Windows.Forms.Label();
            this.lblNombreAFP = new System.Windows.Forms.Label();
            this.lblNup = new System.Windows.Forms.Label();
            this.lblIsss = new System.Windows.Forms.Label();
            this.lblFechaIngreso = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.cbxGenero = new System.Windows.Forms.ComboBox();
            this.txtNumeroDui = new System.Windows.Forms.MaskedTextBox();
            this.txtNumeroNit = new System.Windows.Forms.MaskedTextBox();
            this.cbxNombreAfp = new System.Windows.Forms.ComboBox();
            this.txtNup = new System.Windows.Forms.MaskedTextBox();
            this.txtNumeroIsss = new System.Windows.Forms.MaskedTextBox();
            this.dtpFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.cbxEstado = new System.Windows.Forms.ComboBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNombres
            // 
            this.lblNombres.AutoSize = true;
            this.lblNombres.Location = new System.Drawing.Point(13, 13);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(49, 13);
            this.lblNombres.TabIndex = 0;
            this.lblNombres.Text = "Nombres";
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Location = new System.Drawing.Point(16, 52);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(49, 13);
            this.lblApellidos.TabIndex = 1;
            this.lblApellidos.Text = "Apellidos";
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(146, 93);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaNacimiento.TabIndex = 2;
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(16, 93);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(106, 13);
            this.lblFechaNacimiento.TabIndex = 3;
            this.lblFechaNacimiento.Text = "Fecha de nacimiento";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(16, 141);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(52, 13);
            this.lblDireccion.TabIndex = 4;
            this.lblDireccion.Text = "Dirección";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Location = new System.Drawing.Point(16, 193);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(42, 13);
            this.lblGenero.TabIndex = 5;
            this.lblGenero.Text = "Género";
            // 
            // lblDui
            // 
            this.lblDui.AutoSize = true;
            this.lblDui.Location = new System.Drawing.Point(16, 238);
            this.lblDui.Name = "lblDui";
            this.lblDui.Size = new System.Drawing.Size(81, 13);
            this.lblDui.TabIndex = 6;
            this.lblDui.Text = "Número de DUI";
            // 
            // lblNit
            // 
            this.lblNit.AutoSize = true;
            this.lblNit.Location = new System.Drawing.Point(17, 278);
            this.lblNit.Name = "lblNit";
            this.lblNit.Size = new System.Drawing.Size(80, 13);
            this.lblNit.TabIndex = 6;
            this.lblNit.Text = "Número de NIT";
            // 
            // lblNombreAFP
            // 
            this.lblNombreAFP.AutoSize = true;
            this.lblNombreAFP.Location = new System.Drawing.Point(20, 321);
            this.lblNombreAFP.Name = "lblNombreAFP";
            this.lblNombreAFP.Size = new System.Drawing.Size(82, 13);
            this.lblNombreAFP.TabIndex = 7;
            this.lblNombreAFP.Text = "Nombre de AFP";
            // 
            // lblNup
            // 
            this.lblNup.AutoSize = true;
            this.lblNup.Location = new System.Drawing.Point(20, 355);
            this.lblNup.Name = "lblNup";
            this.lblNup.Size = new System.Drawing.Size(30, 13);
            this.lblNup.TabIndex = 8;
            this.lblNup.Text = "NUP";
            // 
            // lblIsss
            // 
            this.lblIsss.AutoSize = true;
            this.lblIsss.Location = new System.Drawing.Point(23, 392);
            this.lblIsss.Name = "lblIsss";
            this.lblIsss.Size = new System.Drawing.Size(31, 13);
            this.lblIsss.TabIndex = 9;
            this.lblIsss.Text = "ISSS";
            // 
            // lblFechaIngreso
            // 
            this.lblFechaIngreso.AutoSize = true;
            this.lblFechaIngreso.Location = new System.Drawing.Point(26, 425);
            this.lblFechaIngreso.Name = "lblFechaIngreso";
            this.lblFechaIngreso.Size = new System.Drawing.Size(89, 13);
            this.lblFechaIngreso.TabIndex = 10;
            this.lblFechaIngreso.Text = "Fecha de ingreso";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(23, 460);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(40, 13);
            this.lblEstado.TabIndex = 11;
            this.lblEstado.Text = "Estado";
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(146, 6);
            this.txtNombres.Multiline = true;
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(233, 20);
            this.txtNombres.TabIndex = 12;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(146, 45);
            this.txtApellidos.Multiline = true;
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(233, 20);
            this.txtApellidos.TabIndex = 12;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(146, 134);
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(233, 20);
            this.txtDireccion.TabIndex = 12;
            // 
            // cbxGenero
            // 
            this.cbxGenero.FormattingEnabled = true;
            this.cbxGenero.Items.AddRange(new object[] {
            "Femenino",
            "Masculino",
            "Otro"});
            this.cbxGenero.Location = new System.Drawing.Point(146, 184);
            this.cbxGenero.Name = "cbxGenero";
            this.cbxGenero.Size = new System.Drawing.Size(121, 21);
            this.cbxGenero.TabIndex = 13;
            // 
            // txtNumeroDui
            // 
            this.txtNumeroDui.Location = new System.Drawing.Point(146, 238);
            this.txtNumeroDui.Mask = "00000000-0";
            this.txtNumeroDui.Name = "txtNumeroDui";
            this.txtNumeroDui.Size = new System.Drawing.Size(121, 20);
            this.txtNumeroDui.TabIndex = 14;
            // 
            // txtNumeroNit
            // 
            this.txtNumeroNit.Location = new System.Drawing.Point(146, 275);
            this.txtNumeroNit.Mask = "0000-000000-000-0";
            this.txtNumeroNit.Name = "txtNumeroNit";
            this.txtNumeroNit.Size = new System.Drawing.Size(121, 20);
            this.txtNumeroNit.TabIndex = 14;
            // 
            // cbxNombreAfp
            // 
            this.cbxNombreAfp.FormattingEnabled = true;
            this.cbxNombreAfp.Items.AddRange(new object[] {
            "Confía",
            "Crecer"});
            this.cbxNombreAfp.Location = new System.Drawing.Point(146, 312);
            this.cbxNombreAfp.Name = "cbxNombreAfp";
            this.cbxNombreAfp.Size = new System.Drawing.Size(121, 21);
            this.cbxNombreAfp.TabIndex = 15;
            // 
            // txtNup
            // 
            this.txtNup.Location = new System.Drawing.Point(146, 352);
            this.txtNup.Mask = "000000000000";
            this.txtNup.Name = "txtNup";
            this.txtNup.Size = new System.Drawing.Size(121, 20);
            this.txtNup.TabIndex = 14;
            // 
            // txtNumeroIsss
            // 
            this.txtNumeroIsss.Location = new System.Drawing.Point(146, 385);
            this.txtNumeroIsss.Mask = "000000000";
            this.txtNumeroIsss.Name = "txtNumeroIsss";
            this.txtNumeroIsss.Size = new System.Drawing.Size(121, 20);
            this.txtNumeroIsss.TabIndex = 14;
            // 
            // dtpFechaIngreso
            // 
            this.dtpFechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaIngreso.Location = new System.Drawing.Point(146, 425);
            this.dtpFechaIngreso.Name = "dtpFechaIngreso";
            this.dtpFechaIngreso.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaIngreso.TabIndex = 16;
            // 
            // cbxEstado
            // 
            this.cbxEstado.FormattingEnabled = true;
            this.cbxEstado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cbxEstado.Location = new System.Drawing.Point(146, 460);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(121, 21);
            this.cbxEstado.TabIndex = 17;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(318, 460);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 18;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // RegistroEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 493);
            this.ControlBox = false;
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.cbxEstado);
            this.Controls.Add(this.dtpFechaIngreso);
            this.Controls.Add(this.cbxNombreAfp);
            this.Controls.Add(this.txtNumeroIsss);
            this.Controls.Add(this.txtNup);
            this.Controls.Add(this.txtNumeroNit);
            this.Controls.Add(this.txtNumeroDui);
            this.Controls.Add(this.cbxGenero);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblFechaIngreso);
            this.Controls.Add(this.lblIsss);
            this.Controls.Add(this.lblNup);
            this.Controls.Add(this.lblNombreAFP);
            this.Controls.Add(this.lblNit);
            this.Controls.Add(this.lblDui);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblFechaNacimiento);
            this.Controls.Add(this.dtpFechaNacimiento);
            this.Controls.Add(this.lblApellidos);
            this.Controls.Add(this.lblNombres);
            this.Name = "RegistroEmpleados";
            this.Text = "Registro de empleados";
            this.Load += new System.EventHandler(this.RegistroEmpleados_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Label lblDui;
        private System.Windows.Forms.Label lblNit;
        private System.Windows.Forms.Label lblNombreAFP;
        private System.Windows.Forms.Label lblNup;
        private System.Windows.Forms.Label lblIsss;
        private System.Windows.Forms.Label lblFechaIngreso;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.ComboBox cbxGenero;
        private System.Windows.Forms.MaskedTextBox txtNumeroDui;
        private System.Windows.Forms.MaskedTextBox txtNumeroNit;
        private System.Windows.Forms.ComboBox cbxNombreAfp;
        private System.Windows.Forms.MaskedTextBox txtNup;
        private System.Windows.Forms.MaskedTextBox txtNumeroIsss;
        private System.Windows.Forms.DateTimePicker dtpFechaIngreso;
        private System.Windows.Forms.ComboBox cbxEstado;
        private System.Windows.Forms.Button btnRegistrar;
    }
}