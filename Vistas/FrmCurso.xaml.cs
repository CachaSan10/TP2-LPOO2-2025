using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using ClasesBase;

namespace Vistas
{
    /// <summary>
    /// Interaction logic for FrmCurso.xaml
    /// </summary>
    public partial class FrmCurso : Window
    {
        private List<Estado> estados = new List<Estado>();
        private List<EstadoType> estadoTypes = new List<EstadoType>();
        private List<Docente> docentes = new List<Docente>();

        public FrmCurso()
        {
            InitializeComponent();
            //InicializarEstados();
           // InicializarDocentes();
        }

        private void InicializarEstados()
        {
            //// Tipos de estado
            //estadoTypes.Add(new EstadoType { Esty_ID = 1, Esty_Nombre = "Curso" });
            ////estadoTypes.Add(new EstadoType { Esty_ID = 2, Esty_Nombre = "Inscripción" });

            //// Estados para Curso
            //estados.Add(new Estado { Est_ID = 1, Est_Nombre = "Programado", Esty_ID = 1 });
            //estados.Add(new Estado { Est_ID = 2, Est_Nombre = "En Curso", Esty_ID = 1 });
            //estados.Add(new Estado { Est_ID = 3, Est_Nombre = "Finalizado", Esty_ID = 1 });
            //estados.Add(new Estado { Est_ID = 4, Est_Nombre = "Cancelado", Esty_ID = 1 });

            //// Estados para Inscripción
            ////estados.Add(new Estado { Est_ID = 5, Est_Nombre = "Inscripto", Esty_ID = 2 });
            ////estados.Add(new Estado { Est_ID = 6, Est_Nombre = "Confirmado", Esty_ID = 2 });
            ////estados.Add(new Estado { Est_ID = 7, Est_Nombre = "Cancelado", Esty_ID = 2 });

            //// Cargar tipos en el combo
            //cmbTipoEstado.ItemsSource = estadoTypes;
            //cmbTipoEstado.DisplayMemberPath = "Esty_Nombre";
            //cmbTipoEstado.SelectedValuePath = "Esty_ID";
        }

        //private void cmbTipoEstado_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    if (cmbTipoEstado.SelectedValue != null)
        //    {
        //        int tipoId = (int)cmbTipoEstado.SelectedValue;

        //        // Filtramos estados según el tipo seleccionado
        //        var estadosFiltrados = estados.Where(est => est.Esty_ID == tipoId).ToList();

        //        cmbEstado.ItemsSource = estadosFiltrados;
        //        cmbEstado.DisplayMemberPath = "Est_Nombre";
        //        cmbEstado.SelectedValuePath = "Est_ID";
        //    }
        //}

        //private void InicializarDocentes()
        //{

        //    docentes.Add(new Docente { Doc_ID = 1, Doc_Nombre = "Juan Pérez" });
        //    docentes.Add(new Docente { Doc_ID = 2, Doc_Nombre = "María González" });
        //    docentes.Add(new Docente { Doc_ID = 3, Doc_Nombre = "Carlos López" });

        //    // Enlazar lista al ComboBox
        //    cmbDocente.ItemsSource = docentes;
        //    cmbDocente.DisplayMemberPath = "Doc_Nombre";
        //    cmbDocente.SelectedValuePath = "Doc_ID";
        //}

        //private void Limpiar_Campos()
        //{
        //    txtNombre.Clear();
        //    txtDescripcion.Clear();
        //    txtCupo.Clear();
        //    dpFechaInicio.SelectedDate = null;
        //    dpFechaFin.SelectedDate = null;
        //    cmbTipoEstado.SelectedIndex = -1;
        //    cmbEstado.ItemsSource = null;
        //    cmbDocente.SelectedIndex = -1;
        //}

 

        //private void Window_Loaded(object sender, RoutedEventArgs e)
        //{

        //}

        //private void btnCancelar_Click(object sender, RoutedEventArgs e)
        //{
        //    this.Close();
        //}

        //private void btnGuardar_Click(object sender, RoutedEventArgs e)
        //{
             
        //    if (MessageBox.Show("¿Desea guardar este Curso?", "Confrimar", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes) {
        //        if (verificarCampos())
        //        {
        //              Curso oCurso = new Curso();
        //                oCurso.Cur_Nombre = txtNombre.Text;
        //                oCurso.Cur_Descripcion = txtDescripcion.Text;
        //                oCurso.Cur_Cupo = int.Parse(txtCupo.Text);
        //                oCurso.Cur_FechaInicio = dpFechaInicio.SelectedDate ?? DateTime.MinValue;
        //                oCurso.Cur_FechaFin = dpFechaFin.SelectedDate ?? DateTime.MinValue;
        //                int tipoSeleccionado = cmbTipoEstado.SelectedValue != null ? (int)cmbTipoEstado.SelectedValue : 0;
        //                //oCurso.Est_ID = cmbTipoEstado.SelectedValue != null ? (int)cmbTipoEstado.SelectedValue : 0;

        //                oCurso.Doc_ID = cmbDocente.SelectedValue != null ? (int)cmbDocente.SelectedValue : 0;


        //                MessageBox.Show(

        //                    "Curso Cargado: \n" +
        //                    "Nombre: " + oCurso.Cur_Nombre + "\n" +
        //                    "Descripción: " + oCurso.Cur_Descripcion + "\n" +
        //                    "Cupo: " + oCurso.Cur_Cupo + "\n" +
        //                    "Fecha de Inicio: " + oCurso.Cur_FechaInicio.ToShortDateString() + "\n" +
        //                    "Fecha de Finalización: " + oCurso.Cur_FechaFin.ToShortDateString() + "\n" +
        //                    "Tipo de Estado: " + (cmbTipoEstado.Text) + "\n" +
        //                    "Estado: " + (cmbEstado.Text) + "\n" +
        //                    "Docente: " + (cmbDocente.Text)
        //              );

        //                Limpiar_Campos();
        //        }
        //        else
        //        {
        //            MessageBox.Show("Por favor, complete todos los campos correctamente. Asegúrese de que los campos numéricos sean válidos y que las fechas estén seleccionadas.");
        //        }
        //    }
        //}

        //private Boolean verificarCampos() 
        //{
        //    Boolean verificado = false;
        //    int cupo;
        //    if(
        //       !string.IsNullOrEmpty(txtNombre.Text) &&
        //       !string.IsNullOrEmpty(cmbEstado.Text) &&
        //       !string.IsNullOrEmpty(cmbTipoEstado.Text) &&
        //       !string.IsNullOrEmpty(cmbDocente.Text) &&
        //       !string.IsNullOrEmpty(txtDescripcion.Text) &&
        //       int.TryParse(txtCupo.Text, out cupo) && 
        //       dpFechaInicio.SelectedDate.HasValue &&
        //       dpFechaFin.SelectedDate.HasValue
        //      )
        //    {
        //        verificado = true;
        //    }

        //    return verificado;
        //}
    }
}
