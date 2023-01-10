
namespace ASPDependency.Services
{
    public class BaseDisposableService : ITransientService, ISingletonService, IScopedService
    {

        public string guid { get; }
        public BaseDisposableService()
        {
            guid = Guid.NewGuid().ToString();
        }
        public void Dispose()
        {
            // this for disposing database handles
            // closing connections
            // throw new NotImplementedException();
        }
    }
}
