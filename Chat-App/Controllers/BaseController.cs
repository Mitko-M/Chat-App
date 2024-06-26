using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Chat_App.Controllers
{
    [Authorize]
    public class BaseController : Controller
    {

    }
}
