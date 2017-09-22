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

            var visaInfoList = bll.GetListByPage(pageIndex,pageSize);

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

        //
        // GET: /VisaInfo/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /VisaInfo/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /VisaInfo/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /VisaInfo/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /VisaInfo/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /VisaInfo/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /VisaInfo/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
