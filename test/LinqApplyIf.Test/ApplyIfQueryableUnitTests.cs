namespace LinqApplyIf.Test;

public class ApplyIfQueryableUnitTests
{
    [Fact]
    public void ApplyIf_TrueCondition_ShouldApply_Transformation()
    {
        var elements = new[] { 1, 2, 3, 4, 5 };

        var alteredElements = elements
            .AsQueryable()
            .ApplyIf(() => true, xs => xs.Select(x => x + 1));
        
        Assert.Equal(elements.Select(x => x + 1), alteredElements);
    }
    
    [Fact]
    public void ApplyIf_FalseCondition_NotShouldApply_Transformation()
    {
        var elements = new[] { 1, 2, 3, 4, 5 };

        var alteredElements = elements
            .AsQueryable()
            .ApplyIf(() => false, xs => xs.Select(x => x + 1));
        
        Assert.Equal(elements, alteredElements);
    }
    [Fact]
    public void ApplyIfElse_TrueCondition_ShouldApply_IfTransformation()
    {
        var elements = new[] { 1, 2, 3, 4, 5 };

        var alteredElements = elements
            .AsQueryable()
            .ApplyIfElse(() => true, 
            xs => xs.Select(x => x + 1),
            xs => xs.Select(x => x - 1));
        
        Assert.Equal(elements.Select(x => x + 1), alteredElements);
    }
    
    [Fact]
    public void ApplyIfElse_FalseCondition_ShouldApply_ElseTransformation()
    {
        var elements = new[] { 1, 2, 3, 4, 5 };

        var alteredElements = elements
            .AsQueryable()
            .ApplyIfElse(() => false, 
            xs => xs.Select(x => x + 1),
            xs => xs.Select(x => x - 1));
        
        Assert.Equal(elements.Select(x => x - 1), alteredElements);
    }
}
