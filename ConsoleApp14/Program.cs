using System;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                var myClass = new MyClass();
                myClass.Change(4, 3);
                myClass.Print();
                myClass.Sum();
                myClass.Max();
            }

        }
        private class MyClass
        {
            private int x;
            private int y;
            public void Change(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
            public void Sum()
            {
                Console.WriteLine($"сумма: {x + y}");
            }
            public void Max()
            {
                Console.WriteLine(x > y ? $"{x} больше чем {y}" : $"{x} меньше чем {y}");
            }
            public void Print()
            {
                Console.WriteLine($"x: {x} y: {y}");
            }



         struct Student
            {
                public string Name;
                public int[] ses;
                public int Group;
                public Student(string n, int g, int[] s)
                {
                    ses = s;
                    Name = n;
                    Group = g;
                }
                public int getMiddleScore() //идиотское название
                {
                    return (ses[0] + ses[1] + ses[2] + ses[3] + ses[4]) / 5;
                }
            }
            class demo
            {
                static void Main()
                {
                    string s;
                    string[] c;
                    int[] d = new int[5];
                    bool morefour = false;
                    Student[] stud1 = new Student[10];
                    for (int i = 0; i < stud1.Length; i++)
                    {
                        Console.Write("Введите имя : ");
                        stud1[i].Name = Console.ReadLine();
                        Console.Write("Введите номер группы : ");
                        stud1[i].Group = Int32.Parse(Console.ReadLine());
                        Console.Write("Введите оценки : ");
                        s = Console.ReadLine();
                        stud1[i].ses = new int[5];
                        c = s.Split(null);
                        for (int j = 0; j < 5; j++) stud1[i].ses[j] = Int32.Parse(c[j]);
                        Console.WriteLine();
                    }
                    Console.WriteLine("Студенты со средним баллом больше 4 : ");
                    foreach (Student st in stud1)
                    {
                        if (st.getMiddleScore() >= 4)
                        {
                            Console.WriteLine(st.Name);
                            morefour = true;
                        }
                    }
                    if (!morefour) Console.WriteLine("Нету людей с хорошими оценками!");
                }
            }
        }
    }
}

    
