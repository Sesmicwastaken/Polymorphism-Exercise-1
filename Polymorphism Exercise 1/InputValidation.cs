namespace Polymorphism_Exercise_1
{
    public class InputValidation
    {
        public static bool IsValid(string input)
        {
            return String.IsNullOrWhiteSpace(input);
        }

        //public static bool IsValid(TimeSpan input)
        //{
        //    if (input <= TimeSpan.Zero)
        //    {
        //        return false;
        //    }
        //    else
        //    {
        //        return true;
        //    }
        //}
    }
}