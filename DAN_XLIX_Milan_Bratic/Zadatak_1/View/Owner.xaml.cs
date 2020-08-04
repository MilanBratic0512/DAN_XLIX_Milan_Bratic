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
using System.Windows.Shapes;
using Zadatak_1.Model;

namespace Zadatak_1.View
{
    /// <summary>
    /// Interaction logic for Owner.xaml
    /// </summary>
    public partial class Owner : Window
    {
        Zadatak_49Entities context = new Zadatak_49Entities();
        public Owner()
        {
            InitializeComponent();
        }

        private void BtnManager(object sender, RoutedEventArgs e)
        {
            try
            {
                tblManager manager = new tblManager();
                manager.FullName = managerName.Text;
                manager.DateOfBirth = DateTime.Parse(managerDateOfBirth.Text);
                manager.Mail = managerMail.Text;
                manager.HotelFloor = int.Parse(managerFloor.Text);
                manager.Username = managerUsername.Text;
                manager.MannagerPassword = managerPassword.Text;
                manager.ProfessionalQualifications = qualifications.Text;
                manager.Experience = int.Parse(experience.Text);
                context.tblManagers.Add(manager);
                context.SaveChanges();
            }
            catch (Exception)
            {
                MessageBox.Show("Incorect entry");
            }

        }

        private void BtnEmployer(object sender, RoutedEventArgs e)
        {

            try
            {
                tblEmployer employer = new tblEmployer();
                employer.Citizenship = citizenship.Text;
                employer.DateOfBirth = DateTime.Parse(employerDateOfBirth.Text);
                employer.EmployerPassword = employerPassword.Text;
                employer.Engagement = engagment.Text;
                employer.FullName = employerName.Text;
                employer.Gender = gender.Text;
                employer.HotelFloor = int.Parse(employerFloor.Text);
                employer.Mail = employerMail.Text;
                employer.Salary = decimal.Parse(salary.Text);
                employer.Username = employerUsername.Text;
                context.tblEmployers.Add(employer);
                context.SaveChanges();
            }
            catch (Exception)
            {
                MessageBox.Show("Incorect entry");
            }
        }
    }
}
