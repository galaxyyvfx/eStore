using BusinessLayer;
using DataAccess.Models;
using Microsoft.AspNetCore.Mvc;

namespace eStore.Controllers
{
    public class MemberController : Controller
    {
        IMemberServices memberServices = null;
        public MemberController() => memberServices = new MemberServices();
        // GET: MemberController
        public ActionResult Index()
        {
            return View(memberServices.GetList());
        }

        // GET: MemberController/Details/5
        public ActionResult Details(int id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var member = memberServices.GetMember(id);
            if (member == null)
            {
                return NotFound();
            }
            return View(member);
        }

        // GET: MemberController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MemberController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Member member)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    memberServices.AddMember(member);
                }
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)    
            {
                ViewBag.Message = ex.Message;
                return View(member);
            }
        }

        // GET: MemberController/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var member = memberServices.GetMember(id.Value);
            if (member == null)
            {
                return NotFound();
            }
            return View(member);
        }

        // POST: MemberController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Member member)
        {
            try
            {
                if (id != member.MemberId)
                {
                    return NotFound();
                }
                if (ModelState.IsValid)
                {
                    memberServices.UpdateMember(member);
                }
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.Message = ex.Message;
                return View(member);
            }
        }

        // GET: MemberController/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var member = memberServices.GetMember(id.Value);
            if (member == null)
            {
                return NotFound();
            }
            return View(member);
        }

        // POST: MemberController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            try
            {
                memberServices.DeleteMember(id);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.Message = ex.Message;
                return View();
            }
        }
    }
}
