
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Museet.Models
{
    public class Museum
    {
        public string museumName;
        public int museumId;
        public List<Room> museumRoomList;
        public List<Art> museumArtList;
        
        
        public Museum(string nMuseumName, int nMuseumId)
        {
            museumName = nMuseumName;
            museumId = nMuseumId;
            museumRoomList = new List<Room>();
        }
        
        public void AddArtCollection()
        {
            museumArtList = new List<Art>(Art.CollectionOfArt());

        }
        public void AddArtCollection2()
        {
            museumArtList = new List<Art>(Art.SecondCollectionOfArt());

        }

        //Add customized rooms to Museeum
        public void AddRoomsToMuseum(Room room)
        {
            museumRoomList.Add(room);
        }

    }
}
