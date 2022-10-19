using System;
using System.Data;

namespace OOPs1
{
    #region Class,Feilds,Methods And Objects
    //class Student
    //{
    //    int Sid;
    //    string Name;
    //    double M1, M2;

    //    public void CreateStudent(int id,string name)
    //    {
    //        Sid = id;
    //        Name = name;
    //    }

    //    public void SetMarks(double m1,double m2)
    //    {
    //        M1 = m1;
    //        M2 = m2;
    //    }

    //    public void Result()
    //    {
    //        double avg = (M1 + M2) / 2;
    //        if(avg>=35)
    //        {
    //            Console.WriteLine("Pass");
    //        }
    //        else
    //        {
    //            Console.WriteLine("Fail");
    //        }
    //    }
    //}
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Student S;
    //        S = new Student();

    //        Console.WriteLine("Enter Sid And Name");
    //        int id = int.Parse(Console.ReadLine());
    //        string name = Console.ReadLine();

    //        S.CreateStudent(id, name); //Initialize Object Explicitly - issue 1

    //        Console.WriteLine("Enter Marks 1 and 2");
    //        double m1 = double.Parse(Console.ReadLine());
    //        double m2 = double.Parse(Console.ReadLine());

    //        S.SetMarks(m1, m2);

    //        S.Result();

    //        S.CreateStudent(200, "raju"); //Re-initialize the object - issue 2


    //        //Student S1 = new Student();
    //        //S1.CreateStudent(200, "raju");

    //       Console.ReadLine();


    //    }
    //} 
    #endregion

    #region Constructors
    //class Student
    //{
    //    int Sid;
    //    string Name;
    //    double M1, M2;

    //    public Student()
    //    {
    //        Console.WriteLine("This is default Constructor");
    //    }

    //    public Student(int id, string name)
    //    {
    //        Sid = id;
    //        Name = name;
    //    }

    //    public void SetMarks(double m1, double m2)
    //    {
    //        M1 = m1;
    //        M2 = m2;
    //    }

    //    public void Result()
    //    {
    //        double avg = (M1 + M2) / 2;
    //        if (avg >= 35)
    //        {
    //            Console.WriteLine("Pass");
    //        }
    //        else
    //        {
    //            Console.WriteLine("Fail");
    //        }
    //    }
    //}
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Student S1 = new Student(200,"raju");


    //        Student S = new Student(100,"Peter");

    //        S.SetMarks(23, 45);

    //        S.Result();

    //        //S.Student(200, "raju");

    //        Console.ReadLine();
    //    }
    //} 
    #endregion


    #region Static-Feilds,Constructors,Properties & Methods
    //class HousingLoanCustomer
    //{
    //    int CustomerId;
    //    string Name;
    //    double LoanAmount;
    //    static double _ROI;

    //    public static double ROI
    //    {
    //        get { return _ROI; }
    //        set { _ROI = value; }
    //    }

    //    static HousingLoanCustomer()
    //    {
    //        _ROI = 11.2;
    //    }

    //    public HousingLoanCustomer(int CustomerId, string Name, double LoanAmount)
    //    {
    //        this.CustomerId = CustomerId;
    //        this.Name = Name;
    //        this.LoanAmount = LoanAmount;
    //    }

    //    public void CalculateIntrest(int months)
    //    {
    //        double IntAmount = LoanAmount * _ROI / 100;
    //        double RePayAmount = LoanAmount + IntAmount;
    //        Console.WriteLine("Loan Amount:{0} IntAmount:{1} RePayAmount:{2} ROI:{3}", LoanAmount, IntAmount, RePayAmount, _ROI);
    //        Console.WriteLine("EMI:" + (RePayAmount / months));
    //    }

    //    public static void Enquiry(double EnLoanAmount, int months)
    //    {
    //        Console.WriteLine("ROI :" + ROI);
    //        Console.WriteLine("Loan Amount:" + EnLoanAmount);
    //        Console.WriteLine("IntAmount:" + EnLoanAmount * ROI / 100);
    //        Console.WriteLine("RepayAmount:" + (EnLoanAmount + (EnLoanAmount * ROI / 100)));
    //        Console.WriteLine("EMI Months:" + months);
    //        Console.WriteLine("EMIs:" + (EnLoanAmount + (EnLoanAmount * ROI / 100)) / months);
    //    }
    //}
    //class Program
    //{      
    //    static void Main(string[] args)
    //    {

    //        var loanCustomer1 = new HousingLoanCustomer(1, "Peter", 75000);
    //        loanCustomer1.CalculateIntrest(12);

    //        var loanCustomer2 = new HousingLoanCustomer(2, "Jack", 85000);
    //        loanCustomer2.CalculateIntrest(24);

    //        HousingLoanCustomer.ROI = 11.5;

