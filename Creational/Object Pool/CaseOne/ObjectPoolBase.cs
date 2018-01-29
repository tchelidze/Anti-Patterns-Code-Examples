using System;
using System.Collections.Concurrent;

namespace Object.Pool.CaseOne
{
    public class ObjectPoolBase<TResource>
    {
        private readonly ConcurrentBag<TResource> _pool = new ConcurrentBag<TResource>();
        private readonly Func<TResource> _resourceFactory;

        protected ObjectPoolBase(
            Func<TResource> resourceFactory)
        {
            _resourceFactory = resourceFactory;
        }

        public virtual TResource Acquire()
        {
            return _pool.TryTake(out var resource) ? resource : _resourceFactory();
        }

        public virtual void Release(TResource resource)
        {
            _pool.Add(resource);
        }
    }
}