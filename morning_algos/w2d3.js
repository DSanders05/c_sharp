// Singly Linked List Has Loop
// Some dastardly coding has left you with a loop in your singly linked list! (Meaning your while loop will run forever!) -- It's up to you to figure out if it's just a really long list or your coworker has created a loop in your list!
// Return true if a loop is found, false if one is not

// Break loop
// After identifying that a loop has been found, break it

makeLoop() {
    // This will make a loop that points the last node to the head, but remember this loop could happen ANYWHERE
    let runner = this.head;
    while (runner.next) {
        runner = runner.next;
    }
    runner.next = this.head;
    return "The dastardly deed is complete";
}