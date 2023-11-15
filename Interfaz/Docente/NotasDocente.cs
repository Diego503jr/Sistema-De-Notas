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
using System.Data.SqlClient;
using System.Windows.Forms.DataVisualization.Charting;

namespace SistemaDeNotas.Interfaz.Docente
{
    public partial class NotasDocente : Form
    {
        private string IDDOCENTE;

        ConstructorNotas notas = new ConstructorNotas();

        public NotasDocente(string id)
        {
            this.IDDOCENTE = id;
            InitializeComponent();
        }

        private void MostrarNotas()
        {
            int idDocente = Convert.ToInt32(IDDOCENTE);
            dgvNotasDocente.DataSource = FuncionesDocente.MostrarNotas(idDocente);
        }

        private void DocentesNotas()
        {
            int idDocente = Convert.ToInt32(IDDOCENTE);
            cbRegistroNotas.DataSource = FuncionesAdministrador.ListarMateriaDocente(idDocente);
        }

        private void NotasDocente_Load(object sender, EventArgs e)
        {
            MostrarNotas();
            DocentesNotas();
            ListarMaterias();
            ConfigurarDataGridView();
            ConfigurarGrafico();
            ObtenerTotales();
            LlenarGrafico();
        }
        private void ConfigurarDataGridView()
        {
            // Establecer el estilo de las celdas
            dgvNotasDocente.DefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Bold);
            dgvNotasDocente.DefaultCellStyle.ForeColor = Color.Black;
            dgvNotasDocente.DefaultCellStyle.BackColor = Color.White;
            dgvNotasDocente.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvNotasDocente.DefaultCellStyle.SelectionBackColor = Color.FromArgb(237, 28, 36);

            // Establecer el estilo de las filas alternas
            dgvNotasDocente.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;

            // Establecer el estilo de las cabeceras de las columnas
            dgvNotasDocente.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 11, FontStyle.Bold);
            dgvNotasDocente.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvNotasDocente.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(237, 28, 36);

            // Agregar relleno (padding) a todos los encabezados de las columnas
            dgvNotasDocente.ColumnHeadersDefaultCellStyle.Padding = new Padding(10);

            // Centrar los encabezados de las columnas
            dgvNotasDocente.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Alinear el contenido de las celdas al centro
            dgvNotasDocente.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            // Configurar la selección de celdas
            dgvNotasDocente.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNotasDocente.MultiSelect = false;

