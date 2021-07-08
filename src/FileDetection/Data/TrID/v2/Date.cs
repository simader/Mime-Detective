﻿using System.Xml.Serialization;

namespace FileDetection.Data.Trid.v2
{

    [XmlType("Date")]
    public class Date
    {
        [XmlElement("Year")]
        public int Year { get; set; }
        
        [XmlElement("Month")]
        public int Month { get; set; }
        
        [XmlElement("Day")]
        public int Day { get; set; }
    }
}
