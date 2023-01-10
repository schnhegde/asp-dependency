Dependency Injection Service Lifecycle

Transient:
each new instance request creates new instance

Scoped:
a new instance is created for each request and every subsiquent instance request refers to the same one for that particular request

Singleton:
instance is created when the service starts and the same instance is referred to whenever instance is requested


When to use transient:
services which are small and require or track little or no state information. as new instances will be created frequently should be as light as possible on the memory

When to use scoped:
services which track or create state information for the request

When to use singleton:
services which track the state of entire application or which are stateless completely, used frequently.








