using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enum22
{
    /*
     * Enum (Enumerator):
     * Enum is a value type.
     * To define enum we have to use a keyword called "enum".
     * using enum we can create our own user defined types.
     * enum is a collection of string constants which represents integer constants.
     * 
     * Why enum.
     * here enum will be loaded like a class,
     * 
     * int===>4
     * char[20]==>20
     * float==>4
     * 
     * 
     *  Structure is value type.
     *  when we create an object for structure
     * it will be allocated into stack memory.
     * To define structure we have to use struct keyword.
     * structure is a collection of members like varibales,
     * properties,constructors ,methods and so on...
     * syntax:
     * <access modifiers> struct <structurename>
     * {
     * members
     * }
     * DEfault access modifier of structure is internal.
     * default access modifier of structure members will be private.
     * we can create an object for structure without using new keyword
     * only when the structure doest not have any instance varibales.
     * we cannot define explicit parametersless constructor with in the structure.
     * we cannot initalize instance varibales of a structure by using instance field
     * initializes for this we have to go for either parameterized constructor 
     * or property.
     * structure can contain static members.
     * we cannot have static structure, we can not have abstract structure,we
     * cannot have sealed structure.
     * but we can have partial structuer and generic structure.
     * structure will not support inheritance due to the reason
     * using structure we cannot implement override but we can implement
     * function overloading.
     * Access modifier of structure and structure members can not be protected
     * and protected internal.
     * 
     * Differeence between structure and class.
     *    class                                     structure
     *  1)class keyword                             1)struct keyword.
     *  2)object will be creating                   2)object will be creating with
     *  with in heap memory                             in stack memory.
     *  3)Instance initializers are allowed.        3)Instance initalizers not allowrd.
     *  4)To create object we should use            4)without using new operator 
     *  new keyword.                                 also we can create object.
     *  5)Explict default constructor              5)we cannot have explicit default c
     *  we can have.                                 constructor.
     *  6)we can have static class,                6)we cannot have static,abstract and sealed classes
     *  abstract class and sealed class
     *  7)class will supports inheritance          7)will not support inheritance.
     *  8)class will support function              8)will not support function overriding.
     *  overriding.
     *  9)access modifier of a class               9)Access modifier of a structure cannot be 
     *  and class member can be any file.           protected and protected internal
     *  10)class is reference type.                 10)Structure is value type.

     * 
     * 
     */
    enum weekdays
    {
        Monday=1,
       Tuesday=2,
       Wednesday=3,
       Thursday=4,
       Friday=5,
       Saturday=6,
       Sunday=7
    }
    class myclass
    {
        internal static void Display(weekdays d)
        {
            switch (d)
            {
                case weekdays.Monday:
                    Console.WriteLine("Today is first day of the week");
                    break;
                case weekdays.Tuesday:
                    Console.WriteLine("Today is second day of the week");
                    break;
                case weekdays.Wednesday:
                    Console.WriteLine("Today is third day of the week");
                    break;
                case weekdays.Thursday:
                    Console.WriteLine("Today is fourth day of the week");
                    break;
                case weekdays.Friday:
                    Console.WriteLine("Today is fifth day of the week");
                    break;
                case weekdays.Saturday:
                    Console.WriteLine("Today is sixth day of the week");
                    break;
                case weekdays.Sunday:
                    Console.WriteLine("Today is last day of the week");
                    break;


            }
        }
    }
   
    internal class Program
    {
        static void Main(string[] args)
        {
            weekdays day=weekdays.Wednesday;
            myclass.Display(day);

        }
    }
}
