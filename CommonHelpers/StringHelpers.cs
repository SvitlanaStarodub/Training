namespace CommonHelpers
{
    public static class StringHelpers
    {
        public static bool IsEmptyString(this string s)
        {
            return string.IsNullOrWhiteSpace(s) || string.IsNullOrEmpty(s);
        }
    }
}
