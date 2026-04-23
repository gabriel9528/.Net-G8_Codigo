using System.ComponentModel;
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
                _fullName = value;
                OnPropertyChanged(nameof(FullName));
                UpdateNamesFromFullName();
            }
        }

        public MainWindowViewModel()
        {
            UpdateCommand = new RelayCommand(Update, CanUpdate);
            _firstName = string.Empty;
            _lastName = string.Empty;
            UpdateFullNameFromNames();
        }

        //ICOMMAND
        public ICommand UpdateCommand { get; }

        private void Update()
        {
            //logica de actualizacion
            FirstName = "firstName";
            LastName = "lastName";
        }

        private bool CanUpdate()
        {
            return !string.IsNullOrWhiteSpace(FirstName) && !string.IsNullOrWhiteSpace(LastName);
        }

        private void UpdateFullNameFromNames()
        {
            _fullName = $"{FirstName} {LastName}";
            OnPropertyChanged(nameof(FullName));
        }


        private void UpdateNamesFromFullName()
        {
            var names = _fullName.Split(new[] { ' ' }, 2);
            if(names.Length == 2)
            {
                FirstName = names[0];
                LastName = names[1];
            }
            else
            {
                FirstName = _fullName;
                LastName = "";
            }
        }



        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
