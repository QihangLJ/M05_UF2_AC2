﻿using System;
namespace MyProgram
{
    public class ProgramCode
    {
        public static void Main(string[] args)
        {
            const string MsgMenu = "Selecciona una figura geometrica: \nA) Quadrat \nB) Rectangle \nC) Cercle \nD) Pentagon";
            const string MsgInvalid = "Opcio invalid!";
            const string MsgEnterValue = "Introdueix un valor:";
            const string MsgArea = "L'area de la figura es {0}.";

            decimal numOne, numTwo, result = 0;
            char menuSelection;
            bool menuSelected = true;

            Console.WriteLine(MsgMenu);
            menuSelection = Convert.ToChar(Console.ReadLine());


            switch (menuSelection)
            {
                case 'A':
                case 'a':

                    break;
                case 'B':
                case 'b':

                    break;
                case 'C':
                case 'c':

                    break;
                case 'D':
                case 'd':

                    break;
                default:

                    break;
            }

            if (menuSelected)
            {
                Console.WriteLine(MsgArea, result);
            }
        }
    }
}