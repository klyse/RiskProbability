﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RiskProbability.Application;
using Xamarin.Forms;

namespace RiskProbability
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

		private void Button_OnClicked(object sender, EventArgs e)
		{
			lbl.Text = Probability.GetProbabilityString(4, 4);
		}
	}
}
