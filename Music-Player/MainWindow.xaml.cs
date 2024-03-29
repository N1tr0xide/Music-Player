using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Music_Player
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(e.ChangedButton == MouseButton.Left) //If left click is pressed
            {

                this.DragMove(); //drag window
          }

            /*   resize window
            if (e.ChangedButton == MouseButton.Left)
            {
                this.Height = 1080;
                this.Width = 1920;
            }*/
        }

        private void CloseButton_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}