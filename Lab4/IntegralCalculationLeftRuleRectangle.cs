namespace Lab4;

public class IntegralCalculationLeftRuleRectangle : IntegralCalculationRuleRectangle
{
    public override string MethodName { get; }

    public IntegralCalculationLeftRuleRectangle()
    {
        MethodName = "Left rule rectangle method";
    }
    
    protected override double MethodArgument(IIntegralCalculation.Integrand integrand, double lowerBound, int interval, double intervalWidth)
    {
        return integrand(lowerBound + interval * intervalWidth);
    }
}