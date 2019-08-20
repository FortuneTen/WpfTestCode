using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace WpfTestCode
{
    class MainWindowViewModel : INotifyPropertyChanged
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

        private string year;
        public string Year
        {
            get { return year; }
            set
            {
                year = value;
                OnPropertyChanged(nameof(Year));
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

        private object selectedItem;
        public object SelectedItem
        {
            get { return selectedItem; }
            set
            {
                selectedItem = value;
                OnPropertyChanged(nameof(SelectedItem));
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
