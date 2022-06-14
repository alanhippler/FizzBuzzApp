namespace FizzBuzzEmbedded
{
    public static class FizzBuzzEmbedded
    {
        public static List<string> WordListOrFizzBuzzResult(List<ValueNamePairs> pairsList, int upperbound)
        {

            // Declare the result string
            List<string> result = new();

            // Loop through the numbers from 1 to the upper bound limit.
            for (int i = 1; i <= upperbound; i++)
            {
                string line = "";

                // If the number is listed in the pairsList, convert the number to the appropriate name.
                // If the number is evenly divisible by multiple numbers in the list, create a list of names to display.
                foreach (ValueNamePairs valueNamePairs in pairsList.OrderBy(x => x.number))
                {
                    if (valueNamePairs.number != 0)
                    {
                        if (i % valueNamePairs.number == 0)
                        {
                            if (line != "")
                            {
                                line += " and " + valueNamePairs.name;
                            }
                            else
                            {
                                line += valueNamePairs.name;
                            }

                        }
                    }

                }

                // If the line is null (because the number was not converted to text), then show the number.
                if (line == "")
                {
                    line += i.ToString();
                };

                // Append this line to the results list.
                result.Add(line);

            };

            // Return the resulting text to the calling method.
            return result;
        }

    }
}
