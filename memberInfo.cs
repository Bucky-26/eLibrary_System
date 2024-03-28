using System;

namespace eLibrary_System
{
    public class membersInfo
    {
        public string LC_Num { get; set; }
        public string LRN_Num { get; set; }
        public string NAME { get; set; }
        public DateTime DATE_OF_BIRTH { get; set; }
        public string GENDER { get; set; }
        public string ADDRESS { get; set; }
        public string CONTACT_NUMBER { get; set; }
        public string Section { get; set; }
        public string ADVISER { get; set; }
        public string GRADE_LEVEL { get; set; }
        public byte[] PHOTO { get; set; } // Byte array to store image data
    }
}
