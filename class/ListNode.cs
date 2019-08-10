namespace AddTwoLinkedList
{
    public class ListNode
    {
        public int val { get; set; }
        public ListNode next { get; set; }
        public ListNode(int x){
            this.val = x;
        }
        public ListNode(){}

        public override string ToString(){
            ListNode current = this;
            string res = "[";

            while(current != null){
                res += current.val;
                if(current.next != null){
                    res += ", ";
                }
                current = current.next;
            }
            res += "]";
            return res;
        }


    }
}