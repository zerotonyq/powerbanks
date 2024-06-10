using PP.Domain.Entities;

namespace PP.Infrastucture.UserRepository;

public interface IUserRepository
{
    Task<User> Get(long id, CancellationToken cancellationToken);

    Task Add(User user, CancellationToken cancellationToken);

    Task Update(User user, CancellationToken cancellationToken);
}