// Balance Point
// Write a function that returns whether the given array has a balance point BETWEEN indices, where one side’s sum is equal to the other’s. 
// Ex: given [1,1,1,1] > return true, because between indices 1 and 2 the sum on the left and right are equal
// Ex: given [2,1,1] > return true, because between indices 0 and 1 the sum of the left and right are equal
// Ex: given [3,1,1] > return false, because at no point is the left sum equal to the right sum

// Balance Index

// Here, a balance point is ON an index, not between indices. Return the balance index where sums are equal on either side (exclude its own value).
// Return -1 if none exist.
// Ex: given [1,20,1] > return 1 because the sums of the values on the left and right of index 1 are equal
// Ex: given [1,20,2] > return -1 because the sums of the values on the left and right of index 1 are not equal
// Ex: given [1,2,1,20,4] > return 3
// Ex: given [2,2,9,6,-2] > return 2

function balancePoint(arr){
    let leftarr =[];
    let rightarr = arr;
    for(i=rightarr.length-1;i>0; i--){
        if(leftarr == rightarr){
            return console.log(true)
        }
        leftarr.push(arr[i]);
        console.log(leftarr);
        rightarr.pop();
        console.log(rightarr);
    }
    return console.log(false)
};

balancePoint([2,3,5,0])