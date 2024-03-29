﻿using System.Xml.Serialization;
using NibrsModels.Constants;

namespace NibrsModels.NibrsReport.Arrest
{
    [XmlRoot("ArrestCharge", Namespace = Namespaces.justice)]
    public class ArrestCharge
    {
        public ArrestCharge()
        {
        }

        public ArrestCharge(string ucrCode)
        {
            UcrCode = ucrCode;
        }

        [XmlElement("ChargeUCRCode", Namespace = Namespaces.cjisNibrs)]
        public string UcrCode { get; set; }
    }
}