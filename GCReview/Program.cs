using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GCLibrary;

namespace GCReview
{
    class MikesAwesomeConsoleApp
    {

        struct MyStruct
        {
            public string Name { get; set; }
            public DateTime DateOfBirth { get; set; }
        }

        static void Main(string[] args)
        {
            //var task = new Task();

            var x = new MyStruct();
            x.Name = "Mike";


            ////task.Timestamp = new DateTime(2015, 1, 1);

            //task._currentDate = new DateTime(2015, 1, 1);

            //var timeStamp = task.Timestamp;
            //var taskName = task.TaskName;
            //var x = task._taskDescription;    
            
            //Console.WriteLine(timeStamp);



            //var newTimesTamp = timeStamp.AddDays(1);
            //task.Timestamp = newTimesTamp;

            //var existingTask = new Task(42);
            //// print out existingTask Timestamp


            //var canBeSeen = new CanBeSeen();

            //Animal dog = new Dog();
            

            //Console.WriteLine("The dog says " + dog.Speak());

            var t = new Task();
            t.WhichDay(43);

            IFly bird = new Bird();
            IFly helicopter= new Helicopter();

            var listOfFly = new List<IFly>();

            listOfFly.Add(new Bird());
            listOfFly.Add(new Helicopter());

            foreach (var flyable in listOfFly)
            {
                Console.WriteLine(flyable.Fly());
            }

            Console.ReadKey();

        }        
    }

    public class Task
    {

        enum DaysOfWeek
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        } 
        
        public DateTime _currentDate;
        public string _taskDescription;

        public Task(int id)
        {
            // look up id from the database
        }

        public Task()
        {
            _currentDate = DateTime.Now;
            TaskName = "Default task name";
            var bar = "Test";

            var today = DayOfWeek.Tuesday;

            PrintDayOfWeek(today);

            Foo();
            Foo("this is a string");
            Foo("This is a string", 42);

            Foo(argument2: 42, argument1:"string");

            Foo("string", 54, "");
        }

        public void Foo()
        {
            Foo("", 0, "");
        }

        public void Foo(string argument)
        {
            Foo(argument, 0, "");
        }

        public void Foo(string argument1, int argument2)
        {
            Foo(argument1, argument2, "");
        }

        public void Foo(string argument1, int argument2, string argument3)
        {
            // All the code that does the stuff
            
            Console.WriteLine("arg1: {0} arg2: {1} arg3: {2}", argument1, argument2, argument3);
        }

        public void PrintDayOfWeek(DayOfWeek theDay)
        {
            switch (theDay)
            {
                case DayOfWeek.Monday:
                    Console.WriteLine("Today is Monday");
                    break;
                case DayOfWeek.Tuesday:
                    Console.WriteLine("Today is Tuesday");
                    break;
            }


        }

        public void WhichDay(int dayNumber)
        {
            var today = DateTime.Today;

            Console.WriteLine(today.DayOfWeek);
            Console.WriteLine(today.Month);
        }

        
        public bool CancelTask()
        {
            // step1
            doStep1();
            // step3
            doStep3();
            // step2
            doStep2();

            return false;
        }

        private void doStep1()
        {
            
        }

        private void doStep2()
        {
            
        }

        private void doStep3() { }
        public DateTime Timestamp
        {
            get { return _currentDate; }
            set
            {
                if (value < DateTime.Now)
                {
                    _currentDate = value;
                }
                else
                {
                    _currentDate = DateTime.Now;
                }
            }
        }

        public string TaskName { get; set; }
    }
}
