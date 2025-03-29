namespace generate_parentheses
{
    public class Runner
    {
        public static void Run()
        {
            //TestCase1();
            //TestCase2();
            TestCase3();
        }

        private static void TestCase1()
        {
            var solution = new Solution();
            int n = 3;
            Console.WriteLine("n = [{0}]", n);
            List<string> expected = new List<string>
            {
                "((()))",
                "(()())",
                "(())()",
                "()(())",
                "()()()"
            };
            Console.WriteLine("expected = [{0}]", string.Join(", ", expected));

            var answers = solution.GenerateParenthesis(n); // Calls your implementation

            for (int i = 0; i < answers.Count - 1; i++)
            {
                if (answers[i] != expected[i])
                    Console.WriteLine(
                        $"generate_parentheses FAILED. answers[{i}] ({answers[i]}) != expectedNums[{i}] ({expected[i]})"
                    );
            }

            Console.WriteLine("Expected = [{0}]", string.Join(", ", expected));
            Console.WriteLine("Output [{0}]", string.Join(", ", answers));
        }

        private static void TestCase2()
        {
            var solution = new Solution();
            int n = 1;
            Console.WriteLine("n = [{0}]", n);
            List<string> expected = new List<string> { "()" };
            Console.WriteLine("expected = [{0}]", string.Join(", ", expected));

            var answers = solution.GenerateParenthesis(n); // Calls your implementation

            for (int i = 0; i < answers.Count - 1; i++)
            {
                if (answers[i] != expected[i])
                    Console.WriteLine(
                        $"generate_parentheses FAILED. answers[{i}] ({answers[i]}) != expectedNums[{i}] ({expected[i]})"
                    );
            }

            Console.WriteLine("Expected = [{0}]", string.Join(", ", expected));
            Console.WriteLine("Output [{0}]", string.Join(", ", answers));
        }

        private static void TestCase3()
        {
            var solution = new Solution();
            int n = 4;
            Console.WriteLine("n = [{0}]", n);
            List<string> expected = new List<string>
            {
                "(((())))",
                "((()()))",
                "((())())",
                "((()))()",
                "(()(()))",
                "(()()())",
                "(()())()",
                "(())(())",
                "(())()()",
                "()((()))",
                "()(()())",
                "()(())()",
                "()()(())",
                "()()()()"
            };
            Console.WriteLine("expected = [{0}]", string.Join(", ", expected));

            var answers = solution.GenerateParenthesis(n); // Calls your implementation

            for (int i = 0; i < answers.Count - 1; i++)
            {
                if (answers[i] != expected[i])
                    Console.WriteLine(
                        $"generate_parentheses FAILED. answers[{i}] ({answers[i]}) != expectedNums[{i}] ({expected[i]})"
                    );
            }

            Console.WriteLine("Expected = [{0}]", string.Join(", ", expected));
            Console.WriteLine("Output [{0}]", string.Join(", ", answers));
        }
    }
}
