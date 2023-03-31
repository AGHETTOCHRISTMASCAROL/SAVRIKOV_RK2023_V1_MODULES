using _20101_SAVRIKOV_1.Core;
using _20101_SAVRIKOV_1.Entity;
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

namespace _20101_SAVRIKOV_1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Student> students = new List<Student>();
        public MainWindow()
        {
            InitializeComponent();

            try
            {
                students = DataBaseHelper.GetContext().Student.ToList(); //список всех студентов
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            LoadData.ItemsSource = students;
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            List<Student> resultStudents = new List<Student>();

            Student student = new Student();
            string firstName = "Андрей";
            string lastName = "Комаров";

            student = DataBaseHelper.GetContext().Student.Where(s => s.FirstName == firstName && s.LastName == lastName).FirstOrDefault(); //Поиск студента по имени и фамилии

            if(student == null) //Если студент не найдется
            {
                MessageBox.Show($"Студента {firstName} {lastName} не найдено");
                return;
            }
            
            resultStudents.Add(student);
            LoadData.ItemsSource = students;
        }

        private void btnSort_Click(object sender, RoutedEventArgs e)
        {
            List<Student> sortStudents = new List<Student>();
            //sortStudents = DataBaseHelper.GetContext().Student.OrderBy(s => s.IdStudent).ToList();
            sortStudents = DataBaseHelper.GetContext().Student.OrderBy(s => s.LastName).ToList();
            sortStudents.Reverse();
            LoadData.ItemsSource = sortStudents;
        }
    }
}
