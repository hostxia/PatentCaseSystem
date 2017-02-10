using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using DevExpress.Persistent.Base;

namespace PatentCaseSystem.Module.BusinessObjects.DBIPS4_PA
{
    [DefaultClassOptions]
    public partial class TCstmr_ClientAddress
    {
        public TCstmr_ClientAddress(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
