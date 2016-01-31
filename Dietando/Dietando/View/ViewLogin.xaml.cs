﻿using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Dietando.View
{
	public partial class ViewLogin : ContentPage
	{
		public ViewLogin ()
		{
			InitializeComponent ();

			MessagingCenter.Subscribe<TodoItem> ("TodoItem", "NovaTask", (sender) => {
				this.Dados.Add (sender);
			});
		}
	}
}

