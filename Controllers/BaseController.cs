using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Matrix.Controllers
{
    [ApiController]
    [ApiVersion( "1.0" )]
    [Route( "api/v{version:apiVersion}/[controller]" )]
    [Authorize]
    public class BaseController: ControllerBase
    {
        
    }
}