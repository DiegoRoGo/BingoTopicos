using System;

namespace BingoWCF.Dominio.Patrones
{


    public class Patrones
    {

        public Boolean[,] GenPatron()
        {
            Boolean[,] resp = new Boolean[5, 5];
            Random rnd = new Random();
            int rndnum = rnd.Next(1,6);


            switch (rndnum)
            {
                case 1:
                   resp= cartonLleno();
                    break;

                case 2:
                    resp= esquinas();
                    break;

                case 3:
                    resp= letraH();
                    break;

                case 4:
                    resp= letraX();
                    break;

                case 5:
                    resp= letraU();
                    break;

            }

            return resp;


        }


        public Boolean[,] cartonLleno()
        {
            bool[,] array = { { true, true, true,true, true },
                              { true, true, true,true, true },
                              { true, true, true,true, true },
                              { true, true, true,true, true },
                              { true, true, true,true, true },};
            return array;
        }



        public Boolean[,] esquinas()
        {
            bool[,] array = {   { true, false, false,false, true },
                                { false, false, false,false, false },
                                { false, false, false,false, false },
                                { false,false, false,false, false },
                                { true, false, false,false, true },};
            return array;
        }



        public Boolean[,] letraH()
        {
            bool[,] array = {   { true, false, false,false, true },
                                { true, false, false,false, true },
                                { true, true, true, true, true },
                                { true,false, false,false, true },
                                { true, false, false,false, true },};

            return array;
        }


        public Boolean[,] letraX()
        {
            bool[,] array = {   { true, false, false,false, true },
                                { false, true, false,true, false },
                                { false, false, true, false, false },
                                { false,true, false,true, false },
                                { true, false, false,false, true },};

            return array;
        }


        public Boolean[,] letraU()
        {
            bool[,] array = {   { true, false, false,false, true },
                                { true, false, false,false, true },
                                { true, false, false,false, true },
                                { true,false, false,false, true },
                                { true, true, true,true, true },};
            return array;
        }



    }


}


