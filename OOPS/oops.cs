using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OOPS
{
    public class Oops
    {
        public static int a = 10;
        public int b = 100;
        public static void StaticIncrement()
        {
            a += 1;
            Console.WriteLine(a);
        }
        public void Increment()
        {
            b += 1;
            Console.WriteLine(b);
        }
    }

    #region Polymorphism
    #region Overload
    public class MethodOverloading
    {
        public int Overload(int a)
        {
            a = 100;
            return a;
        }
        private void Overload(string name)
        {
            Console.WriteLine(name);
        }
        public void OverloadFun()
        {
            Overload("Private Method");
        }
    }

    #endregion Overload

    #region Overriding

    public class MethodOverriding
    {
        public virtual string Overriding(string name)
        {
            return name;
        }
    }

    public class OverridInherit : MethodOverriding
    {
        public override string Overriding(string name)
        {
            name = "String";
            return name;
        }
    }

    #endregion Overriding
    #endregion Polymorphism

    #region Abstract

    public abstract class absBase
    {
        public abstract int AddTwoNumbers(int Num1, int Num2);
        public abstract int MultiplyTwoNumbers(int Num1, int Num2);
    }

    #endregion Abstract

    #region Encapsulation

    public class Student
    {
        public string Name;
        public int StudentId;
        private void DBConnection()
        {
            // ConnectionString.
        }
        private void Validation()
        {
            // Validation Process.
        }
        public void Add() // How to Implement.
        {
            DBConnection();
            Validation();
        }
        public void StudentDetail() // Abstract (Our Thought Process)
        {
            Student student = new Student();
            student.Name = "Manish";
            student.StudentId = 472;
            student.Add(); // Encapsulation (Hidding DBConnection,Validation Method inside Add Method).
        }
    }

    #endregion Encapsulation

    #region ReferenceType

    public class RefOut
    {
        public void ReferenceType()
        {
            string value = "Hi";
            GetValue(value);
            Console.WriteLine(value);
            GetRefValue(ref value);
            Console.WriteLine(value);
        }
        public void GetValue(string value)
        {
            value = "Hello World";
        }


        public void GetRefValue(ref string value)
        {
            value = "Hello World in Reference";
        }
        public void OutType()
        {
            int value = 10;
            OutIncreament(out value);
        }
        public void OutIncreament(out int value)
        {
            value = 0;
            value = value + 20;
        }
    }

    #endregion ReferenceType

    #region Override Keyword
    public class OverrideA
    {
        public virtual void show()
        {
            Console.WriteLine("Hello: Base ClassA!");
        }
    }

    public class OverrideB : OverrideA
    {
        public override void show()
        {
            Console.WriteLine("Hello: Derived ClassB!");
        }
    }
    public class OverrideC : OverrideB
    {
        public new void show()
        {
            Console.WriteLine("Am Here ClassC!");
        }
    }

    #endregion Override Keyword

    #region IEnumuratorVsIEnumurable

    public class MethodEnumuator
    {
        public List<int> MethodYear()
        {
            for (int i = 2001; i < 2010; i++)
            {
                Year.Add(i);
            }
            return Year.ToList();
        }
        #region Enumurable
        public void FirstEnumurable()
        {
            List<int> year = MethodYear();
            foreach (int i in year)
            {
                Console.WriteLine(i);
                if (i > 2005)
                {
                    SecondEnumurable(year);
                }
            }

        }
        public void SecondEnumurable(IEnumerable<int> year)
        {
            foreach (int i in year)
            {
                Console.WriteLine(i);
            }
        }
        #endregion Enumurable

        #region Enumurator
        public void FirstMethod()
        {
            List<int> year = MethodYear();
            IEnumerator<int> list = year.GetEnumerator();
            while (list.MoveNext())
            {
                Console.WriteLine(list.Current.ToString());
                if (Convert.ToInt16(list.Current) > 2005)
                {
                    SecondMethod(list);
                }
            }

        }
        public void SecondMethod(IEnumerator<int> year)
        {
            while (year.MoveNext())
            {
                Console.WriteLine(year.Current.ToString());
            }
        }
        #endregion Enumurator

        List<int> Year = new List<int>();
    }

    #endregion IEnumurator

    #region InterFace

    public class SampleInterface : IEmp
    {
        public void GetEmpDetailById(int Id)
        {
            Console.WriteLine("InterFace GetEmpDetailById : " + Id);
        }

        public void GetEmpName(string Name)
        {
            Console.WriteLine("InterFace GetEmpName : " + Name);
        }
    }

    #endregion InterFace

    #region Delegates

    #region SingleDeletegat

    public delegate int SingleDelegatSample(int a, int b);
    public class SingleDelegatClass
    {
        public int Add(int x, int y)
        {
            return x + y;
        }
        public int Sub(int x, int y)
        {
            return x - y;
        }
    }

    #endregion SingleDeletegat

    #region MultipleDeletegat

    public delegate void MultiDelegat(int a, int b);
    public class MultipleDelegatclass
    {
        public void Add(int x, int y)
        {
            Console.WriteLine("---- MultiDelegat Addition Value: " + (x + y));
        }
        public void Sub(int x, int y)
        {
            Console.WriteLine("---- MultiDelegat Subtraction Value: " + (x - y));
        }
        public void Mul(int x, int y)
        {
            Console.WriteLine("---- MultiDelegat Multiply Value: " + (x * y));
        }
    }

    #endregion MultipleDeletegat

    #endregion Delegates


    public class StaticMethod : absBase
    {
        static Oops objStaticApp = new Oops();
        static MethodOverloading objOverload = new MethodOverloading();
        static MethodOverriding objOverrid = new MethodOverriding();
        static StaticMethod objMethod = new StaticMethod();
        delegate int AddAnonymous(int x, int y);
        static RefOut refOut = new RefOut();
        static SampleInterface inter = new SampleInterface();
        static MethodEnumuator method = new MethodEnumuator();
        static SingleDelegatClass singleDeleget = new SingleDelegatClass();
        static MultipleDelegatclass multipleDeleget = new MultipleDelegatclass();

        static string result;
        static volatile bool done;
        static void SetVolatile()
        {
            result = "Csharpcorner.com";
            done = true;
        }

        static void Main(string[] args)
        {
            method.FirstMethod();
            //method.FirstEnumurable();
            inter.GetEmpDetailById(2);
            inter.GetEmpName("Name");

            double d2 = 5673.74;
            int i1;
            string s = "123";
            int i2;
            // cast double to int.
            i1 = (int)d2;
            i2 = Convert.ToInt16(s);
            Console.WriteLine("Casting From Double to Int : " + i1);
            Console.WriteLine("Casting From String to Int : " + i2);

            new Thread(new ThreadStart(SetVolatile)).Start();
            Thread.Sleep(900);
            if (done)
            {
                Console.WriteLine(result);
            }

            SingleDelegatSample objSingleDeleget = singleDeleget.Add;
            int sda = objSingleDeleget(10, 10);
            Console.WriteLine("---- SingleDelegat Addition Value : " + sda);
            objSingleDeleget = singleDeleget.Sub;
            int sds = objSingleDeleget(10, 5);
            Console.WriteLine("---- SingleDelegat Subtraction Value : " + sds);

            MultiDelegat objMultipleDeleget = multipleDeleget.Add;
            objMultipleDeleget += multipleDeleget.Sub;
            objMultipleDeleget += multipleDeleget.Mul;
            objMultipleDeleget(50, 20);

            refOut.ReferenceType();
            refOut.OutType();

            OverrideA overridea = new OverrideA();
            overridea.show();
            OverrideB overrideb = new OverrideB();
            overrideb.show();
            OverrideA overrideab = new OverrideB();
            overrideab.show();

            OverrideC overridec = new OverrideC();
            overridec.show();
            OverrideA overrideac = new OverrideC();
            overrideac.show();
            OverrideB overridebc = new OverrideC();
            overridebc.show();

            string str = Constant.Name;

            object a = str;
            if (str is string)
            {
                Console.WriteLine("---- 'Is' is True ----");
            }
            else
                Console.WriteLine("---- 'Is' is False ----");

            string b = a as string;
            if (b != null)
            {
                Console.WriteLine("---- 'As' Function True ----");
            }
            else
                Console.WriteLine("---- 'As' Function False ----");

            for (int i = 0; i < 10; i++)
            {
                Stopwatch watch = new Stopwatch();
                watch.Reset();
                watch.Start();
                if (i == 0)
                {
                    Console.WriteLine("---- Start Recording Anonymous Function ----");
                }
                for (int j = 0; j < 1000; j++)
                {
                    AddAnonymous d1 = delegate (int x, int y) { return x + y; };

                    int z1 = d1(5, 4);
                }
                Console.WriteLine(watch.ElapsedTicks.ToString());
                watch.Stop();
            }

            for (int p = 0; p < 10; p++)
            {
                Stopwatch watch = new Stopwatch();
                watch.Reset();
                watch.Start();
                if (p == 0)
                {
                    Console.WriteLine("---- Start Recording Named Delegate Function ----");
                }
                for (int q = 0; q < 1000; q++)
                {
                    AddAnonymous d = Add;
                    int z1 = d(5, 4);
                }
                Console.WriteLine(watch.ElapsedTicks.ToString());
                watch.Stop();
            }


            for (int i = 0; i < 5; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine("---- Start Static Function ----");
                }
                //objStaticApp = new StaticFunction();
                Oops.StaticIncrement();
                objStaticApp.Increment();
            }
            Console.WriteLine(Oops.a);
            Console.WriteLine(objStaticApp.b);
            Console.WriteLine("---- End Static Function ----");

            Console.WriteLine("---- Start Overloading Function");
            Console.WriteLine(objOverload.Overload(9));
            objOverload.OverloadFun();
            Console.WriteLine("---- End Overloading Function ----");

            Console.WriteLine("---- Start Overriding Function ----");
            Console.WriteLine(objOverrid.Overriding("Override Function"));
            Console.WriteLine("---- End Overriding Function ----");

            int added = objMethod.AddTwoNumbers(5, 5);
            int multiplied = objMethod.MultiplyTwoNumbers(5, 5);
            Console.WriteLine("Added : {0}, Multiplied: {1}", added, multiplied);
            Console.ReadLine();
        }

        static int Add(int x, int y)
        {
            return x + y;
        }

        public override int AddTwoNumbers(int Num1, int Num2)
        {
            return Num1 + Num2;
        }

        public override int MultiplyTwoNumbers(int Num1, int Num2)
        {
            return Num1 + Num2;
        }
    }
}
