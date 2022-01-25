function diagonalDifference(arr) {
    // Write your code here
    let lrdiag = 0;
    let rldiag = 0;
    
    for(let i=0; i<arr.length;i++){
        lrdiag += arr[i][i];
        rldiag += arr[i][(arr.length-i)-1]
    }
    return Math.abs(lrdiag-rldiag)
}