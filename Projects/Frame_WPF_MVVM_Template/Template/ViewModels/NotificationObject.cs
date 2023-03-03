using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace Template.ViewModels
{
    public class NotificationObject : INotifyPropertyChanged  // 继承 消息属性改变 接口
    {
        // 接口的实现
        public event PropertyChangedEventHandler PropertyChanged;

        // 自己写的通知方法
        public void RaisePropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
