using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using SchoolManagementApp.DAL.Enum;
using SchoolManagementApp.DAL.DTO;
using SchoolManagementApp.DAL.Concrete;
using SchoolManagementApp.DAL.Interface;

namespace SchoolManagementApp.Desktop
{
    
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private IGender _dataService;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {          
            var c = new GenderDTO()
            {               
                Name = genderTextbox.Text,        
            };

            _dataService.SaveGender(c);
        }
    }
}
