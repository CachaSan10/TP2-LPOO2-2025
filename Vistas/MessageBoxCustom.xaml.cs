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

namespace Vistas
{
    /// <summary>
    /// Lógica de interacción para MessageBoxCustom.xaml
    /// </summary>
    public partial class MessageBoxCustom : Window
    {
        public MessageBoxCustom(string message)
        {
            InitializeComponent();
            txtMessage.Text = message;
        }

        private void btnAceptar_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
            this.Close();
        }

        // Método fácil de usar
        public static void Show(string message)
        {
            MessageBoxCustom box = new MessageBoxCustom(message);
            box.Owner = Application.Current.MainWindow;
            box.ShowDialog(); // ← ¡ESPERA hasta que se cierre!
        }
    }
}
