function countingSort(arr) {
    const result = new Array(100).fill(0)
    arr.forEach((number) => {
        result[number] ++
    })
    return result
}