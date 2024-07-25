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
    public class QualityControlTitle : XPObject
    { 
        public QualityControlTitle(Session session): base(session){}

        // xp + esc + space
        ProductEntityList productEntityList;
        DateTime _ControlDate;
        public DateTime ControlDate
        {
            get => _ControlDate;
            set => SetPropertyValue(nameof(ControlDate), ref _ControlDate, value);
        }

        bool _LotNoControl;
        public bool LotNoControl
        {
            get => _LotNoControl;
            set => SetPropertyValue(nameof(LotNoControl), ref _LotNoControl, value);
        }

        bool _DamagedParcelControl;
        public bool DamagedParcelControl
        {
            get => _DamagedParcelControl;
            set => SetPropertyValue(nameof(DamagedParcelControl), ref _DamagedParcelControl, value);
        }

        bool _UnlabeledParcelControl;
        public bool UnlabeledParcelControl
        {
            get => _UnlabeledParcelControl;
            set => SetPropertyValue(nameof(UnlabeledParcelControl), ref _UnlabeledParcelControl, value);
        }

        bool _BobbinCountControl;
        public bool BobbinCountControl
        {
            get => _BobbinCountControl;
            set => SetPropertyValue(nameof(BobbinCountControl), ref _BobbinCountControl, value);
        }

        string _LotNoControlExplanation;
        public string LotNoControlExplanation
        {
            get => _LotNoControlExplanation;
            set => SetPropertyValue(nameof(LotNoControlExplanation), ref _LotNoControlExplanation, value);
        }

        string _DamagedParcelControlExplanation;
        public string DamagedParcelControlExplanation
        {
            get => _DamagedParcelControlExplanation;
            set => SetPropertyValue(nameof(LotNoControlExplanation), ref _DamagedParcelControlExplanation, value);
        }

        string _UnlabeledParcelControlExplanation;
        public string UnlabeledParcelControlExplanation
        {
            get => _UnlabeledParcelControlExplanation;
            set => SetPropertyValue(nameof(UnlabeledParcelControlExplanation), ref _UnlabeledParcelControlExplanation, value);
        }

        string _BobbinCountControlExplanation;
        public string BobbinCountControlExplanation
        {
            get => _BobbinCountControlExplanation;
            set => SetPropertyValue(nameof(BobbinCountControlExplanation), ref _BobbinCountControlExplanation, value);
        }

        
        public ProductEntityList ProductEntityList
        {
            get => productEntityList;
            set => SetPropertyValue(nameof(ProductEntityList), ref productEntityList, value);
        }

        [Association("QualityControlTitle-QualityControlItems")]
        public XPCollection<QualityControlItem> QualityControlItems
        {
            get { return GetCollection<QualityControlItem>(nameof(QualityControlItems)); }
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();  
        }
        
    }
}