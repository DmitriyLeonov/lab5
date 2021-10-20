using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            Experiment test1 = new Test();
            Console.WriteLine(test1.GetTheme());
            IQuestion test2 = new Test();
            Console.WriteLine(test2.GetTheme());
            var test3 = test1 as Test;
            if (test3 != null)
            {
                Console.WriteLine("Преобразовалось");
            }
            if (test2 is Test)
            {
                Console.WriteLine("Можно преобразовать в Test");
            }
            Console.Read();
        }
    }

    abstract class Experiment
    {
        public abstract string GetTheme();
    }

    class Test : Experiment, IQuestion
    {
        private string theme = "C#";
        private int[] answers = new int[10] { 2, 4, 1, 1, 3, 1, 4, 4, 1, 3 };

        public int CheckAnswer(int[] answers)
        {
            return 1;
        }

        string IQuestion.GetTheme()
        {
            return "Hello from interface";
        }

        public override string GetTheme()
        {
            return "Hello from class";
        }

        public override string ToString()
        {
            return this.GetType().ToString();
        }
    }

    class Exam : Experiment
    {
        private string theme = "OOP";
        private DateTime examDate = DateTime.Now.AddDays(12);

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return 1;
        }

        public override string GetTheme()
        {
            return theme;
        }

        public override string ToString()
        {
            return this.GetType().ToString();
        }

        public DateTime GetDate()
        {
            return examDate;
        }
    }

    sealed class FinalExam : Exam
    {
        public override string ToString()
        {
            return this.GetType().ToString();
        }
    }

    public interface IQuestion
    {
        int CheckAnswer(int[] answers);
        string GetTheme();
    }
}
