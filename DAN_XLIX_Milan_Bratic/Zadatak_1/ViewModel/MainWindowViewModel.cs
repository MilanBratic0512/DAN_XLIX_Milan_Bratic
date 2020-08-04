using System;
using System.IO;
using System.Windows;
using System.Windows.Input;
using Zadatak_1.Command;
using Zadatak_1.Model;
using Zadatak_1.View;

namespace Zadatak_1.ViewModel
{
    class MainWindowViewModel : ViewModelBase
    {
        static string path = "../../OwnerAccess.txt";
        string[] ownerUsernameAndPassword = File.ReadAllLines(path);
        Zadatak_49Entities context = new Zadatak_49Entities();
        MainWindow main;
        public MainWindowViewModel()
        {

        }
        public MainWindowViewModel(MainWindow mainOpen)
        {
            main = mainOpen;
        }
        private string username;
        public string Username
        {
            get
            {
                return username;
            }
            set
            {
                username = value;
                OnPropertyChanged("Username");
            }
        }
        private string password;
        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
                OnPropertyChanged("Password");
            }
        }

        private ICommand login;
        public ICommand Login
        {
            get
            {
                if (login == null)
                {
                    login = new RelayCommand(param => LoginExecute(), param => CanLoginExecute());
                }
                return login;
            }
        }
        /// <summary>
        /// Method for determining which user has logged in
        /// </summary>
        private void LoginExecute()
        {
            try
            {
                //iz admin is logged
                if (Username == ownerUsernameAndPassword[0] && Password == ownerUsernameAndPassword[1])
                {
                    Owner owner = new Owner();
                    owner.ShowDialog();
                }
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());

            }
        }
        //can press button only if both fields are not empty
        private bool CanLoginExecute()
        {
            if (String.IsNullOrEmpty(Password) || String.IsNullOrEmpty(Username))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private ICommand close;
        public ICommand Close
        {
            get
            {
                if (close == null)
                {
                    close = new RelayCommand(param => CloseExecute(), param => CanCloseExecute());
                }
                return close;
            }
        }
        private void CloseExecute()
        {
            main.Close();
        }
        private bool CanCloseExecute()
        {
            return true;
        }
       
    }
}
