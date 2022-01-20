function gradingStudents(grades) {
    let rounded = [];
    grades.map(gr =>{
        if(gr < 38){
            rounded.push(gr)
        }else if (gr%5 > 3){
            rounded.push(gr)
        }else{
            let num = Math.ceil((gr/5)+0.1)*5;
            rounded.push(num)
        }
    })
    return rounded
    
}
function gradingStudents(grades) {
    let finalGrades = [];
    
    for(const grade of grades){
        if(grade >= 38){
            const nextMultiple = Math.ceil((grade / 5)+0.1) * 5;
            
            if(nextMultiple - grade < 3){
                finalGrades.push(nextMultiple);
            }else{
                finalGrades.push(grade);
            }
        }else{
            finalGrades.push(grade);
        }

    }
    return finalGrades;
}