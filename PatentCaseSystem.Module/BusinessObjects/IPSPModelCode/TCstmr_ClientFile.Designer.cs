﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
namespace PatentCaseSystem.Module.BusinessObjects.DBIPS4_PA
{

    public partial class TCstmr_ClientFile : XPLiteObject
    {
        int fn_ID;
        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }
        TCstmr_Client fn_ClientID;
        [Association(@"TCstmr_ClientFileReferencesTCstmr_Client")]
        public TCstmr_Client n_ClientID
        {
            get { return fn_ClientID; }
            set { SetPropertyValue<TCstmr_Client>("n_ClientID", ref fn_ClientID, value); }
        }
        string fs_Name;
        [Size(200)]
        public string s_Name
        {
            get { return fs_Name; }
            set { SetPropertyValue<string>("s_Name", ref fs_Name, value); }
        }
        string fs_Description;
        [Size(800)]
        public string s_Description
        {
            get { return fs_Description; }
            set { SetPropertyValue<string>("s_Description", ref fs_Description, value); }
        }
        string fs_FilePath;
        [Size(500)]
        public string s_FilePath
        {
            get { return fs_FilePath; }
            set { SetPropertyValue<string>("s_FilePath", ref fs_FilePath, value); }
        }
        DateTime fdt_EditDate;
        public DateTime dt_EditDate
        {
            get { return fdt_EditDate; }
            set { SetPropertyValue<DateTime>("dt_EditDate", ref fdt_EditDate, value); }
        }
        DateTime fdt_CreateDate;
        public DateTime dt_CreateDate
        {
            get { return fdt_CreateDate; }
            set { SetPropertyValue<DateTime>("dt_CreateDate", ref fdt_CreateDate, value); }
        }
    }

}
