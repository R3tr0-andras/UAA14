using System.Net;

namespace CalculatriceMasqueSSR
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Entrez une adresse IP : ");
            string ipAddress = Console.ReadLine();

            Console.Write("Entrez le nombre de machines nécessaires : ");
            if (!int.TryParse(Console.ReadLine(), out int requiredHosts) || requiredHosts <= 0)
            {
                Console.WriteLine("Nombre de machines invalide !");
                return;
            }

            if (!IPAddress.TryParse(ipAddress, out IPAddress ip))
            {
                Console.WriteLine("Adresse IP invalide !");
                return;
            }

            int cidr = GetOptimalCidr(requiredHosts);
            uint ipInt = IpToUInt(ip);
            uint subnetMask = ~(uint.MaxValue >> cidr);
            uint networkAddress = ipInt & subnetMask;
            uint broadcastAddress = networkAddress | ~subnetMask;
            uint hostCount = (uint)(Math.Pow(2, 32 - cidr) - 2);

            Console.WriteLine($"\n- Masque CIDR optimal : /{cidr}");
            Console.WriteLine($"- Masque de sous-réseau : {UIntToIp(subnetMask)}");
            Console.WriteLine($"- Adresse réseau : {UIntToIp(networkAddress)}");
            Console.WriteLine($"- Adresse de diffusion : {UIntToIp(broadcastAddress)}");
            Console.WriteLine($"- Nombre d'hôtes possibles : {hostCount}");
        }

        static int GetOptimalCidr(int requiredHosts)
        {
            int neededBits = (int)Math.Ceiling(Math.Log2(requiredHosts + 2));
            return 32 - neededBits;
        }

        static uint IpToUInt(IPAddress ip)
        {
            byte[] bytes = ip.GetAddressBytes();
            Array.Reverse(bytes);
            return BitConverter.ToUInt32(bytes, 0);
        }

        static string UIntToIp(uint ip)
        {
            byte[] bytes = BitConverter.GetBytes(ip);
            Array.Reverse(bytes);
            return new IPAddress(bytes).ToString();
        }
    }
}