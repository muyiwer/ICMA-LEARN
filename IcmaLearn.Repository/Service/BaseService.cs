using IcmaLearn.Model.Edmx;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IcmaLearn.Repository.Service
{
    public class BaseService
    {
        public IcmaLearnContext db;// = ConfigurationManager.ConnectionStrings["IcmaLearnEntities"].ConnectionString;

        public BaseService()
        {
            db = new IcmaLearnContext(); 
        }
    }
}
