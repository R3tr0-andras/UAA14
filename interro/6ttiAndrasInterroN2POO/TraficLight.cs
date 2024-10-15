using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6ttiAndrasInterroN2POO
{
    class TraficLight
    {
        private string _traficLightId;
        private bool _isOn;
        private int _colorNow;

        public TraficLight(string traficLightId, bool isOn, int colorNow)
        {
            _traficLightId = traficLightId;
            _isOn = isOn;
            _colorNow = colorNow;
        }

        public string TraficLightId
        {
            get { return _traficLightId; }

        }
        public int ChangeColor()
        {
            if (_isOn)
            {
                if (_colorNow == 0) //rouge
                {
                    _colorNow = 1;
                }
                else if (_colorNow == 1) //orange
                {
                    _colorNow = 2;
                }
                else if (_colorNow == 2) //vert
                {
                    _colorNow = 0;
                }
                else //exception
                {
                    Console.WriteLine("en dehors des paramètres");
                }
            }
            else
            {
                _colorNow = _colorNow;
            }

            return _colorNow;
        }

        public bool TurnOnOrOff()
        {
            if (_isOn)
            {
                _isOn = true;
            }
            else
            {
                _isOn = false;
            }
            return _isOn;
        }

        public void WinkLight()
        {
            if (_isOn)
            {
                _isOn = false;
                Console.WriteLine($"Le feu de signalisation {_traficLightId} est éteint.");
            }
            else
            {
                _isOn = true;
                Console.WriteLine($"Le feu de signalisation {_traficLightId} est allumé.");
            }
        }

        
        
    }
}
