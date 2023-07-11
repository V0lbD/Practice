namespace Lab4;

public class IntegralCalculationRightRuleRectangle : IntegralCalculationRuleRectangle
{
    public override string MethodName { get; }

    public IntegralCalculationRightRuleRectangle()
    {
        MethodName = "Right rule rectangle method";
    }
    
    protected override double MethodArgument(IIntegralCalculation.Integrand integrand, double lowerBound, int interval, double intervalWidth)
    {
        return integrand(lowerBound + (interval + 1) * intervalWidth);
    }
}