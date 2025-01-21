namespace I5_6TTIUAA14_Andras
{
    internal class Fusil
    {
        private byte _nbCartoucheDuFusil;
        public byte NbCartoucheDuFusil
        { get { return _nbCartoucheDuFusil; } set { _nbCartoucheDuFusil = value; } }

        public Fusil()
        {
            _nbCartoucheDuFusil = 16;
        }

        public bool Verifier()
        {
            if (_nbCartoucheDuFusil > 16)
            {
                Console.WriteLine("T'as fait une erreur là andouille");
            }
            if (_nbCartoucheDuFusil == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}