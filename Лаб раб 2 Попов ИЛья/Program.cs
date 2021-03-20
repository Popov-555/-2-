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
        public string NachaloExp { get; set; }
        [DataMember]
        public int Probeg { get; set; }
             
    }

    class Program
    {
        static void Main(string[] args)

        {
            var Serializer = new DataContractJsonSerializer(typeof(Bus[]));

            using (var stream = new StreamReader(@"./Date.json"))
            {
                var BusList = (Bus[])Serializer.ReadObject(stream.BaseStream);


                var FinterList = BusList.Where(b => b.Marshrut == 1);
                foreach (var curBus in BusList)
                    Console.WriteLine($"Bus {curBus.NumberBus}");

                FinterList = BusList.Where(b => (DateTime.Now.Year - Convert.ToInt32(b.NachaloExp)) > 10);
                foreach (var curBus in BusList)
                    Console.WriteLine($"Bus {curBus.NachaloExp}");

            }


            Console.ReadLine();

           

        }
    }
}

    


    

