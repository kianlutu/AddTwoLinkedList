using System;

namespace AddTwoLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {

            ListNode results = AddTwoNumbers(IntToListNode(18), IntToListNode(0));
            Console.WriteLine(results.ToString());
            Console.Read();
        }

            //first solution
            //
            // public static ListNode AddTwoNumbers(ListNode l1, ListNode l2) 
            // {
            //     int val1 = ListNodeToInt(l1);
            //     int val2 = ListNodeToInt(l2);
            //     ListNode res = IntToListNode(val1 + val2);
                
            //     return res;

            // }

           
            // public static int ListNodeToInt(ListNode ln)
            // {
            //     int res = 0;
            //     string resString = "";
            //     while(ln != null)
            //     {
            //         resString = resString + ln.val.ToString();
            //         ln = ln.next;    
            //     }
            //     Int32.TryParse(resString, out res);
            //     return res;                
            // }

            public static ListNode IntToListNode(int val)
            {
                string valString = val.ToString();
                int tempVal;
                ListNode tempListNode = new ListNode();
                ListNode root = null;

                for (int i = 0; i < valString.Length ; i++)
                {   
                    Int32.TryParse( valString[i].ToString(),out tempVal);
                    tempListNode = root;
                    root = new ListNode(tempVal);
                    root.next = tempListNode;
                }
                return root;

            }

             public static ListNode AddTwoNumbers(ListNode l1, ListNode l2) 
            {
                ListNode root = new ListNode(0);
                ListNode current = root;
                int carry = 0;
                while(l1 !=  null || l2 != null){
                    int x = l1 != null ? l1.val : 0;
                    int y = l2 != null ? l2.val : 0;
                    int sum = x + y + carry;
                    carry = sum > 9 ? 1 : 0;
                    current.next = new ListNode(sum % 10);
                    current = current.next;
                    if(l1 != null) l1 = l1.next;
                    if(l2 != null) l2 = l2.next;
                    if(l1 == null && l2 == null && carry == 1) current.next = new ListNode(carry);
                }
  

                return root.next;

            }

     
    }
}
