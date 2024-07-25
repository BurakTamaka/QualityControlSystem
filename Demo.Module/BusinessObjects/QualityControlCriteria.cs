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

    public class QualityControlCriteria : XPObject
    {

        //constructor
        public QualityControlCriteria(Session session) : base(session) {}

        private int _QCCID;
        public int QCCID
        {
            get { return _QCCID; }
            set { SetPropertyValue(nameof(QCCID), ref _QCCID, value); }
        }

        private float _BobbinWeightMin;
        public float BobbinWeightMin
        {
            get { return _BobbinWeightMin; }
            set { SetPropertyValue(nameof(BobbinWeightMin), ref _BobbinWeightMin, value); }
        }

        private float _BobbinWeightMax;
        public float BobbinWeightMax
        {
            get { return _BobbinWeightMax; }
            set { SetPropertyValue(nameof(BobbinWeightMax), ref _BobbinWeightMax, value); }
        }

        private float _YarnNumberMin;
        public float YarnNumberMin
        {
            get { return _YarnNumberMin; }
            set { SetPropertyValue(nameof(YarnNumberMin), ref _YarnNumberMin, value); }
        }

        private float _ThreadNumberMax;
        public float ThreadNumberMax
        {
            get { return _ThreadNumberMax; }
            set { SetPropertyValue(nameof(ThreadNumberMax), ref _ThreadNumberMax, value); }
        }

        private float _YarnThicknessMin;
        public float YarnThicknessMin
        {
            get { return _YarnThicknessMin; }
            set { SetPropertyValue(nameof(YarnThicknessMin), ref _YarnThicknessMin, value); }
        }

        private float _YarnThicknessMax;
        public float YarnThicknessMax
        {
            get { return _YarnThicknessMax; }
            set { SetPropertyValue(nameof(YarnThicknessMax), ref _YarnThicknessMax, value); }
        }
        
        private float _YarnResistanceMin;
        public float YarnResistanceMin
        {
            get { return _YarnResistanceMin; }
            set { SetPropertyValue(nameof(YarnResistanceMin), ref _YarnResistanceMin, value); }
        }

        private float _YarnResistanceMax;
        public float YarnResistanceMax
        {
            get { return _YarnResistanceMax; }
            set { SetPropertyValue(nameof(YarnResistanceMax), ref _YarnResistanceMax, value); }
        }

        private float _ThreadElongationMin;
        public float ThreadElongationMin
        {
            get { return _ThreadElongationMin; }
            set { SetPropertyValue(nameof(ThreadElongationMin), ref _ThreadElongationMin, value); }
        }

        private float _ThreadElongationMax;
        public float ThreadElongationMax
        {
            get { return _ThreadElongationMax; }
            set { SetPropertyValue(nameof(ThreadElongationMax), ref _ThreadElongationMax, value); }
        }


        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
        
    }
}