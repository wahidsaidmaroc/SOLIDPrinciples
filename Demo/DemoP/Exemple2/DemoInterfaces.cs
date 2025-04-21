
namespace DemoS.Exemple2;
public class UserService
{
    private readonly IUserRepository _userRepository;
    private readonly IEmailService _emailService;

    public UserService(IUserRepository userRepository, IEmailService emailService)
    {
        _userRepository = userRepository;
        _emailService = emailService;
    }

    public void RegisterUser(User user)
    {
        _userRepository.Add(user);
        _emailService.SendWelcomeEmail(user);
    }
}

public interface IUserRepository
{
    void Add(User user);
}
public interface IEmailService
{
    void SendWelcomeEmail(User user);
}



public class User 
{
}