static int marsExploration(string s)
    {
        string substr="SOS";
        int i=0;
        int changes=0;
        while(i<s.Length){
             if (s[i]!=substr[i%substr.Length])
                 changes++;
             i++;
        }
        return changes;
    }