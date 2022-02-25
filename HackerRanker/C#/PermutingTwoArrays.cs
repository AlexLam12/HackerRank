 static string twoArrays(int k, List<int> A, List<int> B)
    {
        int[] ABar=A.ToArray();
        int[] BBar=B.ToArray();
        bool flag=false;
        int count=0;
        for(int l=0;l<A.Count;l++){
            int saveB=int.MaxValue,indexB=-1;
            flag=false;
            for(int i=0;i<B.Count;i++){
                if(  BBar[i]!=-1 && (A[l]+B[i])>=k ){
                    if(!flag){
                        count++;
                        flag=true;
                    }
                    if (saveB>BBar[i]){
                        if(indexB!=-1)
                        {
                            BBar[indexB]=saveB;
                        }
                        saveB=BBar[i];
                        indexB=i;
                        BBar[indexB]=-1;
                    }
                }
            }
            if(count==A.Count){
                return "YES";
            }
        }
        return "NO";   
    }