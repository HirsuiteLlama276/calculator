using System;
namespace Kalkulator
{
    ///<summary> Szablon klasy - trzeba w programie wpisać typ </summary>
    class Calculator<T>
    {
        ///<summary>  Dodawanie zmiennych </summary>
        public  void Add(T first, T second)
        {
            dynamic firstnumber = first;
            dynamic secondtnumber = second;
            T result = firstnumber + secondtnumber;
            Console.WriteLine(result);
        }
        /// <summary>Odejmowanie od pierwszej zmiennej drugiej </summary>
        public  void Substract(T first, T second)
        {
            dynamic firstnumber = first;
            dynamic secondtnumber = second;
            T result = firstnumber - secondtnumber;
            Console.WriteLine(result);
        }
        /// <summary> Mnożenie zmiennych </summary>
        public  void Multiply(T first, T second)
        {
            dynamic firstnumber = first;
            dynamic secondtnumber = second;
            T result = firstnumber * secondtnumber;
            Console.WriteLine(result);
        }
        /// <summary> Dzielenie pierwszej zmiennej przez drugą  </summary>
        public  void Divide(T first, T second)
        {
            dynamic firstnumber = first;
            dynamic secondtnumber = second;
            T result = firstnumber / secondtnumber;
            Console.WriteLine(result);
        }

    }
}
