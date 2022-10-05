using System;
using System.Collections.Generic;
using System.Linq;

namespace Museet.Models
{
	// TODO: Needs further work
	public class Room
	{
        public string roomName;
        public int roomId;
        public List<Art> artList;
        

        public Room(string nRoomName, int nRoomId)
        {
            roomName = nRoomName;
            roomId = nRoomId;
            artList = new List<Art>();
        }

        public void AddArtsToRoom(List<Art> museumArts, int art1)
        {
            for (int i = 0; i < museumArts.Count; i++)
            {
                Art artsToAdd = museumArts[i];

                if (i == art1)
                {
                    artList.Add(artsToAdd);
                }
            }
        }

        public void AddArtsToRoom(List<Art> museumArts, int art1, int art2)
        {
            for (int i = 0; i < museumArts.Count; i++)
            {
                Art artsToAdd = museumArts[i];

                if (i == art1 || i == art2)
                {
                    artList.Add(artsToAdd);
                }
            }

        }

        public void AddArtsToRoom(List<Art> museumArts, int art1, int art2, int art3)
        {
            for (int i = 0; i < museumArts.Count; i++)
            {
                Art artsToAdd = museumArts[i];

                if (i == art1 || i == art2 || i == art3)
                {
                    artList.Add(artsToAdd);
                }
            }
        }
       
       
    }
}
