using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
namespace PatentCaseSystem.Module.BusinessObjects.DBIPS4_PA
{

    public partial class TCstmr_ClientChangeHistory
    {
        public TCstmr_ClientChangeHistory(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
