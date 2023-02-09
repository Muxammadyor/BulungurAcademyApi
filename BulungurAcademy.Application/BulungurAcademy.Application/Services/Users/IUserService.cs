﻿using BulungurAcademy.Application.DataTranferObjects.Users;
namespace BulungurAcademy.Application.Services.Users;

public interface IUserService
{
    ValueTask<UserDto> CreateUserAsync(UserForCreaterDto userForCreaterDto);
    ValueTask<UserDto> ModifyUserAsync(UserForModificationDto userForModificationDto);
    
}
