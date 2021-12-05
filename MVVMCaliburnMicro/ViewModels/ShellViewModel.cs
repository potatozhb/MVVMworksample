using Caliburn.Micro;
using MVVMCaliburnMicro.Models;

namespace MVVMCaliburnMicro.ViewModels
{
    public class ShellViewModel:Conductor<object>
    {
        private string _firstname = "Joe";
        public string FirstName
        {
            get { return _firstname;}
            set 
            { 
                _firstname = value;
                NotifyOfPropertyChange(() => FirstName);
                NotifyOfPropertyChange(()=>FullName);
            }
        }

        private string _lastname;
        public string LastName
        {
            get { return _lastname; }
            set
            { 
                _lastname = value; 
                NotifyOfPropertyChange(()=>LastName);
                NotifyOfPropertyChange(()=>FullName);
            }
        }


        public string FullName
        {
            get { return $"{FirstName} {LastName}"; }

        }

        private BindableCollection<PersonModel> _people = new BindableCollection<PersonModel>();
        public BindableCollection<PersonModel> People
        {
            get { return _people; }
            set { _people = value; }
        }

        private PersonModel _selectedperson;
        public PersonModel SelectedPerson
        {
            get { return _selectedperson; }
            set 
            { 
                _selectedperson = value; 
                NotifyOfPropertyChange(()=>SelectedPerson);
            }
        }

        public ShellViewModel()
        {
            People.Add(new PersonModel { FirstName ="Joe", LastName ="Zhao" });
            People.Add(new PersonModel { FirstName ="Steven", LastName ="Fenson" });
            People.Add(new PersonModel { FirstName ="Sharon", LastName ="Wan" });
            People.Add(new PersonModel { FirstName ="Zach", LastName ="Cool" });
        }

        public bool CanClearText(string firstName, string lastName)
        {
            return !string.IsNullOrWhiteSpace(firstName) || !string.IsNullOrWhiteSpace(lastName);
        }
        public void ClearText(string firstName, string lastName)
        {
            FirstName ="";
            LastName ="";
        }


        public void LoadPageOne()
        {
            ActivateItemAsync(new FirstChildViewModel());

        }
        public void LoadPageTwo()
        {
            ActivateItemAsync(new SecondChildViewModel());

        }
    }
}
