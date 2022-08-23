using System;
using System.Collections.Generic;
using System.Text;

namespace MistakesCheck
{
    internal class Employee
    {
        private int _age;
        private string _name;
        private double _salary;
        public Employee(int age, string name, double salary)
        {
            Age = age;
            Name = name;
            Salary = salary;
        }
        public int Age
        {
            get { return _age; }
            set
            {
                if (value < 18)
                {
                    throw new ArgumentException();
                    //  throw new Exception("Лицам до 18 регистрация запрещена");
                }
                else
                {
                    _age = value;
                }
            }
        }
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {

                if (string.IsNullOrEmpty(value) || value.Length >= 100)
                {
                    //  throw new Exception("Длина имени меньше 2 символов");
                    throw new ArgumentException();
                }
                else
                {
                    _name = value;
                    Console.WriteLine($" Введенное имя: {value}");
                }
            }
        }
        public double Salary
        {
            get { return _salary; }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentNullException();
                    //throw new Exception("Зарплата должна быть равна больше 0");
                }
                else
                {
                    _salary = value;
                }
            }
        }
    }
}
