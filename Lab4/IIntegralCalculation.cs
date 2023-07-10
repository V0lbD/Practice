namespace Lab4;

public interface IIntegralCalculation
{
    public string? MethodName
    {
        get;
    }
    
    public delegate double Integrand(double x); // delegate for integrand
    public static void CheckBoundsAndEps(ref double lowerBound, ref double upperBound, ref double eps)
    {
        if (eps <= 0)
        {
            eps = -eps;
        }
        
        if (lowerBound > upperBound)
        {
            (lowerBound, upperBound) = (upperBound, lowerBound);
        }
    }

    public (double, int) IntegralCalculation(Integrand integrand, double lowerBound, double highBound, double eps);
}