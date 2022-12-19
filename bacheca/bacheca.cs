using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bacheca
{
    public class bacheca
    {
        private string _id;
        private const int MAX = 999;
        private int lung;
        private annuncio[] annunc = new annuncio[MAX];


        public string Id
        {
            get
            {
                return _id;
            }
            private set
            {
                if (value != "")
                {
                    _id = value;
                }
                else
                {
                    throw new Exception("invalid id");
                }

            }
        }

        public int Max
        {
            get
            {
                return MAX;
            }
        }

        public bacheca()
        {

        }

        public bacheca(string id)
        {
            Id = id;
        }

        public void Aggiungi(annuncio a)
        {
            if (lung == MAX)
            {
                throw new Exception("bacheca piena");
            }
            if (a != null)
            {
                annunc[lung] = a;
                lung++;
            }

        }

        public void Modifica(annuncio n)
        {
            if (n != null)
            {
                for (int i = 0; i < lung; i++)
                {
                    if (annunc[i].Id == n.Id)
                    {
                        annunc[i] = n;
                    }
                }
            }
            else
            {
                throw new Exception("inserire annuncio valido");
            }
        }

        public int Remove(int p)
        {
            if (p != -1)
            {
                for (int i = p; i < annunc.Length - 1; i++)
                    annunc[i] = annunc[i + 1];

                annunc[annunc.Length - 1] = null;

                lung--;

                return p;
            }
            else
                throw new Exception("Product not found");
        }




        public void OrdinaP()
        {
            for (int i = 0; i < lung; i++)
            {
                for (int j = 1; j < lung + i; j++)
                {
                    if (annunc [j ].Prezzo > annunc[j+1].Prezzo)
                    {
                        annuncio temp = annunc[j];
                        annunc[j] = annunc[j+1];
                        annunc[j+1] = temp;
                    }
                }
            }

        }

        public float Costotot()
        {
            float tot = 0;

            for (int i = 0; i < lung; i++)
            {
                tot = tot + annunc[i].Prezzo;
            }

            return tot;

        }

        public void visualizza()
        {
            for (int i = 0; i < lung; i++)
            {
                MessageBox.Show(annunc[i].Testo);
            }
        }

        public annuncio[] prodotti()
        {
            return annunc;

        }

        public override string ToString()
        {
            return "Product:" + Id + ";" + Name + ";" + Manufacturer + ";" + Description + ";" + Price;
        }

    }
}
