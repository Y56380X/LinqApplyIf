namespace LinqApplyIf.Test;

public class ApplyIfAsyncEnumerableUnitTests
{
    [Fact]
    public void ApplyIf_TrueCondition_ShouldApply_Transformation()
    {
        var elements = new[] { 1, 2, 3, 4, 5 };

        var alteredElements = EnumerateAsync(elements)
            .ApplyIf(() => true, xs => xs.Select(x => x + 1));
        
        Assert.Equal(elements.Select(x => x + 1), alteredElements.ToEnumerable());
    }
    
    [Fact]
    public void ApplyIf_FalseCondition_NotShouldApply_Transformation()
    {
        var elements = new[] { 1, 2, 3, 4, 5 };

        var alteredElements = EnumerateAsync(elements)
            .ApplyIf(() => false, xs => xs.Select(x => x + 1));
        
        Assert.Equal(elements, alteredElements.ToEnumerable());
    }
    
    [Fact]
    public void ApplyIfElse_TrueCondition_ShouldApply_IfTransformation()
    {
        var elements = new[] { 1, 2, 3, 4, 5 };

        var alteredElements = EnumerateAsync(elements)
            .ApplyIfElse(() => true, 
            xs => xs.Select(x => x + 1),
            xs => xs.Select(x => x - 1));
        
        Assert.Equal(elements.Select(x => x + 1), alteredElements.ToEnumerable());
    }
    
    [Fact]
    public void ApplyIfElse_FalseCondition_ShouldApply_ElseTransformation()
    {
        var elements = new[] { 1, 2, 3, 4, 5 };

        var alteredElements = EnumerateAsync(elements)
            .ApplyIfElse(() => false, 
            xs => xs.Select(x => x + 1),
            xs => xs.Select(x => x - 1));
        
        Assert.Equal(elements.Select(x => x - 1), alteredElements.ToEnumerable());
    }
    
    [Fact]
    public void ApplyIf_EvaluatedTrueCondition_ShouldApply_Transformation()
    {
        var elements = new[] { 1, 2, 3, 4, 5 };

        var alteredElements = EnumerateAsync(elements)
            .ApplyIf(true, xs => xs.Select(x => x + 1));
        
        Assert.Equal(elements.Select(x => x + 1), alteredElements.ToEnumerable());
    }
    
    [Fact]
    public void ApplyIf_EvaluatedFalseCondition_NotShouldApply_Transformation()
    {
        var elements = new[] { 1, 2, 3, 4, 5 };

        var alteredElements = EnumerateAsync(elements)
            .ApplyIf(false, xs => xs.Select(x => x + 1));
        
        Assert.Equal(elements, alteredElements.ToEnumerable());
    }
    [Fact]
    public void ApplyIfElse_EvaluatedTrueCondition_ShouldApply_IfTransformation()
    {
        var elements = new[] { 1, 2, 3, 4, 5 };

        var alteredElements = EnumerateAsync(elements)
            .ApplyIfElse(true, 
                xs => xs.Select(x => x + 1),
                xs => xs.Select(x => x - 1));
        
        Assert.Equal(elements.Select(x => x + 1), alteredElements.ToEnumerable());
    }
    
    [Fact]
    public void ApplyIfElse_EvaluatedFalseCondition_ShouldApply_ElseTransformation()
    {
        var elements = new[] { 1, 2, 3, 4, 5 };

        var alteredElements = EnumerateAsync(elements)
            .ApplyIfElse(false, 
                xs => xs.Select(x => x + 1),
                xs => xs.Select(x => x - 1));
        
        Assert.Equal(elements.Select(x => x - 1), alteredElements.ToEnumerable());
    }
    
    private static async IAsyncEnumerable<int> EnumerateAsync(int[] elements)
    {
        foreach (var element in elements)
            yield return await ValueTask.FromResult(element);
    }
}
