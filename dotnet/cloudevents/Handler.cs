using CloudNative.CloudEvents;

public class Handler
{
    public Task HandleEvent(CloudEvent cloudEvent)
    {
        return Task.CompletedTask;
    }
}