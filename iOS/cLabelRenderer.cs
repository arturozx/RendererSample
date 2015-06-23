using System;
using Xamarin.Forms.Platform.iOS;
using Xamarin.Forms;
using RendererSample;
using RendererSample.iOS;

[assembly: ExportRendererAttribute(typeof(cLabel),typeof(cLabelRenderer))]

namespace RendererSample.iOS
{
	public class cLabelRenderer : LabelRenderer
	{
		protected override void OnElementChanged (ElementChangedEventArgs<Xamarin.Forms.Label> e)
		{
			base.OnElementChanged (e);
			cLabel clbl = (cLabel)this.Element;
			Control.TextColor = clbl.cTextColor.ToUIColor();
		}
	}
}

