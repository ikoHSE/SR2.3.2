/*
ФИО: Костюченко Илья Игоревич
Группа: БПИ 171-1
Дата: 5.12.17
Вариант: m2.3.2
*/

using System;
using static Iko.Iko;

namespace SR2 {

    class Student {

        /// <summary>
        /// Random number generator
        /// </summary>
        private static Random rand = new Random();

        /// <summary>
        /// Name of university
        /// </summary>
        /// <value>Name of university</value>
        public virtual string University => "Unknown";

        /// <summary>
        /// Name of student
        /// </summary>
        /// <value>Name of student</value>
        public string StudentName { get; set; }

        /// <summary>
        /// Amount of free time
        /// </summary>
        /// <value>Amount of free time</value>
        public int FreeTime { get; set; }


        /// <summary>
        /// Does the student have free time.
        /// </summary>
        /// <returns><c>true</c>, if student has, <c>false</c> otherwise.</returns>
        virtual public bool HasFreeTime() => FreeTime > 7;


        /// <summary>
        /// Initializes a new instance of the <see cref="T:SR2.Student"/> class.
        /// </summary>
        /// <param name="name">Name</param>
        public Student(string name) {
            this.StudentName = name;
            this.FreeTime = rand.Next(13);
        }

    }

    class HseStudent: Student {

        /// <summary>
        /// Name of university
        /// </summary>
        /// <value>Name of university</value>
        public override string University => "Higher School of Economics";

        /// <summary>
        /// Does the student have free time.
        /// </summary>
        /// <returns><c>true</c>, if student has, <c>false</c> otherwise.</returns>
        public override bool HasFreeTime() => false;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:SR2.Student"/> class.
        /// </summary>
        /// <param name="name">Name</param>
        public HseStudent(string name) : base(name) {
            
        }

        class MainClass {
            public static void Main(string[] args) {
                Repeat(() => {
                    Student student = new Student("Alex");
                    Student hseStudent = new HseStudent("Marty");

                    Console.WriteLine($"student:");
                    Console.WriteLine($"\tUnversity:\t{student.University}");
                    Console.WriteLine($"\tStudentName:\t{student.StudentName}");
                    Console.WriteLine($"\tFreeTime:\t{student.FreeTime}");
                    Console.WriteLine($"\tHasFreeTime:\t{student.HasFreeTime()}");
                    Console.WriteLine($"hseStudent:");
                    Console.WriteLine($"\tUnversity:\t{hseStudent.University}");
                    Console.WriteLine($"\tStudentName:\t{hseStudent.StudentName}");
                    Console.WriteLine($"\tFreeTime:\t{hseStudent.FreeTime}");
                    Console.WriteLine($"\tHasFreeTime:\t{hseStudent.HasFreeTime()}");
                });
            }
        }
    }
}
