using System;

using Xamarin.Forms;

namespace RendererSample
{
	public class MyPage : ContentPage
	{
		public MyPage ()
		{
			Title = "Renderer Label Text Color";
			cLabel lbl = new cLabel{ Text = "helloworld" };
			lbl.cTextColor = Color.Red;

			Content = new StackLayout { 
				Children = {
					lbl
				}
			};
		}
	}
}


