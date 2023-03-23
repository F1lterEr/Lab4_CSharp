using System;

namespace StudentSort
{
    struct Student
    {
        public string Name;
        public int Group;
        public int[] Grades;

        public float GetAverageGrade()
        {
            int total = 0;
            foreach (int grade in Grades)
            {
                total += grade;
            }
            return (float)total / Grades.Length;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[7];
            Random random = new Random();

            students[0].Name = "1";
            students[0].Group = 1;
            students[0].Grades = new int[5];
            for (int j = 0; j < students[0].Grades.Length; j++)
            {
                students[0].Grades[j] = random.Next(2, 6);
            }

            students[1].Name = "2";
            students[1].Group = 1;
            students[1].Grades = new int[5];
            for (int j = 0; j < students[1].Grades.Length; j++)
            {
                students[1].Grades[j] = random.Next(2, 6);
            }

            students[2].Name = "3";
            students[2].Group = 2;
            students[2].Grades = new int[5];
            for (int j = 0; j < students[2].Grades.Length; j++)
            {
                students[2].Grades[j] = random.Next(2, 6);
            }

            students[3].Name = "4";
            students[3].Group = 2;
            students[3].Grades = new int[5];
            for (int j = 0; j < students[3].Grades.Length; j++)
            {
                students[3].Grades[j] = random.Next(2, 6);
            }

            students[4].Name = "5";
            students[4].Group = 3;
            students[4].Grades = new int[5];
            for (int j = 0; j < students[4].Grades.Length; j++)
            {
                students[4].Grades[j] = random.Next(2, 6);
            }

            students[5].Name = "6";
            students[5].Group = 4;
            students[5].Grades = new int[5];
            for (int j = 0; j < students[5].Grades.Length; j++)
            {
                students[5].Grades[j] = random.Next(2, 6);
            }

            students[6].Name = "7";
            students[6].Group = 4;
            students[6].Grades = new int[5];
            for (int j = 0; j < students[6].Grades.Length; j++)
            {
                students[6].Grades[j] = random.Next(2, 6);
            }

            // Сортировка массива по возрастанию среднего балла
            for (int i = 0; i < students.Length - 1; i++)
            {
                for (int j = i + 1; j < students.Length; j++)
                {
                    if (students[j].GetAverageGrade() < students[i].GetAverageGrade())
                    {
                        Student temp = students[i];
                        students[i] = students[j];
                        students[j] = temp;
                    }
                }
            }

            // Вывод отсортированного массива на экран
            foreach (Student student in students)
            {
                Console.WriteLine("ФИО {0}, Группа {1}, Средний балл: {2:F2}", student.Name, student.Group, student.GetAverageGrade());
            }

            Console.ReadKey();
        }
    }
}