    //        loanCustomer1.CalculateIntrest(12);
    //        loanCustomer2.CalculateIntrest(24);

    //        HousingLoanCustomer.Enquiry(60000, 24);

    //        //var loanCustomer3 = new HousingLoanCustomer(3, "Lily", 175000);
    //        //var loanCustomer4 = new HousingLoanCustomer(4, "Bob", 80000);

    //        Console.ReadLine();
    //    }
    //} 
    #endregion

    #region Static - Class
    //static class Calculation
    //{
    //    public static void Add(int a,int b)
    //    {
    //        Console.WriteLine("Additin is " + (a + b));
    //    }
    //    public static void Multiply(int a, int b)
    //    {
    //        Console.WriteLine("multiplication is " + (a * b));
    //    }
    //}
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        //Calculation C;
    //        //C = new Calculation();

    //        Calculation.Add(23, 45);
    //        Calculation.Multiply(34, 67);
    //        Console.ReadLine();
    //    }
    //} 
    #endregion


    using System;

    #region InheritanceEg
    //namespace InheritanceEg1
    //{
    //    class Customer
    //    {
    //        public int CustomerId { get; set; }
    //        public string Name { get; set; }
    //        public string Email { get; set; }

    //        public void Details()
    //        {
    //            Console.WriteLine("CustomerId" + CustomerId);
    //        }
    //    }

    //    class BankCustomer:Customer
    //    {
    //        public int AccountNumber { get; set; }
    //        public double Balance { get; set; }

    //        public void BankCustomerDetails()
    //        {
    //            Console.WriteLine("CustomerId " + CustomerId);
    //            Console.WriteLine("Bal " + Balance);
    //        }
    //    }

    //    class LoanCustomer:BankCustomer
    //    {
    //        public double LoanAmount { get; set; }
    //    }

    //    class Program
    //    {
    //        static void Main(string[] args)
    //        {
    //            Customer C = new Customer()
    //            {
    //                CustomerId = 123,
    //                Name = "raju",
    //                Email = "rajuk5425@gmail.com"
    //            };

    //            BankCustomer BC = new BankCustomer()
    //            {
    //                CustomerId = 124,
    //                Name = "Peter",
    //                Email="Peter@gmail.com",
    //                AccountNumber=12345,
    //                Balance=5000
    //            };

    //            BC.Details();
    //            BC.BankCustomerDetails();

    //            C.Details();

    //            LoanCustomer LC = new LoanCustomer();
    //            //LC. Can access all the properties of Customer, 
    //            //BankCustomer And LoanCustomer
    //        }
    //    }
    //} 
    #endregion

    #region Protected Members
    //namespace InheritanceEg1
    //{
    //    class Customer
    //    {
    //        protected int CustomerId;
    //        string Name;

    //        public void Details()
    //        {
    //            Console.WriteLine("CustomerId" + CustomerId);
    //            Console.WriteLine("Name" + Name);
    //        }
    //    }

    //    class BankCustomer:Customer
    //    {
    //        int AcNo;

    //        public void BankCustomerDetails()
    //        {
    //           // CustomerId
    //        }
    //    }

    //    class Program
    //    {
    //        static void Main(string[] args)
    //        {
    //            Customer C = new Customer();          

    //            BankCustomer BC = new BankCustomer();            
    //        }
    //    }
    //} 
    #endregion

    #region ConstructorChaining
    //namespace InheritanceEg1
    //{
    //    class Customer
    //    {
    //        protected int CustomerId;
    //        protected string Name;
    //        protected string Email;

    //        public Customer()
    //        {
    //            Console.WriteLine("This is Customer Constructor!");
    //        }

    //        public Customer(int CustomerId,string Name,string Email)
    //        {
    //            Console.WriteLine("This is Customer Constructor with Param");
    //            this.CustomerId = CustomerId;
    //            this.Name = Name;
    //            this.Email = Email;
    //        }
    //    }

    //    class BankCustomer : Customer
    //    {
    //        protected int AcNo;
    //        protected double Balance;

    //        public BankCustomer()
    //        {
    //            Console.WriteLine("This is Bank Customer Constructor");
    //        }

    //        public BankCustomer(int CustomerId, string Name, string Email,int AcNo,double Balance)
    //            :base(CustomerId,Name,Email)
    //        {
    //            Console.WriteLine("This is Bank Customer Constructor with Param");
    //            //this.CustomerId = CustomerId;
    //            //this.Name = Name;
    //            //this.Email = Email;
    //            this.AcNo = AcNo;
    //            this.Balance = Balance;
    //        }
    //    }

    //    class Program
    //    {
    //        static void Main(string[] args)
    //        {
    //            var BC = new BankCustomer(123, "raju", "xxxx", 7678, 5000);

    //        }
    //    }
    //} 
    #endregion



}

