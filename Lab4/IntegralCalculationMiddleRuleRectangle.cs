namespace Lab4;

public class IntegralCalculationMiddleRuleRectangle : IntegralCalculationRuleRectangle
{
    public override string MethodName { get; }

    public IntegralCalculationMiddleRuleRectangle()
    {
        MethodName = "Middle rectangle method";
    }
    
    protected override double MethodArgument(IIntegralCalculation.Integrand integrand, double lowerBound, int interval, double intervalWidth)
    {
        return integrand(lowerBound + interval * intervalWidth + intervalWidth / 2);
    }
}