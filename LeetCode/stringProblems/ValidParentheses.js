/**
 * @param {string} s
 * @return {boolean}
 */
 var isValid = function(s) {
    let bracket ={
        '[':']',
        '(':')',
        '{':'}'
    };
    let heep = [];
    for (let char of s){
        if (bracket[char]){
            heep.push(bracket[char])
        }else{
            if(heep.pop() !== char) return false
        }
    }
    return (!heep.length)
    
};