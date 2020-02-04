using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace AFCAD_parser
{
    // AFCAD Class parser
    [XmlRoot(ElementName = "ExclusionRectangle")]
    public class ExclusionRectangle
    {
        [XmlAttribute(AttributeName = "latitudeMinimum")]
        public string LatitudeMinimum { get; set; }
        [XmlAttribute(AttributeName = "latitudeMaximum")]
        public string LatitudeMaximum { get; set; }
        [XmlAttribute(AttributeName = "longitudeMinimum")]
        public string LongitudeMinimum { get; set; }
        [XmlAttribute(AttributeName = "longitudeMaximum")]
        public string LongitudeMaximum { get; set; }
        [XmlAttribute(AttributeName = "excludeAllObjects")]
        public string ExcludeAllObjects { get; set; }
        [XmlAttribute(AttributeName = "excludeEffectObjects")]
        public string ExcludeEffectObjects { get; set; }
        [XmlAttribute(AttributeName = "excludeGenericBuildingObjects")]
        public string ExcludeGenericBuildingObjects { get; set; }
        [XmlAttribute(AttributeName = "excludeTaxiwaySignObjects")]
        public string ExcludeTaxiwaySignObjects { get; set; }
        [XmlAttribute(AttributeName = "excludeWindsockObjects")]
        public string ExcludeWindsockObjects { get; set; }
        [XmlAttribute(AttributeName = "excludeLibraryObjects")]
        public string ExcludeLibraryObjects { get; set; }
        [XmlAttribute(AttributeName = "excludeTriggerObjects")]
        public string ExcludeTriggerObjects { get; set; }
    }

    [XmlRoot(ElementName = "ModelData")]
    public class ModelData
    {
        [XmlAttribute(AttributeName = "sourceFile")]
        public string SourceFile { get; set; }
        [XmlAttribute(AttributeName = "fileOffset")]
        public string FileOffset { get; set; }
    }

    [XmlRoot(ElementName = "Fuel")]
    public class Fuel
    {
        [XmlAttribute(AttributeName = "type")]
        public string Type { get; set; }
        [XmlAttribute(AttributeName = "availability")]
        public string Availability { get; set; }
    }

    [XmlRoot(ElementName = "Services")]
    public class Services
    {
        [XmlElement(ElementName = "Fuel")]
        public List<Fuel> Fuel { get; set; }
    }

    [XmlRoot(ElementName = "DeleteAirport")]
    public class DeleteAirport
    {
        [XmlAttribute(AttributeName = "deleteAllRunways")]
        public string DeleteAllRunways { get; set; }
        [XmlAttribute(AttributeName = "deleteAllStarts")]
        public string DeleteAllStarts { get; set; }
        [XmlAttribute(AttributeName = "deleteAllHelipads")]
        public string DeleteAllHelipads { get; set; }
        [XmlAttribute(AttributeName = "deleteAllFrequencies")]
        public string DeleteAllFrequencies { get; set; }
        [XmlAttribute(AttributeName = "deleteAllTaxiways")]
        public string DeleteAllTaxiways { get; set; }
        [XmlAttribute(AttributeName = "deleteAllAprons")]
        public string DeleteAllAprons { get; set; }
        [XmlAttribute(AttributeName = "deleteAllApronLights")]
        public string DeleteAllApronLights { get; set; }
        [XmlAttribute(AttributeName = "deleteAllControlTowers")]
        public string DeleteAllControlTowers { get; set; }
        [XmlAttribute(AttributeName = "deleteAllJetways")]
        public string DeleteAllJetways { get; set; }
        [XmlAttribute(AttributeName = "deleteAllBoundaryFences")]
        public string DeleteAllBoundaryFences { get; set; }
        [XmlAttribute(AttributeName = "deleteAllBlastFences")]
        public string DeleteAllBlastFences { get; set; }
        [XmlAttribute(AttributeName = "deleteAllApproaches")]
        public string DeleteAllApproaches { get; set; }
    }

    [XmlRoot(ElementName = "Tower")]
    public class Tower
    {
        [XmlAttribute(AttributeName = "lat")]
        public string Lat { get; set; }
        [XmlAttribute(AttributeName = "lon")]
        public string Lon { get; set; }
        [XmlAttribute(AttributeName = "alt")]
        public string Alt { get; set; }
    }

    [XmlRoot(ElementName = "Markings")]
    public class Markings
    {
        [XmlAttribute(AttributeName = "alternateThreshold")]
        public string AlternateThreshold { get; set; }
        [XmlAttribute(AttributeName = "alternateTouchdown")]
        public string AlternateTouchdown { get; set; }
        [XmlAttribute(AttributeName = "alternateFixedDistance")]
        public string AlternateFixedDistance { get; set; }
        [XmlAttribute(AttributeName = "alternatePrecision")]
        public string AlternatePrecision { get; set; }
        [XmlAttribute(AttributeName = "leadingZeroIdent")]
        public string LeadingZeroIdent { get; set; }
        [XmlAttribute(AttributeName = "noThresholdEndArrows")]
        public string NoThresholdEndArrows { get; set; }
        [XmlAttribute(AttributeName = "edges")]
        public string Edges { get; set; }
        [XmlAttribute(AttributeName = "threshold")]
        public string Threshold { get; set; }
        [XmlAttribute(AttributeName = "fixedDistance")]
        public string FixedDistance { get; set; }
        [XmlAttribute(AttributeName = "touchdown")]
        public string Touchdown { get; set; }
        [XmlAttribute(AttributeName = "dashes")]
        public string Dashes { get; set; }
        [XmlAttribute(AttributeName = "ident")]
        public string Ident { get; set; }
        [XmlAttribute(AttributeName = "precision")]
        public string Precision { get; set; }
        [XmlAttribute(AttributeName = "edgePavement")]
        public string EdgePavement { get; set; }
        [XmlAttribute(AttributeName = "singleEnd")]
        public string SingleEnd { get; set; }
        [XmlAttribute(AttributeName = "primaryClosed")]
        public string PrimaryClosed { get; set; }
        [XmlAttribute(AttributeName = "secondaryClosed")]
        public string SecondaryClosed { get; set; }
        [XmlAttribute(AttributeName = "primaryStol")]
        public string PrimaryStol { get; set; }
        [XmlAttribute(AttributeName = "secondaryStol")]
        public string SecondaryStol { get; set; }
    }

    [XmlRoot(ElementName = "Lights")]
    public class Lights
    {
        [XmlAttribute(AttributeName = "center")]
        public string Center { get; set; }
        [XmlAttribute(AttributeName = "edge")]
        public string Edge { get; set; }
        [XmlAttribute(AttributeName = "centerRed")]
        public string CenterRed { get; set; }
    }

    [XmlRoot(ElementName = "BlastPad")]
    public class BlastPad
    {
        [XmlAttribute(AttributeName = "end")]
        public string End { get; set; }
        [XmlAttribute(AttributeName = "length")]
        public string Length { get; set; }
        [XmlAttribute(AttributeName = "width")]
        public string Width { get; set; }
        [XmlAttribute(AttributeName = "surface")]
        public string Surface { get; set; }
    }

    [XmlRoot(ElementName = "ApproachLights")]
    public class ApproachLights
    {
        [XmlAttribute(AttributeName = "end")]
        public string End { get; set; }
        [XmlAttribute(AttributeName = "system")]
        public string System { get; set; }
        [XmlAttribute(AttributeName = "strobes")]
        public string Strobes { get; set; }
        [XmlAttribute(AttributeName = "reil")]
        public string Reil { get; set; }
        [XmlAttribute(AttributeName = "touchdown")]
        public string Touchdown { get; set; }
        [XmlAttribute(AttributeName = "endLights")]
        public string EndLights { get; set; }
    }

    [XmlRoot(ElementName = "Vasi")]
    public class Vasi
    {
        [XmlAttribute(AttributeName = "end")]
        public string End { get; set; }
        [XmlAttribute(AttributeName = "type")]
        public string Type { get; set; }
        [XmlAttribute(AttributeName = "side")]
        public string Side { get; set; }
        [XmlAttribute(AttributeName = "biasX")]
        public string BiasX { get; set; }
        [XmlAttribute(AttributeName = "biasZ")]
        public string BiasZ { get; set; }
        [XmlAttribute(AttributeName = "spacing")]
        public string Spacing { get; set; }
        [XmlAttribute(AttributeName = "pitch")]
        public string Pitch { get; set; }
    }

    [XmlRoot(ElementName = "GlideSlope")]
    public class GlideSlope
    {
        [XmlAttribute(AttributeName = "lat")]
        public string Lat { get; set; }
        [XmlAttribute(AttributeName = "lon")]
        public string Lon { get; set; }
        [XmlAttribute(AttributeName = "alt")]
        public string Alt { get; set; }
        [XmlAttribute(AttributeName = "pitch")]
        public string Pitch { get; set; }
        [XmlAttribute(AttributeName = "range")]
        public string Range { get; set; }
    }

    [XmlRoot(ElementName = "Dme")]
    public class Dme
    {
        [XmlAttribute(AttributeName = "lat")]
        public string Lat { get; set; }
        [XmlAttribute(AttributeName = "lon")]
        public string Lon { get; set; }
        [XmlAttribute(AttributeName = "alt")]
        public string Alt { get; set; }
        [XmlAttribute(AttributeName = "range")]
        public string Range { get; set; }
    }

    [XmlRoot(ElementName = "Ils")]
    public class Ils
    {
        [XmlElement(ElementName = "GlideSlope")]
        public GlideSlope GlideSlope { get; set; }
        [XmlElement(ElementName = "Dme")]
        public Dme Dme { get; set; }
        [XmlAttribute(AttributeName = "lat")]
        public string Lat { get; set; }
        [XmlAttribute(AttributeName = "lon")]
        public string Lon { get; set; }
        [XmlAttribute(AttributeName = "alt")]
        public string Alt { get; set; }
        [XmlAttribute(AttributeName = "heading")]
        public string Heading { get; set; }
        [XmlAttribute(AttributeName = "frequency")]
        public string Frequency { get; set; }
        [XmlAttribute(AttributeName = "end")]
        public string End { get; set; }
        [XmlAttribute(AttributeName = "range")]
        public string Range { get; set; }
        [XmlAttribute(AttributeName = "magvar")]
        public string Magvar { get; set; }
        [XmlAttribute(AttributeName = "ident")]
        public string Ident { get; set; }
        [XmlAttribute(AttributeName = "width")]
        public string Width { get; set; }
        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }
        [XmlAttribute(AttributeName = "backCourse")]
        public string BackCourse { get; set; }
    }

    [XmlRoot(ElementName = "Runway")]
    public class Runway
    {
        [XmlElement(ElementName = "Markings")]
        public Markings Markings { get; set; }
        [XmlElement(ElementName = "Lights")]
        public Lights Lights { get; set; }
        [XmlElement(ElementName = "BlastPad")]
        public BlastPad BlastPad { get; set; }
        [XmlElement(ElementName = "ApproachLights")]
        public List<ApproachLights> ApproachLights { get; set; }
        [XmlElement(ElementName = "Vasi")]
        public List<Vasi> Vasi { get; set; }
        [XmlElement(ElementName = "Ils")]
        public Ils Ils { get; set; }
        [XmlAttribute(AttributeName = "lat")]
        public string Lat { get; set; }
        [XmlAttribute(AttributeName = "lon")]
        public string Lon { get; set; }
        [XmlAttribute(AttributeName = "alt")]
        public string Alt { get; set; }
        [XmlAttribute(AttributeName = "surface")]
        public string Surface { get; set; }
        [XmlAttribute(AttributeName = "heading")]
        public string Heading { get; set; }
        [XmlAttribute(AttributeName = "length")]
        public string Length { get; set; }
        [XmlAttribute(AttributeName = "width")]
        public string Width { get; set; }
        [XmlAttribute(AttributeName = "number")]
        public string Number { get; set; }
        [XmlAttribute(AttributeName = "designator")]
        public string Designator { get; set; }
        [XmlAttribute(AttributeName = "patternAltitude")]
        public string PatternAltitude { get; set; }
        [XmlAttribute(AttributeName = "primaryTakeoff")]
        public string PrimaryTakeoff { get; set; }
        [XmlAttribute(AttributeName = "primaryLanding")]
        public string PrimaryLanding { get; set; }
        [XmlAttribute(AttributeName = "primaryPattern")]
        public string PrimaryPattern { get; set; }
        [XmlAttribute(AttributeName = "secondaryTakeoff")]
        public string SecondaryTakeoff { get; set; }
        [XmlAttribute(AttributeName = "secondaryLanding")]
        public string SecondaryLanding { get; set; }
        [XmlAttribute(AttributeName = "secondaryPattern")]
        public string SecondaryPattern { get; set; }
    }

    [XmlRoot(ElementName = "Start")]
    public class Start
    {
        [XmlAttribute(AttributeName = "type")]
        public string Type { get; set; }
        [XmlAttribute(AttributeName = "lat")]
        public string Lat { get; set; }
        [XmlAttribute(AttributeName = "lon")]
        public string Lon { get; set; }
        [XmlAttribute(AttributeName = "alt")]
        public string Alt { get; set; }
        [XmlAttribute(AttributeName = "heading")]
        public string Heading { get; set; }
        [XmlAttribute(AttributeName = "number")]
        public string Number { get; set; }
        [XmlAttribute(AttributeName = "designator")]
        public string Designator { get; set; }
    }

    [XmlRoot(ElementName = "Helipad")]
    public class Helipad
    {
        [XmlAttribute(AttributeName = "lat")]
        public string Lat { get; set; }
        [XmlAttribute(AttributeName = "lon")]
        public string Lon { get; set; }
        [XmlAttribute(AttributeName = "alt")]
        public string Alt { get; set; }
        [XmlAttribute(AttributeName = "surface")]
        public string Surface { get; set; }
        [XmlAttribute(AttributeName = "heading")]
        public string Heading { get; set; }
        [XmlAttribute(AttributeName = "length")]
        public string Length { get; set; }
        [XmlAttribute(AttributeName = "width")]
        public string Width { get; set; }
        [XmlAttribute(AttributeName = "type")]
        public string Type { get; set; }
        [XmlAttribute(AttributeName = "closed")]
        public string Closed { get; set; }
        [XmlAttribute(AttributeName = "transparent")]
        public string Transparent { get; set; }
    }

    [XmlRoot(ElementName = "Com")]
    public class Com
    {
        [XmlAttribute(AttributeName = "frequency")]
        public string Frequency { get; set; }
        [XmlAttribute(AttributeName = "type")]
        public string Type { get; set; }
        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }
    }

    [XmlRoot(ElementName = "TaxiwayPoint")]
    public class TaxiwayPoint
    {
        [XmlAttribute(AttributeName = "index")]
        public string Index { get; set; }
        [XmlAttribute(AttributeName = "type")]
        public string Type { get; set; }
        [XmlAttribute(AttributeName = "orientation")]
        public string Orientation { get; set; }
        [XmlAttribute(AttributeName = "lat")]
        public string Lat { get; set; }
        [XmlAttribute(AttributeName = "lon")]
        public string Lon { get; set; }
    }

    [XmlRoot(ElementName = "TaxiwayParking")]
    public class TaxiwayParking
    {
        [XmlAttribute(AttributeName = "index")]
        public string Index { get; set; }
        [XmlAttribute(AttributeName = "lat")]
        public string Lat { get; set; }
        [XmlAttribute(AttributeName = "lon")]
        public string Lon { get; set; }
        [XmlAttribute(AttributeName = "heading")]
        public string Heading { get; set; }
        [XmlAttribute(AttributeName = "radius")]
        public string Radius { get; set; }
        [XmlAttribute(AttributeName = "type")]
        public string Type { get; set; }
        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }
        [XmlAttribute(AttributeName = "number")]
        public string Number { get; set; }
        [XmlAttribute(AttributeName = "pushBack")]
        public string PushBack { get; set; }
        [XmlAttribute(AttributeName = "airlineCodes")]
        public string AirlineCodes { get; set; }
    }

    [XmlRoot(ElementName = "TaxiName")]
    public class TaxiName
    {
        [XmlAttribute(AttributeName = "index")]
        public string Index { get; set; }
        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }
    }

    [XmlRoot(ElementName = "TaxiwayPath")]
    public class TaxiwayPath
    {
        [XmlAttribute(AttributeName = "type")]
        public string Type { get; set; }
        [XmlAttribute(AttributeName = "start")]
        public string Start { get; set; }
        [XmlAttribute(AttributeName = "end")]
        public string End { get; set; }
        [XmlAttribute(AttributeName = "width")]
        public string Width { get; set; }
        [XmlAttribute(AttributeName = "weightLimit")]
        public string WeightLimit { get; set; }
        [XmlAttribute(AttributeName = "drawSurface")]
        public string DrawSurface { get; set; }
        [XmlAttribute(AttributeName = "drawDetail")]
        public string DrawDetail { get; set; }
        [XmlAttribute(AttributeName = "surface")]
        public string Surface { get; set; }
        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }
        [XmlAttribute(AttributeName = "centerLine")]
        public string CenterLine { get; set; }
        [XmlAttribute(AttributeName = "number")]
        public string Number { get; set; }
        [XmlAttribute(AttributeName = "designator")]
        public string Designator { get; set; }
        [XmlAttribute(AttributeName = "rightEdgeLighted")]
        public string RightEdgeLighted { get; set; }
        [XmlAttribute(AttributeName = "leftEdge")]
        public string LeftEdge { get; set; }
        [XmlAttribute(AttributeName = "rightEdge")]
        public string RightEdge { get; set; }
    }

    [XmlRoot(ElementName = "Vertex")]
    public class Vertex
    {
        [XmlAttribute(AttributeName = "lat")]
        public string Lat { get; set; }
        [XmlAttribute(AttributeName = "lon")]
        public string Lon { get; set; }
    }

    [XmlRoot(ElementName = "Apron")]
    public class Apron
    {
        [XmlElement(ElementName = "Vertex")]
        public List<Vertex> Vertex { get; set; }
        [XmlAttribute(AttributeName = "surface")]
        public string Surface { get; set; }
        [XmlAttribute(AttributeName = "drawSurface")]
        public string DrawSurface { get; set; }
        [XmlAttribute(AttributeName = "drawDetail")]
        public string DrawDetail { get; set; }
    }

    [XmlRoot(ElementName = "Aprons")]
    public class Aprons
    {
        [XmlElement(ElementName = "Apron")]
        public List<Apron> Apron { get; set; }
    }

    [XmlRoot(ElementName = "TaxiwaySign")]
    public class TaxiwaySign
    {
        [XmlAttribute(AttributeName = "lat")]
        public string Lat { get; set; }
        [XmlAttribute(AttributeName = "lon")]
        public string Lon { get; set; }
        [XmlAttribute(AttributeName = "heading")]
        public string Heading { get; set; }
        [XmlAttribute(AttributeName = "label")]
        public string Label { get; set; }
        [XmlAttribute(AttributeName = "size")]
        public string Size { get; set; }
        [XmlAttribute(AttributeName = "justification")]
        public string Justification { get; set; }
    }

    [XmlRoot(ElementName = "BoundaryFence")]
    public class BoundaryFence
    {
        [XmlElement(ElementName = "Vertex")]
        public List<Vertex> Vertex { get; set; }
        [XmlAttribute(AttributeName = "profile")]
        public string Profile { get; set; }
    }

    [XmlRoot(ElementName = "Airport")]
    public class Airport
    {
        [XmlElement(ElementName = "Services")]
        public Services Services { get; set; }
        [XmlElement(ElementName = "DeleteAirport")]
        public DeleteAirport DeleteAirport { get; set; }
        [XmlElement(ElementName = "Tower")]
        public Tower Tower { get; set; }
        [XmlElement(ElementName = "Runway")]
        public List<Runway> Runway { get; set; }
        [XmlElement(ElementName = "Start")]
        public List<Start> Start { get; set; }
        [XmlElement(ElementName = "Helipad")]
        public List<Helipad> Helipad { get; set; }
        [XmlElement(ElementName = "Com")]
        public List<Com> Com { get; set; }
        [XmlElement(ElementName = "TaxiwayPoint")]
        public List<TaxiwayPoint> TaxiwayPoint { get; set; }
        [XmlElement(ElementName = "TaxiwayParking")]
        public List<TaxiwayParking> TaxiwayParking { get; set; }
        [XmlElement(ElementName = "TaxiName")]
        public List<TaxiName> TaxiName { get; set; }
        [XmlElement(ElementName = "TaxiwayPath")]
        public List<TaxiwayPath> TaxiwayPath { get; set; }
        [XmlElement(ElementName = "Aprons")]
        public Aprons Aprons { get; set; }
        [XmlElement(ElementName = "TaxiwaySign")]
        public List<TaxiwaySign> TaxiwaySign { get; set; }
        [XmlElement(ElementName = "BoundaryFence")]
        public List<BoundaryFence> BoundaryFence { get; set; }
        [XmlAttribute(AttributeName = "country")]
        public string Country { get; set; }
        [XmlAttribute(AttributeName = "city")]
        public string City { get; set; }
        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }
        [XmlAttribute(AttributeName = "lat")]
        public string Lat { get; set; }
        [XmlAttribute(AttributeName = "lon")]
        public string Lon { get; set; }
        [XmlAttribute(AttributeName = "alt")]
        public string Alt { get; set; }
        [XmlAttribute(AttributeName = "magvar")]
        public string Magvar { get; set; }
        [XmlAttribute(AttributeName = "trafficScalar")]
        public string TrafficScalar { get; set; }
        [XmlAttribute(AttributeName = "airportTestRadius")]
        public string AirportTestRadius { get; set; }
        [XmlAttribute(AttributeName = "ident")]
        public string Ident { get; set; }
    }

    [XmlRoot(ElementName = "Marker")]
    public class Marker
    {
        [XmlAttribute(AttributeName = "lat")]
        public string Lat { get; set; }
        [XmlAttribute(AttributeName = "lon")]
        public string Lon { get; set; }
        [XmlAttribute(AttributeName = "alt")]
        public string Alt { get; set; }
        [XmlAttribute(AttributeName = "type")]
        public string Type { get; set; }
        [XmlAttribute(AttributeName = "heading")]
        public string Heading { get; set; }
    }

    [XmlRoot(ElementName = "Vor")]
    public class Vor
    {
        [XmlElement(ElementName = "Dme")]
        public Dme Dme { get; set; }
        [XmlAttribute(AttributeName = "dme")]
        public string _Dme { get; set; }
        [XmlAttribute(AttributeName = "dmeOnly")]
        public string DmeOnly { get; set; }
        [XmlAttribute(AttributeName = "lat")]
        public string Lat { get; set; }
        [XmlAttribute(AttributeName = "lon")]
        public string Lon { get; set; }
        [XmlAttribute(AttributeName = "alt")]
        public string Alt { get; set; }
        [XmlAttribute(AttributeName = "type")]
        public string Type { get; set; }
        [XmlAttribute(AttributeName = "frequency")]
        public string Frequency { get; set; }
        [XmlAttribute(AttributeName = "range")]
        public string Range { get; set; }
        [XmlAttribute(AttributeName = "magvar")]
        public string Magvar { get; set; }
        [XmlAttribute(AttributeName = "region")]
        public string Region { get; set; }
        [XmlAttribute(AttributeName = "ident")]
        public string Ident { get; set; }
        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }
    }

    [XmlRoot(ElementName = "Ndb")]
    public class Ndb
    {
        [XmlAttribute(AttributeName = "lat")]
        public string Lat { get; set; }
        [XmlAttribute(AttributeName = "lon")]
        public string Lon { get; set; }
        [XmlAttribute(AttributeName = "alt")]
        public string Alt { get; set; }
        [XmlAttribute(AttributeName = "type")]
        public string Type { get; set; }
        [XmlAttribute(AttributeName = "frequency")]
        public string Frequency { get; set; }
        [XmlAttribute(AttributeName = "range")]
        public string Range { get; set; }
        [XmlAttribute(AttributeName = "magvar")]
        public string Magvar { get; set; }
        [XmlAttribute(AttributeName = "region")]
        public string Region { get; set; }
        [XmlAttribute(AttributeName = "ident")]
        public string Ident { get; set; }
        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }
    }

    [XmlRoot(ElementName = "FSData")]
    public class FSData
    {
        [XmlElement(ElementName = "ExclusionRectangle")]
        public List<ExclusionRectangle> ExclusionRectangle { get; set; }
        [XmlElement(ElementName = "ModelData")]
        public ModelData ModelData { get; set; }
        [XmlElement(ElementName = "Airport")]
        public Airport Airport { get; set; }
        [XmlElement(ElementName = "Marker")]
        public List<Marker> Marker { get; set; }
        [XmlElement(ElementName = "Vor")]
        public List<Vor> Vor { get; set; }
        [XmlElement(ElementName = "Ndb")]
        public List<Ndb> Ndb { get; set; }
        [XmlAttribute(AttributeName = "version")]
        public string Version { get; set; }
        [XmlAttribute(AttributeName = "xsi", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Xsi { get; set; }
        [XmlAttribute(AttributeName = "noNamespaceSchemaLocation", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
        public string NoNamespaceSchemaLocation { get; set; }

        public FSData()
        {
            this.ExclusionRectangle = new List<ExclusionRectangle>();
            this.Marker = new List<Marker>();
            this.Vor = new List<Vor>();
            this.Ndb = new List<Ndb>();
        }

        // XML Write / Read 
        // ********* Input/Output Methods **********
        public void Load(string XmlPath)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(FSData));

            System.IO.StreamReader reader = new System.IO.StreamReader(XmlPath);
            FSData loadedpackage = (FSData)serializer.Deserialize(reader);
            reader.Close();

            this.CloneFrom(loadedpackage);
        }

        public void CloneFrom(FSData loadedpackage)
        {
            foreach (ExclusionRectangle r in loadedpackage.ExclusionRectangle)
                this.ExclusionRectangle.Add(r);
            foreach (Marker r in loadedpackage.Marker)
                this.Marker.Add(r);
            foreach (Vor r in loadedpackage.Vor)
                this.Vor.Add(r);
            foreach (Ndb r in loadedpackage.Ndb)
                this.Ndb.Add(r);

            this.ModelData = loadedpackage.ModelData;
            this.Airport = loadedpackage.Airport;
            this.Version = loadedpackage.Version;
            this.Xsi = loadedpackage.Xsi;
            this.NoNamespaceSchemaLocation = loadedpackage.NoNamespaceSchemaLocation;

        }
    }
}
