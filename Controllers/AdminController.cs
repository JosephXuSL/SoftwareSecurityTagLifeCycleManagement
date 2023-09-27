using SSTLifeCycleManagement.Models;
using SSTLifeCycleManagement.Repositories;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using SSTLifeCycleManagement.Entities;
using Microsoft.EntityFrameworkCore;

namespace SSTLifeCycleManagement.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    [Produces("application/json")]
    public class AdminController : ControllerBase
    {
        private readonly ILogger<AdminController> _logger;
        private readonly DataRepository _repository;
        private readonly IMapper _mapper;

        public AdminController(ILogger<AdminController> logger, DataRepository repository, IMapper mapper)
        {
            _logger = logger;
            _repository = repository;
            _mapper = mapper;
        }


        #region Admin
        [HttpPost(Name = "AddAdmin")]
        [ProducesResponseType(200)]
        public async Task<IActionResult> AddAdmin([FromBody] AdminDto request)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var admin = _mapper.Map<Admin>(request);
                    if (await _repository.AddAdminAsync(admin))
                    {
                        return Ok(admin);
                    }
                }
                else
                {
                    return BadRequest(ModelState);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError($"Failed due to : {ex}");
            }
            return BadRequest("Some error makes request failed");
        }                

        [HttpPost]
        [ProducesResponseType(200)]
        public async Task<IActionResult> UpdateAdmin([FromBody] AdminDto request)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    
                    if (await _repository.UpdateAdminAsync(request))
                    {
                        return Ok("updated");
                    }
                }
                else
                {
                    return BadRequest(ModelState);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError($"Failed due to : {ex}");
            }
            return BadRequest("Some error makes request failed");
        }

        [HttpGet("{id:}")]
        [ProducesResponseType(typeof(Admin), 200)]
        public async Task<IActionResult> GetAdminById(int id)
        {
            try
            {
                var result = await _repository.GetAdminById(id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Failed due to : {ex}");
                return BadRequest("Some error makes request failed");
            }
        }
        #endregion Admin

        #region AdminAccount
        [HttpPost]
        [ProducesResponseType(200)]
        public async Task<IActionResult> AddAdminAccount([FromBody] AdminAccountDto request)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var adminAccount = _mapper.Map<AdminAccount>(request);
                    if (await _repository.AddAdminAccountAsync(adminAccount))
                    {
                        return Ok(adminAccount);
                    }
                }
                else
                {
                    return BadRequest(ModelState);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError($"Failed due to : {ex}");
            }
            return BadRequest("Some error makes request failed");
        }

        [HttpPost]
        [ProducesResponseType(200)]
        public async Task<IActionResult> UpdateAdminAccount([FromBody] AdminAccountDto request)
        {
            try
            {
                if (ModelState.IsValid)
                {

                    if (await _repository.UpdateAdminAccountAsync(request))
                    {
                        return Ok("updated");
                    }
                }
                else
                {
                    return BadRequest(ModelState);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError($"Failed due to : {ex}");
            }
            return BadRequest("Some error makes request failed");
        }

        [HttpGet("{id:}")]
        [ProducesResponseType(typeof(AdminAccount), 200)]
        public async Task<IActionResult> GetAdminAccountById(int id)
        {
            try
            {
                var result = await _repository.GetAdminAccountById(id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Failed due to : {ex}");
                return BadRequest("Some error makes request failed");
            }
        }
        #endregion AdminAccount

        #region User
        [HttpPost]
        [ProducesResponseType(200)]
        public async Task<IActionResult> AddUser([FromBody] UserDto request)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var user = _mapper.Map<User>(request);
                    if (await _repository.AddUserAsync(user))
                    {
                        return Ok(user);
                    }
                }
                else
                {
                    return BadRequest(ModelState);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError($"Failed due to : {ex}");
            }
            return BadRequest("Some error makes request failed");
        }

        [HttpPost]
        [ProducesResponseType(200)]
        public async Task<IActionResult> UpdateUser([FromBody] UserDto request)
        {
            try
            {
                if (ModelState.IsValid)
                {

                    if (await _repository.UpdateUserAsync(request))
                    {
                        return Ok("updated");
                    }
                }
                else
                {
                    return BadRequest(ModelState);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError($"Failed due to : {ex}");
            }
            return BadRequest("Some error makes request failed");
        }

        [HttpGet("{id:}")]
        [ProducesResponseType(typeof(User), 200)]
        public async Task<IActionResult> GetUserById(int id)
        {
            try
            {
                var result = await _repository.GetUserById(id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Failed due to : {ex}");
                return BadRequest("Some error makes request failed");
            }
        }
        #endregion User

        #region UserAccount
        [HttpPost]
        [ProducesResponseType(200)]
        public async Task<IActionResult> AddUserAccount([FromBody] UserAccountDto request)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var UserAccount = _mapper.Map<UserAccount>(request);
                    if (await _repository.AddUserAccountAsync(UserAccount))
                    {
                        return Ok(UserAccount);
                    }
                }
                else
                {
                    return BadRequest(ModelState);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError($"Failed due to : {ex}");
            }
            return BadRequest("Some error makes request failed");
        }

        [HttpPost]
        [ProducesResponseType(200)]
        public async Task<IActionResult> UpdateUserAccount([FromBody] UserAccountDto request)
        {
            try
            {
                if (ModelState.IsValid)
                {

                    if (await _repository.UpdateUserAccountAsync(request))
                    {
                        return Ok("updated");
                    }
                }
                else
                {
                    return BadRequest(ModelState);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError($"Failed due to : {ex}");
            }
            return BadRequest("Some error makes request failed");
        }

        [HttpGet("{id:}")]
        [ProducesResponseType(typeof(UserAccount), 200)]
        public async Task<IActionResult> GetUserAccountById(int id)
        {
            try
            {
                var result = await _repository.GetUserAccountById(id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Failed due to : {ex}");
                return BadRequest("Some error makes request failed");
            }
        }
        #endregion UserAccount

        #region Developer
        [HttpPost]
        [ProducesResponseType(200)]
        public async Task<IActionResult> AddDeveloper([FromBody] DeveloperDto request)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var developer = _mapper.Map<Developer>(request);
                    if (await _repository.AddDeveloperAsync(developer))
                    {
                        return Ok(developer);
                    }
                }
                else
                {
                    return BadRequest(ModelState);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError($"Failed due to : {ex}");
            }
            return BadRequest("Some error makes request failed");
        }

        [HttpPost]
        [ProducesResponseType(200)]
        public async Task<IActionResult> UpdateDeveloper([FromBody] DeveloperDto request)
        {
            try
            {
                if (ModelState.IsValid)
                {

                    if (await _repository.UpdateDeveloperAsync(request))
                    {
                        return Ok("updated");
                    }
                }
                else
                {
                    return BadRequest(ModelState);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError($"Failed due to : {ex}");
            }
            return BadRequest("Some error makes request failed");
        }

        [HttpGet("{id:}")]
        [ProducesResponseType(typeof(Developer), 200)]
        public async Task<IActionResult> GetDeveloperById(int id)
        {
            try
            {
                var result = await _repository.GetDeveloperById(id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Failed due to : {ex}");
                return BadRequest("Some error makes request failed");
            }
        }
        #endregion Developer

        #region SecurityTag
        [HttpPost]
        [ProducesResponseType(200)]
        public async Task<IActionResult> AddSecurityTag([FromBody] SecurityTagDto request)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var tag = _mapper.Map<SecurityTag>(request);
                    if (await _repository.AddSecurityTagAsync(tag))
                    {
                        return Ok(tag);
                    }
                }
                else
                {
                    return BadRequest(ModelState);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError($"Failed due to : {ex}");
            }
            return BadRequest("Some error makes request failed");
        }

        [HttpPost]
        [ProducesResponseType(200)]
        public async Task<IActionResult> UpdateSecurityTag([FromBody] SecurityTagDto request)
        {
            try
            {
                if (ModelState.IsValid)
                {

                    if (await _repository.UpdateSecurityTagAsync(request))
                    {
                        return Ok("updated");
                    }
                }
                else
                {
                    return BadRequest(ModelState);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError($"Failed due to : {ex}");
            }
            return BadRequest("Some error makes request failed");
        }

        [HttpGet("{id:}")]
        [ProducesResponseType(typeof(SecurityTag), 200)]
        public async Task<IActionResult> GetSecurityTagById(int id)
        {
            try
            {
                var result = await _repository.GetSecurityTagById(id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Failed due to : {ex}");
                return BadRequest("Some error makes request failed");
            }
        }
        #endregion SecurityTag

        #region RoleAccess
        [HttpPost]
        [ProducesResponseType(200)]
        public async Task<IActionResult> AddRoleAccess([FromBody] RoleAccessDto request)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var role = _mapper.Map<RoleAccess>(request);
                    if (await _repository.AddRoleAccessAsync(role))
                    {
                        return Ok(role);
                    }
                }
                else
                {
                    return BadRequest(ModelState);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError($"Failed due to : {ex}");
            }
            return BadRequest("Some error makes request failed");
        }

        [HttpPost]
        [ProducesResponseType(200)]
        public async Task<IActionResult> UpdateRoleAccess([FromBody] RoleAccessDto request)
        {
            try
            {
                if (ModelState.IsValid)
                {

                    if (await _repository.UpdateRoleAccessAsync(request))
                    {
                        return Ok("updated");
                    }
                }
                else
                {
                    return BadRequest(ModelState);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError($"Failed due to : {ex}");
            }
            return BadRequest("Some error makes request failed");
        }

        [HttpGet("{id:}")]
        [ProducesResponseType(typeof(RoleAccess), 200)]
        public async Task<IActionResult> GetRoleAccessById(int id)
        {
            try
            {
                var result = await _repository.GetRoleAccessById(id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Failed due to : {ex}");
                return BadRequest("Some error makes request failed");
            }
        }
        #endregion RoleAccess

        #region UserRole
        [HttpPost]
        [ProducesResponseType(200)]
        public async Task<IActionResult> AddUserRole([FromBody] UserRoleDto request)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var role = _mapper.Map<UserRole>(request);
                    if (await _repository.AddUserRoleAsync(role))
                    {
                        return Ok(role);
                    }
                }
                else
                {
                    return BadRequest(ModelState);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError($"Failed due to : {ex}");
            }
            return BadRequest("Some error makes request failed");
        }

        [HttpPost]
        [ProducesResponseType(200)]
        public async Task<IActionResult> UpdateUserRole([FromBody] UserRoleDto request)
        {
            try
            {
                if (ModelState.IsValid)
                {

                    if (await _repository.UpdateUserRoleAsync(request))
                    {
                        return Ok("updated");
                    }
                }
                else
                {
                    return BadRequest(ModelState);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError($"Failed due to : {ex}");
            }
            return BadRequest("Some error makes request failed");
        }

        [HttpGet("{id:}")]
        [ProducesResponseType(typeof(UserRole), 200)]
        public async Task<IActionResult> GetUserRoleById(int id)
        {
            try
            {
                var result = await _repository.GetUserRoleById(id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Failed due to : {ex}");
                return BadRequest("Some error makes request failed");
            }
        }
        #endregion UserRole

    }
}
