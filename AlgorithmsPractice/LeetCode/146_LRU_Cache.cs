using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsPractice.LeetCode
{
    public class LRUCache
    {
        Dictionary<int, int> _cache;
        List<int> _usedKeys;
        int _capacity;

        public LRUCache(int capacity)
        {
            // capacity > 0        
            _cache = new Dictionary<int, int>(capacity);
            _usedKeys = new List<int>(capacity);
            _capacity = capacity;
        }

        public int Get(int key)
        {
            if (_cache.ContainsKey(key))
            {
                _usedKeys.Remove(key);
                _usedKeys.Add(key);
                return _cache[key];
            }
            // -1 if not exists
            return -1;
        }

        public void Put(int key, int value)
        {
            // update or insert
            if (_cache.ContainsKey(key))
            {
                // update
                _cache[key] = value;
                _usedKeys.Remove(key);
            }
            else
            {
                if (_cache.Count == _capacity)
                {
                    // evict least recently used if at capacity
                    var keyToRemove = _usedKeys.First();
                    _cache.Remove(keyToRemove);
                    _usedKeys.Remove(keyToRemove);
                }
                _cache.Add(key, value);
            }
            _usedKeys.Add(key);
        }
    }

    /**
     * Your LRUCache object will be instantiated and called as such:
     * LRUCache obj = new LRUCache(capacity);
     * int param_1 = obj.Get(key);
     * obj.Put(key,value);
     */
}
