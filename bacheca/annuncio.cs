using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bacheca
{
    public class annuncio
    {
        private int _id;
        private string _testo;
        private string _data;
        private float _prezzo;
        public annuncio(int id, string testo, string data, float prezzo)
        {
            Id = id;
            Testo = testo;
            Data = data;
            Prezzo = prezzo;
        }
        public int Id
        {
            get
            {
                return _id;
            }
            private set
            {
                if (value >= 0)
                {
                    _id = value;
                }
                else
                {
                    throw new Exception("invalid id");
                }
            }
        }


        public string Testo
        {
            get
            {
                return _testo;
            }
            set
            {
                if (value != "")
                {
                    _testo = value;
                }
                else
                {
                    throw new Exception("invalid text");
                }
            }
        }

        public string Data
        {
            get
            {
                return _data;
            }
            set
            {
                if (value != "")
                {
                    _data = value;
                }
                else
                {
                    throw new Exception("invalid data");
                }
            }
        }

        public float Prezzo
        {
            get
            {
                return _prezzo;
            }
            set
            {
                if (value > 0)
                {
                    _prezzo = value;
                }
                else
                {
                    throw new Exception("invalid price");
                }
            }
        }

        public annuncio()
        {

        }

        


    }
}
