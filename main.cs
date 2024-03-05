public class Solution {
    public int LengthOfLastWord(string s) {
        List<string> listValue = s.Trim().Split().ToList();

        return listValue.Last().Length;
    }
}
