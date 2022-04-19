namespace CSharpBasics
{
    public class ExceptionHandling
    {
        public static float Divide(int numeratior, int denominator)
        {
            float result =0;
            try{
            result = numeratior/denominator;
            }
            catch(DivideByZeroException ex){
                //Logging Logic => NLog
                Console.WriteLine(ex.Message);
            }
            return result;
        }
    }
}