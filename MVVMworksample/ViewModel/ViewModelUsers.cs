using Model;
using MVVMworksample.Commands;
using System.ComponentModel;
using System.Windows;
using System.Windows.Input;


namespace MVVMworksample.ViewModel
{

    public class UsersViewModel : INotifyPropertyChanged
    {
        Users myusers = new Users();

        public bool CanSaveButtonUpdate
        {
            get
            {
                return !string.IsNullOrEmpty(UserName);
            }
        }


        public bool CanUpdateButtonUpdate
        {
            get
            {
                return UserAge > 10;
            }
        }


        public ICommand SaveButtonCommand
        {
            get;
            private set;
        }

        public ICommand UpdateButtonCommand
        {
            get;
            private set;
        }

        public Users MyUser
        {
            get { return myusers; }
        }

        public void SaveChangeButton()
        {
            UserID = 1;
            UserName ="Data content binding";
            UserAge =18;
            UserJob ="worker df";
            UserMarried =true;

        }
        public void UpdateButton()
        {
            UserID = 2;
            UserName ="Update content binding";
            UserAge =118;
            UserJob ="nooooooooo";
            UserMarried =false;


        }

        public UsersViewModel()
        {
            myusers.Id = 1;
            myusers.Name ="Data content binding";
            myusers.Age =18;
            myusers.Job ="worker df";
            myusers.Married =true;

            SaveButtonCommand = new Commands.SaveCommand(this);
            UpdateButtonCommand = new UpdateCommand(this);

        }

        public int UserID
        {
            get { return myusers.Id; }
            set { myusers.Id = value; 
                OnPropertyChanged("UserID"); }
        }

        public string UserName
        {
            get { return myusers.Name; }
            set
            {
                myusers.Name = value;
                OnPropertyChanged("UserName");
            }
        }

        public int UserAge
        {
            get { return myusers.Age; }
            set
            {
                myusers.Age = value;
                OnPropertyChanged("UserAge");
                OnPropertyChanged("UserAgeColor");
            }
        }


        public string UserAgeColor
        {//
            get
            {
                if (myusers.Age > 20)
                    return "Green";
                else
                    return "Red";
            }
        }


        public string UserJob
        {
            get => myusers.Job;
            set
            {
                myusers.Job = value;
                OnPropertyChanged("UserJobe");
            }
        }

        public bool UserMarried
        {
            get { return myusers.Married; }
            set { myusers.Married = value; OnPropertyChanged("UserMarried"); }
        }



        public event PropertyChangedEventHandler? PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyname)
        {

            //this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyname));
            }
        }
    }
}