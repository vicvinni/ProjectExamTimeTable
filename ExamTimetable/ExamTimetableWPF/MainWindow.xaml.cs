using ExamTimetableBusiness;
using System;
using System.Windows;
using System.Windows.Controls;

using System.Linq;
using System.Windows;

namespace ExamTimetableWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private CRUDManager _crudManager = new CRUDManager();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnCreateProfile_Click(object sender, RoutedEventArgs e)
        {
            new CreateProfile().Show();
            this.Close();
        }

        private void BtnLoadProfile_Click(object sender, RoutedEventArgs e)
        {
            //new LoadProfile().Show();
        }

        private void BtnExamCalander_Click(object sender, RoutedEventArgs e)
        {
           // new ExamCalander.show();
            //this.Close(); 
        }
    }
}
