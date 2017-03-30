using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    public static class ExtensionClass
    {
        public static int Power(this int myInt, int exponent)
        {
            int result = myInt;
            for (int i = 1; i < exponent; i++)
                result = result * myInt;
            return result;
        }

        public static string MyReverse(this string myStr)
        {
            char[] charArray = myStr.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }

    class Vector2
    {
        public static int count = 0;

        float x;
        float y;

        public Vector2()
        {
            x = 0.0f;
            y = 0.0f;
            count++;
        }

        public Vector2(float _x, float _y)
        {
            x = _x;
            y = _y;
            count++;
        }

        public Vector2(Vector2 _vec) : this(_vec.x, _vec.y)
        {
        }

        public float X
        {
            get { return x; }
            set { x = value; }
        }

        public float Y
        {
            get { return y; }
            set { y = value; }
        }

        public static Vector2 operator +(Vector2 vec1, Vector2 vec2)
        {

            return new Vector2(vec1.x + vec2.x, vec1.y + vec2.y);
        }

        public static Vector2 operator -(Vector2 vec1, Vector2 vec2)
        {
            return new Vector2(vec1.x - vec2.x, vec1.y - vec2.y);
        }

        public static Vector2 operator *(Vector2 vec1, Vector2 vec2)
        {
            return new Vector2(vec1.x * vec2.x, vec1.y * vec2.y);
        }

        public static Vector2 operator /(Vector2 vec1, Vector2 vec2)
        {
            return new Vector2(vec1.x / vec2.x, vec1.y / vec2.y);
        }

        public static float Dot(Vector2 vec1, Vector2 vec2)
        {
            return vec1.x * vec2.x + vec1.y * vec2.y;
        }

    }

    class A
    {
        int[] arr;

        public A()
        {
            arr = new int[100];
        }

        public void Set(int index, int value)
        {
            if (index >= 0 && index < arr.Length)
                arr[index] = value;
        }

        public int Get(int index)
        {
            if (index >= 0 && index < arr.Length)
                return arr[index];
            else
            {
                Console.WriteLine("index가 범위를 벗어났습니다.");
                return 0;
            }
        }

        public int this[int index]
        {
            get
            {
                if (index >= 0 && index < arr.Length)
                    return arr[index];
                else
                {
                    Console.WriteLine("index가 범위를 벗어났습니다.");
                    return 0;
                }
            }
            set
            {
                if (index >= 0 && index < arr.Length)
                    arr[index] = value;
                else
                    Console.WriteLine("index가 범위를 벗어났습니다.");
            }
        }

    }




    class Student
    {
        public int number;
        public string name;
        public string major;
        public int credit;
        public float averageGrade;

        public Student()
        {
            number = 70302;
            name = "홍길동";
            major = "게임프로그래밍";
            credit = 0;
            averageGrade = 3.5f;
        }

        public static bool BiggerThanNumber(Student lhs, Student rhs)
        {
            if (lhs.number > rhs.number)
                return true;
            else
                return false;

        }

        public static bool BiggerThanName(Student lhs, Student rhs)
        {
            if ( String.Compare(lhs.name, rhs.name) > 0 )
                return true;
            else
                return false;

        }

        public static bool BiggerThanCredit(Student lhs, Student rhs)
        {
            if (lhs.credit > rhs.credit)
                return true;
            else
                return false;

        }

        public static bool BiggerThanAverageGrade(Student lhs, Student rhs)
        {
            if (lhs.averageGrade > rhs.averageGrade)
                return true;
            else
                return false;
        }
    }


    class StudentManager
    {
        delegate bool BiggerThan(Student lhs, Student rhs);

        BiggerThan biggerThan;
        Student[] students = new Student[100];

        public StudentManager()
        {
            students = new Student[100];
        }

        public Student this[int index]
        {
            get { return students[index]; }
            set { students[index] = value; }
        }

        public Student[] SortByNumber()
        {
            biggerThan = new BiggerThan(Student.BiggerThanNumber);
            Sort();

            return students;

        }

        public Student[] SortByName()
        {
            biggerThan = new BiggerThan(Student.BiggerThanName);
            Sort();
            return students;
        }

        public Student[] SortByCredit()
        {
            biggerThan = new BiggerThan(Student.BiggerThanCredit);
            Sort();
            return students;
        }

        public Student[] SortByAverageGrade()
        {
            biggerThan = new BiggerThan(Student.BiggerThanAverageGrade);
            Sort();
            return students;
        }

        private void Sort()
        {            
            for ( int i = 0; i < students.Length; i++ )
            {                
                for ( int j = i+1; j < students.Length; j++ )
                    if ( biggerThan(students[i], students[j]) )
                    //if ( students[i].number > students[j].number))
                    //if ( string.Compare(students[i].name, students[j].name) <0 )
                    //if (students[i].credit > students[j].credit )
                    //if (students[i].averageGrade > students[j].averageGrade)
                    {
                        Student tmp = students[i];
                        students[i] = students[j];
                        students[j] = tmp;
                    }
            }
        }

    }



class Program
{


    static void Main(string[] args)
    {
        
        A classA = new A();
        classA[3] = 3;
        classA[1] = 1;
        Console.WriteLine(classA[1]);

        Vector2 vec1 = new Vector2(1.0f, 1.0f);
        Vector2 vec2 = new Vector2(0.0f, 0.0f);
        Vector2 vec3 = new Vector2(3.0f, 2.0f);

        Vector2.Dot(vec1, vec2);

        vec1.X += 0.1f;

        //Vector2 sumVec = vec1.Sum(vec2);
        //sumVec = sumVec.Sum(vec3);
        //Vector2 sumVec = (vec1.Sum(vec2)).Sum(vec3);
        Vector2 sumVec = vec1 + vec2 + vec3;

        Console.WriteLine(Vector2.count);

        int a = 3, b = 3, c = 2;
        int sum = a + b + c;



        //int a = 10;
        //int b = 4;
        //string str = "hello, World";

        //Console.WriteLine(a.Power(b));
        //Console.WriteLine(str.MyReverse());
    }
}
}
