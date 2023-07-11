using Lab4;
using System.Globalization;

namespace Lab4
{
    class Program
    {
        public static double IntegrandFunc(double x)
        {
            return Math.Exp(x);
        }

        static double GetMs(long tick)
        {
            return tick * 1.0 / 10000000;
        }
        static void Main(string[] args)
        {
            try
            {
                IIntegralCalculation.Integrand integrand = IntegrandFunc;
                double lowerBound = 0;
                double upperBound = 2;
                double eps = 1.0 / 1000000;
                
                #region методы прямоугольников
                
                var leftRectangleMethod = new IntegralCalculationLeftRuleRectangle();
                var rightRectangleMethod = new IntegralCalculationRightRuleRectangle();
                var middleRectangleMethod = new IntegralCalculationMiddleRuleRectangle();
                
                var watchLeft = System.Diagnostics.Stopwatch.StartNew();
                (double, int) resultLeft = leftRectangleMethod.IntegralCalculation(integrand, lowerBound, upperBound, eps);
                watchLeft.Stop();
                var elapsedLeft = GetMs(watchLeft.ElapsedTicks);
                
                var watchRight = System.Diagnostics.Stopwatch.StartNew();
                (double, int) resultRight = rightRectangleMethod.IntegralCalculation(integrand, lowerBound, upperBound, eps);
                watchRight.Stop();
                var elapsedRight = GetMs(watchRight.ElapsedTicks);
            
                var watchMiddle = System.Diagnostics.Stopwatch.StartNew();
                (double, int) resultMiddle = middleRectangleMethod.IntegralCalculation(integrand, lowerBound, upperBound, eps);
                watchMiddle.Stop();
                var elapsedMiddle = GetMs(watchMiddle.ElapsedTicks);
                #endregion
                
                IntegralCalculationTrapezoidal trapezoidalMethod = new IntegralCalculationTrapezoidal();
                var watchTrapezoidal = System.Diagnostics.Stopwatch.StartNew();
                (double, int) resultTrapez = trapezoidalMethod.IntegralCalculation(integrand, lowerBound, upperBound, eps);
                watchTrapezoidal.Stop();
                var elapsedTrapezoidal = GetMs(watchTrapezoidal.ElapsedTicks);
            
                IntegralCalculationSimpsonRule simpsonRule = new IntegralCalculationSimpsonRule();
                var watchSimpson = System.Diagnostics.Stopwatch.StartNew();
                (double, int) resultSimpson = simpsonRule.IntegralCalculation(integrand, lowerBound, upperBound, eps);
                watchSimpson.Stop();
                var elapsedSimpson = GetMs(watchSimpson.ElapsedTicks);
                
            
                Console.WriteLine("With eps = {0}", eps.ToString(CultureInfo.InvariantCulture));
                Console.WriteLine("{0, -4}: {2, -3}    {1, -2}     {3, -1} ", "Method name", "Time consumed s", "Result", "Iterations count");
                Console.WriteLine("{0, -4}: {2, -3}    {1, -2}     {3, -1} ", leftRectangleMethod.MethodName, elapsedLeft.ToString(), resultLeft.Item1.ToString(CultureInfo.InvariantCulture), resultLeft.Item2.ToString());
                Console.WriteLine("{0, -4}: {2, -3}    {1, -2}     {3, -1} ", rightRectangleMethod.MethodName, elapsedRight.ToString(), resultRight.Item1.ToString(CultureInfo.InvariantCulture), resultRight.Item2.ToString());
                Console.WriteLine("{0, -4}: {2, -3}    {1, -2}     {3, -1} ", middleRectangleMethod.MethodName, elapsedMiddle.ToString(), resultMiddle.Item1.ToString(CultureInfo.InvariantCulture), resultMiddle.Item2.ToString());
                Console.WriteLine("{0, -4}: {2, -3}    {1, -2}     {3, -1} ", trapezoidalMethod.MethodName, elapsedTrapezoidal.ToString(), resultTrapez.Item1.ToString(CultureInfo.InvariantCulture), resultTrapez.Item2.ToString());
                Console.WriteLine("{0, -4}: {2, -3}    {1, -2}     {3, -1} ", simpsonRule.MethodName, elapsedSimpson.ToString(), resultTrapez.Item1.ToString(CultureInfo.InvariantCulture), resultSimpson.Item2.ToString());
            }
            catch (ArgumentNullException exception)
            {
                Console.WriteLine(exception.Message);
            }   
            catch (ArgumentException exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}