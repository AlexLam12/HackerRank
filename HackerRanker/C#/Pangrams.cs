class Result
{

    /*
     * Complete the 'pangrams' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string pangrams(string s)
    {
  return "abcdefghijklmnopqrstuvwxyz".Intersect(s.ToLower()).Count() == 26 ? "pangram" : "not pangram";
 
    }

}