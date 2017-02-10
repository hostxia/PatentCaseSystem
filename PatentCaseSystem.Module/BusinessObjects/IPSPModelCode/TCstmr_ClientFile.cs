using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
namespace PatentCaseSystem.Module.BusinessObjects.DBIPS4_PA
{

    public partial class TCstmr_ClientFile
    {
        public TCstmr_ClientFile(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
