using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DataContextDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Student s1 = new Student("Randy"); // constructor sets property StudentName on each Student
            Student s2 = new Student("Joey");
            Student s3 = new Student("Lulu");

            // Connect TextBox1 to a Student Object
            // The binding will then extract the StudentName property
            TextBox1.DataContext = s1;
            Course CourseRoster = new Course();
            CourseRoster.addStudent(s1);
            CourseRoster.addStudent(s2);

            // Connect ListBox1 to an IEnumerable (in this case a List)
            // For each item in the List, the binding in the XAML extracts the StudentName property again
            ListBox1.ItemsSource = CourseRoster.Students;

            // Test of item changes after we have set our sources
            CourseRoster.addStudent(s3);
            s1.StudentName = "Cesar";
        }
    }
}