using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace prGrfSerpientesGuitarras
{
	/// <summary>
	/// Description of frmJuego.
	/// </summary>
	public partial class frmJuego : Form
	{
		public frmJuego()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			
			//string para la imagen de la ficha1
			string sFicha1 = System.IO.Directory.GetCurrentDirectory() + "\\images\\Ficha1.png";
			
			//carga la imagen a pctFicha1
			pctFicha1.Image = Image.FromFile(sFicha1);
			
			//string para la imagen de la ficha2
			string sFicha2 = System.IO.Directory.GetCurrentDirectory() + "\\images\\Ficha2.png";
			
			//carga la imagen a pctFicha2
			pctFicha2.Image = Image.FromFile(sFicha2);
			
			//string para la imagen de la ficha3
			string sFicha3 = System.IO.Directory.GetCurrentDirectory() + "\\images\\Ficha3.png";
			
			//carga la imagen a pctFicha3
			pctFicha3.Image = Image.FromFile(sFicha3);
		}//Fin Constructor frmVentanaInicio

	private	void Label1Click(object sender, EventArgs e)
		{
		
		//Invoca metodo para Lanzar Dado
	     LanzarDado();
		
		}
		
	
	public void LanzarDado()
	{//Abre metodo para Lanzar el dado
		
		    //Crea una nueva instancia en Random
		    Random aleatoreo = new Random();
	
			//genera un valor para el primer dado del 1 a 6
			int iValor = aleatoreo.Next (1,7);
		
			//muestra en la etiqueta lblDado1 el numero 
			lblDado.Text = Convert.ToString(iValor);
				
	}//Fin metodo para Lanzar Dado
	
		//declara variables para el movimiento en el tablero
		int iX = 0;
		int iY = 0;
		
		//declara la variable drag 
		bool bDrag = false;
	
		//Inician metodos de movimiento para FICHA1 
		void PctFicha1MouseDown(object sender, MouseEventArgs e)
		{
			iX = e.X;
			iY = e.Y;
			bDrag = true;
		}
		
		void PctFicha1MouseMove(object sender, MouseEventArgs e)
		{
			if(bDrag)
			{
				pctFicha1.Top += e.Y - iY;
				pctFicha1.Left += e.X - iX;
			}
		}
		
		void PctFicha1MouseUp(object sender, MouseEventArgs e)
		{
			bDrag = false;
		}
		
		//Fin de los metodos de movimiento de la FICHA1
		
		//Inician metodos de movimiento de la FICHA2
		void PctFicha2MouseDown(object sender, MouseEventArgs e)
		{
			iX = e.X;
			iY = e.Y;
			bDrag = true;
		}
		
		void PctFicha2MouseMove(object sender, MouseEventArgs e)
		{
			if(bDrag)
			{
				pctFicha2.Top += e.Y - iY;
				pctFicha2.Left += e.X - iX;
			}
		}
		
		void PctFicha2MouseUp(object sender, MouseEventArgs e)
		{
			bDrag = false;
		}
		
		//Inician metodos de movimiento de la FICHA2
		
		//Inician metodos de movimiento de la FICHA3
		void PctFicha3MouseDown(object sender, MouseEventArgs e)
		{
			iX = e.X;
			iY = e.Y;
			bDrag = true;
		}
		
		void PctFicha3MouseMove(object sender, MouseEventArgs e)
		{
			if(bDrag)
			{
				pctFicha3.Top += e.Y - iY;
				pctFicha3.Left += e.X - iX;
			}
		}
		
		void PctFicha3MouseUp(object sender, MouseEventArgs e)
		{
			bDrag = false;
		}
		
		//Inician metodos de movimiento de la FICHA3
		
		
		//Inician metodos para las casillas con guitarras
		
		void PctCasilla4MouseHover(object sender, EventArgs e)
		{//Abre metodo para Casilla4
			
			MessageBox.Show("SUBE A LA CASILLA 47","A Rockear una guitarra",MessageBoxButtons.OK);
			
		}//Fin metodo para Casilla4
		
		void PctCasilla21MouseHover(object sender, EventArgs e)
		{//Abre metodo para Casilla21
			
			MessageBox.Show("SUBE A LA CASILLA 29","A Rockear una guitarra",MessageBoxButtons.OK);
			
		}//Fin metodo para Casilla21
		
		void PctCasilla24MouseHover(object sender, EventArgs e)
		{//Abre metodo para Casilla24
			
			MessageBox.Show("SUBE A LA CASILLA 55","A Rockear una guitarra",MessageBoxButtons.OK);
			
		}//Fin metodo para Casilla24
		
		void PctCasilla28MouseHover(object sender, EventArgs e)
		{//Abre metodo para Casilla28
			
			MessageBox.Show("SUBE A LA CASILLA 91","A Rockear una guitarra",MessageBoxButtons.OK);
			
		}//Fin metodo para Casilla28
		
		void PctCasilla38MouseHover(object sender, EventArgs e)
		{//Abre metodo para Casilla38
			
			MessageBox.Show("SUBE A LA CASILLA 44","A Rockear una guitarra",MessageBoxButtons.OK);
			
		}//Fin metodo para Casilla38
		
		void PctCasilla40MouseHover(object sender, EventArgs e)
		{//Abre metodo para Casilla40
			
			MessageBox.Show("SUBE A LA CASILLA 69","A Rockear una guitarra",MessageBoxButtons.OK);
			
		}//Fin metodo para Casilla40
		
		void PctCasilla48MouseHover(object sender, EventArgs e)
		{//Abre metodo para Casilla48
			
			MessageBox.Show("SUBE A LA CASILLA 76","A Rockear una guitarra",MessageBoxButtons.OK);
			
		}//Fin metodo para Casilla48
		
		void PctCasilla56MouseHover(object sender, EventArgs e)
		{//Abre metodo para Casilla56
			
			MessageBox.Show("SUBE A LA CASILLA 87","A Rockear una guitarra",MessageBoxButtons.OK);
			
		}//Fin metodo para Casilla56
		
		void PctCasilla60MouseHover(object sender, EventArgs e)
		{//Abre metodo para Casilla60
			
			MessageBox.Show("SUBE A LA CASILLA 92","A Rockear una guitarra",MessageBoxButtons.OK);
			
		}//Fin metodo para Casilla60
		
	   //Fin metodos para las casillas con guitarras
	   
	   //Inicia métodos para serpientes
	   
	   void PctCasilla13MouseHover(object sender, System.EventArgs e)
		{//Abre metodo para Casilla13
	   
			MessageBox.Show("BAJA A LA CASILLA 7","Decibeles a bajo una serpiente",MessageBoxButtons.OK);
			
		}//Fin metodo Casilla13
		
		
		void PctCasilla52MouseHover(object sender, EventArgs e)
		{//Abre metodo para Casilla52
			
			MessageBox.Show("BAJA A LA CASILLA 18","Decibeles a bajo una serpiente",MessageBoxButtons.OK);
			
		}//Fin metodo para Casilla52
		
		void PctCasilla58MouseHover(object sender, EventArgs e)
		{//Abre metodo para Casilla58
			
			MessageBox.Show("BAJA A LA CASILLA 27","Decibeles a bajo una serpiente",MessageBoxButtons.OK);
			
		}//Fin metodo para Casilla58
		
		void PctCasilla68MouseHover(object sender, EventArgs e)
		{//Abre metodo para Casilla68
			
			MessageBox.Show("BAJA A LA CASILLA 43","Decibeles a bajo una serpiente",MessageBoxButtons.OK);
			
		}//Fin metodo para Casilla68
		
		void PctCasilla79MouseHover(object sender, EventArgs e)
		{//Abre metodo para Casila79
			
			MessageBox.Show("BAJA A LA CASILLA 63","Decibeles a bajo una serpiente",MessageBoxButtons.OK);
			
		}//Fin metodo para Casilla79
		
		void PctCasilla89MouseHover(object sender, EventArgs e)
		{//Abre metodo para Casilla89
			
			MessageBox.Show("BAJA A LA CASILLA 83","Decibeles a bajo una serpiente",MessageBoxButtons.OK);
			
		}//Fin metodo para Casilla89
		
		void PctCasilla96MouseHover(object sender, EventArgs e)
		{//Abre metodo para Casilla96
			
			MessageBox.Show("BAJA A LA CASILLA 64","Decibeles a bajo una serpiente",MessageBoxButtons.OK);
			
		}//Fin metodo para Casilla96
		
		void PctCasilla97MouseHover(object sender, EventArgs e)
		{//Abre metodo para Casilla97
			
			MessageBox.Show("BAJA A LA CASILLA 5","Decibeles a bajo una serpiente",MessageBoxButtons.OK);
			
		}//Fin metodo para Casilla97
		
		void PctCasilla98MouseHover(object sender, EventArgs e)
		{//Abre metodo para Casilla98
			
			MessageBox.Show("BAJA A LA CASILLA 71","Decibeles a bajo una serpiente",MessageBoxButtons.OK);
			
		}//Fin metodo para Casilla98
		
		//Fin de los metodos para las Serpientes
		
		
		
		void PctMetaMouseHover(object sender, EventArgs e)
		{//Abre metodo para Meta

			MessageBox.Show("FELICIDADES GANASTE","Buen concierto, los aplausos son tuyos",MessageBoxButtons.OK);
			
			//crea nueva instancia para frmVentanaInicio
			frmVentanaInicio salir = new frmVentanaInicio();
			
			//Invoca metod Show()
			salir.Show();
			
			//invoca metodo para salir
			this.Hide();
			
			
		}//Fin metodo para Meta
		
		
		}
	}

