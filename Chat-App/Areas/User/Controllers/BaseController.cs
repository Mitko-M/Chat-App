using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Chat_App.Areas.User.Controllers
{
    [Authorize]
    public class BaseController : Controller
    {
       
    }
}
