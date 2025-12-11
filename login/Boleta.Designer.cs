/*
 * Creado por SharpDevelop.
 * Usuario: CC1_PC44
 * Fecha: 10/12/2025
 * Hora: 02:21 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace login
{
	partial class Boleta
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>

		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnRegresar = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.TxtNombreDelAlumno = new System.Windows.Forms.TextBox();
			this.cmbGrado = new System.Windows.Forms.ComboBox();
			this.cmbEspecialidad = new System.Windows.Forms.ComboBox();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.cmbSubmodulo = new System.Windows.Forms.ComboBox();
			this.BtnRegistrar = new System.Windows.Forms.Button();
			this.BtnCancelar = new System.Windows.Forms.Button();
			this.BtnSalir = new System.Windows.Forms.Button();
			this.LblParcial1 = new System.Windows.Forms.Label();
			this.Parcial2 = new System.Windows.Forms.Label();
			this.LblParcial3 = new System.Windows.Forms.Label();
			this.TxtParcial1 = new System.Windows.Forms.TextBox();
			this.TxtParcial2 = new System.Windows.Forms.TextBox();
			this.TxtParcial3 = new System.Windows.Forms.TextBox();
			this.lvTabla = new System.Windows.Forms.ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
			this.LblPromedio = new System.Windows.Forms.Label();
			this.TxtPromedio = new System.Windows.Forms.TextBox();
			this.LblNombreAlumno = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.LblAdignatura = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnRegresar
			// 
			this.btnRegresar.Location = new System.Drawing.Point(823, 239);
			this.btnRegresar.Margin = new System.Windows.Forms.Padding(4);
			this.btnRegresar.Name = "btnRegresar";
			this.btnRegresar.Size = new System.Drawing.Size(100, 28);
			this.btnRegresar.TabIndex = 0;
			this.btnRegresar.Text = "Regresar";
			this.btnRegresar.UseVisualStyleBackColor = true;
			this.btnRegresar.Click += new System.EventHandler(this.BtnRegresarClick);
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(40, 249);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 5;
			this.label5.Text = "Fecha Actual";
			// 
			// TxtNombreDelAlumno
			// 
			this.TxtNombreDelAlumno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.TxtNombreDelAlumno.Location = new System.Drawing.Point(276, 34);
			this.TxtNombreDelAlumno.Name = "TxtNombreDelAlumno";
			this.TxtNombreDelAlumno.Size = new System.Drawing.Size(316, 22);
			this.TxtNombreDelAlumno.TabIndex = 6;
			// 
			// cmbGrado
			// 
			this.cmbGrado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.cmbGrado.FormattingEnabled = true;
			this.cmbGrado.Items.AddRange(new object[] {
									"1",
									"2",
									"3"});
			this.cmbGrado.Location = new System.Drawing.Point(276, 82);
			this.cmbGrado.Name = "cmbGrado";
			this.cmbGrado.Size = new System.Drawing.Size(85, 24);
			this.cmbGrado.TabIndex = 7;
			// 
			// cmbEspecialidad
			// 
			this.cmbEspecialidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.cmbEspecialidad.FormattingEnabled = true;
			this.cmbEspecialidad.Items.AddRange(new object[] {
									"Proogramacion ",
									"Soporte",
									"Alimentos",
									"Mecanica",
									"Siberseguridad",
									"Mecanica"});
			this.cmbEspecialidad.Location = new System.Drawing.Point(276, 134);
			this.cmbEspecialidad.Name = "cmbEspecialidad";
			this.cmbEspecialidad.Size = new System.Drawing.Size(316, 24);
			this.cmbEspecialidad.TabIndex = 8;
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(276, 250);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(105, 22);
			this.dateTimePicker1.TabIndex = 10;
			// 
			// cmbSubmodulo
			// 
			this.cmbSubmodulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.cmbSubmodulo.FormattingEnabled = true;
			this.cmbSubmodulo.Items.AddRange(new object[] {
									"Emplea Software",
									"Ingles ",
									"Lengua y comunicacion",
									"Ecositemas y  sus interacciones ",
									"Humanidades ",
									"Educacion Socioemocional"});
			this.cmbSubmodulo.Location = new System.Drawing.Point(276, 184);
			this.cmbSubmodulo.Name = "cmbSubmodulo";
			this.cmbSubmodulo.Size = new System.Drawing.Size(316, 24);
			this.cmbSubmodulo.TabIndex = 11;
			// 
			// BtnRegistrar
			// 
			this.BtnRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
			this.BtnRegistrar.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnRegistrar.Location = new System.Drawing.Point(414, 241);
			this.BtnRegistrar.Name = "BtnRegistrar";
			this.BtnRegistrar.Size = new System.Drawing.Size(87, 31);
			this.BtnRegistrar.TabIndex = 12;
			this.BtnRegistrar.Text = "Registrar ";
			this.BtnRegistrar.UseVisualStyleBackColor = false;
			this.BtnRegistrar.Click += new System.EventHandler(this.BtnRegistrarClick);
			// 
			// BtnCancelar
			// 
			this.BtnCancelar.BackColor = System.Drawing.Color.Yellow;
			this.BtnCancelar.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnCancelar.Location = new System.Drawing.Point(536, 239);
			this.BtnCancelar.Name = "BtnCancelar";
			this.BtnCancelar.Size = new System.Drawing.Size(86, 33);
			this.BtnCancelar.TabIndex = 13;
			this.BtnCancelar.Text = "Cancelar";
			this.BtnCancelar.UseVisualStyleBackColor = false;
			this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelarClick);
			// 
			// BtnSalir
			// 
			this.BtnSalir.BackColor = System.Drawing.Color.Red;
			this.BtnSalir.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnSalir.Location = new System.Drawing.Point(662, 242);
			this.BtnSalir.Name = "BtnSalir";
			this.BtnSalir.Size = new System.Drawing.Size(75, 33);
			this.BtnSalir.TabIndex = 22;
			this.BtnSalir.Text = "Salir";
			this.BtnSalir.UseVisualStyleBackColor = false;
			this.BtnSalir.Click += new System.EventHandler(this.BtnSalirClick);
			// 
			// LblParcial1
			// 
			this.LblParcial1.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblParcial1.Location = new System.Drawing.Point(662, 35);
			this.LblParcial1.Name = "LblParcial1";
			this.LblParcial1.Size = new System.Drawing.Size(100, 23);
			this.LblParcial1.TabIndex = 23;
			this.LblParcial1.Text = "Parcial1";
			// 
			// Parcial2
			// 
			this.Parcial2.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Parcial2.Location = new System.Drawing.Point(768, 35);
			this.Parcial2.Name = "Parcial2";
			this.Parcial2.Size = new System.Drawing.Size(100, 23);
			this.Parcial2.TabIndex = 24;
			this.Parcial2.Text = "Parcial2";
			// 
			// LblParcial3
			// 
			this.LblParcial3.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblParcial3.Location = new System.Drawing.Point(862, 35);
			this.LblParcial3.Name = "LblParcial3";
			this.LblParcial3.Size = new System.Drawing.Size(100, 23);
			this.LblParcial3.TabIndex = 25;
			this.LblParcial3.Text = "Parcial3";
			// 
			// TxtParcial1
			// 
			this.TxtParcial1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.TxtParcial1.Location = new System.Drawing.Point(662, 86);
			this.TxtParcial1.Name = "TxtParcial1";
			this.TxtParcial1.Size = new System.Drawing.Size(57, 22);
			this.TxtParcial1.TabIndex = 26;
			// 
			// TxtParcial2
			// 
			this.TxtParcial2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.TxtParcial2.Location = new System.Drawing.Point(768, 86);
			this.TxtParcial2.Name = "TxtParcial2";
			this.TxtParcial2.Size = new System.Drawing.Size(61, 22);
			this.TxtParcial2.TabIndex = 27;
			// 
			// TxtParcial3
			// 
			this.TxtParcial3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.TxtParcial3.Location = new System.Drawing.Point(862, 86);
			this.TxtParcial3.Name = "TxtParcial3";
			this.TxtParcial3.Size = new System.Drawing.Size(61, 22);
			this.TxtParcial3.TabIndex = 28;
			// 
			// lvTabla
			// 
			this.lvTabla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.lvTabla.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
									this.columnHeader1,
									this.columnHeader2,
									this.columnHeader3,
									this.columnHeader4,
									this.columnHeader5,
									this.columnHeader6});
			this.lvTabla.Location = new System.Drawing.Point(40, 386);
			this.lvTabla.Name = "lvTabla";
			this.lvTabla.Size = new System.Drawing.Size(838, 247);
			this.lvTabla.TabIndex = 29;
			this.lvTabla.UseCompatibleStateImageBehavior = false;
			this.lvTabla.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Asignatura ";
			this.columnHeader1.Width = 122;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Parcial 1";
			this.columnHeader2.Width = 84;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Parcial 2";
			this.columnHeader3.Width = 94;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Parcial 3";
			this.columnHeader4.Width = 98;
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "Promedio";
			this.columnHeader5.Width = 119;
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "Aprobado o no Aprobado";
			this.columnHeader6.Width = 175;
			// 
			// LblPromedio
			// 
			this.LblPromedio.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblPromedio.Location = new System.Drawing.Point(36, 308);
			this.LblPromedio.Name = "LblPromedio";
			this.LblPromedio.Size = new System.Drawing.Size(139, 45);
			this.LblPromedio.TabIndex = 30;
			this.LblPromedio.Text = "Promedio Final";
			// 
			// TxtPromedio
			// 
			this.TxtPromedio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.TxtPromedio.Location = new System.Drawing.Point(276, 307);
			this.TxtPromedio.Name = "TxtPromedio";
			this.TxtPromedio.Size = new System.Drawing.Size(144, 22);
			this.TxtPromedio.TabIndex = 31;
			// 
			// LblNombreAlumno
			// 
			this.LblNombreAlumno.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblNombreAlumno.Location = new System.Drawing.Point(40, 33);
			this.LblNombreAlumno.Name = "LblNombreAlumno";
			this.LblNombreAlumno.Size = new System.Drawing.Size(152, 23);
			this.LblNombreAlumno.TabIndex = 32;
			this.LblNombreAlumno.Text = "Nomber De Alumno";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(36, 82);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 33;
			this.label1.Text = "Grado";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(40, 135);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 34;
			this.label2.Text = "Especialidad";
			// 
			// LblAdignatura
			// 
			this.LblAdignatura.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblAdignatura.Location = new System.Drawing.Point(40, 194);
			this.LblAdignatura.Name = "LblAdignatura";
			this.LblAdignatura.Size = new System.Drawing.Size(188, 23);
			this.LblAdignatura.TabIndex = 35;
			this.LblAdignatura.Text = "Asignatura o Submodulo";
			// 
			// Boleta
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.ClientSize = new System.Drawing.Size(949, 659);
			this.Controls.Add(this.LblAdignatura);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.LblNombreAlumno);
			this.Controls.Add(this.TxtPromedio);
			this.Controls.Add(this.LblPromedio);
			this.Controls.Add(this.lvTabla);
			this.Controls.Add(this.TxtParcial3);
			this.Controls.Add(this.TxtParcial2);
			this.Controls.Add(this.TxtParcial1);
			this.Controls.Add(this.LblParcial3);
			this.Controls.Add(this.Parcial2);
			this.Controls.Add(this.LblParcial1);
			this.Controls.Add(this.BtnSalir);
			this.Controls.Add(this.BtnCancelar);
			this.Controls.Add(this.BtnRegistrar);
			this.Controls.Add(this.cmbSubmodulo);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.cmbEspecialidad);
			this.Controls.Add(this.cmbGrado);
			this.Controls.Add(this.TxtNombreDelAlumno);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.btnRegresar);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "Boleta";
			this.Text = "Boleta";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox TxtPromedio;
		private System.Windows.Forms.Label LblPromedio;
		private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ListView lvTabla;
		private System.Windows.Forms.TextBox TxtParcial3;
		private System.Windows.Forms.TextBox TxtParcial2;
		private System.Windows.Forms.TextBox TxtParcial1;
		private System.Windows.Forms.Label LblParcial3;
		private System.Windows.Forms.Label Parcial2;
		private System.Windows.Forms.Label LblParcial1;
		private System.Windows.Forms.Button BtnSalir;
		private System.Windows.Forms.Button BtnCancelar;
		private System.Windows.Forms.Button BtnRegistrar;
		private System.Windows.Forms.ComboBox cmbSubmodulo;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.ComboBox cmbEspecialidad;
		private System.Windows.Forms.ComboBox cmbGrado;
		private System.Windows.Forms.TextBox TxtNombreDelAlumno;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label LblAdignatura;
		private System.Windows.Forms.Label LblNombreAlumno;
		private System.Windows.Forms.Button btnRegresar;
	}
}
