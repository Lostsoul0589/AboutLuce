using Xamarin.Forms;

namespace AboutLuce
{
	public partial class AboutLucePage : ContentPage
	{
		public AboutLucePage()
		{
			InitializeComponent();

			BindingContext = new AboutLucePage();
		}
	}
}
