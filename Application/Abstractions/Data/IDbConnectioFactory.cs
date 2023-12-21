using System.Data;

namespace Application.Abstractions.Data;

public interface IDbConnectioFactory
{
    IDbConnection CreateOpenConnection();
}
