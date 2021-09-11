//David Crouch
namespace Unit5_Polymorphism 
{ 
    class Program 
    { 
        static void Main(string[] args) 
        { 
            Student student1 = new Student(); 
            Console.WriteLine("Enter student name:"); 
            student1.Name = Console.ReadLine(); 
            Console.WriteLine("Enter student age:"); 
            student1.Age = Convert.ToInt16(Console.ReadLine()); 
            Console.WriteLine("Enter student grade:"); 
            student1.grade = Convert.ToInt16(Console.ReadLine()); 
  
            Professor professor1 = new Professor(); 
            Console.WriteLine("Enter professor name:"); 
            professor1.Name = Console.ReadLine(); 
            Console.WriteLine("Enter professor age:"); 
            professor1.Age = Convert.ToInt16(Console.ReadLine()); 
            Console.WriteLine("Enter professor program:"); 
            professor1.Program = Console.ReadLine(); 
  
            student1.displayData(); 
            professor1.displayData();       
        } 
    } 
} 
 
*************************************************** 
 
namespace Unit5_Polymorphism 
{ 
    class Person 
    { 
        protected string name; 
  
        public string Name 
        { 
            get { return name; } 
            set { name = value; } 
        } 
  
        protected int age; 
  
        public int Age 
        { 
            get { return age; } 
            set { age = value; } 
        } 
  
        //We will overload the below method 
        public virtual void displayData() 
        { 
            Console.WriteLine("Name is {0}", name); 
            Console.WriteLine("Age is {0}", age); 
        } 
  
  
    } 
} 
 
************************************************ 
 
namespace Unit5_Polymorphism 
{ 
    class Student : Person // specifies it inherits from Person class 
    { 
        public int grade; 
  
        public override void displayData() 
        { 
            base.displayData(); //This uses the original  
            Console.WriteLine("Grade is {0}", grade); 
        } 
    } 
} 
 
************************************** 
 
namespace Unit5_Polymorphism 
{ 
    class Professor : Person 
    { 
        private string program; 
  
        public string Program 
        { 
            get { return program; } 
            set { program = value; } 
        } 
  
        public override void displayData() 
        { 
            base.displayData(); 
            Console.WriteLine("Program is {0}", program); 
        } 
    } 
} 