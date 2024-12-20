namespace listPractice
{    
    //example of setting up node class with private fields and properties
    public class Node 
    {
        private int _val; 
        private Node next;

        public Node(int val, Node next)
        {
            this._val = val;
            this.next = next;
        }

        public int Val
        {
            get {return this._val;}
            set {this._val = value;}
        }

        public Node Next
        {
            get {return this.next;}
            set {this.next = value;}
        }
    }
}

