using BlazorDependencyInjection.Shared.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorDependencyInjection.Shared.Services
{
    public class CounterServiceWrapper
    {
        private ICounterService _counterService;
        public CounterServiceWrapper(CounterService counterService)
        {
            _counterService = counterService;
        }

        public int GetCount()
        {
            return _counterService.GetCount();
        }

        public void IncrementCount()
        {
             _counterService.IncrementCount();
        }
    }
}
