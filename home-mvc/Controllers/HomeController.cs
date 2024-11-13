using Microsoft.AspNetCore.Mvc;
using EComWindowTeam.HomeMvc.Data;
using EComWindowTeam.HomeMvc.Models;
using System.Linq;

public class HomeController : Controller
{
    private readonly ApplicationDbContext _context;

    public HomeController(ApplicationDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        // Lấy toàn bộ danh sách người dùng
         var users = _context.TbUsers.ToList();

        // Kiểm tra nếu có bất kỳ người dùng nào có IsActive = true
        var activeUser = users.FirstOrDefault(u => u.IsActive);
        bool hasActiveUser = activeUser != null;
        
        // Truyền trạng thái hasActiveUser và id người dùng vào ViewData
        ViewData["HasActiveUser"] = hasActiveUser;
        ViewData["ActiveUserId"] = activeUser?.id;

        return View(users); // Truyền danh sách người dùng qua ModelTruyền danh sách người dùng qua Model
    }

    [HttpPost]
    public IActionResult Logout()
    {
        // Đặt IsActive của tất cả người dùng thành false
        var users = _context.TbUsers.ToList();
        foreach (var user in users)
        {
            user.IsActive = false;
        }
        
        // Lưu thay đổi vào cơ sở dữ liệu
        _context.SaveChanges();

        // Trả về JSON để AJAX biết đã hoàn tất
        return Json(new { success = true });
    }
}
