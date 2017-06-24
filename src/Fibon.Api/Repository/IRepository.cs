namespace Fibon.Api.Repository{
    public interface IRepository{
        void Insert (int number, int result);
        int? Get (int number);
    }
}