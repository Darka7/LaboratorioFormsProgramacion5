
namespace WinFormLaboratorio
{
    partial class FormMarcaVehiculo
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
            this.GridViewMarcaVehiculo = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewMarcaVehiculo)).BeginInit();
            this.SuspendLayout();
            // 
            // GridViewMarcaVehiculo
            // 
            this.GridViewMarcaVehiculo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewMarcaVehiculo.Location = new System.Drawing.Point(35, 26);
            this.GridViewMarcaVehiculo.Name = "GridViewMarcaVehiculo";
            this.GridViewMarcaVehiculo.RowHeadersWidth = 51;
            this.GridViewMarcaVehiculo.RowTemplate.Height = 29;
            this.GridViewMarcaVehiculo.Size = new System.Drawing.Size(753, 412);
            this.GridViewMarcaVehiculo.TabIndex = 0;
            // 
            // FormMarcaVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GridViewMarcaVehiculo);
            this.Name = "FormMarcaVehiculo";
            this.Text = "FormMarcaVehiculo";
            this.Load += new System.EventHandler(this.FormMarcaVehiculo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewMarcaVehiculo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GridViewMarcaVehiculo;
    }
}