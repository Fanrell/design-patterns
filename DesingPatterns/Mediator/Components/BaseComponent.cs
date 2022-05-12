namespace DesingPatterns.Mediator.Components;

public class BaseComponent
{
    protected IMediator _mediator;

    public BaseComponent( IMediator mediator = null)
    {
        SetMediator(mediator);
    }

    public void SetMediator(IMediator mediator)
    {
        _mediator = mediator;
    }
}