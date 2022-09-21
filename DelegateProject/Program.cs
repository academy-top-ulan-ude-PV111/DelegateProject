namespace DelegateProject
{
    enum OperationType
    {
        Add,
        Mult,
        Min,
        Del
    }


    delegate void VoidMethod();
    delegate int MathOperation(int x, int y);

    delegate T TMathOperation<T>(T x, T y);

    delegate T OneOperation<T, V>(V x);
    class SmsMessgae
    {
        public static void Send()
        {
            Console.WriteLine("Incoming SMS");
        }
    }

    class User
    {
        int age;
        public int Age
        {
            set
            {
                if (value > 0 && value < 100)
                    age = value;
            }
            get => age;
        }
    }


    class HelloPeople
    {
        public void SayHello()
        {
            Console.WriteLine("Hello people");
        }
    }
    internal class Program
    {

        static void Message()
        {
            Console.WriteLine("Hello world");
        }

        static void SayGoodBy()
        {
            Console.WriteLine("Good By");
        }
        static int Add(int a, int b)
        {
            Console.WriteLine("Add work");
            return a + b;
        }

        static int Mult(int a, int b)
        {
            Console.WriteLine("Mult work");
            return a * b;
        }

        static int Min(int a, int b)
        {
            Console.WriteLine("Min work");
            return (a < b ? a : b);
        }

        static MathOperation? SelectOperation(OperationType type)
        {
            switch (type)
            {
                case OperationType.Add:
                    return Add;
                    break;
                case OperationType.Mult:
                    return Mult;
                    break;
                case OperationType.Min:
                    return Min;
                    break;
                case OperationType.Del:
                    return (a, b) => a - b;
                    break;
                default:
                    break;
            }
            return null;
        }

        static double Sqr(float a)
        {
            return a * a;
        }

        static public int Calc(int a, int b, MathOperation operation)
        {
            return operation.Invoke(a, b);
        }

        static void Main(string[] args)
        {
            //VoidMethod? voidMethod = null;

            //voidMethod += Message;
            ////voidMethod();

            //voidMethod += SmsMessgae.Send;
            ////voidMethod();



            //HelloPeople helloPeople = new HelloPeople();
            //helloPeople.SayHello();

            //VoidMethod voidMethod = helloPeople.SayHello;
            //voidMethod();

            //Console.WriteLine("--------------");

            //voidMethod -= SmsMessgae.Send;
            //voidMethod += Message;

            //if (voidMethod != null)
            //    voidMethod();

            //voidMethod -= Message;

            //Console.WriteLine("--------------");

            //voidMethod?.Invoke();

            //voidMethod = new HelloPeople().SayHello;
            //voidMethod();

            //VoidMethod method1 = new VoidMethod(Message);
            //method1 += SmsMessgae.Send;

            //VoidMethod method2 = new VoidMethod(new HelloPeople().SayHello);
            //method2 += SayGoodBy;

            //VoidMethod method3 = method2 + method1;

            //method3?.Invoke();



            //int a = 10, b = 30;
            //MathOperation operation = Add;
            //Console.WriteLine(operation(a, b));
            //Console.WriteLine("--------------");

            //operation += Mult;
            //Console.WriteLine(operation(a, b));
            //Console.WriteLine("--------------");

            //operation += new MathOperation(Min);
            //Console.WriteLine(operation?.Invoke(a, b));


            ////TMathOperation<int> math = Add;
            ////TMathOperation<float> fmath = Add;
            ////TMathOperation<double> dmath = Add;

            //OneOperation<double, float> op = Sqr;

            //int a = 10, b = 30;
            //MathOperation? operation = SelectOperation(OperationType.Add);
            //Console.WriteLine(Calc(a, b, operation!));
            //Console.WriteLine("--------------");
            //operation += Mult;
            //Console.WriteLine(Calc(a, b, operation));
            //Console.WriteLine("--------------");
            //operation += Min;
            //Console.WriteLine(Calc(a, b, operation));
            //Console.WriteLine("--------------");

            //operation = delegate (int a, int b)
            //{
            //    Console.WriteLine("Del work");
            //    return a - b;
            //};

            //operation = (a, b) =>
            //{
            //    Console.WriteLine("Del work");
            //    return a - b;
            //};

            //operation = (a, b) => b / a;

            //Console.WriteLine(Calc(a, b, operation));
            //Console.WriteLine("--------------");

            //Console.WriteLine(Calc(a, b, delegate (int a, int b)
            //{
            //    //Console.WriteLine("Div work");
            //    return b / a;
            //}));

            //Console.WriteLine(Calc(a, b, (a, b) => {
            //    Console.WriteLine("Div work");
            //    return b / a; 
            //}));

            var helloLambda = (string s) => 
            {
                Console.WriteLine("Hello " + s);
                return "Hello " + s; 
            };

            Console.WriteLine(helloLambda.GetType());

            Console.WriteLine(helloLambda("Bob"));
            Console.WriteLine("--------------");



            helloLambda += (s) => 
            {
                Console.WriteLine("Good By " + s);
                return "Good By " + s;
            };

            Console.WriteLine(helloLambda("Joe"));

        }
    }
}