

using System.ComponentModel;

namespace Test
{
    public class Model: INotifyPropertyChanged
    {
        private int content;
        public int MyContent
        {
            get { return content; }
            set
            {
                content = value;
                OnPropertyChanged("MyContent");
            }
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
