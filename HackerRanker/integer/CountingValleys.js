function countingValleys(steps, path) {
  // Write your code here
  let valleyCount = 0
  let elevation = 0
  for (const a of path){
      if(elevation === 0 && a === 'D'){valleyCount++}
      if( a === 'D'){
          elevation--
      }else{
          elevation++
      }
  }
  return valleyCount
}