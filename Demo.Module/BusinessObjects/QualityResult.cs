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
    
    public class QualityResult : XPObject
    { 
        public QualityResult(Session session): base(session){}

        int _ResultID;
        public int ResultID
        {
            get => _ResultID;
            set => SetPropertyValue(nameof(ResultID), ref _ResultID, value);
        }

        string _ResultExplanation;
        public string ResultExplanation
        {
            get => _ResultExplanation;
            set => SetPropertyValue(nameof(ResultExplanation), ref _ResultExplanation, value);
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
        
    }
}