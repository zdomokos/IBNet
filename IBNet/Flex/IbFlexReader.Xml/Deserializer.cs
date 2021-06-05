using System;

namespace IbFlexReader.Xml
{
    using System.Collections.Generic;
    using System.IO;
    using System.Xml;
    using System.Xml.Serialization;
    using IbFlexReader.Contracts;
    using IbFlexReader.Utils;
    using IbFlexReader.Xml.Contracts;

    public static class Deserializer
    {
        public static TOut Deserialize<TXml, TOut>(Stream content, out List<ErrorMessage> errorObjects)
            where TXml : XmlBase where TOut : class, new()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(TXml));
            serializer.AddDebugHooks();

            using (XmlReader reader = XmlReader.Create(content))
            {
                try
                {
                    var obj = (TXml)serializer.Deserialize(reader);
                    errorObjects = new List<ErrorMessage>();
                    return new TOut().PopulateFrom(obj, errorObjects);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
            }
        }

        public static TOut Deserialize<TXml, TOut>(XmlReader content, out List<ErrorMessage> errorObjects)
            where TXml : XmlBase where TOut : class, new()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(TXml));
            serializer.AddDebugHooks();

            try
            {
                var obj = (TXml)serializer.Deserialize(content);
                errorObjects = new List<ErrorMessage>();
                return new TOut().PopulateFrom(obj, errorObjects);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        private static void AddDebugHooks(this XmlSerializer serializer)
        {
            serializer.UnknownAttribute += (sender, args) =>
            {
                System.Xml.XmlAttribute attr = args.Attr;
                Console.WriteLine($"Unknown attribute {attr.Name}=\'{attr.Value}\'");
            };
            serializer.UnknownNode += (sender, args) =>
            {
                Console.WriteLine($"Unknown Node:{args.Name}\t{args.Text}");
            };
            
            serializer.UnknownElement     += (sender, args) =>
            {
                Console.WriteLine("Unknown Element:" + args.Element.Name + "\t" + args.Element.InnerXml);
            };
            
            serializer.UnreferencedObject += (sender, args) =>
            {
                Console.WriteLine("Unreferenced Object:" + args.UnreferencedId + "\t" + args.UnreferencedObject.ToString());
            };
        }
    }
}
