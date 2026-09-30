using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.MoskalevSO.Sprint1.Task6.V17.Lib
{
    public class DataService : ISprint1Task6V17
    {
        public bool CheckPalindrome(string value)
        {
            string text = value.ToLower().Replace(" ", "");

            string reversed = new string(text.Reverse().ToArray());

            return text == reversed;
        }
    }
}