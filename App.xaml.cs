using System.Windows;

namespace RegistroUsuariosyLogin
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
                 private void Application_DispatcherUnhandledException(object sender, System.Windows.Threading.DispatcherUnhandledExceptionEventArgs e) 
            {           
                     MessageBox.Show($"Ocurrio una excepción :( {e.Exception.Message}", "");
                     e.Handled = true;
            }
    }
}
