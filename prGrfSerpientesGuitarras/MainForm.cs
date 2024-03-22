using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Media;
using System.IO;

namespace prGrfSerpientesGuitarras
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class frmVentanaInicio : Form
	{
		public frmVentanaInicio()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
	
		
		void BtnJugarClick(object sender, EventArgs e)
		{//Abre metodo para abrir frmJuego
			
			//crea nueva instancia para frmJuego
			frmJuego abrir = new frmJuego();
			
			//invoca el metodo Show() para abrir el frmJuego
			abrir.Show();
			
			//Invoca metodo para ocultar el frmVentanaInicio
			this.Hide();
			
		}//Fin metodo para abrir frmJuego
		
		
		
		void BtnSalirClick(object sender, EventArgs e)
		{//Abre metodo para salir
			
			//Invoca metodo Close()
			this.Close();
			
		}//Fin metodo para salir
		
	}
}
