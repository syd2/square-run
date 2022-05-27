using System.IO;
using System.Xml.Serialization;
public static class Helper
{
    //Serialize
    public static string Serialize<T>(this T toSerialize)
    {
        //this is how we turn any datatype, any class into a string;
        XmlSerializer xml = new XmlSerializer(typeof(T));
        StringWriter writer = new StringWriter();
        xml.Serialize(writer, toSerialize);
        return  writer.ToString();
    }

    //DeSerialize
    public static T Deserialize<T>(this string toDeserialize)
    {
        //this is how we deserialize.
        XmlSerializer xml = new XmlSerializer(typeof(T));
        StringReader reader = new StringReader(toDeserialize);
        return (T)xml.Deserialize(reader);
    }
}
