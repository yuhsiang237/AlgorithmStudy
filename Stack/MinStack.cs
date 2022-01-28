public class MinStack {
    private Node head = null;
    
    public MinStack() {
        
    }
    
    public void Push(int val) {
        if(head == null){
             head = new Node(val);
        }else{
            var temp = head;
            head = new Node(val);
            head.next = temp;
        }
    }
    
    public void Pop() {
        head = head.next;
    }
    
    public int Top() {
        return head.val;
    }
    
    public int GetMin() {
        var cursor = head;
        int minValue = int.MaxValue;
        while(cursor != null){
            if(cursor.val < minValue){
                minValue =  cursor.val;
            }
            cursor = cursor.next;
        }
        return minValue;
    }
}

public class Node {
    public int val;
    public Node next;
    public Node(int val) {
        this.val = val;
    }
}
