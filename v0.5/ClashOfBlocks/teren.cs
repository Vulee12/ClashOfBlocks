using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClashOfBlocks
{
    class Teren
    {
        private int PocetnaKoordinataX;
        private int PocetnaKoordinataY;
        private int[,] mapa;

        public Teren()
        {
            Random random = new Random();
            int n = random.Next(10, 20);
            this.Mapa = new int[n, n];
        }

        public int[,] Mapa { get => mapa; set => mapa = value; }

        public void Generisi()//0 - wall, 1 - empty, 2 - player, 3 - enemy
        {
            Random random1 = new Random();
            int n = random1.Next(10, 20);
            this.Mapa = new int[n, n];
            Random random;
            for (int i = 0; i < Mapa.GetLength(0); i++)
            {
                for(int j = 0; j < Mapa.GetLength(0); j++)
                {
                    Mapa[i, j] = 1;
                    if (i == 0 || j == 0 || i == Mapa.GetLength(0) - 1 || j == Mapa.GetLength(0) - 1)
                    {
                        Mapa[i, j] = 0;
                    }
                }
            }
            for (int i = 1; i < Mapa.GetLength(0) - 1; i++)
            {
                for (int j = 1; j < Mapa.GetLength(0) - 1; j++)
                {
                    random = new Random();
                    for (int k = 0; k < 1234567; k++)
                    {
                    }
                    if (Mapa[i - 1, j] != 0 && Mapa[i + 1, j] != 0 && Mapa[i, j - 1] != 0 && Mapa[i, j + 1] != 0 && Mapa[i-1, j - 1] != 0 &&  Mapa[i + 1, j - 1] != 0 && Mapa[i - 1, j +1] != 0 && Mapa[i +1, j +1] != 0)
                    {
                        if (random.Next(0, 3) == 1)
                        {
                            Mapa[i, j] = 0;
                        }
                    }
                }
            }
            Random enemyX = new Random();
            Random enemyY = new Random();
            PocetnaKoordinataX = enemyX.Next(1, Mapa.GetLength(0) - 2);
            PocetnaKoordinataY = enemyY.Next(1, Mapa.GetLength(0) - 2);
            Mapa[PocetnaKoordinataX, PocetnaKoordinataY] = 3;
        }

        public void Prosiri()
        {
            int[,] temp = new int[mapa.GetLength(0), mapa.GetLength(0)];
            for (int i = 0; i < mapa.GetLength(0); i++)
            {
                for (int j = 0; j < mapa.GetLength(0); j++)
                {
                    temp[i, j] = mapa[i, j];
                }
            }
            for (int i = 0; i < Mapa.GetLength(0); i++)
            {
                for (int j = 0; j < Mapa.GetLength(0); j++)
                {
                    if(temp[i,j] == 2 || temp[i,j] == 3)
                    {
                        int vrednost = Mapa[i, j];
                        if(Mapa[i-1,j] == 1)
                        {
                            Mapa[i - 1, j] = vrednost;
                        }
                        if (Mapa[i + 1, j] == 1)
                        {
                            Mapa[i + 1, j] = vrednost;
                        }
                        if (Mapa[i, j -1] == 1)
                        {
                            Mapa[i,j-1] = vrednost;
                        }
                        if (Mapa[i, j + 1] == 1)
                        {
                            Mapa[i, j + 1] = vrednost;
                        }
                    }
                }
            }
        }

        public void Resetuj()
        {
            for (int i = 0; i < mapa.GetLength(0); i++)
            {
                for (int j = 0; j < mapa.GetLength(0); j++)
                {
                    if (mapa[i, j] == 2 || mapa[i, j] == 3)
                        mapa[i, j] = 1;
                }
            }
            mapa[PocetnaKoordinataX, PocetnaKoordinataY] = 3;
        }
    }
}
