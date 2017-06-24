using System;
using System.Collections.Generic;

namespace Fibon.Api.Repository{
    public class Repository:IRepository{
        private Dictionary<int, int> storage = new Dictionary<int,int>();

        int? IRepository.Get(int number)
        {
            int result;
            if (storage.TryGetValue(number, out result)){
                return result;
            }
            return null;
        }

        void IRepository.Insert(int number, int result)
        {
            storage[number] = result;
        }
    }
}