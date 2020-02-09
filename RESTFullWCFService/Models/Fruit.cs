using System.Runtime.Serialization;

namespace RESTFullWCFService.Models
{
    [DataContract]
    public class Fruit
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public int Price { get; set; }
    }
}