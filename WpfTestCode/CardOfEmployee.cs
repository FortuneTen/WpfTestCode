using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Input;

namespace WpfTestCode
{

    public class DateConvert : IValueConverter
    {
        public static DateConvert InstaConvert = new DateConvert();
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return ((DateTime)value).ToString("dd.MM.yyyy HH:mm:ss");
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    public class UserFormViewModel : INotifyPropertyChanged
    {
        private DelegateCommand firstIncrementCommand;

        public DelegateCommand FirstIncrementCommand
        {
            get
            {
                return firstIncrementCommand ?? (firstIncrementCommand = new DelegateCommand(OnIncrementFirstInputCommand, OnCanIncrementFirstInputCommand));
            }
        }

        #region Bindable Properties

        private int firstInput;
        public int FirstInput
        {
            get { return firstInput; }
            set
            {
                firstInput = value;
                OnPropertyChanged(nameof(FirstInput));
            }
        }

        private void OnIncrementFirstInputCommand(object arg)
        {
            FirstInput += 1;
            FirstIncrementCommand.RaiseCanExecuteChanged();
        }

        // Enable Increment - First button only if first value is less than 5
        private bool OnCanIncrementFirstInputCommand(object arg)
        {
            bool ifFirstInputLessThan5 = firstInput < 5;
            return ifFirstInputLessThan5;
        }

        #region INotifyPropertyChanged implementation

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName = null)
        {
            if (PropertyChanged != null)
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion


        private string nameEmployee;
        public string NameEmployee
        {
            get { return nameEmployee; }
            set
            {
                nameEmployee = value;
                OnPropertyChanged(nameof(NameEmployee));
            }
        }

        private string salary;
        public string Salary
        {
            get { return salary; }
            set
            {
                salary = value;
                OnPropertyChanged(nameof(Salary));
            }
        }

        
       

        private DateTime dateBirthday;
        public DateTime DateBirthday
        {
            get { return dateBirthday; }
            set
            {
                dateBirthday = value;
                OnPropertyChanged(nameof(DateBirthday));
            }
        }

        private string multiplysalary;
        public string MultiplySalary
        {
            get { return multiplysalary; }
            set
            {
                multiplysalary = value;
                OnPropertyChanged(nameof(MultiplySalary));
            }
        }

        private string adress;
        public string Adress
        {
            get { return adress; }
            set
            {
                adress = value;
                OnPropertyChanged(nameof(Adress));
            }
        }
        #endregion


    }
}
