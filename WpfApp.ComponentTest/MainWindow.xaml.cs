using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp.ComponentTest.Classes;
using WpfApp.ComponentTest.Resources;

namespace WpfApp.ComponentTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DataResourse _dataResourse;
        private IEnumerable<PersonInfo> _persons;

        public MainWindow()
        {
            InitializeComponent();
            _dataResourse = new DataResourse();
            _persons = _dataResourse.Persons;
            ListView_peopleInfo.ItemsSource = _persons;


            SetCombobox();
            SetDisplayBox();
        }

        private void SetDisplayBox()
        {
            PeopleNames_listBox.ItemsSource = _persons;
            PeopleNames_listBox.DisplayMemberPath = nameof(PersonInfo.FullName);
        }

        private void SetCombobox()
        {
           
            PeopleNames_comboBox.ItemsSource = _persons;
            PeopleNames_comboBox.DisplayMemberPath = nameof(PersonInfo.FirstName);
            if (_persons.Any())
            {
                PeopleNames_comboBox.SelectedIndex = 0;
            }
        }

        private void Button_ChangeBackground_Click(object sender, RoutedEventArgs e)
        {
            ChangeBackgroundColor(Colors.LightGray);
        }

    

        private void RadioButton_ChangeBackground_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            if (radioButton != null && radioButton.IsChecked == true)
            {
                switch (radioButton.Content.ToString())
                {
                    case "LightGreen":
                        ChangeBackgroundColor(Colors.LightGreen);
                        break;
                    case "LightSkyBlue":
                        ChangeBackgroundColor(Colors.LightSkyBlue);
                        break;
                    case "LightGoldenrodYellow":
                        ChangeBackgroundColor(Colors.LightGoldenrodYellow);
                        break;
                    case "LightGray":
                        ChangeBackgroundColor(Colors.LightGray);
                        break;
                }
            }
        }

        private void ChangeBackgroundColor(Color color)
        {
            this.Background = new SolidColorBrush(color);
        }

        private void ToggleButton_Clicked(object sender, RoutedEventArgs e)
        {
            ToggleButton toggleButton = sender as ToggleButton;
            if (toggleButton.IsChecked == true)
            {
                toggleButton.Foreground = Brushes.Black;
            }
            else
            {
                toggleButton.Foreground = Brushes.White;
            }
        }

        private void LightSalmonButton_Click(object sender, RoutedEventArgs e)
        {
           ChangeColorSecondColumns(Brushes.LightSalmon);
           
        }

        private void ColorToggleButton_Clicked(object sender, RoutedEventArgs e)
        {
            ToggleButton toggleButton = sender as ToggleButton;
            if (toggleButton.IsChecked == true)
            {
                ChangeColorSecondColumns(Brushes.LightGreen);
            }
            else
            {
                ChangeColorSecondColumns(Brushes.LightSkyBlue);
            }
        }

        private void ChangeColorSecondColumns(Brush color)
        {
            Border border = SecondColumnBorder;
            if (border != null)
            {
                border.Background = color;
            }
        }

        private void PeopleNames_listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (PeopleNames_listBox.SelectedItem != null)
            {
                var person = PeopleNames_listBox.SelectedItem as PersonInfo;
                SelectedItem_TextBox.Text = person.FullName;
            }
        }
    }

}
