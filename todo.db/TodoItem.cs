using System;

namespace todo.db
{
    public class TodoItem
    {
        public long Id {set; get;}
        public string Name {set; get;}
        public bool IsComplete {set; get;}
    }
}
