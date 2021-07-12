
namespace WinFormLaboratorio.Forms
{
    partial class FormVehiculo
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
            this.panelForm = new System.Windows.Forms.Panel();
            this.dpFechaModelo = new System.Windows.Forms.DateTimePicker();
            this.txtDefectos = new System.Windows.Forms.RichTextBox();
            this.lbDefectos = new System.Windows.Forms.Label();
            this.chkTieneDefectos = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboMarcaVehiculo = new System.Windows.Forms.ComboBox();
            this.BtnGuardar = new FontAwesome.Sharp.IconButton();
            this.chkEstado = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtVehiculoId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnEliminar = new FontAwesome.Sharp.IconButton();
            this.BtnActualizar = new FontAwesome.Sharp.IconButton();
            this.BtnNuevo = new FontAwesome.Sharp.IconButton();
            this.GridViewVehiculo = new System.Windows.Forms.DataGridView();
            this.VehiculoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MarcaVehiculoDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Matricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaModelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Defectos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewVehiculo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelForm
            // 
            this.panelForm.Controls.Add(this.dpFechaModelo);
            this.panelForm.Controls.Add(this.txtDefectos);
            this.panelForm.Controls.Add(this.lbDefectos);
            this.panelForm.Controls.Add(this.chkTieneDefectos);
            this.panelForm.Controls.Add(this.label8);
            this.panelForm.Controls.Add(this.label7);
            this.panelForm.Controls.Add(this.txtModelo);
            this.panelForm.Controls.Add(this.label6);
            this.panelForm.Controls.Add(this.txtColor);
            this.panelForm.Controls.Add(this.label5);
            this.panelForm.Controls.Add(this.txtMatricula);
            this.panelForm.Controls.Add(this.label4);
            this.panelForm.Controls.Add(this.cboMarcaVehiculo);
            this.panelForm.Controls.Add(this.BtnGuardar);
            this.panelForm.Controls.Add(this.chkEstado);
            this.panelForm.Controls.Add(this.label3);
            this.panelForm.Controls.Add(this.label2);
            this.panelForm.Controls.Add(this.txtVehiculoId);
            this.panelForm.Controls.Add(this.label1);
            this.panelForm.Location = new System.Drawing.Point(1041, 0);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(598, 617);
            this.panelForm.TabIndex = 9;
            this.panelForm.Visible = false;
            // 
            // dpFechaModelo
            // 
            this.dpFechaModelo.Location = new System.Drawing.Point(167, 320);
            this.dpFechaModelo.Name = "dpFechaModelo";
            this.dpFechaModelo.Size = new System.Drawing.Size(268, 27);
            this.dpFechaModelo.TabIndex = 21;
            // 
            // txtDefectos
            // 
            this.txtDefectos.Location = new System.Drawing.Point(165, 416);
            this.txtDefectos.Name = "txtDefectos";
            this.txtDefectos.Size = new System.Drawing.Size(318, 62);
            this.txtDefectos.TabIndex = 20;
            this.txtDefectos.Text = "";
            this.txtDefectos.Visible = false;
            // 
            // lbDefectos
            // 
            this.lbDefectos.AutoSize = true;
            this.lbDefectos.Location = new System.Drawing.Point(42, 419);
            this.lbDefectos.Name = "lbDefectos";
            this.lbDefectos.Size = new System.Drawing.Size(71, 20);
            this.lbDefectos.TabIndex = 18;
            this.lbDefectos.Text = "Defectos:";
            this.lbDefectos.Visible = false;
            // 
            // chkTieneDefectos
            // 
            this.chkTieneDefectos.AutoSize = true;
            this.chkTieneDefectos.Location = new System.Drawing.Point(175, 371);
            this.chkTieneDefectos.Name = "chkTieneDefectos";
            this.chkTieneDefectos.Size = new System.Drawing.Size(18, 17);
            this.chkTieneDefectos.TabIndex = 17;
            this.chkTieneDefectos.UseVisualStyleBackColor = true;
            this.chkTieneDefectos.CheckedChanged += new System.EventHandler(this.chkTieneDefectos_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 368);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Tiene Defectos?";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 320);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Fecha Modelo :";
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(167, 269);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(268, 27);
            this.txtModelo.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 272);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Modelo :";
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(167, 220);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(268, 27);
            this.txtColor.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Color :";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(167, 172);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(268, 27);
            this.txtMatricula.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Matricula :";
            // 
            // cboMarcaVehiculo
            // 
            this.cboMarcaVehiculo.FormattingEnabled = true;
            this.cboMarcaVehiculo.Location = new System.Drawing.Point(167, 116);
            this.cboMarcaVehiculo.Name = "cboMarcaVehiculo";
            this.cboMarcaVehiculo.Size = new System.Drawing.Size(269, 28);
            this.cboMarcaVehiculo.TabIndex = 7;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(47)))), ((int)(((byte)(64)))));
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnGuardar.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.BtnGuardar.IconColor = System.Drawing.Color.White;
            this.BtnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnGuardar.IconSize = 30;
            this.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGuardar.Location = new System.Drawing.Point(250, 552);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(111, 38);
            this.BtnGuardar.TabIndex = 6;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // chkEstado
            // 
            this.chkEstado.AutoSize = true;
            this.chkEstado.Checked = true;
            this.chkEstado.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEstado.Location = new System.Drawing.Point(175, 502);
            this.chkEstado.Name = "chkEstado";
            this.chkEstado.Size = new System.Drawing.Size(18, 17);
            this.chkEstado.TabIndex = 5;
            this.chkEstado.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 499);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Estado :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Marca Vehiculo :";
            // 
            // txtVehiculoId
            // 
            this.txtVehiculoId.Location = new System.Drawing.Point(296, 32);
            this.txtVehiculoId.Name = "txtVehiculoId";
            this.txtVehiculoId.Size = new System.Drawing.Size(125, 27);
            this.txtVehiculoId.TabIndex = 1;
            this.txtVehiculoId.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(47)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(18, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Formulario";
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(47)))), ((int)(((byte)(64)))));
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnEliminar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.BtnEliminar.IconColor = System.Drawing.Color.White;
            this.BtnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnEliminar.IconSize = 30;
            this.BtnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEliminar.Location = new System.Drawing.Point(236, 579);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(106, 38);
            this.BtnEliminar.TabIndex = 8;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(47)))), ((int)(((byte)(64)))));
            this.BtnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnActualizar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnActualizar.IconChar = FontAwesome.Sharp.IconChar.PencilAlt;
            this.BtnActualizar.IconColor = System.Drawing.Color.White;
            this.BtnActualizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnActualizar.IconSize = 30;
            this.BtnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnActualizar.Location = new System.Drawing.Point(124, 579);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(106, 38);
            this.BtnActualizar.TabIndex = 7;
            this.BtnActualizar.Text = "Editar";
            this.BtnActualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnActualizar.UseVisualStyleBackColor = false;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(47)))), ((int)(((byte)(64)))));
            this.BtnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNuevo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnNuevo.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.BtnNuevo.IconColor = System.Drawing.Color.White;
            this.BtnNuevo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnNuevo.IconSize = 30;
            this.BtnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnNuevo.Location = new System.Drawing.Point(12, 579);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(106, 38);
            this.BtnNuevo.TabIndex = 6;
            this.BtnNuevo.Text = "Nuevo";
            this.BtnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnNuevo.UseVisualStyleBackColor = false;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // GridViewVehiculo
            // 
            this.GridViewVehiculo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewVehiculo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VehiculoId,
            this.MarcaVehiculoDescripcion,
            this.Matricula,
            this.Color,
            this.Modelo,
            this.FechaModelo,
            this.Estado,
            this.Defectos});
            this.GridViewVehiculo.Location = new System.Drawing.Point(-18, 0);
            this.GridViewVehiculo.Name = "GridViewVehiculo";
            this.GridViewVehiculo.ReadOnly = true;
            this.GridViewVehiculo.RowHeadersWidth = 51;
            this.GridViewVehiculo.RowTemplate.Height = 29;
            this.GridViewVehiculo.Size = new System.Drawing.Size(1053, 550);
            this.GridViewVehiculo.TabIndex = 5;
            // 
            // VehiculoId
            // 
            this.VehiculoId.DataPropertyName = "VehiculoId";
            this.VehiculoId.HeaderText = "Id";
            this.VehiculoId.MinimumWidth = 6;
            this.VehiculoId.Name = "VehiculoId";
            this.VehiculoId.ReadOnly = true;
            this.VehiculoId.Width = 125;
            // 
            // MarcaVehiculoDescripcion
            // 
            this.MarcaVehiculoDescripcion.DataPropertyName = "MarcaVehiculoDescripcionColum";
            this.MarcaVehiculoDescripcion.HeaderText = "Marca Vehiculo";
            this.MarcaVehiculoDescripcion.MinimumWidth = 6;
            this.MarcaVehiculoDescripcion.Name = "MarcaVehiculoDescripcion";
            this.MarcaVehiculoDescripcion.ReadOnly = true;
            this.MarcaVehiculoDescripcion.Width = 125;
            // 
            // Matricula
            // 
            this.Matricula.DataPropertyName = "Matricula";
            this.Matricula.HeaderText = "Matricula";
            this.Matricula.MinimumWidth = 6;
            this.Matricula.Name = "Matricula";
            this.Matricula.ReadOnly = true;
            this.Matricula.Width = 125;
            // 
            // Color
            // 
            this.Color.DataPropertyName = "Color";
            this.Color.HeaderText = "Color";
            this.Color.MinimumWidth = 6;
            this.Color.Name = "Color";
            this.Color.ReadOnly = true;
            this.Color.Width = 125;
            // 
            // Modelo
            // 
            this.Modelo.DataPropertyName = "Modelo";
            this.Modelo.HeaderText = "Modelo";
            this.Modelo.MinimumWidth = 6;
            this.Modelo.Name = "Modelo";
            this.Modelo.ReadOnly = true;
            this.Modelo.Width = 125;
            // 
            // FechaModelo
            // 
            this.FechaModelo.DataPropertyName = "FechaModelo";
            this.FechaModelo.HeaderText = "FechaModelo";
            this.FechaModelo.MinimumWidth = 6;
            this.FechaModelo.Name = "FechaModelo";
            this.FechaModelo.ReadOnly = true;
            this.FechaModelo.Width = 125;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "Estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.MinimumWidth = 6;
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Width = 125;
            // 
            // Defectos
            // 
            this.Defectos.DataPropertyName = "Defectos";
            this.Defectos.HeaderText = "Defectos";
            this.Defectos.MinimumWidth = 6;
            this.Defectos.Name = "Defectos";
            this.Defectos.ReadOnly = true;
            this.Defectos.Width = 125;
            // 
            // FormVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1661, 665);
            this.Controls.Add(this.panelForm);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnActualizar);
            this.Controls.Add(this.BtnNuevo);
            this.Controls.Add(this.GridViewVehiculo);
            this.Name = "FormVehiculo";
            this.Text = "Vehiculo";
            this.Load += new System.EventHandler(this.FormVehiculo_Load);
            this.panelForm.ResumeLayout(false);
            this.panelForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewVehiculo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelForm;
        private FontAwesome.Sharp.IconButton BtnGuardar;
        private System.Windows.Forms.CheckBox chkEstado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtVehiculoId;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton BtnEliminar;
        private FontAwesome.Sharp.IconButton BtnActualizar;
        private FontAwesome.Sharp.IconButton BtnNuevo;
        private System.Windows.Forms.DataGridView GridViewVehiculo;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboMarcaVehiculo;
        private System.Windows.Forms.RichTextBox txtDefectos;
        private System.Windows.Forms.Label lbDefectos;
        private System.Windows.Forms.CheckBox chkTieneDefectos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dpFechaModelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn VehiculoId;
        private System.Windows.Forms.DataGridViewTextBoxColumn MarcaVehiculoDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Matricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Color;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaModelo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Defectos;
    }
}