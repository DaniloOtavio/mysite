namespace MyAPP.LIB.Interfaces.Database
{
    public interface IDatabase
    {
        void Config();
        IPessoa Pessoa { get; }
    }
}
