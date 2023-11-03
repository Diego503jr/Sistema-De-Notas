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

namespace SistemaDeNotas.Interfaz.Alumno
{
    public partial class NotasAlumnocs : Form
    {
        public NotasAlumnocs()
        {
            InitializeComponent();
        }
        public void MostrarNotas()
        {
            dgvNotas.DataSource = FuncionesAdministrador.MostrarNotas();

        }

        private void NotasAlumnocs_Load(object sender, EventArgs e)
        {
            ConfigurarDataGridView();
            MostrarNotas();
        }

        private void ConfigurarDataGridView()
        {
            // Establecer el estilo de las celdas
            dgvNotas.DefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Bold);
            dgvNotas.DefaultCellStyle.ForeColor = Color.Black;
            dgvNotas.DefaultCellStyle.BackColor = Color.White;
            dgvNotas.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvNotas.DefaultCellStyle.SelectionBackColor = Color.FromArgb(237, 28, 36);

            // Establecer el estilo de las filas alternas
            dgvNotas.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;

            // Establecer el estilo de las cabeceras de las columnas
            dgvNotas.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 11, FontStyle.Bold);
            dgvNotas.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvNotas.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(237, 28, 36);

            // Agregar relleno (padding) a todos los encabezados de las columnas
            dgvNotas.ColumnHeadersDefaultCellStyle.Padding = new Padding(10);

            // Centrar los encabezados de las columnas
            dgvNotas.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Alinear el contenido de las celdas al centro
            dgvNotas.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            // Configurar la selección de celdas
            dgvNotas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNotas.MultiSelect = false;

            // Agregar el evento DataBindingComplete para establecer el ancho de las columnas de manera segura
            dgvNotas.DataBindingComplete += (sender, e) =>
            {
                foreach (DataGridViewColumn column in dgvNotas.Columns)
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
