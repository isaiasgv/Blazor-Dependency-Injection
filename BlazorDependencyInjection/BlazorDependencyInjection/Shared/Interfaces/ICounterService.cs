using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorDependencyInjection.Shared.Interfaces
{
    public interface ICounterService
    {
        int Count { get; set; }
        int GetCount();
        void IncrementCount();
    }
}
