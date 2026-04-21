using System.ComponentModel;
using System.IO.Packaging;
using System.Windows.Input;

namespace INotifyPropertyChanged_Exercise_WPF
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        private string _firstName;
        private string _lastName;
        private string _fullName;

        public string FirstName
        {
            get { return _firstName; }
            set 
            {
                _firstName = value;
                OnPropertyChanged(nameof(FirstName));
                UpdateFullNameFromNames();
            }
        }

        public string LastName
        {
            get { return _lastName; }
            set
            {
                _lastName = value;
                OnPropertyChanged(nameof(LastName));
                UpdateFullNameFromNames();
            }
        }

        public string FullName
        {
            get { return _fullName; }
            set
            {
                _lastName = value;
                OnPropertyChanged(nameof(FullName));
                UpdateFullNameFromNames();
            }
        }

        private void UpdateFullNameFromNames()
        {
            _fullName = $"{FirstName} {LastName}";
            OnPropertyChanged(nameof(FullName));
        }

        //ICOMMAND
        public ICommand UpdateCommand { get; }

        private void Update()
        {
            //logica de actualizacion
            FirstName = "updated";
            LastName = "Name";
        }

        private bool CanUpdate()
        {
            return !string.IsNullOrWhiteSpace(FirstName) && !string.IsNullOrWhiteSpace(LastName);
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