            // Agregar el evento DataBindingComplete para establecer el ancho de las columnas de manera segura
            dgvNotasDocente.DataBindingComplete += (sender, e) =>
            {
                foreach (DataGridViewColumn column in dgvNotasDocente.Columns)
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    int width = column.Width;
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                    column.Width = width;
                }
            };
        }

        private void dgvNotasDocente_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            CConexion conexion = new CConexion();
            if (e.RowIndex >= 0)
            {
                //Obteniendo la fila seleccionada
                DataGridViewRow row = dgvNotasDocente.Rows[e.RowIndex];

                //Obteniendo el valor del campo IdAlumno, IdCurso, IdMateria de la fila seleccionada
                string UsuarioId = row.Cells["Nombre"].Value.ToString();
                string MateriaId = row.Cells["Materia"].Value.ToString();
                string NotasEvaluacion1 = row.Cells["Nota1"].Value.ToString();
                string NotasEvaluacion2 = row.Cells["Nota2"].Value.ToString();
                string NotasEvaluacion3 = row.Cells["Nota3"].Value.ToString();
                string NotasEvaluacion4 = row.Cells["Nota4"].Value.ToString();
                string NotasPromedio = row.Cells["Promedio"].Value.ToString();

                txtNota1.Text = NotasEvaluacion1;
                txtNota2.Text = NotasEvaluacion2;
                txtNota3.Text = NotasEvaluacion3;
                txtNota4.Text = NotasEvaluacion4;
                txtPromedio.Text = NotasPromedio;

                //Se hacen las consulta SQL a las 3 tablas

                string queryAlumno = "SELECT Nombre, Carnet FROM dbo.Usuarios WHERE Nombre = @UsuarioId";
                string queryMateria = "SELECT Nombre FROM dbo.Materias WHERE Nombre = @MateriaId";

                SqlCommand cmdAlumno = new SqlCommand(queryAlumno, conexion.establecerConexion());
                SqlCommand cmdMateria = new SqlCommand(queryMateria, conexion.establecerConexion());
                cmdAlumno.Parameters.AddWithValue("@UsuarioId", UsuarioId);
                cmdMateria.Parameters.AddWithValue("@MateriaId", MateriaId);

                SqlDataReader drAlumno = cmdAlumno.ExecuteReader();
                SqlDataReader drMateria = cmdMateria.ExecuteReader();

                if (drAlumno.Read() && drMateria.Read())
                {
                    string NombreUsuario = drAlumno["Nombre"].ToString();
                    string NombreMateria = drMateria["Nombre"].ToString();


                    txtNombre.Text = NombreUsuario;
                    cbRegistroNotas.Text = NombreMateria;

                }
                else
                {
                    MessageBox.Show("No hay registros de un dato");
                }

            }
        }
        public void ListarMaterias()
        {
            int idDocente = Convert.ToInt32(IDDOCENTE);
            cbRegistroNotas.DataSource = FuncionesAdministrador.ListarMateriaDocente(idDocente);
            cbRegistroNotas.DisplayMember = "Nombre";
            cbRegistroNotas.ValueMember = "Id";
            cbRegistroNotas.Text = null;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cbRegistroNotas.Text = null;
            txtNombre.Clear();
        }

        private void cbRegistroNotas_SelectedIndexChanged(object sender, EventArgs e)
        {
            string buscar = cbRegistroNotas.Text.Trim();
            if (!string.IsNullOrEmpty(buscar))
            {
                // Realiza la búsqueda en la fuente de datos y filtra los resultados
                (dgvNotasDocente.DataSource as DataTable).DefaultView.RowFilter = $"Materia = '{buscar}'";
            }
            else
            {
                // Si el cuadro de búsqueda está vacío, muestra todos los datos
                (dgvNotasDocente.DataSource as DataTable).DefaultView.RowFilter = "";
            }
        }

        public void Actualizar()
        {
            if (cbRegistroNotas.SelectedIndex == -1 || txtNombre.Text == "" || txtNota1.Text == "" || txtNota2.Text == "" || txtNota3.Text == "" || txtNota4.Text == "")
            {
                MessageBox.Show("Datos incompletos, por favor llene todos los campos", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string alumno = txtNombre.Text;
                int usuario = ObtenerIdAlumno(alumno);
                int idMateria = Convert.ToInt32(cbRegistroNotas.SelectedValue);
                int id = (int)dgvNotasDocente.SelectedRows[0].Cells["Id"].Value;
                notas.IdAlumno = usuario;
                notas.IdMateria = Convert.ToInt32(cbRegistroNotas.SelectedValue);
                notas.Nota1 = Convert.ToDecimal(txtNota1.Text);
                notas.Nota2 = Convert.ToDecimal(txtNota2.Text);
                notas.Nota3 = Convert.ToDecimal(txtNota3.Text);
                notas.Nota4 = Convert.ToDecimal(txtNota4.Text);
                decimal promedioFinal = ObtenerPromedio(notas.Nota1, notas.Nota2, notas.Nota3, notas.Nota4);
                notas.Promedio = promedioFinal;
                notas.Id = id;
                FuncionesDocente.AgregarNota(notas);
                MostrarNotas();
            }

        }

        public void ActualizarNota()
        {
            if (cbRegistroNotas.SelectedIndex == -1 || txtNombre.Text == "" || txtNota1.Text == "" || txtNota2.Text == "" || txtNota3.Text == "" || txtNota4.Text == "")
            {
                MessageBox.Show("Datos incompletos, por favor llene todos los campos", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string alumno = txtNombre.Text;
                int usuario = ObtenerIdAlumno(alumno);
                int idMateria = Convert.ToInt32(cbRegistroNotas.SelectedValue);
                int id = (int)dgvNotasDocente.SelectedRows[0].Cells["Id"].Value;
                notas.IdAlumno = usuario;
                notas.IdMateria = Convert.ToInt32(cbRegistroNotas.SelectedValue);
                notas.Nota1 = Convert.ToDecimal(txtNota1.Text);
                notas.Nota2 = Convert.ToDecimal(txtNota2.Text);
                notas.Nota3 = Convert.ToDecimal(txtNota3.Text);
                notas.Nota4 = Convert.ToDecimal(txtNota4.Text);
                decimal promedioFinal = ObtenerPromedio(notas.Nota1, notas.Nota2, notas.Nota3, notas.Nota4);
                notas.Promedio = promedioFinal;
                notas.Id = id;
                FuncionesDocente.ActualizarNota(notas);
                MostrarNotas();
            }
        }

        public static decimal ObtenerPromedio(decimal nota1, decimal nota2, decimal nota3, decimal nota4)
        {

            decimal promediosuma = nota1 + nota2 + nota3 + nota4;
            decimal promediodivision = promediosuma / 4;

            return promediodivision;

        }

        public static int ObtenerIdAlumno(string nombre)
        {
            int idUsuario = -1;

            try
            {
                CConexion conexion = new CConexion();
                string query = "SELECT Id FROM dbo.Usuarios Where Nombre = @nombre";

                SqlCommand cmd = new SqlCommand(query, conexion.establecerConexion());
                cmd.Parameters.AddWithValue("@nombre", nombre);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    idUsuario = (int)reader["Id"];
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hubo un error de conexion {ex}", "Error crítico", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

            return idUsuario;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void ObtenerTotales()
        {
            int totalAprobados = 0;
            int totalReprobados = 0;

            foreach (DataGridViewRow fila in dgvNotasDocente.Rows)
            {
                if (fila.Cells["Promedio"].Value != null)
                {
                    string estado = fila.Cells["Promedio"].Value.ToString();

                    double acu = Convert.ToDouble(estado);

                    if (acu >= 7)
                    {
                        totalAprobados ++;
                        datosAprobados.Add(acu);
                    }
                    else
                    {
                        totalReprobados ++;
                        datosReprobados.Add(acu);
                    }
                }
            }

            // Puedes mostrar los resultados donde desees
            txtAprobados.Text = "Aprobados: " + totalAprobados.ToString();
            txtReprobados.Text = "Reprobados: " + totalReprobados.ToString();

        }
        List<double> datosAprobados = new List<double>();
        List<double> datosReprobados = new List<double>();
        private void ConfigurarGrafico()
        {
            // Configuración del gráfico
            gfcNotas.ChartAreas.Add("AreaPrincipal");
            int totApro= datosAprobados.Count;
            int totRepro = datosReprobados.Count;

            gfcNotas.Series.Add("Aprobados");
            gfcNotas.Series["Aprobados"].ChartType = SeriesChartType.Column;
            gfcNotas.Series["Aprobados"].Points.Add(totApro); // Agrega un punto para evitar el color predeterminado
            gfcNotas.Series["Aprobados"].LegendText = "Aprobados";

            gfcNotas.Series.Add("Reprobados");
            gfcNotas.Series["Reprobados"].ChartType = SeriesChartType.Column;
            gfcNotas.Series["Aprobados"].Points.Add(totRepro); // Agrega un punto para evitar el color predeterminado
            gfcNotas.Series["Reprobados"].LegendText = "Reprobados";

            gfcNotas.Titles.Add("Rendimiento Académico");

        }

        private void LlenarGrafico() 
        {
            // Limpiar la serie antes de agregar nuevos datos
            gfcNotas.Series["Aprobados"].Points.Clear();
            gfcNotas.Series["Reprobados"].Points.Clear();

            // Agregar el total de aprobados al gráfico
            gfcNotas.Series["Aprobados"].Points.AddY(datosAprobados.Count);

            // Agregar el total de reprobados al gráfico
            gfcNotas.Series["Reprobados"].Points.AddY(datosReprobados.Count);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ActualizarNota();
        }
    }
}
