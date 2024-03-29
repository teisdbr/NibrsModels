﻿using System.Xml.Serialization;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using NibrsModels.Constants;
using NibrsModels.NibrsReport.Misc;

namespace NibrsModels.NibrsReport.Subject
{
    [XmlRoot("Subject", Namespace = Namespaces.justice)]
    public class Subject
    {
        public Subject()
        {
        }

        public Subject(string subjectId)
        {
            SubjectRef = subjectId;
        }

        public Subject(
            Person.Person person,
            string seqNum,
            string uniquePrefix)
        {
            Person = person;
            if(Person != null)
            Role = new RoleOfPerson(Person.Id);
            this.SeqNum = seqNum;
            this.Id = uniquePrefix + "Subject" + int.Parse(seqNum);
        }
        [XmlIgnore] public Person.Person Person { get; set; }

        [XmlAttribute("id", Namespace = Namespaces.niemStructs)]
        public string Id { get; set; }

        /// <summary>
        ///     This property is public only For serialization.
        ///     It should only be set by using the Subject(string) constructor and accessed using the reference property.
        /// </summary>
        [XmlAttribute("ref", Namespace = Namespaces.niemStructs)]
        public string SubjectRef { get; set; }

        [XmlElement("RoleOfPerson", Namespace = Namespaces.niemCore, Order = 1)]
        public RoleOfPerson Role { get; set; }

        [XmlElement("SubjectSequenceNumberText", Namespace = Namespaces.justice, Order = 2)]
        public string SeqNum { get; set; }

        [BsonIgnore] [XmlIgnore] [JsonIgnore]
        public Subject Reference
        {
            get { return new Subject(Id); }
        }
    }
}