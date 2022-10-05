**KOMMANDON**
    
# Tillgängliga Verb|
|------------------|
|    add           |
|    show          |
|    delete        |
|------------------|


**options till verbet "add"**

|------------------|
#       add        |
|------------------|
#     options      |
|------------------|
| -art-darkroom    |
| -art-abstractroom|
| -art-oddroom     |
| -art-secretroom  |
| -art-ovalroom    |
| -art-emptyroom   |
| -art-greenroom   |
|------------------|
| -room            |
|------------------|
| -museum          |
|------------------|

**options till verbet "show"**

|------------------|
#       show       |  
|------------------|
#     options      |
|------------------|
| -art-darkroom    |
| -art-abstractroom|
| -art-oddroom     |
| -art-secretroom  |
| -art-ovalroom    |
| -art-emptyroom   |
| -art-greenroom   |
|------------------|
| -all             |
|------------------|


**options till verbet "delete"**

|------------------|
#       delete     |
|------------------|
#     options      |
|------------------|
| -art-darkroom    |
| -art-abstractroom|
| -art-oddroom     |
| -art-secretroom  |
| -art-ovalroom    |
| -art-emptyroom   |
| -art-greenroom   |
|------------------|
| -darkroom        |
| -abstractroom    |
| -oddroom         |
| -secretroom      |
| -ovalroom        |
| -emptyroom       |
| -greenroom       |
|------------------|


**Seperation**

`För att upprätthålla en avgränsning mellan modell-klasserna och Console-klassen så skapade jag klassen MuseumHandler. Via den sköts samtlig logik och all input/output från Console-klassen. När programmet "mu" startar så skapas två olika museeum som får varsin konstsamling samt några rum. Den enda interaktionen som görs med Consolklassen är när någon av rummen/museeumen skickas med som parameter till någon av metoderna i MuseumHandeler.`


**Testning**

# AddArtSampleToMuseumTest #
`I första testet så börjar jag med att skapa ett test-museum, sedan lägger jag till hela kollektionen av konst med "AddArtCollection", eftersom den innehåller 10 konstverk så skapar jag en variabel som heter "artsExpectedToAdd" vilken motsvarar 10, sedan räknar jag hur många konstverk som faktiskt las till i museet och ger den variabeln "actualResult. Sedan jämförs dessa två med Assert-metoden Equal för att kontrollera att rätt antal konstverk hamande i museet. `

*Motivering*
`Är enligt mig ett bra test för att säkerställa att det går att lägga till en konstsamling i ett museeum.`

# AddRoomToMuseumTest #
`I det andra testet så kollar jag att man kan lägga till ett eller flera rum till ett museum med metoden "AddRoomsToMuseum". Jag skapar ett testmuseeum följt av ett testrum för att sedan lägga till testrummet som parameter i den ovan nämnda metoden.För att säkerhetställa att rummet las till kontrollerar jag detta med att jämföra variablen roomsToMuseum med expectedResult i Assert-metoden Equal. `

*Motivering*
`Eftersom första testet kontrollerar att en konstlista kan läggas till i ett museum så tycker jag att ett lämpligt andra test var att säkerställa att specifika rum går att lägga till i ett museum.`

# AddArtsToRoomTest #
`Det tredje testet följer samma linje som föregående test, jag börjar med att skapa ett testmuseum och lägger till en konstsamling, sedan skapar jag ett testrum och lägger till det i museet. Med metoden "AddArtsToRoom" lägger jag till 3 stycken konstverk till det skapade testrummet. Sedan kontrollerar jag att det faktiskt var 3 konstverk som lades till med Assert-metoden Equal som jämför det förväntade resultatet med det faktiska resultatet.`


*Motivering*
`Eftersom det första testet säkerhetsställer att en konstlista kan läggas till i ett museum och det andra testet kontrollerar att ett/flera rum kan läggas till i ett museum så tycker jag att ett test för att bekfräfta att specifika konstverk kan läggas till i ett rum var ett lämpligt tredje test. `



