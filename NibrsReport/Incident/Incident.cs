﻿using System.Xml.Serialization;
using NibrsModels.Constants;
using NibrsModels.NibrsReport.Misc;

namespace NibrsModels.NibrsReport.Incident
{
    [XmlRoot("Incident", Namespace = Namespaces.niemCore)]
    public class Incident
    {
        public Incident()
        {
        }

        public Incident(ActivityIdentification id, ActivityDate date, CjisIncidentAugmentation cjis,
            JxdmIncidentAugmentation jdxm)
        {
            ActivityId = id;
            ActivityDate = date;
            CjisIncidentAugmentation = cjis;
            JxdmIncidentAugmentation = jdxm;
        }

        [XmlElement("ActivityIdentification", Namespace = Namespaces.niemCore, Order = 1)]
        public ActivityIdentification ActivityId { get; set; }

        [XmlElement("ActivityDate", Namespace = Namespaces.niemCore, Order = 2)]
        public ActivityDate ActivityDate { get; set; }

        [XmlElement("IncidentAugmentation", Namespace = Namespaces.cjis, Order = 3)]
        public CjisIncidentAugmentation CjisIncidentAugmentation { get; set; }

        [XmlElement("IncidentAugmentation", Namespace = Namespaces.justice, Order = 4)]
        public JxdmIncidentAugmentation JxdmIncidentAugmentation { get; set; }
    }
}