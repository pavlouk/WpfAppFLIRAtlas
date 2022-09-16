using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfAppFLIRAtlas.Models;

namespace WpfAppFLIRAtlas.ViewModels
{
    public class SecondChildViewModel : Screen
    {
        private string _firstName = "Tolis";
        private string _lastName = "Voskopoulos";
        private PersonModel _selectedPerson;
        private BindableCollection<PersonModel> _people = new BindableCollection<PersonModel>();
        

        // constructor used to simulate populated data
        public SecondChildViewModel()
        {
            People.Add(new PersonModel { FirstName = "Vik", LastName = "Geek" });
            People.Add(new PersonModel { FirstName = "Vikos", LastName = "Taramitri" });
            People.Add(new PersonModel { FirstName = "Vikolleta", LastName = "Koukarea" });

        }

        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
                NotifyOfPropertyChange(nameof(FirstName));
                NotifyOfPropertyChange(nameof(FullName));

            }
        }

        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
                NotifyOfPropertyChange(nameof(LastName));
                NotifyOfPropertyChange(nameof(FullName));

            }
        }

        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }

        public PersonModel SelectedPerson
        {
            get
            {
                return _selectedPerson;
            }
            set
            {
                _selectedPerson = value;
                NotifyOfPropertyChange(nameof(SelectedPerson));
            }
        }

        public BindableCollection<PersonModel> People
        {
            get 
            { 
                return _people; 
            }
            set 
            { 
                _people = value; 
            }
        }
                
        public bool CanClearText(string firstName, string lastName)
        {
            //return !String.IsNullOrEmpty(firstName) || !String.IsNullOrEmpty(lastName);
            if (String.IsNullOrEmpty(firstName) && String.IsNullOrEmpty(lastName))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public void ClearText(string firstName, string lastName)
        {
            FirstName = "";
            LastName = "";
        }

    }
}
