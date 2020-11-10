using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Variant_No_Odin
{
    public partial class MainPage : ContentPage
    {
        Picker picker;
        Entry entry;
        Image img;
        public MainPage()
        {
            Grid gr = new Grid
            {
                RowDefinitions =
                {
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
                },
                ColumnDefinitions =
                {
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                }
            };
            picker = new Picker
            {
                Title = "Maakonnad"
            };
            picker.Items.Add("Valgamaa");
            picker.Items.Add("Viljandimaa");
            picker.Items.Add("Võrumaa");
            picker.Items.Add("Ida-Virumaa");
            picker.Items.Add("Jõgevamaa");
            picker.Items.Add("Lääne-Virumaa");
            picker.Items.Add("Läänemaa");
            picker.Items.Add("Polvamaa");
            picker.Items.Add("Pärnumaa");
            picker.Items.Add("Raplamaa");
            picker.Items.Add("Saaremaa");
            picker.Items.Add("Tartumaa");
            picker.Items.Add("Harjumaa");
            picker.Items.Add("Hiiumaa");
            picker.Items.Add("Järvamaa");

            picker.SelectedIndexChanged += Picker_SelectedIndexChanged;
            gr.Children.Add(picker, 0, 0);

            picker = new Picker
            {
                Title = "Kapital"
            };
            picker.Items.Add("Vala");
            picker.Items.Add("Viljandi");
            picker.Items.Add("Võru");
            picker.Items.Add("Jyhvi");
            picker.Items.Add("Jõgeva");
            picker.Items.Add("Rakveres");
            picker.Items.Add("Haapsalu");
            picker.Items.Add("Põlva");
            picker.Items.Add("Pärnu");
            picker.Items.Add("Rapla");
            picker.Items.Add("Kuressaare");
            picker.Items.Add("Tartu");
            picker.Items.Add("Tallinn");
            picker.Items.Add("Kardla");
            picker.Items.Add("Paide");
            gr.Children.Add(picker, 1, 0);
            Content = gr;


        }

        private void Picker_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }
    }
}
