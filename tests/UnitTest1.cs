using System;
using Xunit;
using Museet.Models;
using System.IO;

namespace tests
{
    public class UnitTest1
    {

        //Testar ifall det går att lägga till hela konstsamlingen till museet
        [Fact]
        public void AddArtSampleToMuseumTest()
        {
            //arrange
            Museum testMuseum = new("test",1);
            var artsExpectedToAdd = 10;

            
            //act
            testMuseum.AddArtCollection();
            var actualResult = testMuseum.museumArtList.Count;

            //assert
            Assert.Equal(artsExpectedToAdd, actualResult);

            
        }


        // Testar ifall det går att lägga till ett rum i museet
        [Fact]
        public void AddRoomToMuseumTest()
        {
            //arange

            Museum testMuseum = new("test", 1);
            Room testRoom = new("test", 1);
            var roomsToMuseum = 1;

            //act

            testMuseum.AddRoomsToMuseum(testRoom);
            var expectedResult = testMuseum.museumRoomList.Count;

            //assert
            Assert.Equal(roomsToMuseum, expectedResult);
        }



        //Testar ifall det går att lägga till konst från konstlistan till ett rum
        [Fact]
        public void AddArtsToRoomTest()
        {
            //arrange
            Museum testMuseum = new("test",1);
            testMuseum.AddArtCollection();

            Room testRoom= new("test", 3);
            testMuseum.AddRoomsToMuseum(testRoom);
            var artsToRoom = 3;

            //act
            testRoom.AddArtsToRoom(testMuseum.museumArtList, 2, 3, 4);
            var expectedResult = testRoom.artList.Count;

            //assert
            Assert.Equal(artsToRoom, expectedResult);
        }




        //Testar ifall det går att lägga till två museeum innehållandes två olika konstsamlingar
        [Fact]
        public void AddNewMuseum()
        {
           
                //arrange
                Museum testMuseum = new("test", 1);
                

                Museum testMuseum1 = new("test1", 2);
                
                //act
                testMuseum.AddArtCollection();
                var test1 = testMuseum.museumArtList;

                testMuseum1.AddArtCollection2();
                var test2 = testMuseum1.museumArtList;

           

                //assert
                Assert.NotEqual(test1, test2);
                Assert.NotEqual(testMuseum1, testMuseum);

            

        }


        
        //Testar så att det inte är möjligt och radera ett rum som innehåller konst
        [Fact]
        public void ImpossibleDeleteRoomTest()
        {

            //arrange
            Museum testMuseum = new("test", 1);
            testMuseum.AddArtCollection();

            //rum som innehåller konstverk
            Room testRoom1 = new("testrum 1", 1);
            testRoom1.AddArtsToRoom(testMuseum.museumArtList, 9, 3,6);
            testMuseum.AddRoomsToMuseum(testRoom1);

            //rum som inte innehåller konstverk
            Room testRoom2 = new("testum 2", 2);
            testMuseum.AddRoomsToMuseum(testRoom2);


            


            //act

            //försöker radera båda rummen
            MuseumHandler.ArtInRoomCheck(testMuseum, testRoom1);
            MuseumHandler.ArtInRoomCheck(testMuseum, testRoom2);


            var expectedRoomsLeft = 1;
            var actualRoomsLeft = testMuseum.museumRoomList.Count;



            //assert

            //det förväntade resultatet, endast ett utav rummen bör raderas

            Assert.Equal(expectedRoomsLeft, actualRoomsLeft);




        }

    }
}
