namespace ConsoleDrawer
{
    public static class StringUtils
    {
        public static bool IsNumber(this string s)
        {
            if(string.IsNullOrEmpty(s)) return false;

            foreach(var character in s)
            {
                if(character < '0' || character > '9')
                {
                    return false;
                }
            }

            return true;
        }
    }
}