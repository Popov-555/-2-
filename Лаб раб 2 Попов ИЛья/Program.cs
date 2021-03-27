// подключены какие-то библиотеки
using System;
using Microsoft.VisualBasic.FileIO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Xml.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using oap_labs;
// про классы мы пока не говорили...
namespace oap_labs
{

    [DataContract]
    abstract class Deliverymeans
    {

        public string Name { get; set; }
        [DataMember]
        public int Speed{ get; set; }
        [DataMember]
        public int Capacity { get; set; }
        [DataMember]
      
        public int Fuel  { get; set; }
       
       
        abstract public (double, double) Calc(int Price , int Distance);
    }
    }


[DataContract]
class Helicopter : Deliverymeans
{
    public double Arenda { get; set; }
    [DataMember]
    public int Rashod { get; set; }
    
    public override (double, double) Calc(int Price, int Distance)
    {
        return ((double)Distance / (double)Speed, Convert.ToInt32(Arenda * Distance + Distance / 100 * Rashod));
    }

}
   
class JetPlane :Deliverymeans {
    [DataMember]
    public int Price { get; set; }
    [DataMember]
    public int TimeWork { get; set; }
  
    public override (double, double) Calc(int Price , int Distance)
    {
        double Time = (double)Distance / (double)Speed;
        if (Time > TimeWork)
            Time = Time / TimeWork * 24;
        return (Time, Convert.ToInt32(Price * Distance));
    }
}

class Maize : Deliverymeans
{
    public double Dop { get; set; }
    public override (double, double) Calc(int Price, int Distance)
    {
        double Time = (double)Distance / (double)Speed;
        return (Time, Dop * Time / 24);
    }
        
}
class Program
{
    // точка входа в программу
    static void Main(string[] args, object fields)
    {

        {

            var HelicopterList = new List<Helicopter>();
            using (TextFieldParser parser = new TextFieldParser("Dostavka.csv"))
            {
                // свойство TextFieldType определяет тип полей: с разделителями или фиксированной ширины
                parser.TextFieldType = FieldType.Delimited;

                // можно указать произвольный разделитель
                parser.SetDelimiters(",");

                // считываем пока не дойдем до конца файла
                while (!parser.EndOfData)
                {
                    //метод ReadFields разбивает исходную строку на массив строк
                    string[] filed= parser.ReadFields();






                }
            }



            Maize[] MaizeArray; ;

            var Serializer = new DataContractJsonSerializer(typeof(Maize[]));
            using (var sr = new StreamReader("Date.json"))
                MaizeArray = (Maize[])Serializer.ReadObject(sr.BaseStream);

            foreach (XElement JetPlaneElement in xdoc.Element("JetPlane").Elements("JetPlane"))
            {
                XAttribute NameAttribute = JetPlaneElement.Attribute("Name");
                XElement SpeedElement = JetPlaneElement.Element("Speed");
                XElement CapacityElement = JetPlaneElement.Element("Capacity");
                XElement PriceElement = JetPlaneElement.Element("Price");
                JetPlaneList.Add(new JetPlane { Name = JetPlaneElement.Attribute("Name").Value, Speed = Convert.ToInt32(JetPlaneElement.Element("Speed").Value), Capacity = Convert.ToInt32(JetPlaneElement.Element("Capacity").Value), Price = Convert.ToInt32(JetPlaneElement.Element("Price").Value) });
            }


            Console.WriteLine("Введите расстояние");
            var Distance = Convert.ToInt32(Console.ReadLine());


            Console.ReadLine();
        }
    } }
    
























