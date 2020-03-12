using System;
namespace MyClass
{
    public class Publisher
    {
        struct LicenseNumber
        {
            public int licenseNumber; // license number
            public DateTime data; // data of getting it

            /* overrided tostring method */
            public override string ToString()
            {
                string s = String.Format($"Лицензия N-{licenseNumber}" +
                    $"от {data.Year} г.");

                return s;
            }

        }

        /* class properties and variables */
        public string Name { get; set; }
        public string EmailAdress { get; set; }
        private LicenseNumber LinNumber;

        /* class constructor */
        public Publisher(string name, string emailAdress,
            int lnumber, DateTime data)
        {
            Name = name;
            EmailAdress = emailAdress;
            LinNumber.licenseNumber = lnumber;
            LinNumber.data = data;
        }

        /* overriding to string method */
        public override string ToString()
        {
            string s = String.Format($": {Name}, электронный адрес:" +
                $"{EmailAdress}, {LinNumber}");

            return s;
        }

    }
}
