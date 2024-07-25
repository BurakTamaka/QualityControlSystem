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
    public class QualityControlItem : XPObject
    { 
        public QualityControlItem(Session session) : base(session) {}

        int _QCIID;
        public int QCIID
        {
            get => _QCIID;
            set => SetPropertyValue(nameof(QCIID), ref _QCIID, value);
        }

        float _BobbinWeight;
        public float BobbinWeight
        {
            get => _BobbinWeight;
            set => SetPropertyValue(nameof(BobbinWeight), ref _BobbinWeight, value);
        }

        float _YarnNo;
        public float YarnNo
        {
            get => _YarnNo;
            set => SetPropertyValue(nameof(YarnNo), ref _YarnNo, value);
        }

        float _YarnThickness;
        public float YarnThickness
        {
            get => _YarnThickness;
            set => SetPropertyValue(nameof(YarnThickness), ref _YarnThickness, value);
        }

        float _YarnResistance;
        public float YarnResistance
        {
            get => _YarnResistance;
            set => SetPropertyValue(nameof(YarnResistance), ref _YarnResistance, value);
        }

        float _YarnElongation;
        public float YarnElongation
        {
            get => _YarnElongation;
            set => SetPropertyValue(nameof(YarnElongation), ref _YarnElongation, value);
        }

        QualityControlTitle _QualityControlTitle;
        [Association("QualityControlTitle-QualityControlItems")]
        public QualityControlTitle QualityControlTitle
        {
            get { return _QualityControlTitle; }
            set { SetPropertyValue(nameof(QualityControlTitle), ref _QualityControlTitle, value); }
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}