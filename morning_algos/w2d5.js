class dNode{
    constructor(val){
        this.value = val;
        this.next = null;
        this.prev = null;
    }
}

// DLL Class
class DLL{
    constructor(){
        this.head = null;
        this.tail = null;
    }
    addToFront(val){
        let newNode = new dNode(val)
        newNode.next = this.head;
        if(this.head){
            this.head.prev = newNode;
        }
        else{
            this.tail = newNode;
        }
        this.head = newNode;
    }
    addToBack(val){
        let newNode = new dNode(val)
        newNode.prev = this.tail;
        if(this.tail){
            this.tail.next = newNode;
        }
        else{
            this.head = newNode;
        }
        this.tail = newNode;
    }
    removeFromFront(){
        if(!this.head){
            return null;
        }
        if(this.head===this.tail){
            this.head = null;
            this.tail = null;
            return null;
        }
        this.head = this.head.next;
        this.head.prev = null;
    }
    removeFromBack(){
        if(!this.tail){
            return null;
        }
        if(this.head===this.tail){
            this.head = null;
            this.tail = null;
            return null;
        }
        this.tail = this.tail.prev;
        this.tail.next = null;
    }
    display(){
        // Edge case: nothing in the list
        if(this.head == null){
            console.log("Nothing to print");
        } else {
            var runner = this.head;
            var result = "<-";
            while(runner){
                result += `${runner.value} <-> `;
                runner = runner.next;
            }
            console.log(result);
        }
    }

    reverseDLL(){
        if(this.tail == null){
            console.log("There is no tail.")
        }
        var runner = this.tail;
        this.tail.prev = null;
    }
}

// start at the tail set .prev = to temp
// then set .next to .prev
var newList = new DLL();
newList.addToBack(7)
newList.addToBack(1)
newList.addToBack(4)
newList.addToBack(9)
newList.addToBack(5)

newList.display();