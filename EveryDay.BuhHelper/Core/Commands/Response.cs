using System;

namespace EveryDay.BuhHelper
{
    public class Response
    {
        public string INN { get; set; }
        public string OGRN { get; set; }
        public ContractorLegal UL { get; set; }
    }

    public class ContractorLegal
    {
        public string KPP { get; set; }

        public Head[] Heads { get; set; }

        public LegalName LegalName { get; set; }
    }

    public class LegalName
    {
        public string Short { get; set; }

        public string Full { get; set; }

        public DateTime Date { get; set; }
    }

    public class Head
    {
        public string Fio { get; set; }

        public string Position { get; set; }
    }
}
