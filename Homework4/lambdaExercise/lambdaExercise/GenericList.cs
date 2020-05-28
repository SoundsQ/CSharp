using System;
using System.Collections.Generic;
using System.Text;

namespace lambdaExercise
{
    class GenericList<T>
    {
        private Node<T> head;
        private Node<T> tail;

        public GenericList()
        {
            tail = head = null;
        }

        public Node<T> Head
        {
            get => head;
        }
        public void Add(T t)
        {
            Node<T> n = new Node<T>(t);
            if(tail == null)
            {
                head = tail = n;
            }
            else
            {
                tail.Next = n;
                tail = n;
            }
        }


        public void ForEach(Action<T> action)
        {
            for(Node<T> t=head;t!=null;t=t.Next)
            {
                action(t.Data);
            }
        }

    }
}
