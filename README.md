# myTournament
Generieke software om een toernooi te organiseren.

String localisatie
In resourcefiles onder Properties, voor uitleg: https://stackoverflow.com/questions/1142802/how-to-use-localization-in-c-sharp
Generiek opbouwen: per klasse een apart resourcebestand in zowel Engels als Nederlands en 1 bestand voor de generieke zaken
Naamgeving voorbeelden: Generic.resx en Generic.nl.resx.
GEEN strings in de klasses zelf, altijd via resources zodat vertaling mogelijk is.

Plugin systeem: https://code.msdn.microsoft.com/windowsdesktop/Creating-a-simple-plugin-b6174b62
