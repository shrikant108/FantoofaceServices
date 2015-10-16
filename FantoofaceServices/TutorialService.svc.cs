using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace FantoofaceServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "TutorialService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select TutorialService.svc or TutorialService.svc.cs at the Solution Explorer and start debugging.
    public class TutorialService : ITutorialService
    {
        FantoofaceService_dbEntities _fdb;
        public TutorialService() {
            _fdb = new FantoofaceService_dbEntities();
        }
        public List<TutorialDataContract> GetTutorials(string appkey)
        {
            Guid aGuid = new Guid(appkey);
            List<TutorialDataContract> _lst = new List<TutorialDataContract>();

            var query = (from t in _fdb.tbl_Tutorial
                         join c in _fdb.Tbl_Category on t.catId equals c.ID
                         join a in _fdb.Tbl_Application on t.AppID equals a.ID
                         where a.APPKey == aGuid
                         select new
                         {
                             t.ID,
                             t.catId,
                             t.createdDate,
                             t.Title,
                             t.Description,
                             c.categoryname
                         }).ToList().OrderBy(x => x.ID);
            query.ToList().ForEach(rec =>
                {
                    _lst.Add(new TutorialDataContract
                    {
                        ID = Convert.ToString( rec.ID ),
                        Title = rec.Title,
                        Description = rec.Description,
                        Categoryname = rec.categoryname,
                        createdDate = string.Format("{0:d}", rec.createdDate)
                    });
                });
            return _lst;
        }
    }
}
