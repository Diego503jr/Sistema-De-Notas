using SistemaDeNotas.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeNotas.Interfaz.Docente
{
	public partial class ListarAlumnos : Form
	{
		private string IdDocente;
		public ListarAlumnos(string id)
		{
			this.IdDocente = id;
			InitializeComponent();
		}

		public void MostrarAlumnos()
		{
			int idDocente = Convert.ToInt32(IdDocente);
			dgvListarAlumnos.DataSource = ControllerDocente.MostrarAlumnos(idDocente);
		}

		private void ConfigurarDataGridView()
		{
			// Establecer el estilo de las celdas
			dgvListarAlumnos.DefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Bold);
			dgvListarAlumnos.DefaultCellStyle.ForeColor = Color.Black;
			dgvListarAlumnos.DefaultCellStyle.BackColor = Color.White;
			dgvListarAlumnos.DefaultCellStyle.SelectionForeColor = Color.White;
			dgvListarAlumnos.DefaultCellStyle.SelectionBackColor = Color.FromArgb(237, 28, 36);
				
			// Establecer el estilo de las filas alternas
			dgvListarAlumnos.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;

			// Establecer el estilo de las cabeceras de las columnas
			dgvListarAlumnos.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 11, FontStyle.Bold);
			dgvListarAlumnos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
			dgvListarAlumnos.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(237, 28, 36);
				
			// Agregar relleno (padding) a todos los encabezados de las columnas
			dgvListarAlumnos.ColumnHeadersDefaultCellStyle.Padding = new Padding(10);

			// Centrar los encabezados de las columnas
			dgvListarAlumnos.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

			// Alinear el contenido de las celdas al centro
			dgvListarAlumnos.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

			// Configurar la selección de celdas
			dgvListarAlumnos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgvListarAlumnos.MultiSelect = false;

			// Agregar el evento DataBindingComplete para establecer el ancho de las columnas de manera segura
			dgvListarAlumnos.DataBindingComplete += (sender, e) =>
			{
				foreach (DataGridViewColumn column in dgvListarAlumnos.Columns)
				{
					column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
					int width = column.Width;
					column.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
					column.Width = width;
				}
			};
		}

		private void ListarAlumnos_Load(object sender, EventArgs e)
		{
			ConfigurarDataGridView();
			MostrarAlumnos();
		}
	}
}
