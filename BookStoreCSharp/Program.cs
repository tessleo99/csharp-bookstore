// See https://aka.ms/new-console-template for more information

//In questo esercizio vogliamo inserire in maniera “hardcoded”
//(ossia scritte nel codice senza dover chiedere all’utente nessun input) tutte le informazioni che troviamo su Amazon di un libro



string title = "L'ombra del vento"; //titolo
string author = "Carlos Ruiz Zafón"; //autore

long ISBNcode = 8804750480; //ISBN
int pageNumber = 420; //numero di pagine

int BookWeight = 290; //peso in grammi

//Dimensioni 13.9 x 2.5 x 21.4 cm

float bookLength = 13.9F; //larghezza
float bookHeighth = 2.5F; //altezza
float bookDepth = 21.4F; //profondita'

int reviewNumber = 5296; //numero di recensioni

float averageRating = 4.5F; //valutazione media


bool kidleVersion = true; //formato kindle dispoanibile
bool flexibleCover = true; //copertina flessibile disponibile

//-------- IL LIBRO DI OGGI: <<titolo>> di <<autore>> ------------
//formazioni generiche:
//BN: << isbn >>
//mero delle pagine: << numeroPagine >> pagine
//so del libro: << pesoLibro >> kg
//mensioni del libro: << larghezza >> cm x << lunghezza >> cm x << profondita >> cm
//formazioni Amazon:
//mero di recensioni: << numeroRecensioni >> recensioni
//lutazione media: << valutazioneMedia >> stelline
//ndle disponibile: Si o No
//pertina flessibile disponibile: Si o No
//-------------------------------------------------------------------------

Console.WriteLine("------- LIBRO DI OGGI:" + title + "di" + author + "-------");
Console.WriteLine("ISBN:" + ISBNcode);
Console.WriteLine("Numero delle pagine:" + pageNumber);
Console.WriteLine("Peso del libro:" + BookWeight + " g");
Console.WriteLine("Dimensioni del libro: " + bookLength + " cm x" + bookHeighth + "cm x" + bookDepth + " cm");

Console.WriteLine("------------------ INFORMAZIONI AMAZON --------------------");
Console.WriteLine("Numero di recensioni:" + reviewNumber + "recensioni");
Console.WriteLine("Valutazione media: " + averageRating + " stelline");
Console.WriteLine("Kindle disponibile: Sì");
Console.WriteLine("Copertina flessibile disponibile: Sì");


Console.WriteLine("-----------------------------------------------------------");