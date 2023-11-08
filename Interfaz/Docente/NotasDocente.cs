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
	public partial class NotasDocente : Form
	{
        private string IDDOCENTE;

		public NotasDocente(string id)
		{
            this.IDDOCENTE = id;
			InitializeComponent();
		}

		private void MostrarNotas()
		{
            int idDocente = Convert.ToInt32(IDDOCENTE);
			dgvnotasdocente.DataSource = FuncionesDocente.MostrarNotas(idDocente);
		}

        private void NotasDocente_Load(object sender, EventArgs e)
        {
			MostrarNotas();
			ConfigurarDataGridView();
        }
        private void ConfigurarDataGridView()
        {
            // Establecer el estilo de las celdas
            dgvnotasdocente.DefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Bold);
            dgvnotasdocente.DefaultCellStyle.ForeColor = Color.Black;
            dgvnotasdocente.DefaultCellStyle.BackColor = Color.White;
            dgvnotasdocente.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvnotasdocente.DefaultCellStyle.SelectionBackColor = Color.FromArgb(237, 28, 36);

            // Establecer el estilo de las filas alternas
            dgvnotasdocente.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;

            // Establecer el estilo de las cabeceras de las columnas
            dgvnotasdocente.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 11, FontStyle.Bold);
            dgvnotasdocente .ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvnotasdocente.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(237, 28, 36);

            // Agregar relleno (padding) a todos los encabezados de las columnas
            dgvnotasdocente.ColumnHeadersDefaultCellStyle.Padding = new Padding(10);

            // Centrar los encabezados de las columnas
            dgvnotasdocente.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Alinear el contenido de las celdas al centro
            dgvnotasdocente .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            // Configurar la selección de celdas
            dgvnotasdocente .SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvnotasdocente.MultiSelect = false;

            // Agregar el evento DataBindingComplete para establecer el ancho de las columnas de manera segura
            dgvnotasdocente.DataBindingComplete += (sender, e) =>
            {
                foreach (DataGridViewColumn column in dgvnotasdocente.Columns)
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
