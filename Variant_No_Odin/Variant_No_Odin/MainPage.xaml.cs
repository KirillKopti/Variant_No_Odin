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
        Picker picker, picker2;
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
            picker.Items.Add("Põlvamaa");
            picker.Items.Add("Pärnumaa");
            picker.Items.Add("Raplamaa");
            picker.Items.Add("Saaremaa");
            picker.Items.Add("Tartumaa");
            picker.Items.Add("Harjumaa");
            picker.Items.Add("Hiiumaa");
            picker.Items.Add("Järvamaa");

            picker.SelectedIndexChanged += Picker_SelectedIndexChanged;
            gr.Children.Add(picker, 0, 0);

            picker2 = new Picker
            {
                Title = "Kapital"
            };
            picker2.Items.Add("Valga");
            picker2.Items.Add("Viljandi");
            picker2.Items.Add("Võru");
            picker2.Items.Add("Jyhvi");
            picker2.Items.Add("Jõgeva");
            picker2.Items.Add("Rakvere");
            picker2.Items.Add("Haapsalu");
            picker2.Items.Add("Põlva");
            picker2.Items.Add("Pärnu");
            picker2.Items.Add("Rapla");
            picker2.Items.Add("Kuresaare");
            picker2.Items.Add("Tartu");
            picker2.Items.Add("Tallinn");
            picker2.Items.Add("Kärdla");
            picker2.Items.Add("Paide");

            picker2.SelectedIndexChanged += Picker2_SelectedIndexCahanged;
            gr.Children.Add(picker2, 1, 0);

            entry = new Entry { Text = "Vali kuupäev \n " };
            gr.Children.Add(entry, 2, 0);

            Image img = new Image { Source = "Harjumaa.jpg" };
            gr.Children.Add(img, 3, 2);


            Content = gr;

        }

        private void Picker2_SelectedIndexCahanged(object sender, EventArgs e)
        {
            picker.SelectedIndex = picker2.SelectedIndex;
        }

        private void Picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            entry.Text = "Oli vakitud: " + picker.Items[picker.SelectedIndex];
            picker2.SelectedIndex = picker.SelectedIndex;
            

        }
    }
}
