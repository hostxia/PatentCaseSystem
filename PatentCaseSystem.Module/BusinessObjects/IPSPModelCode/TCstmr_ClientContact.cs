using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
namespace PatentCaseSystem.Module.BusinessObjects.DBIPS4_PA
{

    public partial class TCstmr_ClientContact
    {
        public TCstmr_ClientContact(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
