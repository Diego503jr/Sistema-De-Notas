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

namespace SistemaDeNotas
{
	public partial class CursosAlumno : Form
	{
		private string IdAlumno;
		public CursosAlumno(string id)
		{
			this.IdAlumno = id;
			InitializeComponent();
		}
		public void MostrarCursos()
		{
			int idAlumno = Convert.ToInt32(IdAlumno);
			dgvCursos.DataSource = FuncionesAlumno.MostrarCursos(idAlumno);
		}

		private void CursosAlumno_Load(object sender, EventArgs e)
		{
			ConfigurarDataGridView();
			MostrarCursos();
		}
		private void ConfigurarDataGridView()
		{
			// Establecer el estilo de las celdas
			dgvCursos.DefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Bold);
			dgvCursos.DefaultCellStyle.ForeColor = Color.Black;
			dgvCursos.DefaultCellStyle.BackColor = Color.White;
			dgvCursos.DefaultCellStyle.SelectionForeColor = Color.White;
			dgvCursos.DefaultCellStyle.SelectionBackColor = Color.FromArgb(237, 28, 36);

			// Establecer el estilo de las filas alternas
			dgvCursos.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;

			// Establecer el estilo de las cabeceras de las columnas
			dgvCursos.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 11, FontStyle.Bold);
			dgvCursos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
			dgvCursos.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(237, 28, 36);

			// Agregar relleno (padding) a todos los encabezados de las columnas
			dgvCursos.ColumnHeadersDefaultCellStyle.Padding = new Padding(10);

			// Centrar los encabezados de las columnas
			dgvCursos.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

			// Alinear el contenido de las celdas al centro
			dgvCursos.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

			// Configurar la selección de celdas
			dgvCursos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgvCursos.MultiSelect = false;

			// Agregar el evento DataBindingComplete para establecer el ancho de las columnas de manera segura
			dgvCursos.DataBindingComplete += (sender, e) =>
			{
				foreach (DataGridViewColumn column in dgvCursos.Columns)
				{
					column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
					int width = column.Width;
					column.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
					column.Width = width;
				}
			};
		}
	}
}
