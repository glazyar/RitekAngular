using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Model.SQL;
using Core.Model.DTO;
using Newtonsoft.Json;

namespace Core.Service
{
    public class PlanService
    {
        public void TestQuery()
        {
            try
            {
                using (RITEK_SURVEY_TPP1Entities dbTPP1 = new RITEK_SURVEY_TPP1Entities())
                {
                    var val = from p in dbTPP1.Survey
                              select p;
                    List<Survey> survey = new List<Survey>();
                    survey = val.ToList();
                }
            }
            catch (Exception ex)
            {

            }
        }
        public List<PlanOperNftDTO> GetPlanOperNFT(int kodTPP)
        {
            try
            {
                using (RITEK_WEBEntities dbWEB = new RITEK_WEBEntities())
                {
                    var val = dbWEB.hp_PlanOperNFT(kodTPP);

                    var list = JsonConvert.DeserializeObject<List<PlanOperNftDTO>>(JsonConvert.SerializeObject(val.ToList()));
   

                    return list;
                }
            }
            catch(Exception ex)
            {
                return null;
            }
        }
    }
}
