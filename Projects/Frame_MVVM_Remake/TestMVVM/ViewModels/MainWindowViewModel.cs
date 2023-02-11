using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using TestMVVM.Model;
using MVVMDemo.Base;

namespace TestMVVM.ViewModel
{
    public class UserInfoViewModel : ViewModelBase
    {
        private UserInfo userInfo;

        public UserInfoViewModel()
        {
            this.userInfo = new UserInfo() { Name = "张三", Age = 18 };
        }

        public string Name
        {
            get
            {
                return this.userInfo.Name;
            }
            set
            {
                this.userInfo.Name = value;
                RaisePropertyChanged("Name");
            }
        }

        public int Age
        {
            get { return this.userInfo.Age; }
            set
            {
                this.userInfo.Age = value;
                RaisePropertyChanged("Age");
            }
        }

        private string textBox1Text;
        public string TextBox1Text
        {
            get
            {
                return this.textBox1Text;
            }
            set
            {
                this.textBox1Text = value;
                RaisePropertyChanged("TextBox1Text");
            }
        }

        public ICommand Button1Cmd
        {
            get
            {
                return new DelegateCommand((obj) =>
                    {
                        //button1点击之后要做的事情写在这里
                        // System.Windows.MessageBox.Show("button1 click!");//测试代码
                        this.TextBox1Text = "button1 click!";
                        this.Name = "李四";
                        this.Age = 19;
                    });
            }
        }

        public ICommand Button2Cmd
        {
            get
            {
                return new DelegateCommand((obj) =>
                {
                    this.TextBox1Text = "button2 click!";
                    this.Name = "王五";
                    this.Age = 20;
                });
            }
        }

        // public event PropertyChangedEventHandler PropertyChanged;

        // private void RaisePropertyChanged(String propertyName)
        // {
        //     PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        // }

        // protected virtual void SetAndNotifyIfChanged<T>(String propertyName, ref T oldVal, ref T newVal)
        // {
        //     if (oldVal == null && newVal == null) return;
        //     if (oldVal != null && oldVal.Equals(newVal)) return;
        //     if (newVal != null && newVal.Equals(oldVal)) return;
        //     oldVal = newVal;
        //     RaisePropertyChanged(propertyName);
        // }

    }
}
