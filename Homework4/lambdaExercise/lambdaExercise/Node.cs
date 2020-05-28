using System;
using System.Collections.Generic;
using System.Text;

namespace lambdaExercise
{
    class Node<T>
    {
        public Node<T> Next { get; set; }
        public T Data { get; set; }

        public Node(T t)
        {
            Next = null;
            Data = t;
        }
    }
}
