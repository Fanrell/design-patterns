namespace DesingPatterns.Template;

public abstract class AbstractClass
{
    public void TemplateMethod()
    {
        this.BaseOperation1();
        this.RequiredOperation1();
        this.BaseOperation2();
        this.Hook1();
        this.RequiredOperation2();
        this.BaseOperation3();
        this.Hook2();
    }

    protected void BaseOperation1() => Console.WriteLine("Abstract Class: \n Base Operation 1");
    protected void BaseOperation2() => Console.WriteLine("Abstract Class: \n Base Operation 2");
    protected void BaseOperation3() => Console.WriteLine("Abstract Class: \n Base Operation 3");

    protected abstract void RequiredOperation1();
    protected abstract void RequiredOperation2();

    protected virtual void Hook1() {}
    protected virtual void Hook2() {}

}