using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFramework.Core.CrossCuttingConcerns.Caching
{
    public interface ICacheManager
    {
        T GetT<T>(string key);
        void Add(string key, object data, int cachetime);
        bool IsAdd(string key);
        void Remove(string key);
        void RemoveByPattern(string pattern);
        void Clear();
    }
}
