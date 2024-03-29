﻿using System.Xml.Serialization;
using NibrsModels.Constants;

namespace NibrsModels.NibrsReport.ReportHeader
{
    [XmlRoot("ReportHeader", Namespace = Namespaces.cjisNibrs)]
    public class ReportHeader
    {
        public ReportHeader()
        {
        }

        public ReportHeader(string nibrsCode, string actionCode, ReportDate date, ReportingAgency agency)
        {
            NibrsReportCategoryCode = nibrsCode;
            ReportActionCategoryCode = actionCode;
            ReportDate = date;
            ReportingAgency = agency;
        }

        [XmlElement("NIBRSReportCategoryCode", Namespace = Namespaces.cjisNibrs, Order = 1)]
        public string NibrsReportCategoryCode { get; set; }

        [XmlElement("ReportActionCategoryCode", Namespace = Namespaces.cjisNibrs, Order = 2)]
        public string ReportActionCategoryCode { get; set; }

        [XmlElement("ReportDate", Namespace = Namespaces.cjisNibrs, Order = 3)]
        public ReportDate ReportDate { get; set; }

        [XmlElement("ReportingAgency", Namespace = Namespaces.cjisNibrs, Order = 4)]
        public ReportingAgency ReportingAgency { get; set; }
    }
}