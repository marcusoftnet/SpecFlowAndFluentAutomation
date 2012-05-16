Egenskap: Demonstrationer
	För att kunna visa hur man skulle kunna bygga automatisering av websidor
	Som en utvecklare
	Vill jag ha några scenarion som jag kan dema med

Scenario: Öppna första sidan
	Givet att jag är på hemsidan
	Så ska det finnas en länk för att skapa nytt lag där

Scenario: Skapa ett nytt lag
	Givet att det inte finns några lag i databasen
	När jag skapar ett nytt lag med namn 'Marcus United'
	Så ska 'Marcus United' listas bland lagen på hemsidan

Scenariomall: Skapa många nya lag
	Givet att det inte finns några lag i databasen
	När jag skapar ett nytt lag med namn '<lagnamn>'
	Så ska '<lagnamn>' listas bland lagen på hemsidan

Exempel: 
	| lagnamn           | 
	| Marcus United     |
	| Emma Rockers      |
	| Twins from heaven |

Scenario: Ta bort ett lag
	Givet att laget 'Marcus united' finns i databasen
	När jag tar bort 'Marcus united'
	Så ska inte 'Marcus united' listas bland lagen på hemsidan