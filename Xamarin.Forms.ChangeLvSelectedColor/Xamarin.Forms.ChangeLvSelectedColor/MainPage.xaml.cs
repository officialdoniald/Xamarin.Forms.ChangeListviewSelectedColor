using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Xamarin.Forms.ChangeLvSelectedColor
{
    public partial class MainPage : ContentPage
    {
        #region Properties

        public List<Person> Names = new List<Person>();

        public Person SelectedName;

        #endregion

        public MainPage()
        {
            Names.Add(new Person()
            {
                Name = "Asd1"
            });
            Names.Add(new Person()
            {
                Name = "Asd2"
            });
            Names.Add(new Person()
            {
                Name = "Asd3"
            });

            InitializeComponent();

            PersonListView.ItemsSource = Names;

            SelectedName = Names[0];
        }

        public class Person
        {
            public string Name { get; set; }
        }

        private void PersonListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            SelectedName = (Person)e.SelectedItem;
        }
    }
}
