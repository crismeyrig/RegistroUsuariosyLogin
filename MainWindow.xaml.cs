using System.Windows;
using RegistroUsuariosyLogin.UI.Registros;
using RegistroUsuariosyLogin.UI.Consultas;
using System;

namespace RegistroUsuariosyLogin
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
         protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            Application.Current.Shutdown();
        }
        public MainWindow()
        {
            InitializeComponent();
        }
         private void rUsuariosMenuItem_Click(object sender, RoutedEventArgs e)
        {
            rUsuarios rUsuarios1 = new rUsuarios();
            rUsuarios1.Show();

        }
        private void cUsuariosMenuItem_Click(object sender, RoutedEventArgs e)
        {
            cUsuarios cUsuarios1 = new cUsuarios();
            cUsuarios1.Show();

        }
        private void AyudaMenu_Click(object sender, RoutedEventArgs e)
        {

        }
       
       
    }
}
