
using System;

namespace Museet.Models
{
	// TODO: Needs further work
   public class Art
	{
       
        public string author;
        public string title;
        public string description;
        public int artId;





        public Art(string nAuthor, string nTitle, string nDescription, int nId)
        {
            author = nAuthor;
            title = nTitle;
            description = nDescription;
            artId = nId;
        }

        public static Art[] CollectionOfArt()
        {
            Art art1 = new("Peter Paul Rubens", "Den oskyldiga massakern", "Visar den bibliska episoden av massakern av de oskyldiga i Betlehem.", 11);
            Art art2 = new("Pablo Picasso", "Pierretes bröllop", "Målningen representerar en grupp på sex figurer, vars sorgliga uttryck är karakteristiskt för Picassos blå period.", 2);
            Art art3 = new("Vincent van Gogh", "Iris", "Oljemålning på duk föreställandes blåa blommor",3);
            Art art4 = new("Diego Velázquez", "Las Meninas", "Visar flickan Margarita, Philip IV:s dotter. Hon omringas av sina hovdamer men också av konstnären själv.", 4);
            Art art5 = new("Jan Vermeer", "Flicka med pärlörhänge", "Föreställer förmodligen en av konstnärens sju döttrar.", 5);
            Art art6 = new("Vincent van Gogh", "Stjärnenatt", "Blandning mellan otämjda linjer och lugna blå nyanser.", 6);
            Art art7 = new("Pablo Picasso", "Flickorna från Avignon", "Ett typiskt kubistiskt verk och inspirerades av afrikansk folkkonst.", 7);
            Art art8 = new("Gustav Klimt", "Kyssen", "sensuell kärlek och förstärks med hjälp av den gyllene bakgrunden", 8);
            Art art9 = new("Michelangelo", "Adams skapelse", "Konstverket föreställer Gud och Adam som sträcker armarna mot varandra och rör vid varandras fingertoppar.", 9);
            Art art10 = new("Sandro Botticelli", "Venus födelse", "Konstverket föreställer kärlekens gudinna i den Romerska mytologin, Venus", 10);
            

            Art[] artCollection = { art1, art2, art3, art4, art5, art6, art7, art8, art9, art10};
            return artCollection;
        }
        public static Art[] SecondCollectionOfArt()
        {
            Art art1 = new("Leonardo Da Vinci", "Salvator Mundi", " Oljemålning på valnöt trä , på temat Kristus Frälsaren.", 1);
            Art art2 = new("Paul Gauguin", "När ska du gifta dig", "Oljemålning på duk föreställande två kvinnor.", 2);
            Art art3 = new("Paul Cézanne", "Kortspelarna", "Oljemålning på duk föreställandes två män som spelar kort.", 3);
            Art art4 = new("Pablo Picasso", "Kvinnor i Alger", "Kvinnor i Alger i deras lägenhet,Olja på duk.", 4);
            Art art5 = new("Amedeo Modigliani", "Liggande naken", "Oljemålning föreställande en naken kvinna.", 5);
            Art art6 = new("Gustav Klimt", "The Lady i guld", "Porträtt av kvinna i olja, guld och silver på duk.", 6);
            Art art7 = new("Vincent van Gogh", "Porträtt av Dr. Gachet", "representerar doktor Gachet som sitter vid ett bord med huvudet böjt och vilar på hans högra arm.", 7);
            Art art8 = new("Edvard Munch", "Skriket", "Symboliserar den arga moderna mannen genom en kris av existentiell ångest.", 8);
            Art art9 = new("Pablo Picasso", "Pojke med ett rör", "Oljan på duk visar en pojke som håller ett rör i vänster hand och bär en krans av blommor.", 9);
            Art art10 = new("Leonardo Da Vinci", "Mona Lisa", "Porträtt av, enligt tradition, florentinskan (Mona) Lisa Gherardini.", 10);
            

            Art[] artCollection = { art1, art2, art3, art4, art5, art6, art7, art8, art9, art10};
            return artCollection;
        }

    }
}