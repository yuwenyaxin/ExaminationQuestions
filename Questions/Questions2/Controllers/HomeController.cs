using Microsoft.AspNetCore.Mvc;
using Questions2.Models;
using System.Diagnostics;

namespace Questions2.Controllers
{
    public class HomeController : Controller
    {
        public BridgeContext DBContext;

        public HomeController(BridgeContext context)
        {
            DBContext = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// 插入数据
        /// </summary>
        /// <param name="Bridge"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult CreateBridge(BridgeTable Bridge)
        {
            DBContext.BridgeTable.Add(Bridge);
            bool result=DBContext.SaveChanges() > 0;
            if (result)
            {
                return Json(new { code = 0, message = "添加成功" });
            }
            else
            {
                return Json(new { code = -1, message = "添加失败" });
            }
        }

        /// <summary>
        /// 删除数据
        /// </summary>
        /// <param name="Bridge"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult DeleteBridge(int ID)
        {
            BridgeTable Bridge = DBContext.BridgeTable.Find(ID);
            if (Bridge != null)
            {
                DBContext.BridgeTable.Remove(Bridge);
                bool result = DBContext.SaveChanges() > 0;
                if (result)
                {
                    return Json(new { code = 0, message = "删除成功" });
                }
                else
                {
                    return Json(new { code = -1, message = "删除失败" });
                }
            }
            else
            {
                return Json(new { code = -1, message = "未找到删除的数据" });
            }
        }

        /// <summary>
        /// 全部记录
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult GetBridgeTable()
        {
            List<BridgeTable> list = DBContext.BridgeTable.ToList();
            return Json(new { code = 0, message = "添加成功",data=list });
        }

        /// <summary>
        /// 修改数据
        /// </summary>
        /// <param name="Bridge"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult UpdateBridge(BridgeTable bridgeTable)
        {
            BridgeTable Bridge = DBContext.BridgeTable.Find(bridgeTable.Id);
            if (Bridge != null)
            {
                DBContext.BridgeTable.Update(Bridge);
                bool result = DBContext.SaveChanges() > 0;
                if (result)
                {
                    return Json(new { code = 0, message = "修改成功" });
                }
                else
                {
                    return Json(new { code = -1, message = "修改失败" });
                }
            }
            else
            {
                return Json(new { code = -1, message = "未找到修改的数据" });
            }
        }
    }
}