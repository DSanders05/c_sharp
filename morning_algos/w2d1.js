class ListNode {
    constructor(value) {
        this.value = value;
        this.next = null;
    }// constructor - like the __init__ method in Python
}

class SinglyLinkedList {
    constructor() {
        this.head = null;
        this.tail = null;
    }
}

addToFront(value) {
    let new_node = new ListNode(value);
    // adding when list is empty
    if (this.head == null) {
        this.head = new_node;
        this.tail = new_node;
    }
    if(new_node===this.head.value){

    }
    // adding if list is not empty
    else {
        new_node.next = this.head;
        this.head = new_node;
    }
}

reverseNode(){
    let limit = SinglyLinkedList.length;
    var runner = this.head.next;
    while(runner!==null){
        this.addToFront(runner.value);
        runner=runner.next;
    }
}