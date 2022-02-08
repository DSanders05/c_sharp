// for(let i=0;i<256;i++){
//     console.log(i)
// }

// for(let i=1;i<256;i+2){
//     console.log(i)
// }

function printSum(){
    let sum = 0;
    for(let i=0;i<256;i++){
        console.log(i);
        sum+=i;
        console.log(sum);
    }
}

printSum();

function printArray(arr){
    for(let i=0;i<arr.length;i++){
        console.log(arr[i]);
    }
}

printArray([2,6,9,2,7,4])