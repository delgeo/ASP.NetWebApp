using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Web;
using System.Xml.Serialization;

public class AsgmtSettings
{
    public String DefaultPageText1 { get; set; }
    public String DefaultPageText2 { get; set; }
    public String HeaderText { get; set; }
    public String FooterText { get; set; }
}

namespace AssignmentWebApplication.App_Start
{
    public class AsgmtManager
    {
        public static AsgmtSettings LoadSettings(string FilePath)
        {
            AsgmtSettings Settings = new AsgmtSettings();
            try
            {
                System.IO.StreamReader file = new System.IO.StreamReader(FilePath);
                if (file.Peek() < 0)
                {
                    Console.WriteLine("The XML file is empty.");
                }
                file.BaseStream.Position = 0;
                file.DiscardBufferedData();

                try
                {
                    System.Xml.Serialization.XmlSerializer reader = new System.Xml.Serialization.XmlSerializer(typeof(AsgmtSettings));
                    Settings = (AsgmtSettings)reader.Deserialize(file);

                    // Process the deserialized settings object
                    Console.WriteLine("XML deserialization successful.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error deserializing XML: {ex.Message}");
                }

                file.Close();

                return Settings;
            }

            catch (Exception)
            {
                return null;
            }
        }
        public static void SaveSettings(string FilePath, AsgmtSettings SettingsObj)
        {
            System.Xml.Serialization.XmlSerializer writer = new System.Xml.Serialization.XmlSerializer(typeof(AsgmtSettings));

            System.IO.FileStream file = System.IO.File.Create(FilePath);

            writer.Serialize(file, SettingsObj);
            file.Close();
        }
    }
}