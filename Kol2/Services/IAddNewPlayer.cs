using Kol2.DTOs;

namespace Kol2.Services;

public interface IAddNewPlayer
{
    Task AddNewPlayer(AddPlayerDto addPlayerDto);
}
    
}