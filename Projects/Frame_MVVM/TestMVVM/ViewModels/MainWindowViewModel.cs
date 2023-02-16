//======================================================================
//
//        Copyright (C) 2018 Zeek
//        All rights reserved
//
//        Filename :ChildWindowViewModel.cs
//        Description :
//
//        Created by Zeek at  02/06/2018
//        Emai: zhangwen-1-2-3@163.com
//        博客文章地址：http://www.cnblogs.com/SilveryBullet/p/8418401.html
//
//======================================================================
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using MVVMDemo.Base;

namespace TestMVVM.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
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
                });
            }
        }
    }
}
