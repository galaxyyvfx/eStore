using BusinessLayer;
using DataAccess.Models;
using eStore.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace eStore.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Login(Member member)
    {
        try
        {
            IMemberServices memberServices = new MemberServices();
            
            var loginMember = memberServices.Login(member.Email, member.Password);
            HttpContext.Session.SetInt32("LoginUserId", loginMember.MemberId);

            return RedirectToAction("List", "MemberController");
        }
        catch (Exception ex)
        {
            TempData["ERROR"] = ex.Message;
            return View("Index");
        }
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
