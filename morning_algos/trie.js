class TrieNode{
    constructor(val){
        this.value = val;
        this.children = [];
        this.isWord = false;
    }
}

class Trie{
    constructor(){
        this.root = new TrieNode("");
    }

    add(word){
        //loop through word
        //look at root
        //if no node exists with that value we add to children and then shift down the word
        let runner = this.root;
        for(let i =0; i<word.length;i++){
            let isPresent = false;
            for(let j=0; j<runner.children.length; j++){
                if(word[i] === runner.children[j].value){
                    runner = runner.children[j]
                    isPresent=true;
                    break;
                }
            }
            if(isPresent == false){
                runner.children.push(new TrieNode(word[i]));
                runner = runner.children[runner.children.length-1];
                console.log("added letter", word[i])
            } else {
                console.log("found letter", word[i])
            }
        }
        runner.isWord=true;
        console.log("word added");
    }
}

let newTrie = new Trie();

newTrie.add("cat");
newTrie.add("car");
newTrie.add("care");