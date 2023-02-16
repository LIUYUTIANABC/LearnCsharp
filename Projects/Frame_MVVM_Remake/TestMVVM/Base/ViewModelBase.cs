//======================================================================
//
//        Copyright (C) 2018 Zeek
//        All rights reserved
//
//        Filename :ViewModelBase.cs
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
using System.ComponentModel;

namespace MVVMDemo.Base
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisePropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
