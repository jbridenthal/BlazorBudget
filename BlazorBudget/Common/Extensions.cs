namespace BlazorBudget.Common
{
    public static class Extensions
    {

        public static bool IsNumeric(this string checkValue)
        {
          return  int.TryParse(checkValue, out _);
        }
        public static bool IsNullOrWhiteSpace(this string checkValue)
        {
            return string.IsNullOrWhiteSpace(checkValue);
        }

    }
}
