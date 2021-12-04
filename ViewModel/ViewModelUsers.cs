using Model;
using System.Windows;
using System.Windows.Input;


namespace ViewModelUsers
{
    
    public class UsersViewModel
    {
        Users myusers = new Users();

        public bool CanUpdate { get; set; }
        public ICommand ButtonCommand()
        {
            myusers.Age =28;
            myusers.Married =false;
        }
        public Users MyUser
        {
            get { return myusers; }
        }

        public UsersViewModel()
        {
            myusers.Id = 1;
            myusers.Name ="Data content binding";
            myusers.Age =18;
            myusers.Job ="worker df";
            myusers.Married =true;

            ButtonCommand = new CommandList();

        }

        public int UserID
        {
            get { return myusers.Id; }
            set { myusers.Id = value; }
        }

        public string UserName
        {
            get { return myusers.Name; }
            set { myusers.Name = value; }
        }

        public int UserAge
        {
            get { return myusers.Age; }
            set { myusers.Age = value; }
        }

        private string useragecolor;
        public string UserAgeColor
        {//method 1
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
            set => myusers.Job = value;
        }

        public bool UserMarried
        {
            get { return myusers.Married; }
            set { myusers.Married = value; }
        }
    }
}