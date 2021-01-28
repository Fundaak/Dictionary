using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary
{
    class MyDictionary<T>

    {
        T[] lessons;

        public MyDictionary()
        {
            lessons = new T[0];
        }

        public void Add(T lesson)
        {
            T[] temparray = lessons;
            lessons = new T[lessons.Length + 1];

            for (int i = 0; i < temparray.Length; i++)
            {
                lessons[i] = temparray[i];
            }

            lessons[lessons.Length - 1] = lesson;

            Console.WriteLine(lesson + " dersi eklanmiştir");



        }

    }

}


