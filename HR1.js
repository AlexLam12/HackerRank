function processData(input) {
    //Enter your code here
    //if first letter is S insert space before capital letter and make all letters lowercase
    //if first letter is C capitalize letter after space
    //if second letter is M add () st the end
    //if second letter is C capitalize first letter
    const titleCase = (word) => word.charAt(0).toUpperCase() + word.slice(1);
    function processData(input) {
      const inputArray = (input.includes("\r")) ? input.split("\r\n") : input.split("\n");
      inputArray.forEach(inp=>{
      let arr = inp.split(';');
      let word = arr[2].split(' ');
    if(arr[0] == 'C') {
            switch (arr[1]) {
            case 'M':
              let pw = word.map(w=>titleCase(w)).join('').trim();
              console.log(pw.charAt(0).toLowerCase() + pw.slice(1) + '()');
              break;
            case 'V':
              let pwV = word.map(w=>titleCase(w)).join('').trim();
             console.log(pwV.charAt(0).toLowerCase() + pwV.slice(1));
              break;
            case 'C':
             console.log(word.map(w=>titleCase(w)).join('').trim())
              break;
          }  
    }
    else if(arr[0] == 'S') {
            switch (arr[1]) {
            case 'M':
             console.log(arr[2].split(/\W+|(?=[A-Z])|_/g).join(' ').toLowerCase());
              break;
            case 'V':
              console.log(arr[2].split(/\W+|(?=[A-Z])|_/g).join(' ').toLowerCase());
              break;
            case 'C':
               console.log(arr[2].match(/[A-Z][a-z]+|[0-9]+/g).map(w=>w.toLowerCase()).join(' '));
              break;
          }
       }
       })
       return input;
    }
    process.stdin.resume();
    process.stdin.setEncoding("ascii");
    _input = "";
    process.stdin.on("data", function (input) {
        _input += input;
    });
    
    process.stdin.on("end", function () {
       processData(_input);
    });
}