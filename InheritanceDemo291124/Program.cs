namespace InheritanceDemo291124
{
    #region
    //class AA1
    //{
    //   protected int i;
    // protected void show()
    //    {
    //        Console.WriteLine("show from AA1");
    //    }
    //}
    //class BB1: AA1
    //{
    //    public void display()
    //    {
    //        Console.WriteLine("display from BB1");
    //        show();
    //        i= 99;
    //    }
    //}

    //class CC1 : BB1
    //{
    //    public void methodCC()
    //    {
    //        Console.WriteLine("method from CC");
    //        show();
    //    }
    //}
    #endregion
    class Person
    {
        public string name { get; set; }
        public int age { get; set; }
        public string address {get;set;}
     virtual   public void showInfo()
        {
            Console.WriteLine("Name :"+name+" Age:"+age+" Address:"+address);
        }
    }
    class Student:Person
    {
        public int Roll { get; set; }
        public int totalMarks { get; set; }
     override   public void showInfo()
        {
            //Console.WriteLine("name:"+name+" Age:"+age+" Address:"+address);
            base.showInfo();
            Console.WriteLine("roll:"+Roll+" Total Marks:"+totalMarks);
        }
    }
    class Teacher:Person
    {

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region
            //BB1 objB=new BB1();
            //// objB.show();
            // objB.display();

            // AA1 objA = new AA1();
            // //objA.show();
            #endregion
            Student s1=new Student();
            s1.age = 20;
            s1.name = "rajesh";
            s1.address = "pune";
            s1.Roll = 1;
            s1.totalMarks = 450;
            s1.showInfo();
        }
    }
}