# AddNewMuseum #
`I det fjärde testet så är tanken att kontrollera ifall det är möjligt att lägga till två olika museum i programmet. Jag börjar med att skapa två stycken testmuseum och ger dessa två helt olika konstsamlingar. Sedan skapar jag två variabler "test1" och "test2" som båda representerar respektive konstlista i det olika museumen. Sedan använder jag mig av metoden Assert.NotEqual för att kontrollera att deras konstsamlingar inte innehåller samma konstverk. Jag kör även varje testmuseum i samma Assert.NotEqual för att säkerställa att museumen är unika. `

*Motivering*
`Ett av kraven var att det skulle vara möjligt att lägga till fler än ett museum i programmet, därav tyckte jag att det var lämpligt att ha detta som fjärde test.`

# ImpossibleDeleteRoomTest #
`I det femte och sista testet så ska jag kontrollera att ett rum som innehåller konstverk inte kan raderas från ett museum. Jag börjar med att skapa ett testmuseum följt av två stycken testrum. I testRoom1 lägger jag till tre stycken konstverk innan jag slutligen lägger till rummet i museet. testRoom2 får däremot ingen konst och jag lägger till det som ett tomt rum i museet. I nästa steg så lägger jag till respektive rum som parameter i metoden "ArtInRoomCheck" som försöker radera ett rum som inte innehåller några konstverk.`
`Sedan skapar jag två variabler där först är "var expectedRoomsLeft = 1;" som motsvarar antalet rum som förväntas vara kvar efter körningarna av den ovan nämnda metoden, den andra variablen är " var actualRoomsLeft = testMuseum.museumRoomList.Count;" som motsvarar det faktiska antalet rum som finns kvar i museet efter körningarna. Eftersom endast ett av rummen är fritt från konstverk så bör endast ett av rummen att raderas från museet. Jag säkerställer detta genom att jämföra de två variablerna i Assert.Equal`

*Motivering*
`Detta var också ett av kraven i uppgiften och tycker att det här testet uppfyller sitt syfte och är ett väldigt lämpligt sista test att ha med`


**Avslutande Reflektion**
`Under de två terminer som varit så tycker jag att den här uppgiften har varit den svåraste utav alla. Nu när jag slutligen skulle sätta mig in i den här uppgiften igen så visste jag inte riktigt hur det skulle gå. Nu när jag är färdig så måste jag säga att det har varit fruktansvärt roligt,lärorikt och utmanande att arbeta med den här uppgiften. Efter vi började med React och fokuset låg på JavaScript så kände jag direkt att "detta är vad jag vill hålla på med efter utbildningen", nu är jag dock inte lika säker på det. Efter En natt på museet så känner jag att många pusselbitar äntligen faller på plats när det kommer till logiskt tänkande och kodskrivning i C#. Att jobba med och skapa enhetstester var dessutom något jag inte riktigt begrep innan, och nu känner jag även att jag äntligen förstår logiken och strukturen gällande testning. `

`Det var under detta moment som jag också insåg hur svårt det var att testa långa och "komplicerade" metoder. Och jag förstod nu också hur viktigt det är att förhålla sig till tumregeln att en metod endast ska ha en specifik uppgift. Min metod jag först hade skapat för att radera ett rum innehåll mycket kod för att kontrollera att ett rum exempelvis var fritt från konst. När jag skulle försöka testa detta blev det genast väldigt komplicerat då metoden innehöll en hel del input från användaren. Så jag delade upp dessa i mindre metoder där en del står för själva borttagningen av ett rum och en annan kontrollerar så att konst inte får finnas i rummet för att sedan anropa metoden som tar bort rum om det kravet uppfylls. Sen la jag in dessa i en annan metod som jag sen använder i sjävla applikationen med alla input/outputs. Efter att jag hade delat upp koden i mindre metoder så var det möjligt på ett helt annat sätt att skapa ett enhetstest för att kontrollera att rum inte får innehålla konst för att kunna raderas. `

`Slutligen så har jag lärt mig otroligt mycket under arbetet med den här uppgiften, och jag märker hur mycket mer man lär sig genom att testa sig fram på olika sätt och att inte begräna sin tankebana till ett specifikt sätt. Känner mig väldigt nöjd med uppgiften och tycker det ska bli sjukt roligt och spännande att kunna få jobba ännu mer med C# i framtiden.`