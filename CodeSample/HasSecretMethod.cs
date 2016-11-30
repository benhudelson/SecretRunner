namespace CodeSample
{
    public static class HasSecretMethod
    {
        public static int Secret(int number)
        {
            if (number < 1000)
            {
                return number;
            }
            return number + 1;
        }
    }
}