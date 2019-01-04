using System.Collections.Generic;
using System.Net.NetworkInformation;

namespace SpeedPay.Models
{
    public class Customer
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Cpf { get; set; }

        public string Rg { get; set; }
       
        public string Lat { get; set; }

        public string Lng { get; set; }

        public string Location { get; set; }

        public string MacAddress { get; set; }

        public List<Order> Orders { get; set; }
        public virtual Order Order { get; set; }

        public List<Phone> Phones { get; set; }
        public virtual Phone Phone { get; set; }
        

        public string GetMacAddress()
        {
            try
            {
                NetworkInterface[] Nics = NetworkInterface.GetAllNetworkInterfaces();
                MacAddress = string.Empty;
                foreach (NetworkInterface adapter in Nics)
                {
                    if (MacAddress == string.Empty)
                    {
                        IPInterfaceProperties properties = adapter.GetIPProperties();
                        MacAddress = adapter.GetPhysicalAddress().ToString();
                    }
                }
                return MacAddress;
            }
            catch (System.Exception Error)
            {

                throw Error;
            }
        }
    }
}
