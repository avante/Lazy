namespace Lazy.Services;

public interface ISomething
{
    public string DoSomething();
    public string DoSomethingAndCallDependentService();
}