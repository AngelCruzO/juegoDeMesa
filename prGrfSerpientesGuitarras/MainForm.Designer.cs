/*
 * Creado por SharpDevelop.
 * Usuario: Ing de Software
 * Fecha: 14/05/2016
 * Hora: 09:32 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace prGrfSerpientesGuitarras
{
	partial class frmVentanaInicio
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVentanaInicio));
			this.btnJugar = new System.Windows.Forms.Button();
			this.btnSalir = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnJugar
			// 
			this.btnJugar.BackColor = System.Drawing.Color.Transparent;
			this.btnJugar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnJugar.BackgroundImage")));
			this.btnJugar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnJugar.Location = new System.Drawing.Point(685, 373);
			this.btnJugar.Name = "btnJugar";
			this.btnJugar.Size = new System.Drawing.Size(206, 61);
			this.btnJugar.TabIndex = 0;
			this.btnJugar.UseVisualStyleBackColor = false;
			this.btnJugar.Click += new System.EventHandler(this.BtnJugarClick);
			// 
			// btnSalir
			// 
			this.btnSalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalir.BackgroundImage")));
			this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnSalir.Location = new System.Drawing.Point(685, 496);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(206, 59);
			this.btnSalir.TabIndex = 2;
			this.btnSalir.UseVisualStyleBackColor = true;
			this.btnSalir.Click += new System.EventHandler(this.BtnSalirClick);
			// 
			// frmVentanaInicio
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(916, 608);
			this.Controls.Add(this.btnSalir);
			this.Controls.Add(this.btnJugar);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmVentanaInicio";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Serpientes y Guitarras";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button btnSalir;
		private System.Windows.Forms.Button btnJugar;
	}
}
