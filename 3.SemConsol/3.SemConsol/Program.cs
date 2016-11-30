﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace _3.SemConsol
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Card> cards = DBMapper.ListOfCards();

            List<Door> doors = DBMapper.ListOfDoors();

            List<Access> accesses = DBMapper.ListOfAccess();

            Log l = new Log();




            bool Doorexists = false;

            while (true)
            {
                Console.WriteLine("What door are you trying to access?");
                int DoorID = Int32.Parse(Console.ReadLine());

                foreach (var d in doors)
                {
                    if (d.DoorID == DoorID)
                    {
                        Doorexists = true;
                    }
                }

                if (Doorexists)
                {
                    Console.WriteLine("Scan card");

                    bool Granted = false;


                    string CardID = Console.ReadLine();

                    foreach (var c in accesses)
                    {
                        if (c.DoorAccessID.Equals(DoorID) && c.CardID.Equals(CardID))
                        {

                            Granted = true;
                        }
                    }
                    if (Granted)
                    {
                        Console.WriteLine("Access Granted");
                        l.DateTime = DateTime.Now;
                        l.AccesGranted = "Granted";
                        l.DoorID = DoorID;
                        l.CardID = CardID;
                        DBMapper.AccessLogs(l);

                    }
                    else
                    {
                        Console.WriteLine("Access Denied");
                        l.DateTime = DateTime.Now;
                        l.AccesGranted = "Denied";
                        l.DoorID = DoorID;
                        l.CardID = CardID;
                        DBMapper.AccessLogs(l);
                    }
                    Doorexists = false;
                }
                else Console.WriteLine("Door does not exist ");




            }
        }
    }
}
