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

namespace oap_labs
{
    // про классы мы пока не говорили...
    [Serializable]
    [DataContract]
    public class Bus
    {
        [DataMember]
        public string FamiliyaIic { get; set; }
        [DataMember]
        public int NumberBus { get; set; }
        [DataMember]
        public int Marshrut { get; set; }
        [DataMember]
        public string Marka { get; set; }
        [DataMember]
        public DateTime NachaloExp { get; set; }
        [DataMember]
        public int Probeg { get; set; }
        public Bus(string familiyaIic, int numberbus, int marshrut, DateTime nachaloexp, int probeg, string marka)
        {
            FamiliyaIic = familiyaIic;
            NumberBus = numberbus;
            Marshrut = marshrut;
            Marka = marka;
            NachaloExp = nachaloexp;
            Probeg = probeg;

        }

        class Program
        {
            static void Import()

            {
                /*using (FileStream fs = new FileStream("Date.json", FileMode.OpenOrCreate))
                {
                    XmlSerializer formatter = new XmlSerializer(typeof(Date[]));
                    Date[] newpeople = (Date[])formatter.Deserialize(fs);

                    var Serializer = new DataContractJsonSerializer(typeof(Date[]));

                    var ms = new MemoryStream();

                    Serializer.WriteObject(ms, newpeople);

                    ms.Position = 0;


                    Console.WriteLine(Encoding.UTF8.GetString(ms.GetBuffer(), 0, (int)ms.Length));
                }
                Console.ReadLine();
            }


            static void Main(string[]args)
            {
                Import();

                //Export();

          
                */

                using FileStream openStream = File.OpenRead(fileName);
                weatherForecast = await JsonSerializer.DeserializeAsync<WeatherForecast>(openStream);

            }

        }
    }

   

}


    

