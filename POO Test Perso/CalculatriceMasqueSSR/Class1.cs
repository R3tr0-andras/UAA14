using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatriceMasqueSSR
{
    class Subnet
    {
        public string IpAddress { get; set; }
        public int Cidr { get; set; }
        public string SubnetMask { get; set; }
        public string NetworkAddress { get; set; }
        public string BroadcastAddress { get; set; }
        public int HostCount { get; set; }

        public void Display()
        {
            Console.WriteLine($"\n- Réseau {IpAddress}/{Cidr}");
            Console.WriteLine($"- Masque de sous-réseau : {SubnetMask}");
            Console.WriteLine($"- Adresse réseau : {NetworkAddress}");
            Console.WriteLine($"- Adresse de diffusion : {BroadcastAddress}");
            Console.WriteLine($"- Nombre d'hôtes possibles : {HostCount}");
        }
    }
}
