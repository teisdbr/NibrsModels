﻿using System.Xml.Serialization;
using NibrsModels.Constants;

namespace NibrsModels.NibrsReport.Associations
{
    [XmlRoot("OffenseVictimAssociation", Namespace = Namespaces.justice)]
    public class OffenseVictimAssociation
    {
        public OffenseVictimAssociation()
        {
        }

        public OffenseVictimAssociation(Offense.Offense offense, Victim.Victim victim)
        {
            OffenseRef = offense.Reference;
            VictimRef = victim.Reference;
            RelatedVictim = victim;
            victim.AssociatedOffenses.Add(offense);
            RelatedOffense = offense;

        }

        public OffenseVictimAssociation(string offenseRef, string victimRef)
        {
            OffenseRef = new Offense.Offense(offenseRef);
            VictimRef = new Victim.Victim(victimRef);
        }

        [XmlElement("Offense", Namespace = Namespaces.justice, Order = 1)]
        public Offense.Offense OffenseRef { get; set; }

        [XmlElement("Victim", Namespace = Namespaces.justice, Order = 2)]
        public Victim.Victim VictimRef { get; set; }

        [XmlIgnore] public Offense.Offense RelatedOffense { get; set; }

        [XmlIgnore] public Victim.Victim RelatedVictim { get; set; }
    }
}