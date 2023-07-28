namespace LinqApplyIf.Test;

public class ApplyIfUnitTests
{
    [Fact]
    public void ApplyIf_TrueCondition_ShouldApply_Transformation()
    {
        var elements = new[] { 1, 2, 3, 4, 5 };

        var alteredElements = elements.ApplyIf(() => true, xs => xs.Select(x => x + 1));
        
        Assert.Equal(elements.Select(x => x + 1), alteredElements);
    }
    
    [Fact]
    public void ApplyIf_FalseCondition_NotShouldApply_Transformation()
    {
        var elements = new[] { 1, 2, 3, 4, 5 };

        var alteredElements = elements.ApplyIf(() => false, xs => xs.Select(x => x + 1));
        
        Assert.Equal(elements, alteredElements);
    }
    [Fact]
    public void ApplyIfElse_TrueCondition_ShouldApply_IfTransformation()
    {
        var elements = new[] { 1, 2, 3, 4, 5 };

        var alteredElements = elements.ApplyIfElse(() => true, 
            xs => xs.Select(x => x + 1),
            xs => xs.Select(x => x - 1));
        
        Assert.Equal(elements.Select(x => x + 1), alteredElements);
    }
    
    [Fact]
    public void ApplyIfElse_FalseCondition_ShouldApply_ElseTransformation()
    {
        var elements = new[] { 1, 2, 3, 4, 5 };

        var alteredElements = elements.ApplyIfElse(() => false, 
            xs => xs.Select(x => x + 1),
            xs => xs.Select(x => x - 1));
        
        Assert.Equal(elements.Select(x => x - 1), alteredElements);
    }
}
