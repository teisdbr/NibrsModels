﻿using System.Xml.Serialization;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using NibrsModels.Constants;

namespace NibrsModels.NibrsReport.Location
{
    [XmlRoot("Location", Namespace = Namespaces.niemCore)]
    public class Location
    {
        public Location()
        {
        }

        public Location(string locationRef)
        {
            LocationRef = locationRef;
        }
        
        public Location(string categoryCode, int id)
        {
            Id = nameof(Location) + id;
            CategoryCode = categoryCode;
        }

        public Location(string categoryCode, string id)
        {
            Id = id;
            CategoryCode = categoryCode;
        }

        /// <summary>
        ///     This property is public only For serialization.
        ///     It should only be set by using the Location(string) constructor and accessed using the reference property.
        /// </summary>
        [XmlAttribute("ref", Namespace = Namespaces.niemStructs)]
        public string LocationRef { get; set; }

        [XmlAttribute("id", Namespace = Namespaces.niemStructs)]
        public string Id { get; set; }

        [XmlElement("LocationCategoryCode", Namespace = Namespaces.cjisNibrs)]
        public string CategoryCode { get; set; }

        [BsonIgnore]
        [XmlIgnore]
        [JsonIgnore]
        public Location Reference
        {
            get { return new Location(Id); }
        }
    }
}