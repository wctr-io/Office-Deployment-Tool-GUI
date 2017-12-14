using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ODTGUI.Models
{
    [Serializable]
    [XmlRoot]
    public class Configuration
    {
        [XmlElement]
        public Add Add { get; set; }

    }

    [Serializable]
    public class Add
    {

        [XmlAttribute]
        public string SourcePath { get; set; }

        [XmlAttribute]
        public string Version { get; set; }

        [XmlAttribute]
        public int OfficeClientEdition { get; set; }

        [XmlAttribute]
        public string Channel { get; set; }

        [XmlAttribute]
        public string DownloadPath { get; set; }

        [XmlAttribute]
        public bool ForceUpgrade { get; set; }

        [XmlElement]
        public List<Product> Products { get; set; }
    }
    [Serializable]
    public class Product
    {
        [XmlAttribute("ID")]
        public string Id { get; set; }

        [XmlElement]
        public List<Language> Languages { get; set; }

        [XmlElement]
        public List<ExcludeApp> ExcludeApps { get; set; }
    }
    [Serializable]
    public class Language
    {
        [XmlAttribute("ID")]
        public string Id { get; set; }
    }
    [Serializable]
    public class Updates
    {
        [XmlAttribute]
        public bool Enabled { get; set; }

        [XmlAttribute]
        public string UpdatePath { get; set; }

        [XmlAttribute]
        public string TargetVersion { get; set; }

        [XmlAttribute]
        public string Deadline { get; set; }

        [XmlAttribute]
        public string Channel { get; set; }
    }

    [Serializable]
    public class Display
    {
        [XmlAttribute]
        public string Level { get; set; }

        [XmlAttribute("AcceptEULA")]
        public string AcceptEula { get; set; }
    }

    [Serializable]
    public class Logging
    {
        [XmlAttribute]
        public string Level { get; set; }

        [XmlAttribute]
        public string Path { get; set; }
    }

    [Serializable]
    public class ExcludeApp
    {
        [XmlAttribute("ID")]
        public string Id { get; set; }
    }
    [Serializable]
    public class Property
    {
        [XmlAttribute]
        public string Name { get; set; }

        [XmlAttribute]
        public string Value { get; set; }
    }

    [Serializable]
    public class Remove
    {
        [XmlAttribute]
        public bool All { get; set; }

        [XmlElement]
        List<Product> Products { get; set; }
    }


}
