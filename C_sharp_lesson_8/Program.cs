using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_lesson_8
{

    //struct constant
    //{
    //    public float Value;
    //    public string Name;

    //}
    internal class MathConstant                                     // индексаторы
    {

        static private float pi = 3.14F;
        static private float e = 2.7F;
        //private List<constant> _lst = new List<constant>();
        //public void addConstant(string _name, float _value)
        //{
        //    constant _constant;
        //    _constant.Name = _name;
        //    _constant.Value = _value;
        //    _lst.Insert(0, _constant);
        //}
        public string this[string index_str]
        {
            get
            {
                switch (index_str)
                {
                    case "pi":
                        return pi.ToString();
                    case "e":
                        return e.ToString();
                    default:
                        return "<empty>";
                }
            }
        }
        public float this[int index]
        {
            get
            {
                switch (index)
                {
                    case 0:
                        return pi;
                    case 1:
                        return e;
                    default:
                        return 0;
                }
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
