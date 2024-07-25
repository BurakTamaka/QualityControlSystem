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
    public class StockCard : XPObject
    {
        public StockCard(Session session) : base(session){}

        private string _StockCode;
        public string StockCode
        {
            get { return _StockCode; }
            set { SetPropertyValue(nameof(StockCode), ref _StockCode, value); }
        }

        private string _StockDefinition;
        public string StockDefinition
        {
            get { return _StockDefinition; }
            set { SetPropertyValue(nameof(StockDefinition), ref _StockDefinition, value); }
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
        
    }
}