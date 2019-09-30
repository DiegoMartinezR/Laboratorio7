using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Ejercicio09
{
    public partial class MainPage : ContentPage
    {
        [Obsolete]
        public MainPage()
        {
            this.Title = "Laboratorio 7";

            var grid = new Grid();
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });

            var btn01 = new Button();
            btn01.Text = "ExplicitDemo";
            btn01.TextColor = Color.AliceBlue;
            
            btn01.HorizontalOptions = LayoutOptions.Center;
            btn01.Clicked += btnExplicitDemo;


            var btn02 = new Button();
            btn02.Text = "ExplicitCode";
            btn02.TextColor = Color.AliceBlue;
            
            btn02.HorizontalOptions = LayoutOptions.Center;
            btn02.Clicked += btnExplicitCode;

            var btn03 = new Button();
            btn03.Text = "ExplicitControlDemo";
            btn03.TextColor = Color.AliceBlue;
           
            btn03.HorizontalOptions = LayoutOptions.Center;
            btn03.Clicked += btnExplicitControlDemo;

            var btn04 = new Button();
            btn04.Text = "ExplicitControlCode";
            btn04.TextColor = Color.AliceBlue;
           
            btn04.HorizontalOptions = LayoutOptions.Center;
            btn04.Clicked += btnExplicitControlCode;

            var btn05 = new Button();
            btn05.Text = "ImplicitDemo";
            btn05.TextColor = Color.AliceBlue;
            
            btn05.HorizontalOptions = LayoutOptions.Center;
            btn05.Clicked += btnImplicitDemo;


            var btn06 = new Button();
            btn06.Text = "ImplicitCode";
            btn06.TextColor = Color.AliceBlue;
           
            btn06.HorizontalOptions = LayoutOptions.Center;
            btn06.Clicked += btnImplicitCode;


            var btn07 = new Button();
            btn07.Text = "ImplicitControlDemo";
            btn07.TextColor = Color.AliceBlue;
            
            btn07.HorizontalOptions = LayoutOptions.Center;
            btn07.Clicked += btnImplicitControlDemo;

            var btn08 = new Button();
            btn08.Text = "GlobalDemo";
            btn08.TextColor = Color.AliceBlue;
            
            btn08.HorizontalOptions = LayoutOptions.Center;
            btn08.Clicked += btnGlobalDemo;

            var btn09 = new Button();
            btn09.Text = "GlobalCode";
            btn09.TextColor = Color.AliceBlue;
            
            btn09.HorizontalOptions = LayoutOptions.Center;
            btn09.Clicked += btnGlobalCode;

            var btn10 = new Button();
            btn10.Text = "InheritanceCode";
            btn10.TextColor = Color.AliceBlue;
          
            btn10.HorizontalOptions = LayoutOptions.Center;
            btn10.Clicked += btnInheritanceCode;

            var btn11 = new Button();
            btn11.Text = "InheritanceDemo";
            btn11.TextColor = Color.AliceBlue;
            
            btn11.HorizontalOptions = LayoutOptions.Center;
            btn11.Clicked += btnInheritanceDemo;

            var btn12 = new Button();
            btn12.Text = "DynamicDemo";
            btn12.TextColor = Color.AliceBlue;
            
            btn12.HorizontalOptions = LayoutOptions.Center;
            btn12.Clicked += btnDynamicDemo;


            var btn13 = new Button();
            btn13.Text = "DynamicCode";
            btn13.TextColor = Color.AliceBlue;
            
            btn13.HorizontalOptions = LayoutOptions.Center;
            btn13.Clicked += btnDynamicCode;

            var btn14 = new Button();
            btn14.Text = "ClassDemo";
            btn14.TextColor = Color.AliceBlue;
            
            btn14.HorizontalOptions = LayoutOptions.Center;
            btn14.Clicked += btnClassDemo;



            grid.Children.Add(btn01, 0, 0);
            grid.Children.Add(btn02, 1, 0);
            grid.Children.Add(btn03, 0, 1);
            grid.Children.Add(btn04, 1, 1);
            grid.Children.Add(btn05, 0, 2);
            grid.Children.Add(btn06, 1, 2);
            grid.Children.Add(btn07, 0, 3);
            grid.Children.Add(btn08, 1, 3);
            grid.Children.Add(btn09, 0, 4);
            grid.Children.Add(btn10, 1, 4);
            grid.Children.Add(btn11, 0, 5);
            grid.Children.Add(btn12, 1, 5);
            grid.Children.Add(btn13, 0, 6);
            grid.Children.Add(btn14, 1, 6);

            Content = grid;

        }

        async private void btnExplicitDemo(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ExplicitDemo());
        }

        async private void btnExplicitCode(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ExplicitCode());
        }

        async private void btnExplicitControlDemo(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ExplicitControlDemo());
        }

        async private void btnExplicitControlCode(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ExplicitControlCode());
        }

        async private void btnImplicitDemo(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ImplicitDemo());
        }

        async private void btnImplicitCode(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ImplicitCode());
        }

        async private void btnImplicitControlDemo(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ImplicitControlDemo());
        }

        async private void btnGlobalDemo(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GlobalDemo());
        }

        async private void btnGlobalCode(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GlobalCode());
        }

        async private void btnInheritanceCode(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new InheritanceCode());
        }

        async private void btnInheritanceDemo(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new InheritanceDemo());
        }

        async private void btnDynamicDemo(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DynamicDemo());
        }

        async private void btnDynamicCode(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DynamicCode());
        }

        async private void btnClassDemo(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ClassDemo());
        }


    }
}