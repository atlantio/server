namespace Atlant.Bitcoin.Server.Domain.Abstractions.Core
{
    public interface IEntity<TId>
    {
        TId Id { get; }
    }
}
