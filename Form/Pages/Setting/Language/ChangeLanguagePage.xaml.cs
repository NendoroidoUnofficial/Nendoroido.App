﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Form.Pages.Setting.Language
{
    /// <summary>
    /// List view 
    /// use to change language
    /// </summary>
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ChangeLanguagePage : ContentPage
	{
		public ChangeLanguagePage ()
		{
			InitializeComponent ();
		}
	}
}