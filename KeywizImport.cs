namespace MasterkeyImport
{
    class KeywizImport
    {
        private string mK_System_ID;

        public int sort_Index_Order;
        public string symbol_Field_One;
        public int symbol_Field_Two;
        public string symbol_Field_Three;
        public string complete_Symbol;
        public string blind_Code;
        public string key_Desc;
        public string key_Mfg;
        public string keyway;
        public string key_Comments;
        public short bitting_One;
        public short bitting_Two;
        public short bitting_Three;
        public short bitting_Four;
        public short bitting_Five;
        public short bitting_Six;
        public short bitting_Seven;
        public string search_Bitting;
        public string single_Ang_One;
        public string single_Ang_Two;
        public string single_Ang_Three;
        public string single_Ang_Four;
        public string single_Ang_Five;
        public string single_Ang_Six;
        public string double_Ang_One;
        public string double_Ang_Two;
        public string double_Ang_Three;
        public string double_Ang_Four;
        public string double_Ang_Five;
        public string double_Ang_Six;
        public short cyl_Pins;
        public char status;

        private string checklength(string temp, int length)
        {
            return temp.Length > length ? temp.Substring(0, length) : temp;
        }

        public string MK_System_ID { get { return mK_System_ID ; }
            set { mK_System_ID = checklength(value, 10); }
        }
        public int Sort_Index_Order { get; set; }

        public string Symbol_Field_One
        {
            get { return symbol_Field_One; } 
            set { symbol_Field_One = checklength(value, 4); } 
        }

        public int Symbol_Field_Two { get; set; }
        public string Symbol_Field_Three
        {
            get { return symbol_Field_Three; }
            set { symbol_Field_Three = checklength(value, 4); }
        }
        public string Complete_Symbol
        {
            get { return complete_Symbol; }
            set { complete_Symbol = checklength(value, 13); }
        }
        public string Blind_Code
        {
            get { return blind_Code; }
            set { blind_Code = checklength(value, 10); }
        }
        public string Key_Desc
        {
            get { return key_Desc; }
            set { key_Desc = checklength(value, 20); }
        }
        public string Key_Mfg
        {
            get { return key_Mfg; }
            set { key_Mfg = checklength(value, 20); }
        }
        public string Keyway
        {
            get { return keyway; }
            set { keyway = checklength(value, 12); }
        }
        public string Key_Comments
        {
            get { return key_Comments; }
            set { key_Comments = checklength(value, 1000); }
        }
        public short Bitting_One { get; set; }
        public short Bitting_Two { get; set; }
        public short Bitting_Three { get; set; }
        public short Bitting_Four { get; set; }
        public short Bitting_Five { get; set; }
        public short Bitting_Six { get; set; }
        public short Bitting_Seven { get; set; }
        public string Search_Bitting { get; set; }
        public string Single_Ang_One { get; set; }
        public string Single_Ang_Two { get; set; }
        public string Single_Ang_Three { get; set; }
        public string Single_Ang_Four { get; set; }
        public string Single_Ang_Five{ get; set; }
        public string Single_Ang_Six { get; set; }
        public string Double_Ang_One { get; set; }
        public string Double_Ang_Two { get; set; }
        public string Double_Ang_Three { get; set; }
        public string Double_Ang_Four { get; set; }
        public string Double_Ang_Five{ get; set; }
        public string Double_Ang_Six { get; set; }
        public short Cyl_Pins { get; set; }
        public char Status { get; set; }

    }
}
