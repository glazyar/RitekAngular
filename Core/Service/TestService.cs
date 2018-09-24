using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Model.SQL;
namespace Core.Service
{
    public class TestService
    {
        public void TestQuery()
        {
            using (RITEK_SURVEY_TPP1Entities dbTPP1 = new RITEK_SURVEY_TPP1Entities())
            {
                var val = from p in dbTPP1.Survey
                          select p;
                List<Survey> survey = new List<Survey>();
                survey = val.ToList();
            }
        }
    }
}
