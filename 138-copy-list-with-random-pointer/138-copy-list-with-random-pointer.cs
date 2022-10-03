/*
// Definition for a Node.
public class Node {
    public int val;
    public Node next;
    public Node random;
    
    public Node(int _val) {
        val = _val;
        next = null;
        random = null;
    }
}
*/

public class Solution {
    public Node CopyRandomList(Node head) {
        var dictMapping = new Dictionary<Node,Node>();
        for(var curr = head ;curr!=null;curr=curr.next){
            if(!dictMapping.ContainsKey(curr)){
                dictMapping.Add(curr,new Node(curr.val));
            }
            var copy = dictMapping[curr];
            var next = curr.next;
            var random = curr.random;
            if(next!=null){
                if(!dictMapping.ContainsKey(next)){
                    dictMapping.Add(next,new Node(next.val));
                }
                copy.next = dictMapping[next];
            }
            if(random!=null){
                if(!dictMapping.ContainsKey(random)){
                    dictMapping.Add(random,new Node(random.val));
                }
                copy.random = dictMapping[random];
            }
        }
       return head == null ? null : dictMapping[head];
       
        
    }
}