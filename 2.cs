
namespace Kata
{
    public class CountUniqueElements
    {
        public static int CountUniqueElementsInList(List<int> numbers)
        {

            HashSet<int> uniqueElements = new HashSet<int>();

            
            foreach (var number in numbers)
            {
                uniqueElements.Add(number);
            }

            return uniqueElements.Count;
        }
    }
}
