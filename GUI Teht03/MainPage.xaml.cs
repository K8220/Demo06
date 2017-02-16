using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace GUI_Teht03
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void laskeButton_Click(object sender, RoutedEventArgs e)
        {
            int L = int.Parse(ikkunaLText.Text);
            int H = int.Parse(ikkunaHText.Text);
            int W = int.Parse(ikkunaWText.Text);

            int ikkunaPA = L * H;
            ikkunaPAText.Text = ikkunaPA.ToString();

            int l = L * H;
            ikkunaPAText.Text = ikkunaPA.ToString();

            int ikkunaPA = L * H;
            ikkunaPAText.Text = ikkunaPA.ToString();
        }
    }
}
