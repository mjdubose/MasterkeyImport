namespace MasterkeyImport
{
    class KeywizImport
    {
        private string mK_System_ID;

       private string sort_Index_Order;
       private string symbol_Field_One;
       private string symbol_Field_Two;
       private string symbol_Field_Three;
       private string complete_Symbol;
       private string blind_Code;
       private string key_Desc;
       private string key_Mfg;
       private string keyway;
       private string key_Comments;
      

        private string checklength(string temp, int length)
        {
            return temp.Length > length ? temp.Substring(0, length) : temp;
        }

        public string MK_System_ID { get { return mK_System_ID ; }
            set { mK_System_ID = checklength(value, 10); }
        }
        public string Sort_Index_Order
        {
            get { return sort_Index_Order; }
            set { sort_Index_Order = checklength(value, 2); }
        }

        public string Symbol_Field_One
        {
            get { return symbol_Field_One; } 
            set { symbol_Field_One = checklength(value, 8); } 
        }

        public string Symbol_Field_Two
        {
            get { return symbol_Field_Two; }
            set { symbol_Field_Two = checklength(value, 4); }
        }
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
        public string Bitting_One { get; set; }
        public string Bitting_Two { get; set; }
        public string Bitting_Three { get; set; }
        public string Bitting_Four { get; set; }
        public string Bitting_Five { get; set; }
        public string Bitting_Six { get; set; }
        public string Bitting_Seven { get; set; }
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
        public string Cyl_Pins { get; set; }
        public char Status { get; set; }

    }
}
