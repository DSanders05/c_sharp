// Binary Search
// Given a sorted array and a value, return whether the array contains that value.
// Do not sequentially iterate through the array. Instead, ‘divide and conquer’, taking advantage of the fact that the array is sorted.

// Ex: Given [1,3,4,6,8,10] and 3, return true
// Ex: Given [2,6,8,10,14,16] and 12, return false

const binarySearch = (arr, idx)=>{
    let midpoint = 0;
    let arrHalf = [];
    midpoint = Math.floor(arr.length/2);

    if(idx > arr[midpoint]){
        arr = arr.slice(midpoint, arr.length)
        // console.log(midpoint)
        // console.log(arr)
    }
    else if(idx < arr[midpoint]){
        arr = arr.slice(0, midpoint)
        // console.log(arr)
        // console.log(midpoint)
    }

    while(arr.length > 1){
        midpoint = Math.floor(arr.length/2);
        console.log(midpoint)
        console.log(arr[midpoint])
        if(idx > arr[midpoint]){
            arr = arr.slice(midpoint,arr.length)
        }
        else if(idx < arr[midpoint]){
            arr = arr.slice(0,midpoint)
        }
        else if(idx == arr[midpoint]){
            let finalVal = arr[midpoint];
            console.log(finalVal);
            return true
        }
    }
    console.log("broke out of the while loop")
    if(idx == arr[0]){
        console.log("made it to the check")
        return true
    }
    return false
}

console.log(binarySearch([1,3,4,6,8,10],3))
console.log(binarySearch([2,6,8,10,14,16],12))
