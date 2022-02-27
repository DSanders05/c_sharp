class BNode{
    constructor(val){
        this.value = val;
        this.left=null;
        this.right=null;
    }
}

// Binary Search Tree
class BST {
    // Our BST only has a root that starts at null
    constructor(){
        this.root=null;
    }
    // How do I identify that a BST is empty?
    isEmpty(){
        // Returns true if it IS empty and false if it is NOT empty
        return this.root==null;
    }

    // How do I find the smallest value?
    minValue(){
        if(this.isEmpty()){
            return null;
        }
        // We have to search down the tree
        let squirrel = this.root;
        // While there is still a left to go to
        // But we do NOT run off the branch
        while(squirrel.left){
            // We shift the squirrel down the branch until the while loop stops
            squirrel=squirrel.left;
        }
        // We are on the last node, so return the value
        return squirrel.value;
    }

    maxValue(){
        if(this.isEmpty()){
            return null;
        }
        let squirrel = this.root;
        while(squirrel.right){
            squirrel = squirrel.right;
        }
        return squirrel.value;
    }

    // Add a node
    addNode(value){
        let node = new BNode(value);
        // First we check if the tree is empty
        if(this.isEmpty()){
            // If we DON'T have a root
            // Our new value IS our root
            this.root = node;
            return this;
        } else {
            // There ARE values so we need to figure out where our new value fits
            let squirrel = this.root;
            // a while true runs literally forever - nothing will stop it
            // So if you're going to do this you need to be confident in your return statements
            while(true){
                if(value < squirrel.value){
                    // If our new value is LESS than our squirrel's value
                    // We go to the left but we need to verify that there IS a left
                    if(!squirrel.left){
                        // This statement triggers if the left pointer points to null
                        squirrel.left = node;
                        return this;
                    } else {
                        // If there IS a left to go down
                        squirrel = squirrel.left;
                    }
                } else {
                    // The value must be greater than OR equal to
                    // Need to see if there is an end to the branch
                    if(!squirrel.right){
                        squirrel.right = node;
                        return this;
                    } else {
                        // If there IS a right to go down
                        squirrel = squirrel.right;
                    }
                }
            }
        }
    }
    printTwo(node = this.root, spaceCnt = 0, spaceIncr = 5) {
        if (!node) {
            return;
        }
        spaceCnt += spaceIncr;
        this.printTwo(node.right, spaceCnt);
        console.log(" ".repeat(spaceCnt < spaceIncr ? 0 : spaceCnt - spaceIncr) + `${node.value}`);
        this.printTwo(node.left, spaceCnt);
    }

    // Returns true or false whether a given value is present in my BST
    contains(val){
        if(this.isEmpty()){
            return false;
        } else {
            while(squirrel){
                let squirrel = this.root;
                if(val == squirrel.value){
                    return true;
                }
                if(val < squirrel.value){
                    // if our value is SMALLER
                    squirrel = squirrel.left;
                } else if(val > squirrel.value){
                    // if our value is GREATER
                    squirrel = squirrel.right;
                }
            }
        }
    }

    sizeCounter(node = this.root){
        if(node == null){
            return 0;
        } else {
            return 1 + this.sizeCounter(node.left) + this.sizeCounter(node.right)
        }
    }

    evenTree(node=this.root){
        if(!node){
            return false;
        } else {
            if(!node.left && !node.right){
                return true;
            } else if(node.left && node.right) {
                return this.evenTree(node.left) && this.evenTree(node.right);
            } else {
                return false;
            }   
        }
    }
}

let newBST = new BST();

newBST.addNode(8);
newBST.addNode(10);
newBST.addNode(6);

console.log(newBST.evenTree());