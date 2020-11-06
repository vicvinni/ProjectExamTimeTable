using ExamTimetableBusiness;
using Microsoft.EntityFrameworkCore.Query;
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
using System.Windows.Shapes;

namespace ExamTimetableWPF
{
    /// <summary>
    /// Interaction logic for LoadProfile.xaml
    /// </summary>
    public partial class CreateProfile : Window
    {
        private CRUDManager _crudManager = new CRUDManager();
        public CreateProfile()
        {
            InitializeComponent();
            populateDropDownSubjects(); 
        }

        private void populateDropDownSubjects()
        {
            ddSelectSubjects.ItemsSource = _crudManager.RetrieveAllSubjects(); 
        }

        private void ddSelectSubjects_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            populateDropDownSubjects();
        }

        private void btnSaveProfile_Click(object sender, RoutedEventArgs e)
        {
            _crudManager.newStudent(txtFirstName.Text, txtLastName.Text, Convert.ToDateTime(txtDateOfBirth.Text), Convert.ToInt32(txtYear.Text), txtClass.Text, txtCity.Text); 
            //See Exam Calander after saving
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            new MainWindow().Show(); 
        }

        private void lstbxSubjects_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(lstbxSubjects.SelectedItem != null )
            {
                _crudManager.setSelectedSubject(lstbxSubjects.SelectedItem); 
            }
        }
    }
}
