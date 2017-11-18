using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravletAgence.BLL;

namespace TravletAgence.UI.Controllers
{
    public class VisaInfoController : Controller
    {
        //
        // GET: /VisaInfo/
        BLL.VisaInfo bll = new VisaInfo();
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult GetAllVisaInfos()
        {
            int pageSize = int.Parse(Request["rows"]);
            int pageIndex = int.Parse(Request["page"]);

            //过滤的用户名   过滤备注schName   schRemark
            string schName = Request["schName"];
            string schRemark = Request["schRemark"];
            int total = bll.GetRecordCount(string.Empty);

            var visaInfoList = bll.GetListByPageOrderByOutState(pageIndex,pageSize);

            var data = new { total = total, rows = visaInfoList };

            return Json(data, JsonRequestBehavior.AllowGet);
        }


        #region 添加用户
        public ActionResult Add(Model.VisaInfo visaInfo)
        {
            visaInfo.EntryTime = DateTime.Now;
            if (bll.Add(visaInfo))
            {
                return Content("ok");
            }
            else
            {
                return Content("添加失败，请检查用户是否已经存在!");
            }
        }
        #endregion
        

        #region 删除
        public ActionResult Delete(string ids)
        {
            if (string.IsNullOrEmpty(ids))
            {
                return Content("请选中要删除数据！");
            }

            //正常处理
            string[] strIds = ids.Split(',');
            //UserInfoService.DeleteList(idList);
            bll.DeleteListByPassNo(strIds.ToList());
            return Content("ok");
        }
        #endregion
    }
}
