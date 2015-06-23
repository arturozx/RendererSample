using System;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;
using RendererSample;
using RendererSample.Droid;

[assembly: ExportRendererAttribute(typeof(cLabel),typeof(cLabelRenderer))]

namespace RendererSample.Droid
{
	public class cLabelRenderer : LabelRenderer
	{
		protected override void OnElementChanged (ElementChangedEventArgs<Xamarin.Forms.Label> e)
		{
			base.OnElementChanged (e);
			cLabel clbl = (cLabel)this.Element;
			Control.SetTextColor (clbl.cTextColor.ToAndroid ());
		}
	}
}

