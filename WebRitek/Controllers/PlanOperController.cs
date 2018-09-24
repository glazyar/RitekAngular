using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Core.Service;
using Core.Model.DTO;
namespace WebRitek.Controllers
{
    public class PlanOperController : Controller
    {
        // GET: PlanOper
        public JsonResult GetPlanOperNFT(int tpp,int month,int year)
        {
            try
            {
                PlanService planService = new PlanService();
                List<PlanOperNftDTO> list = planService.GetPlanOperNFT(tpp);
                return Json(list, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json(new { Title = "Error", MessageErr = ex.Message }, JsonRequestBehavior.AllowGet);

            }
        }
    }
}