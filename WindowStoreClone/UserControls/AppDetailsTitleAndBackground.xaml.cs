using System.Windows;
using System.Windows.Controls;


namespace WindowStoreClone.UserControls
{
    /// <summary>
    /// Interaction logic for AppDetailsTitleAndBackground.xaml
    /// </summary>
    public partial class AppDetailsTitleAndBackground : UserControl
    {
        public delegate void OnBackButtonClicked(object sender, RoutedEventArgs e);
        public event OnBackButtonClicked BackButtonClicked;

        public AppDetailsTitleAndBackground()
        {
            InitializeComponent();
        }

        private void Back_Btn(object sender, RoutedEventArgs e)
        {
            BackButtonClicked(sender, e);
        }
    }
}
