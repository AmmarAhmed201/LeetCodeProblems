/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        ListNode dummy= new ListNode();
        var current = dummy ;
        int carry = 0;
        int val1 , val2,value;
        while(l1 != null || l2!=null || carry>0){
            if (l1!= null){
                val1 = l1.val;
                l1=l1.next;
            }
            else 
                val1 = 0;
            if(l2!=null){
                val2= l2.val;
                l2=l2.next;
            }
            else 
                val2 =0;
            //get current value 
            value = val1+val2+carry;
            carry = value/10;
            value = value%10;
            
            //update our linked list 
            ListNode temp = new ListNode(value);
            current.next = temp;
            current = current.next;
            
        }
        
        return dummy.next;
    }
}