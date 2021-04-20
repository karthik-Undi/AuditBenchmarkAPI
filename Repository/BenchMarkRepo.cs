
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuditBenchmarkAPI.Repository
{
    public class BenchMarkRepo : IBenchMarckRepo
    {
        Dictionary<string,int> internalandsoxdict = new Dictionary<string,int>();



        public Dictionary<string,int> GetInternaAndSOXNoCount(string auditType)
        {



            if (auditType == "Internal")
            {
                internalandsoxdict.Add("Internal", 3);
            }
            else {
                if(auditType == "SOX")
                {
                    internalandsoxdict.Add("SOX", 1);
                }
            }

            return internalandsoxdict;
                

        }

       
    }
}
