using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Security.AccessControl;

public class addition
{
    
    
        private int _frontn;
        private int _backn;

        public addition()
        {
            _frontn = 1;
            _backn = 1;
        }

        public addition(int wholenumber)
        {
            _frontn = wholenumber;
            _backn = 1;
        }

        public addition(int front, int back)
        {
            _frontn = front;
            _backn = back;
        }

        public string GetaddString()
        {
            return $"{_frontn} + {_backn}";

        }

        public int Gettotvalue()
        {
            return _frontn + _backn;
        }

    
}