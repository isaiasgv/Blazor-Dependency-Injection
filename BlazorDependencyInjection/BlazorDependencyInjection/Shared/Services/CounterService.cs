using BlazorDependencyInjection.Shared.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorDependencyInjection.Shared.Services
{
    public class CounterService : ICounterService
    {
        public int Count { get; set; } = 0;

        public int GetCount()
        {
            return Count;
        }

        public void IncrementCount()
        {
            Count++;
        }
    }
}
