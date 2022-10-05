
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Museet.Models
{
    public abstract class MuseumHandler
    {
        
        public static void ShowAll(Museum museum)
        {
            Console.Clear();
            Console.WriteLine($"i {museum.museumName} finns följande rum och dess konst \n ");
            foreach (var room in museum.museumRoomList)
            {


                Console.WriteLine("-------------------------------------------- ");


                Console.WriteLine($"I {room.roomName} finns {room.artList.Count} konstverk att betrakta:\n--------------------------------------------  ");
                foreach (var art in room.artList)
                {
                   
                    Console.WriteLine("Titel: " + art.title);
                    Console.WriteLine();
                    Console.WriteLine("Beskrivning: " + art.description);
                    Console.WriteLine();
                    Console.WriteLine("Av konstnären: " + art.author);
                   
                    Console.WriteLine("\n");
                }
            }
        }
        public static void ShowArts(Room room)
        {
            Console.Clear();

            Console.WriteLine($"I {room.roomName} finns {room.artList.Count} konstverk att betrakta:\n--------------------------------------------  ");
            foreach (var art in room.artList)
            {
                Console.WriteLine("-------------------------------------------- ");
                Console.WriteLine("Titel: " + art.title);
                Console.WriteLine();
                Console.WriteLine("Beskrivning: " + art.description);
                Console.WriteLine();
                Console.WriteLine("Av konstnären: " + art.author);
                Console.WriteLine("\n");
            }


        }

        public static void AddNewArt(Room room)
        {
            
            Console.Clear();
            if (room.artList.Count == 0)
            {
                Console.WriteLine($"I {room.roomName} finns för tillfället inga konstverk.\n ");

            }
            else
            {
                Console.WriteLine($"I {room.roomName} finns följande {room.artList.Count} konstverk att betrakta:\n ");
                foreach (var art in room.artList)
                {
                    Console.WriteLine("-------------------------------------------- ");
                    Console.WriteLine("Titel: " + art.title);
                    Console.WriteLine("Beskrivning: " + art.description);
                    Console.WriteLine("Av konstnären: " + art.author);
                    Console.WriteLine("\n");
                }
            }
            
            Console.WriteLine("Du har valt att lägg till ett nytt konstverk\n ");
            Console.Write("Vem är upphovsmakaren?\n ");
            string author = Console.ReadLine();
            Console.Write("vad heter konstverket?\n ");
            var title = Console.ReadLine();
            Console.Write("beskriv konstverket\n ");
            var description = Console.ReadLine();
            Console.Write("Ge konstverket ett ID-nummer\n ");

            int artId= Int32.Parse(Console.ReadLine());

            Console.WriteLine();


            var newArt = new Art(author,title,description,artId);
           
            room.artList.Add(newArt);
            LoadingSimulator();
            Console.WriteLine($"i {room.roomName} finns nu följande {room.artList.Count}  konstverk att betrakta\n ");
            foreach (var art in room.artList)
            {
                Console.WriteLine("-------------------------------------------- ");
                Console.WriteLine("Titel: " + art.title);
                Console.WriteLine("Beskrivning: " + art.description);
                Console.WriteLine("Av konstnären: " + art.author);
                Console.WriteLine("\n");
            }

                
            

        }


        public static void AddNewRoom(Museum museum)
        {

            Console.Clear();
            Console.WriteLine($"i Museet finns det för närvarande följande rum \n ");


            foreach (var room in museum.museumRoomList)
            {
                Console.WriteLine("----------- ");
                Console.WriteLine(" ");
                Console.WriteLine($"{room.roomName}");
                
            }
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("----------- ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("Du har valt att lägga till ett nytt rum");
            Console.WriteLine(" ");
            Console.WriteLine("Vad heter rummet? ");
            Console.WriteLine(" ");
            var RoomName = Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine("Vilket ID nummer ska rummet få? ");
            Console.WriteLine(" ");
            int RoomId = Int32.Parse(Console.ReadLine());

            var newRoom = new Room(RoomName, RoomId);


            museum.museumRoomList.Add(newRoom);
            Console.WriteLine(" ");
            LoadingSimulator();
            AddNewArt(newRoom);
            LoadingSimulator();
            Console.WriteLine($"i Museet finns nu följande rum följt av dess konst \n ");
            foreach (var room in museum.museumRoomList)
            {
               

                Console.WriteLine("-------------------------------------------- ");


                Console.WriteLine($"I {room.roomName} finns {room.artList.Count} konstverk att betrakta:\n -------------------------------------------- ");
                foreach (var art in room.artList)
                {
                    Console.WriteLine("Titel: " + art.title);
                    Console.WriteLine("Beskrivning: " + art.description);
                    Console.WriteLine("Av konstnären: " + art.author);
                    Console.WriteLine("\n");
                }
            }

        }

       
        public static void DeleteArt(Room room)
        {
            int ID;
            Console.Clear();
            Console.WriteLine($"Det finns förnärvarande dessa konstverk i {room.roomName} \n ");
            foreach (var art in room.artList)
            {
                Console.WriteLine("-------------------------------------------- ");
                Console.WriteLine("Titel: " + art.title);
                Console.WriteLine("Beskrivning: " + art.description);
                Console.WriteLine("Av konstnären: " + art.author);
                Console.WriteLine("Id-nummer: " + art.artId);
                Console.WriteLine("\n");
            }


            Console.Write("Skriv in ID-nummret tillhörande det konstverket som ska tas bort: ID");
            ID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            for (int i = room.artList.Count - 1; i >= 0; i--)
            {
                
                if (ID == room.artList[i].artId)
                {
                    room.artList.RemoveAt(i);
                }
            }
            LoadingSimulator();
            Console.WriteLine($"Det valda konstverket har raderats, nu finns följande konstverk kvar i {room.roomName}\n ");
            foreach (var art in room.artList)
            {
                Console.WriteLine("-------------------------------------------- ");
                Console.WriteLine("Titel: " + art.title);
                Console.WriteLine("Beskrivning: " + art.description);
                Console.WriteLine("Av konstnären: " + art.author);
                Console.WriteLine("Id-nummer: " + art.artId);
                Console.WriteLine("\n");
            }

            
        }


       
        public static void AddNewMuseum()
        {
            Console.Clear();
            Console.WriteLine("Du har valt att skapa ett helt nytt museeum \n ");
            Console.WriteLine("Vad ska det nya museet heta?\n ");
            string name= Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Var vänlig och ge det nya museet ett ID-nummer, \n ID: ");
            
            int museumId = Int32.Parse(Console.ReadLine());

            Museum newMuseum = new(name,museumId);
            
            LoadingSimulator();
            Console.WriteLine("Det nya museet är nu skapat\n Var vänlig och lägg till ett nytt rum och ett nytt konstverk till det nya museet i nästa steg\n ");
            Console.WriteLine("");
            System.Threading.Thread.Sleep(6000);
            Console.Clear();
            AddNewRoom(newMuseum);

            
            
            
            var museum = newMuseum;

            Console.Clear();
            Console.WriteLine($"i {museum.museumName} finns nu följande rum med dess konst \n ");
            foreach (var room in museum.museumRoomList)
            {


                Console.WriteLine("-------------------------------------------- ");


                Console.WriteLine($"I {room.roomName} finns {room.artList.Count} konstverk att betrakta:\n--------------------------------------------  ");
                foreach (var art in room.artList)
                {
                    Console.WriteLine("Titel: " + art.title);
                    Console.WriteLine("Beskrivning: " + art.description);
                    Console.WriteLine("Av konstnären: " + art.author);
                    Console.WriteLine("\n");
                }
            }

        }


        static public void DeleteRoom(Museum museum, Room room)
        {
            int ID = room.roomId;

                for (int i = museum.museumRoomList.Count - 1; i >= 0; i--)
                {

                    if (ID == museum.museumRoomList[i].roomId)
                    {
                        museum.museumRoomList.RemoveAt(i);
                    }
                }
        }

        static public void ArtInRoomCheck(Museum museum, Room room)
        {
            
            if (room.artList.Count == 0)
            {
               DeleteRoom(museum, room); 

            }

            else if (room.artList.Count >= 1)
            {
                Console.WriteLine($"ERROR! det {room.roomName} innehåller för närvarande {room.artList.Count} konstverk och kan inte raderas");
                System.Threading.Thread.Sleep(1000);
               
            }
        }


        public static void DeleteRoomInApplication(Museum museum, Room room)
        {
            Console.Clear();
            Console.WriteLine($"{museum.museumName} innehåller följande rum");
            Console.WriteLine();
            foreach (var rum in museum.museumRoomList)
            {

                Console.WriteLine($">Name: {rum.roomName}");
                Console.WriteLine();

            }
            Console.WriteLine();
            Console.WriteLine($"Du har valt att radera det {room.roomName}");
            Console.WriteLine();
            Console.WriteLine("Skriv ja följt av enter för att bekräfta ditt val.");
            Console.WriteLine();
            Console.WriteLine("Skriv nej följt av enter för att avsluta programmet");
            string confirm = Console.ReadLine();

            if(confirm == "ja")
            {
                Console.Clear();
                LoadingSimulator();
                ArtInRoomCheck(museum, room);
            }
            else if (confirm == "nej")
            {
                System.Environment.Exit(0);

            }
            if (room.artList.Count >=1)
            {
                Console.Write($"Tryck på <Enter> för att ta bort konstverken i det {room.roomName}\n innan programmet försöker att radera rummet igen.");

                while (Console.ReadKey(true).Key != ConsoleKey.Enter) { }

                Console.WriteLine("");
                Console.WriteLine("Konsten kommer nu att raderas.");
                LoadingSimulator();
                room.artList.Clear();
                Console.WriteLine($"Det {room.roomName} innehåller nu {room.artList.Count} konstverk och rummet kommer att raderas.");
                System.Threading.Thread.Sleep(5000);
                LoadingSimulator();
                DeleteRoom(museum, room);
            }
            
            
            Console.WriteLine($"Det valda rummet har nu raderats och {museum.museumName} innehåller nu följande rum");
            Console.WriteLine();
            foreach (var rum in museum.museumRoomList)
            {
                Console.WriteLine($">Namn: {rum.roomName}");
                Console.WriteLine();
            }

        }

        public static void LoadingSimulator()
        {
            
            Console.Clear();
            System.Threading.Thread.Sleep(800);
            Console.WriteLine(".");
            System.Threading.Thread.Sleep(800);
            Console.Clear();
            Console.WriteLine("..");
            System.Threading.Thread.Sleep(800);
            Console.Clear();
            Console.WriteLine("...");
            System.Threading.Thread.Sleep(800);
            Console.Clear();
        }



        public static void HelpMenu()
        {
            Console.Clear();
            System.Console.WriteLine("EN NATT PÅ MUSEET");
            System.Console.WriteLine("Kommandon skrivs med (verb | option)");
            Console.WriteLine("");
            System.Console.WriteLine("Tillgängliga verb:");
            Console.WriteLine("");
            System.Console.WriteLine("|show| visar konsten i det valda rummet");
            Console.WriteLine("");
            System.Console.WriteLine("|add| lägger till ett nytt konstverk/rum/museum");
            Console.WriteLine("");
            System.Console.WriteLine("|delete| tar bort konstverk från ett rum alternativt tar bort ett rum från museet");
            Console.WriteLine("");
            System.Console.WriteLine("Tillgängliga options");
            System.Console.WriteLine("-art-darkroom");
            System.Console.WriteLine("-art-abstractroom");
            System.Console.WriteLine("-art-oddroom ");
            System.Console.WriteLine("-art-secretroom");
            System.Console.WriteLine("-art-ovalroom ");
            System.Console.WriteLine("-art-emptyroom");
            System.Console.WriteLine("-art-greenroom");
            System.Console.WriteLine("");
            System.Console.WriteLine("");
            System.Console.WriteLine("-darkroom");
            System.Console.WriteLine("-abstractroom");
            System.Console.WriteLine("-oddroom  ");
            System.Console.WriteLine("-secretroom");
            System.Console.WriteLine("-ovalroom ");
            System.Console.WriteLine("-emptyroom");
            System.Console.WriteLine("-greenroom ");
            System.Console.WriteLine("");
            System.Console.WriteLine("");
            System.Console.WriteLine("-all");
            System.Console.WriteLine("-room");
            System.Console.WriteLine("-museum");
        }

    }

   
}
    

