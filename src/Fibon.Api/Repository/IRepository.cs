using System.Collections.Generic;

namespace Fibon.Api.Repository{
    public interface IRepository{
        void Insert (int number, int result);
        int? Get (int number);
        Dictionary<int,int> GetAll();
    }
}