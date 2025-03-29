namespace generate_parentheses
{
    public class Solution
    {
        public IList<string> GenerateParenthesis(int n)
        {
            var result = new List<string>();
            var currentArray = new List<string>();
            var maxLengthString = n * 2;
            var totalArrays = n * n;

            for (int i = totalArrays; i >= 1; i--)
            {
                AddCombination(currentArray, i, maxLengthString);

                while (currentArray.Count != 0 && currentArray.Count < maxLengthString)
                {
                    AddCombination(
                        currentArray,
                        maxLengthString - currentArray.Count,
                        maxLengthString
                    );
                }

                AddToResult(result, currentArray, maxLengthString);
                currentArray = new List<string>();
            }

            // special case
            for (int i = 0; i < n; i++)
            {
                currentArray.Add("(");
                currentArray.Add(")");
            }
            AddToResult(result, currentArray, maxLengthString);

            return result.AsEnumerable().Distinct().ToList();
        }

        private static void AddToResult(
            List<string> result,
            List<string> currentArray,
            int maxLengthString
        )
        {

            if (currentArray.Count > maxLengthString)
                return;
            var stringToAdd = string.Join("", currentArray);
            Console.WriteLine($"Try adding {stringToAdd}");
            if (!result.Any(x => x == stringToAdd))
            {
                result.Add(stringToAdd);
            }
        }

        private static void AddCombination(List<string> currentArray, int i, int maxLengthString)
        {
            if (currentArray.Count >= maxLengthString)
                return;

            if (i % 2 != 0)
            {
                currentArray.Add("(");
                for (int j = 0; j < i - 1; j += 2)
                {
                    AddCombination(currentArray, 1, maxLengthString);
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
