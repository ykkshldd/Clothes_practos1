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

using Clotes_practos1111.Сlothing_storeDataSetTableAdapters;
namespace Clotes_practos1111
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Store_Employees_RusTableAdapter employees = new Store_Employees_RusTableAdapter();
        Clothes_RusTableAdapter clothes = new Clothes_RusTableAdapter();
        public MainWindow()
        {
            InitializeComponent();
            EmployeesDataGrid.ItemsSource = employees.GetData();
            EmployeesDataGrid.DisplayMemberPath = "Фамилия сотрудника";

            ClothesDataGrid.ItemsSource = clothes.GetData();
            ClothesDataGrid.DisplayMemberPath = "Название одежды";
        }
            public void ShowEmployess_Click(object sender, RoutedEventArgs e)
            {
                EmployeesDataGrid.Visibility = Visibility.Visible;
                ClothesDataGrid.Visibility = Visibility.Collapsed;
            }
            public void ShowClothes_Click(object sender, RoutedEventArgs e)
            {
                EmployeesDataGrid.Visibility = Visibility.Collapsed;
                ClothesDataGrid.Visibility = Visibility.Visible;
            }

    }
}
