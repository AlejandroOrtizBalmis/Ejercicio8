using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Ejercicio8
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            nombreTextBox.Tag = ayudaNombreTextBlock;
            apellidoTextBox.Tag = ayudaApellidoTextBlock;

        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        { TextBlock ayuda = (sender as TextBox).Tag as TextBlock;
            if (e.Key == Key.F1)
            {
                if (ayuda.IsVisible) ayuda.Visibility = Visibility.Hidden;
                else ayuda.Visibility = Visibility.Visible;
            }
        }


        private void edadTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            bool result = int.TryParse(edadTextBox.Text, out _);
            if (result is false && e.Key == Key.F2)
            {
                validarEdadTextBlock.Visibility = Visibility.Visible;
            }
            else if(e.Key == Key.F2)  validarEdadTextBlock.Visibility = Visibility.Hidden;
        }
    }
}
