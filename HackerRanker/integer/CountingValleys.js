function countingValleys(steps, path) {
    // Wrote my code here
    let altitude = 0
    let valleys = 0
    for (const a of path) {
      if (altitude === -1 && a === 'U') {valleys++}
      a === 'U' ? altitude++ : altitude--
    }
  return valleys
}