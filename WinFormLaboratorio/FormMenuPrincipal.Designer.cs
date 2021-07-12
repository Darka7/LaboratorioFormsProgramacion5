
namespace WinFormLaboratorio
{
    partial class FormMenuPrincipal
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
            this.panelMenuIzquierda = new System.Windows.Forms.Panel();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.MenuMarcaVehiculo = new FontAwesome.Sharp.IconButton();
            this.panelMenuLogo = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.panelMenuTop = new System.Windows.Forms.Panel();
            this.LbUsuario = new System.Windows.Forms.Label();
            this.MenuLabelPrincipal = new System.Windows.Forms.Label();
            this.panelMenuPrincipal = new System.Windows.Forms.Panel();
            this.panelMenuIzquierda.SuspendLayout();
            this.panelMenuLogo.SuspendLayout();
            this.panelMenuTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenuIzquierda
            // 
            this.panelMenuIzquierda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(55)))), ((int)(((byte)(75)))));
            this.panelMenuIzquierda.Controls.Add(this.iconButton2);
            this.panelMenuIzquierda.Controls.Add(this.MenuMarcaVehiculo);
            this.panelMenuIzquierda.Controls.Add(this.panelMenuLogo);
            this.panelMenuIzquierda.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenuIzquierda.Location = new System.Drawing.Point(0, 0);
            this.panelMenuIzquierda.Name = "panelMenuIzquierda";
            this.panelMenuIzquierda.Size = new System.Drawing.Size(190, 786);
            this.panelMenuIzquierda.TabIndex = 0;
            // 
            // iconButton2
            // 
            this.iconButton2.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.iconButton2.IconColor = System.Drawing.Color.LightSkyBlue;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 30;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.iconButton2.Location = new System.Drawing.Point(0, 152);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(190, 47);
            this.iconButton2.TabIndex = 2;
            this.iconButton2.Text = "Vehiculo";
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton2.UseVisualStyleBackColor = true;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // MenuMarcaVehiculo
            // 
            this.MenuMarcaVehiculo.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuMarcaVehiculo.FlatAppearance.BorderSize = 0;
            this.MenuMarcaVehiculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MenuMarcaVehiculo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MenuMarcaVehiculo.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.MenuMarcaVehiculo.IconColor = System.Drawing.Color.LightSkyBlue;
            this.MenuMarcaVehiculo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuMarcaVehiculo.IconSize = 30;
            this.MenuMarcaVehiculo.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.MenuMarcaVehiculo.Location = new System.Drawing.Point(0, 105);
            this.MenuMarcaVehiculo.Name = "MenuMarcaVehiculo";
            this.MenuMarcaVehiculo.Size = new System.Drawing.Size(190, 47);
            this.MenuMarcaVehiculo.TabIndex = 1;
            this.MenuMarcaVehiculo.Text = "Marca Vehiculo";
            this.MenuMarcaVehiculo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.MenuMarcaVehiculo.UseVisualStyleBackColor = true;
            this.MenuMarcaVehiculo.Click += new System.EventHandler(this.MenuMarcaVehiculo_Click);
            // 
            // panelMenuLogo
            // 
            this.panelMenuLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(47)))), ((int)(((byte)(64)))));
            this.panelMenuLogo.Controls.Add(this.iconButton1);
            this.panelMenuLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenuLogo.Location = new System.Drawing.Point(0, 0);
            this.panelMenuLogo.Name = "panelMenuLogo";
            this.panelMenuLogo.Size = new System.Drawing.Size(190, 105);
            this.panelMenuLogo.TabIndex = 0;
            // 
            // iconButton1
            // 
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iconButton1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Car;
            this.iconButton1.IconColor = System.Drawing.Color.LightSkyBlue;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(0, 21);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(187, 81);
            this.iconButton1.TabIndex = 0;
            this.iconButton1.Text = "Agencia";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // panelMenuTop
            // 
            this.panelMenuTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(55)))), ((int)(((byte)(75)))));
            this.panelMenuTop.Controls.Add(this.LbUsuario);
            this.panelMenuTop.Controls.Add(this.MenuLabelPrincipal);
            this.panelMenuTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenuTop.Location = new System.Drawing.Point(190, 0);
            this.panelMenuTop.Name = "panelMenuTop";
            this.panelMenuTop.Size = new System.Drawing.Size(1121, 105);
            this.panelMenuTop.TabIndex = 1;
            // 
            // LbUsuario
            // 
            this.LbUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LbUsuario.AutoSize = true;
            this.LbUsuario.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbUsuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LbUsuario.Location = new System.Drawing.Point(1021, 33);
            this.LbUsuario.Name = "LbUsuario";
            this.LbUsuario.Size = new System.Drawing.Size(100, 35);
            this.LbUsuario.TabIndex = 1;
            this.LbUsuario.Text = "Usuario";
            // 
            // MenuLabelPrincipal
            // 
            this.MenuLabelPrincipal.AutoSize = true;
            this.MenuLabelPrincipal.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MenuLabelPrincipal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MenuLabelPrincipal.Location = new System.Drawing.Point(28, 33);
            this.MenuLabelPrincipal.Name = "MenuLabelPrincipal";
            this.MenuLabelPrincipal.Size = new System.Drawing.Size(83, 35);
            this.MenuLabelPrincipal.TabIndex = 0;
            this.MenuLabelPrincipal.Text = "Home";
            // 
            // panelMenuPrincipal
            // 
            this.panelMenuPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.panelMenuPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMenuPrincipal.Location = new System.Drawing.Point(190, 105);
            this.panelMenuPrincipal.Name = "panelMenuPrincipal";
            this.panelMenuPrincipal.Size = new System.Drawing.Size(1121, 681);
            this.panelMenuPrincipal.TabIndex = 2;
            // 
            // FormMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1311, 786);
            this.Controls.Add(this.panelMenuPrincipal);
            this.Controls.Add(this.panelMenuTop);
            this.Controls.Add(this.panelMenuIzquierda);
            this.Name = "FormMenuPrincipal";
            this.ShowInTaskbar = false;
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMenuPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.FormMenuPrincipal_Load);
            this.panelMenuIzquierda.ResumeLayout(false);
            this.panelMenuLogo.ResumeLayout(false);
            this.panelMenuTop.ResumeLayout(false);
            this.panelMenuTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenuIzquierda;
        private FontAwesome.Sharp.IconButton MenuMarcaVehiculo;
        private System.Windows.Forms.Panel panelMenuLogo;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Panel panelMenuTop;
        private System.Windows.Forms.Panel panelMenuPrincipal;
        private System.Windows.Forms.Label MenuLabelPrincipal;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.Label LbUsuario;
    }
}