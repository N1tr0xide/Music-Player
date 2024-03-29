using Music_Player.UserControls;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;

namespace Music_Player
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ColorPalette p3ColorPalette = new ColorPalette("#2A4AA8", "#0E1272", "#4BA3EB", "#73CCEE", "#CE3633");

        public MainWindow()
        {
            InitializeComponent();
            SetColorPalette(p3ColorPalette);
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(e.ChangedButton == MouseButton.Left) //If left click is pressed
            {
                this.DragMove(); //drag window 
            }
        }

        private void CloseButton_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void MaximizeButton_MouseDown(object sender, MouseButtonEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void SetColorPalette(ColorPalette colorPalette)
        {
            LeftMenu.Background = ColorPainter.SetColorBrush(colorPalette.secondaryBackground);
            PrimaryBackground.Background = ColorPainter.SetColorBrush(colorPalette.mainBackground);
            SongsPanel.Background = ColorPainter.SetColorBrush(colorPalette.mainBackground);
            Player.Background = ColorPainter.SetColorBrush(colorPalette.secondaryBackground);
            
        }
    }
}