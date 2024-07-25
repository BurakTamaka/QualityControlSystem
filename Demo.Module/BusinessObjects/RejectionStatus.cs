using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Demo.Module.BusinessObjects
{
    [DefaultClassOptions]
    public class RejectionStatus : XPObject
    { 
        public RejectionStatus(Session session) : base(session){}

        int _RejectionID;
        public int RejectionID
        {
            get => _RejectionID;
            set => SetPropertyValue(nameof(RejectionID), ref _RejectionID, value);
        }

        int _RejectionExplanation;
        public int RejectionExplanation
        {
            get => _RejectionExplanation;
            set => SetPropertyValue(nameof(RejectionExplanation), ref _RejectionExplanation, value);
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }  
    }
}