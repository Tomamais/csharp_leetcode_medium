namespace generate_parentheses
{
    public class Solution
    {
        public IList<string> GenerateParenthesis(int n)
        {
            var result = new List<string>();
            var currentArray = new List<string>();
            var totalArrays = n * 2;

            for (int i = totalArrays; i >= 1; i--)
            {
                AddCombination(currentArray, i);

                while (currentArray.Count != 0 && currentArray.Count < totalArrays)
                {
                    AddCombination(currentArray, totalArrays - currentArray.Count);
                }

                AddToResult(result, currentArray);
                currentArray = new List<string>();
            }

            // special case
            for (int i = 0; i < n; i++)
            {
                currentArray.Add("(");
                currentArray.Add(")");
            }
            AddToResult(result, currentArray);

            return result;
        }

        private static void AddToResult(List<string> result, List<string> currentArray)
        {
            var stringToAdd = string.Join("", currentArray);
            if (!result.Any(x => x == stringToAdd))
            {
                result.Add(stringToAdd);
            }
        }

        private static void AddCombination(List<string> currentArray, int i)
        {
            if (i % 2 != 0)
            {
                currentArray.Add("(");
                for (int j = 0; j < i - 1; j += 2)
                {
                    AddCombination(currentArray, 1);
                }
                currentArray.Add(")");
            }
            else
            {
                for (int j = 0; j < i / 2; j++)
                {
                    currentArray.Add("(");
                }

                for (int j = i / 2; j < i; j++)
                {
                    currentArray.Add(")");
                }
            }
        }
    }
}
