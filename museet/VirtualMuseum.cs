using System;
using Museet.Models;
using Simulator;
using System.Linq;
using System.Collections.Generic;

namespace Museet
{
	internal class VirtualMuseumProgram : IApplication
	{
		public void Run(string verb, string[] options)
		{
			// FIXME: Continue with your program here
			Console.WriteLine("Verb: \"{0}\", Options: \"{1}\"", verb, String.Join(',', options));

			//Skapar två stycken museeum
			Museum EmilsMuseum = new("Emils Museeum",1);
			EmilsMuseum.AddArtCollection();
			


			Museum EmilsVIPmuseeum = new("Emils VIP Museeum",2);
			EmilsVIPmuseeum.AddArtCollection2();

			//Skapar rum innehållandes konst och lägger till dessa i museeumen

			// Emils Museeum
			Room darkRoom = new("Mörka rummet", 1);
			darkRoom.AddArtsToRoom(EmilsMuseum.museumArtList, 1, 3);
			EmilsMuseum.AddRoomsToMuseum(darkRoom);

			Room abstractRoom = new("Abstrakta rummet", 2);
			abstractRoom.AddArtsToRoom(EmilsMuseum.museumArtList, 2, 4);
			EmilsMuseum.AddRoomsToMuseum(abstractRoom);

			Room oddRoom= new("Udda rummet", 3);
			oddRoom.AddArtsToRoom(EmilsMuseum.museumArtList, 5, 6);
			EmilsMuseum.AddRoomsToMuseum(oddRoom);

			Room secretRoom = new("Hemliga rummet", 4);
			secretRoom.AddArtsToRoom(EmilsMuseum.museumArtList, 7, 8, 9);
			EmilsMuseum.AddRoomsToMuseum(secretRoom);

			Room ovalRoom = new("Ovala rummet", 5);
			ovalRoom.AddArtsToRoom(EmilsMuseum.museumArtList, 5);
			EmilsMuseum.AddRoomsToMuseum(ovalRoom);

			Room emptyRoom = new("Tomma rummet",6);
			EmilsMuseum.AddRoomsToMuseum(emptyRoom);



			//Emils VIP Museeum
			Room greenRoom = new("Gröna Rummet", 2);
			greenRoom.AddArtsToRoom(EmilsVIPmuseeum.museumArtList, 0, 1);
			EmilsVIPmuseeum.AddRoomsToMuseum(greenRoom);

			

			//Mark start position
			bool showHelp = false;
			
			
			List<string> optionsList = new()
			{
				// VERB LISTA

				// show
			    // add
				// delete


				// OPTIONS LISTA

				"-all",//0

				//rum options

				"-darkroom",//1
				"-abstractroom", //2
				"-oddroom",   //3
				"-secretroom",//4
				"-ovalroom",//5
				"-emptyroom",//6
				"-greenroom",//7

				//övrigt

				"-museum",//8 
				"-room",//9

				// Konstverk options

				"-art-darkroom",//10
				"-art-abstractroom", //11
				"-art-oddroom",   //12
				"-art-secretroom",//13
				"-art-ovalroom",//14
				"-art-emptyroom",//15
				"-art-greenroom",//16
				
			};

			




			switch (verb)

				{
				case "show":

					// Visar konsten i respektive rum
					if (options.Contains(optionsList[0]))
					{
						MuseumHandler.ShowAll(EmilsMuseum);
					}
					else if (options.Contains(optionsList[10]))
					{
						MuseumHandler.ShowArts(darkRoom);
					}
					else if (options.Contains(optionsList[11]))
					{
						MuseumHandler.ShowArts(abstractRoom);
					}
					else if (options.Contains(optionsList[12]))
					{
						MuseumHandler.ShowArts(oddRoom);
					}
					else if (options.Contains(optionsList[13]))
					{
						MuseumHandler.ShowArts(secretRoom);
					}
					else if (options.Contains(optionsList[14]))
					{
						MuseumHandler.ShowArts(ovalRoom);
					}
					else if (options.Contains(optionsList[15]))
					{
						MuseumHandler.ShowArts(emptyRoom);
					}
					else if (options.Contains(optionsList[16]))
					{
						MuseumHandler.ShowArts(greenRoom);
					}
					break;
				case "add":
					// Ny konst till rum
					if (options.Contains(optionsList[10]))
					{
						MuseumHandler.AddNewArt(darkRoom);
					}
					else if (options.Contains(optionsList[11]))
					{
						MuseumHandler.AddNewArt(abstractRoom);
					}
					else if (options.Contains(optionsList[12]))
					{
						MuseumHandler.AddNewArt(oddRoom);
					}
					else if (options.Contains(optionsList[13]))
					{
						MuseumHandler.AddNewArt(secretRoom);
					}
					else if (options.Contains(optionsList[14]))
					{
						MuseumHandler.AddNewArt(ovalRoom);
					}
					else if (options.Contains(optionsList[15]))
					{
						MuseumHandler.AddNewArt(emptyRoom);
					}
					else if (options.Contains(optionsList[16]))
					{
						MuseumHandler.AddNewArt(greenRoom);
					}


					// nytt rum till museet
					else if (options.Contains(optionsList[9]))
                    {
						MuseumHandler.AddNewRoom(EmilsMuseum);
                    }


					//nytt museum
					 else if (options.Contains(optionsList[8]))
                    {
						MuseumHandler.AddNewMuseum();
                    }


					break;
				case "delete":
					//tar bort konstverk från det valda rummet
					if (options.Contains(optionsList[10]))
					{
						MuseumHandler.DeleteArt(darkRoom);
					}
					else if (options.Contains(optionsList[11]))
					{
						MuseumHandler.DeleteArt(abstractRoom);
					}
					else if (options.Contains(optionsList[12]))
					{
						MuseumHandler.DeleteArt(oddRoom);
					}
					else if (options.Contains(optionsList[13]))
					{
						MuseumHandler.DeleteArt(secretRoom);
					}
					else if (options.Contains(optionsList[14]))
					{
						MuseumHandler.DeleteArt(ovalRoom);
					}
					else if (options.Contains(optionsList[15]))
					{
						MuseumHandler.DeleteArt(emptyRoom);
					}
					else if (options.Contains(optionsList[16]))
					{
						MuseumHandler.DeleteArt(greenRoom);
					}


					//tar bort det valda rummet från museet
					else if (options.Contains(optionsList[1]))
					{
						MuseumHandler.DeleteRoomInApplication(EmilsMuseum,darkRoom);
					}
					else if (options.Contains(optionsList[2]))
					{
						MuseumHandler.DeleteRoomInApplication(EmilsMuseum, abstractRoom);
					}
					else if (options.Contains(optionsList[3]))
					{
						MuseumHandler.DeleteRoomInApplication(EmilsMuseum, oddRoom);
					}
					else if (options.Contains(optionsList[4]))
					{
						MuseumHandler.DeleteRoomInApplication(EmilsMuseum, secretRoom);
					}
					else if (options.Contains(optionsList[5]))
					{
						MuseumHandler.DeleteRoomInApplication(EmilsMuseum, ovalRoom);
					}
					else if (options.Contains(optionsList[6]))
					{
						MuseumHandler.DeleteRoomInApplication(EmilsMuseum, emptyRoom);
					}
					else if (options.Contains(optionsList[7]))
					{
						MuseumHandler.DeleteRoomInApplication(EmilsMuseum, greenRoom);
					}


					break;


				default:
					// Show the help menu when the verb was unrecognized
					System.Console.WriteLine("Unkown command!");
					showHelp = true;
					break;



			}

			// Show the help menu if requested
			if (showHelp)
			{
				MuseumHandler.HelpMenu();
			}   
		}
	}
}