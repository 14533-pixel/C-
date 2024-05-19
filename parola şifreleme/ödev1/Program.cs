﻿// See https://aka.ms/new-console-template for more information
using System;

namespace ConsoleApp11
{
    class Program
    {
        public static bool kontrol(string parola)
        {
            bool b = false, k = false, r = false;
            foreach (char kr in parola)
            {
                if (Char.IsLower(kr)) k = true;
                if (Char.IsUpper(kr)) b = true;
                if (char.IsDigit(kr)) r = true;
            }
            if (parola.Length == 10 && b && k && r)
                return true;
            else
                return false;
        }
        public static string sifrele(string parola)
        {
            string sifreli = "";
            for (int i = 0; i < parola.Length; i++)
            {
                if (i > 0 && i % 2 == 0) sifreli += "-";
                sifreli += (char)((((int)parola[i]) + 4));

            }
            return sifreli;
        }
        public static string sifreCoz(string parola)
        {

            string sifreli = "";
            for (int i = 0; i < parola.Length; i++)
            {
                if (parola[i] != '-')
                    sifreli += (char)((((int)parola[i]) - 4));

            }

            return sifreli;
        }
        static void Main(string[] args)
        {
            Console.Write("Parola giriniz ");
            string sfr = Console.ReadLine();
            if (kontrol(sfr))
            {
                Console.WriteLine("şifrelenmiş parola");
                string sfrl = sifrele(sfr);
                Console.WriteLine(sfrl);
                Console.WriteLine("Şifresi çözülmüş parola");
                string sfrc = sifreCoz(sfrl);
                Console.WriteLine(sfrc);

            }
            else
                Console.WriteLine("şifre içinde büyük, küçük harf ve rakam olmalı");

        }
    }
}
