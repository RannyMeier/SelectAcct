using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SelectAcct.Models
{

    public class AcctAcctsV
    {
        public int Id { get; set; }
        public string CS { get; set; }
        public string FsLine { get; set; }
        public string Type { get; set; }
        public bool Real { get; set; }
        public string Num { get; set; }
        public string Name { get; set; }
    }

    public class AcctList
    {
        [JsonPropertyName("entities")]
        public List<AcctAcctsV> Accts { get; set; }
    }

    public class EntSel
    {
        public int Id { get; set; }
        public string ValStrs { get; set; }
        public string Name { get; set; }
        public string Number { get; set; }
    }

    public class EntList
    {
        [JsonPropertyName("entities")]
        public List<EntSel> Ents { get; set; }
    }

    public class Order
    {
        public int Id { get; set; }
        public string DocNum { get; set; }
        public DateTime Date { get; set; }
        public int EntId { get; set; }
        public int AcctId { get; set; }
        public int ItmId { get; set; }
        public decimal Amount { get; set; }
    }

}
