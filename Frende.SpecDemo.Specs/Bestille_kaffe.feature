Egenskap: Bestilling av kaffe
	For å kunne fortsette å levere fantastiske løsninger
	Som en kodeape
	Ønsker jeg å kunne bestille kaffe

Abstrakt Scenario: Bestille en enkelprodukt
	Gitt at jeg har valgt en <produkt>
	Når jeg bestiller
	Så skal prisen være <pris> kr
	
	Eksempler:
		| produkt         | pris |
		| enkel espresso  | 10   |
		| dobbel espresso | 20   |
		| cappucino       | 20   |

Scenario: Bestilling en dobbel espresso og en cappucino skal gi rabatt
	Gitt at jeg har valgt en dobbel espresso
	Og at jeg har valgt en cappucino
	Når jeg bestiller
	Så skal prisen være 35 kr