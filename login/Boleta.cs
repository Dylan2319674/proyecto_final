/*
 * Creado por SharpDevelop.
 * Usuario: CC1_PC44
 * Fecha: 10/12/2025
 * Hora: 02:21 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace login
{
	/// <summary>
	/// Description of Boleta.
	/// </summary>
	public partial class Boleta : Form
	{
		public Boleta()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtnRegresarClick(object sender, EventArgs e)
		{
			Principal FormularioPrincipal = new Principal();
			FormularioPrincipal.Show();
			this.Hide();
		
	}
		
		void BtnRegistrarClick(object sender, EventArgs e)
		{
			if(cmbSubmodulo.SelectedIndex == -1)
				MessageBox.Show("Deve selccionar un...!!");
			else if (cmbGrado.SelectedIndex == -1)
				MessageBox.Show("Deve ingresar un gardo...!!");
			else if (cmbEspecialidad.SelectedIndex == -1)
				MessageBox.Show("Deve seleccionar una especialidad...!!");
			
			else  
				
			{
				string asignatura = cmbSubmodulo.Text;
				double Parcial1 = Convert.ToInt32(TxtParcial1.Text);
				double Parcial2 = Convert.ToInt32(TxtParcial2.Text);
				double Parcial3 = Convert.ToInt32(TxtParcial3.Text);
				double  Promedio =(Parcial1+Parcial2+Parcial3 ) / 3;
				string paso;
				if(Promedio >=6 )
					paso = "Aprobado";
						
						else paso = "Reprobado";
				
				ListViewItem fila = new ListViewItem(asignatura);
				fila.SubItems.Add(Parcial1.ToString());
				fila.SubItems.Add(Parcial2.ToString());
				fila.SubItems.Add(Parcial3.ToString());
				fila.SubItems.Add(Promedio.ToString());
				fila.SubItems.Add(paso.ToString());
				lvTabla.Items.Add(fila);
			}

			double parcial1 = double.Parse(TxtParcial1.Text);
			double parcial2 = double.Parse(TxtParcial2.Text);
			double parcial3 = double.Parse(TxtParcial3.Text);
			
			double promedioFinal = (parcial1 + parcial2 + parcial3) / 3;
TxtPromedio.Text = promedioFinal.ToString("0.0");
		}
		
		void BtnCancelarClick(object sender, EventArgs e)
		{
			TxtParcial1.Clear();
			TxtParcial2.Clear();
			TxtParcial3.Clear();
			TxtPromedio.Clear();
			TxtNombreDelAlumno.Clear();
			cmbSubmodulo.SelectedIndex = -1;
			cmbGrado.SelectedIndex = -1;
			cmbEspecialidad.SelectedIndex = -1;
			TxtParcial1.Focus();
		}
		
		void BtnSalirClick(object sender, EventArgs e)
		{
			Close();
		}
}
}
