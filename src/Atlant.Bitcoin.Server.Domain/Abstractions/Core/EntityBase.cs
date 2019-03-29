namespace Atlant.Bitcoin.Server.Domain.Abstractions.Core
{
    public abstract class EntityBase<TId> : IEntity<TId>
    {
        public TId Id { get; }

        public EntityBase(TId id)
        {
            Id = id;
        }
    }
}
