function center (strng, width, fill = ' ') {
    if(strng.length < width){
        strng= fill + strng
    }
    if(strng.length < width){
        strng = strng + fill
    }
    if(strng.length < width){
        center(strng, width, fill)
    }

 return strng
}