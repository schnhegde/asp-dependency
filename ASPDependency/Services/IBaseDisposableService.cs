namespace ASPDependency.Services
{
    public interface IBaseDisposableService : IDisposable
    {
        public string guid { get; }
    }

    public interface ITransientService : IBaseDisposableService { }
    public interface IScopedService : IBaseDisposableService { }
    public interface ISingletonService : IBaseDisposableService { }

}
