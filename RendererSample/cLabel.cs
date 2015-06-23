using System;

using Xamarin.Forms;

namespace RendererSample
{
	public class cLabel : Label
	{
		public static readonly BindableProperty cTextColorProperty =
			BindableProperty.Create<cLabel,Color> (p => p.cTextColor, Color.Default);

		public Color cTextColor {
			get { return (Color)base.GetValue (cTextColorProperty); }
			set { base.SetValue (cTextColorProperty, value); }
		}

	}
}


