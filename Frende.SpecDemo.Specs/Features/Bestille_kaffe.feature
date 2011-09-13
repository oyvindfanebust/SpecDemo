Egenskap: Bestilling av kaffe
	For å kunne fortsette å levere fantastiske løsninger
	Som en kodeape
	Ønsker jeg å kunne bestille kaffe

Bakgrunn: 
	Gitt at jeg er på ordresiden

Abstrakt Scenario: Bestille en enkelprodukt
	Gitt at jeg har valgt en <produkt>
	Når jeg bestiller
	Så skal prisen være <pris> kr
	
	Eksempler:
		| produkt         | pris |
		| Espresso        | 10   |
		| Dobbel espresso | 20   |
		| Cappucino       | 20   |

Scenario: Bestilling en dobbel espresso og en cappucino skal gi rabatt
	Gitt at jeg har valgt en Dobbel espresso
	Og at jeg har valgt en Cappucino
	Når jeg bestiller
	Så skal prisen være 40 kr