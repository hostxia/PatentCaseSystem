using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using DevExpress.ExpressApp.DC;
using DevExpress.Persistent.Base;

namespace PatentCaseSystem.Module.BusinessObjects.DBIPS4_PA
{
    public partial class TCstmr_Client
    {
        public TCstmr_Client(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
