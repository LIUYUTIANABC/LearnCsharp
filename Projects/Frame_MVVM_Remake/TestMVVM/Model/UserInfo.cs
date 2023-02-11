using System;
using System.Collections.Generic;
using System.Text;

namespace TestMVVM.Model
{
  public  class UserInfo
    {
        private String _Name;
        private int _Age;
        public string Name { get => _Name; set => _Name = value; }
        public int Age { get => _Age; set => _Age = value; }
    }
}
