using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using DevExpress.Utils.Serializing;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;


namespace Demo.Module.BusinessObjects
{

    
    [DefaultClassOptions]

    public class ProductEntityList : XPObject
    {  
        public ProductEntityList(Session session) : base(session) {}

        private string _WaybillNo;
        public string WaybillNo
        {
            get { return _WaybillNo; }
            set { SetPropertyValue(nameof(WaybillNo), ref _WaybillNo, value); }
        }

        private string _SupplierName;
        public string SupplierName
        {
            get { return _SupplierName; }
            set { SetPropertyValue(nameof(SupplierName), ref _SupplierName, value); }
        }

        private string _Lot;
        public string Lot
        {
            get { return _Lot; }
            set { SetPropertyValue(nameof(Lot), ref _Lot, value); }
        }

        private string _OrderNo;
        public string OrderNo
        {
            get { return _OrderNo; }
            set { SetPropertyValue(nameof(OrderNo), ref _OrderNo, value); }
        }
               
        private float _Weight;

        public float Weight
        {
            get { return _Weight; }
            set { SetPropertyValue(nameof(Weight), ref _Weight, value); }
        }   
        
        private DateTime _ProductEntryDate;
        public DateTime ProductEntryDate
        {
            get { return _ProductEntryDate; }
            set { SetPropertyValue(nameof(ProductEntryDate), ref _ProductEntryDate, value); }
        }

        private DateTime _ProductRegistrationDate;
        public DateTime ProductRegistrationDate
        {
            get { return _ProductRegistrationDate; }
            set { SetPropertyValue(nameof(ProductRegistrationDate), ref _ProductRegistrationDate, value); }
        }     
        
        private string _Result;
        public string Result
        {
            get { return _Result; }
            set { SetPropertyValue(nameof(Result), ref _Result, value); }
        }  

        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Varsayılan değer atama
            SupplierName = "google";
        }

    }
}