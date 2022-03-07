    ratings = ratings.sort(function(a, b){return a-b});
    var bias = 0;
    for(var i=0; i<ratings.length; ++i){
        bias += ratings[i+1]-ratings[i];
        ++i
    }
    return bias