function matchingStrings(strings, queries) {
    // Write your code here
    let matches = []
    queries.forEach(q => matches.push((string.filter(s=> s === q)).length));
    return matches;
}