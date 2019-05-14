using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LayoutXF
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(true)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void GoToStackLayout(object sender, EventArgs args)
        {
            Navigation.PushAsync(new Layouts.StackLayout.StackPage());
        }

        private void GoToGridLayout(object sender, EventArgs args)
        {
            Navigation.PushAsync(new Layouts.GridLayout.GridPage());
        }

        private void GoToAbsoluteLayout(object sender, EventArgs args)
        {
            Navigation.PushAsync(new Layouts.AbsoluteLayout.AbsolutePage());
        }

        private void GoToRelativeLayout(object sender, EventArgs args)
        {
            Navigation.PushAsync(new Layouts.RelativeLayout.RelativePage());
        }

        private void GoToScrollLayout(object sender, EventArgs args)
        {
            Navigation.PushAsync(new Layouts.ScrollLayout.ScrollPage());
        }
    }
}
