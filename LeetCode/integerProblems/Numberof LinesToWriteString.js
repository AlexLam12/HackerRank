/**
 * @param {number[]} widths
 * @param {string} s
 * @return {number[]}
 */
 var numberOfLines = function(widths, s) {
    let numLines = 1;
    let width = 0;

    for (let i =0; i< s.length; i++){
        const value = s[i].charCodeAt() -97;
        const w = widths[value];
        if (width + w > 100){
            numLines++;
            width = w;
        }else{
            width += w;
        }
    }
    
    return [numLines, width]
};