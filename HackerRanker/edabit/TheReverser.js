function reverse(str) {
	var newStr = "";
	for (var i = str.length - 1; i >= 0; i--){
		var letter = str[i]
		if (letter == letter.toUpperCase()){
			letter = letter.toLowerCase()
		}
		else {
			letter = letter.toUpperCase()
		}
		newStr += letter;
	}
	return newStr;
}