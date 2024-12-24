using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace OOP
{
    internal struct PhoneBook
    {
        #region Attributes 

        string[] names;
        long[] numbers;
        int size;

        #endregion

        #region Properties

        public int Size { get { return size; } }

        #endregion

        #region Constructor
        public PhoneBook(int _size)
        {
            size = _size;
            names = new string[size];
            numbers = new long[size];
        }
        #endregion

        #region Methods

        public void AddPerson(int position, string name, long number)
        {
            if (names is not null && numbers is not null)
            {
                if (position >= 0 && position < size)
                {
                    names[position] = name;
                    numbers[position] = number;
                }
            }
        }

        #endregion

        #region Encapsulation 

        #region Getter / setter
        public long GetNumber(string name)
        {

            if (names is not null && numbers is not null)
            {
                for (int i = 0; i < names.Length; i++)
                {
                    if (names[i] == name)
                        return numbers[i];
                }
            }
            return -1;
        }
        public void SetNumber(string name, long number)
        {
            if (names is not null && numbers is not null)
            {
                if (names.Length > 0 && numbers.Length > 0)
                {
                    for (int i = 0; i < names.Length; i++)
                    {
                        if (names[i] == name)
                            numbers[i] = number;
                    }
                }
            }

        }

        #endregion

        #region Index

        public long this[string name]
        {
            get
            {
                if (names is not null && numbers is not null)
                {
                    for (int i = 0; i < names.Length; i++)
                    {
                        if (names[i] == name)
                            return numbers[i];
                    }
                }
                return -1;
            }

            set
            {
                if (names is not null && numbers is not null)
                {
                    if (names.Length > 0 && numbers.Length > 0)
                    {
                        for (int i = 0; i < names.Length; i++)
                        {
                            if (names[i] == name)
                                numbers[i] = value;
                        }
                    }
                }
            }
        }

        #endregion

        #endregion


    }
}
