using System;
using System.Reflection.Emit;

namespace MinButik
{
    public class Artiklar : Generator
    {
        public string? _motiv;
        public int? _snittbetyg;
        public int _pris;

        public string GetMotiv()
        {

             Random randommotiv = new Random();
             int index = randommotiv.Next(MotivLista.Count);
             string randomString = MotivLista[index];

             return randomString;
        }

         public int GetSnittBetyg()
         {
             Random randomsnittb = new Random();
             int index = randomsnittb.Next(SnittBLista.Count);
             int randomInt = SnittBLista[index];

             return randomInt;
         }
    }

    public class Tshirts : Artiklar
    {
        public string? _storlek;
        public string? _storlek1;
        public string? _storlek2;
        public string? _material;

        public Tshirts()
        {

        }
        
        public string GetStorlek()
        {
            Random randomstorlek = new Random();
            int index = randomstorlek.Next(StrlLista.Count);
            string randomString = StrlLista[index];

            return randomString;
        }

        public string GetMaterial()
        {
            Random randommaterial = new Random();
            int index = randommaterial.Next(MaterialLista.Count);
            string randomString = MaterialLista[index];

            return randomString;
        }

        public void GetTshirt()
        {
            _motiv = GetMotiv();
            _pris = 300;
            _snittbetyg = GetSnittBetyg();
            _storlek = GetStorlek();
            _storlek1 = GetStorlek();
            _storlek2 = GetStorlek();
            _material = GetMaterial();

            if (_snittbetyg < 5)
            {
                _pris = 200;

            }
            if (_snittbetyg == 10)
            {
                    Console.WriteLine($"~ Tshirt ~ \nMotiv: {_motiv}\n" +
                    $"Pris: {_pris}:-\nSnittbetyg: {_snittbetyg} [KUNDFAVORIT]\n" +
                    $"Storlek: {_storlek}, {_storlek1}, {_storlek2}\n" +
                    $"Material: {_material}\n\n");
            }
            else
            {
                Console.WriteLine($"~ Tshirt ~ \nMotiv: {_motiv}\n" +
                    $"Pris: {_pris}:-\nSnittbetyg: {_snittbetyg}\n" +
                    $"Storlek: {_storlek}, {_storlek1}, {_storlek2}\n" +
                    $"Material: {_material}\n\n");
            }
        }

    }

    public class Muggar : Artiklar
    {
        public string? _typ;

        public Muggar()
        {

        }

         public string GetTyp()
         {
             Random randomtyp = new Random();
             int index = randomtyp.Next(TypLista.Count);
             string randomString = TypLista[index];

             return randomString;
         }

         public void GetMugg()
         {
             _motiv = GetMotiv();
             _pris = 150;
             _snittbetyg = GetSnittBetyg();
             _typ = GetTyp();

             if (_snittbetyg < 5 || _typ == "äggkopp")
             {
                 _pris = 95;

             }
             if (_snittbetyg == 10)
             {
                 Console.WriteLine($"~ Mugg ~ \nTyp: {_typ}\nMotiv: {_motiv}\n" +
                     $"Pris: {_pris}:-\nSnittbetyg: {_snittbetyg} [KUNDFAVORIT]\n\n");
             }
             else
             {
                 Console.WriteLine($"~ Mugg ~ \nTyp: {_typ}\nMotiv: {_motiv}\n" +
                     $"Pris: {_pris}:-\nSnittbetyg: {_snittbetyg}\n\n");
             }
         }

    }

}