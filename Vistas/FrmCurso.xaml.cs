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
           
        }

        private void Limpiar_Campos()
        {
            altaCurso.txtNombre.Clear();
            altaCurso.txtDescripcion.Clear();
            altaCurso.txtCupo.Clear();
            altaCurso.dpFechaInicio.SelectedDate = null;
            altaCurso.dpFechaFin.SelectedDate = null;
            altaCurso.cmbTipoEstado.SelectedIndex = -1;
            altaCurso.cmbEstado.ItemsSource = null;
            altaCurso.cmbDocente.SelectedIndex = -1;
        }

        private Boolean verificarCampos()
        {
            Boolean verificado = false;
            int cupo;
            if (
               !string.IsNullOrEmpty(altaCurso.txtNombre.Text) &&
               !string.IsNullOrEmpty(altaCurso.cmbEstado.Text) &&
               !string.IsNullOrEmpty(altaCurso.cmbTipoEstado.Text) &&
               !string.IsNullOrEmpty(altaCurso.cmbDocente.Text) &&
               !string.IsNullOrEmpty(altaCurso.txtDescripcion.Text) &&
               int.TryParse(altaCurso.txtCupo.Text, out cupo) &&
               altaCurso.dpFechaInicio.SelectedDate.HasValue &&
               altaCurso.dpFechaFin.SelectedDate.HasValue
              )
            {
                verificado = true;
            }

            return verificado;
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {

            if (MessageBox.Show("¿Desea guardar este Curso?", "Confrimar", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                if (verificarCampos())
                {
                    Curso oCurso = new Curso();
                    oCurso.Cur_Nombre = altaCurso.txtNombre.Text;
                    oCurso.Cur_Descripcion = altaCurso.txtDescripcion.Text;
                    oCurso.Cur_Cupo = int.Parse(altaCurso.txtCupo.Text);
                    oCurso.Cur_FechaInicio = altaCurso.dpFechaInicio.SelectedDate ?? DateTime.MinValue;
                    oCurso.Cur_FechaFin = altaCurso.dpFechaFin.SelectedDate ?? DateTime.MinValue;
                    int tipoSeleccionado = altaCurso.cmbTipoEstado.SelectedValue != null ? (int)altaCurso.cmbTipoEstado.SelectedValue : 0;
                    //oCurso.Est_ID = cmbTipoEstado.SelectedValue != null ? (int)cmbTipoEstado.SelectedValue : 0;

                    oCurso.Doc_ID = altaCurso.cmbDocente.SelectedValue != null ? (int)altaCurso.cmbDocente.SelectedValue : 0;


                    MessageBox.Show(

                        "Curso Cargado: \n" +
                        "Nombre: " + oCurso.Cur_Nombre + "\n" +
                        "Descripción: " + oCurso.Cur_Descripcion + "\n" +
                        "Cupo: " + oCurso.Cur_Cupo + "\n" +
                        "Fecha de Inicio: " + oCurso.Cur_FechaInicio.ToShortDateString() + "\n" +
                        "Fecha de Finalización: " + oCurso.Cur_FechaFin.ToShortDateString() + "\n" +
                        "Tipo de Estado: " + (altaCurso.cmbTipoEstado.Text) + "\n" +
                        "Estado: " + (altaCurso.cmbEstado.Text) + "\n" +
                        "Docente: " + (altaCurso.cmbDocente.Text)
                  );

                    Limpiar_Campos();
                }
                else
                {
                    MessageBox.Show("Por favor, complete todos los campos correctamente. Asegúrese de que los campos numéricos sean válidos y que las fechas estén seleccionadas.");
                }
            }
        }

        
    }
}
