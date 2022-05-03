 using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

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

    static string twoArrays(int k, List<int> A, List<int> B)
    {
       int[] Aarr = A.ToArray(); 
       int[] Barr = B.ToArray();
        string flag = "NO";
        for(int i = 0; i < A.Count; i++){
            if(Aarr[i]+Barr[i] > k){
                flag = "YES";
            }
        };
        return flag;
    }