using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class GreetPage : ContentPage
	{

		public GreetPage ()
		{
			InitializeComponent ();
		}

        void Button_Clicked(object sender, System.EventArgs e)
        {
            DisplayAlert("Hello World!", "You just clicked the button!", "OK", "Cancel");
        }

    }
}