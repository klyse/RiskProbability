using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RiskProbability
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AttackVsDefender : ContentPage
	{
		public AttackVsDefender()
		{
			InitializeComponent();
		}

		private void ButtonAttacker_OnClicked(object sender, EventArgs e)
		{
			var i = Int32.Parse(((Button)sender).Text);
		}

		private void ButtonDefender_OnClicked(object sender, EventArgs e)
		{
			var i = Int32.Parse(((Button)sender).Text);
		}
	}
}