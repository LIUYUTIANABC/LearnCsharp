using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Microsoft.Win32;
using Template.Commands;

namespace Template.ViewModels
{
    public class MainWindowViewModel : NotificationObject
    {
        public MainWindowViewModel()
        {
            AddCommand = new DelegateCommand();
            AddCommand.ExecuteAction = new Action<object>(Add);
            SaveCommand = new DelegateCommand();
            SaveCommand.ExecuteAction = new Action<object>(Save);
        }

        private double input1;
        public double Input1
        {
            get{  return input1;  }
            set
            {
                input1 = value;
                RaisePropertyChanged("Input1");
            }
        }

        private double input2;
        public double Input2
        {
            get{  return input2;  }
            set
            {
                input2 = value;
                RaisePropertyChanged("Input2");
            }
        }

        private double resulte;
        public double Resulte
        {
            get{  return resulte;  }
            set
            {
                resulte = value;
                RaisePropertyChanged("Resulte");
            }
        }

        public DelegateCommand AddCommand{ get; set; }
        public DelegateCommand SaveCommand{ get; set; }

        private void Save(object parameter)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.ShowDialog();
        }

        private void Add(object parameter)
        {
            Resulte = input1 + input2;
        }
    }
}
