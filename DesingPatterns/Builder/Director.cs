namespace DesingPatterns.Builder;

public class Director
{
    private IBuilder _builder;

    public IBuilder Builder
    {
        set { _builder = value; }
    }

    public void BuildMinimalViableProduct()
    {
        this._builder.BuildPartA();
    }

    public void BuildFullFeaturedProduct()
    {
        this._builder.BuildPartA();
        this._builder.BuildPartB();
        this._builder.BuildPartC();
    }
}