#include <cstdlib>
#include <iostream>
#include <ctime>
#include <conio.h>

using namespace std;

/*ŒMIETNIK
               cout << tab[0] << tab[52] << endl;};                            // sprawdzenie wyzerowanej tablicy (mozna wykasowac)
    cout << "wylosowany nr " << losowanie() << endl;                            // pokazanie nr karty USUN¥Æ!
*/

int menu() // MENU
{
    cout << "GRA W OCZKO" << endl;
    cout << endl;
    if ( kbhit()!= 1 ){system("PAUSE");system("cls");};
    };
    
void stat_tur(int licz_t, int g0, int g1) // GENEROWANIE STATYSTYKI TUR
{   
    cout << "NUMER TURY : " << licz_t << "               ";
    cout << "WYNIK:   ";
    cout << "Gracz A - " << g0 << "   ";
    cout << "Gracz B - " << g1 << endl << endl;
};

void stat_akt(int r0, int r1) // GENEROWANIE STATYSTYKI AKTUALNEJ TURY
{
     cout << "     Suma punktów za karty Gracza A: " << r0 << " / 22 punktow." << endl;
     cout << "     Suma punktów za karty Gracza B: " << r1 << " / 22 punktow" << endl << endl << endl << endl;
};

int czy_nastepna_tura() // CZY NASTÊPNA TURA?
{
     int nxt_t=0; // prze³¹cznik czy rozpocz¹æ nastêpn¹ ture
     cout << "Czy chcesz rozpocz¹æ nastepna ture? Wpisz 0 i zatwierdz jesli tak." << endl;
     cin >> nxt_t;
     return nxt_t;
};

void przelaczenie_gracza(int gracz) // INFORMACJA JAKI GRACZ
{    
     if ( gracz==1 )
     {cout << "Gracz A";}
     else{cout << "Gracz B";}; cout << endl;
};

int losowanie() // FUNKCJA LOSUJ¥CA
{
    srand( time( 0 ) );
    return( rand() % 51 );
};


// FUNKCJA MÓWI¥CA JAKA JEST WYLOSOWANA KARTA I ILE ZA NI¥ MA SIE PUNKTOW


// FUNKCJA PRZYPISUJ¥CA SUME WARTOSCI KART GRACZOWI
// FUNKCJA SPRAWDZAJ¥CA - CZY JEST 21, KTO MA WIECEJ, CZY JEST PERSKIE OCZKO
// FUNKCJA STOP (INICJUJ¥CA PRZE£ACZENIE GRACZA) - 2xSTOP - SPRAWDZENIE WYNIKU TURY


//=========================================
//=========================================
//=========================================
int main(int argc, char *argv[])
{
    // MIEJSCE NA ZMIENNE
    int a=0; // do petli czyszczacej tablice
    int t=0;
    int dr=2; // Ile razy ma losowaæ
    int tab[52]; // tablica zajetych kart (zerowana po kazdej turze)
    int licz_t=0; // licznik tury
    int gracz=2; // prze³¹cznik gracza
    int g0=0; // punkty gracza 1
    int g1=0; // punkty gracza 2
    int r=0; // wartosc punktowa wylosowanej karty
    int r0=0; // suma wartosci kart gracza 1
    int r1=0; // suma wartosci kart gracza 2
    int w0=0; // znacznik wygranej gracza 1
    int w1=0; // znacznik wygranej gracza 2
    int dalej=0;
    int stop=0;
    //-------------------------------------------------
    
    menu();                                                                     // MENU
    // TU BEDZIE SIE ZACZYNA£A PÊTLA GRY
    do{
    licz_t++;                                                                   // TURA +1
    r0=0; r1=0; a=0; dr=2;                                                      // ZEROWANIE PUNKTÓW ZA KARTY
    for (a; a<=52; a++){tab[a] = 0;}                                            // czyszczenie tablicy zajetych kart (uk³adanie kart)
    do{system("cls");                                                           // TU ZACZYNA SIÊ PÊTLA TURY
    if( gracz==1 ){gracz=2;} else {gracz=1;};                                   // PRZE£¥CZA GRACZA
    przelaczenie_gracza(gracz);                                                 // INFORMUJE ¯E PRZE£¥CZA GRACZA
    stop=0;
    while ( stop==0 ) {
    system("cls");
    stat_tur(licz_t, g0, g1);                                                   // GENEROWANIE STATYSTYKI TUR
    stat_akt(r0, r1);                                                           // GENEROWANIE STATYSTYKI AKTUALNEJ TURY
    przelaczenie_gracza(gracz);                                                 // INFORMUJE ¯E PRZE£¥CZA GRACZA
    cout << "Trwa tasowanie..." << endl;
    do{
    losowanie();} while ( tab[losowanie()] != 0 );                              // losuje dopóki bedzie nie zajêta karta (tasowanie)
    system("cls");
    stat_tur(licz_t, g0, g1);                                                   // GENEROWANIE STATYSTYKI TUR
    stat_akt(r0, r1);                                                           // GENEROWANIE STATYSTYKI AKTUALNEJ TURY
    przelaczenie_gracza(gracz);                                                 // INFORMUJE ¯E PRZE£¥CZA GRACZA
    tab[losowanie()] = 1;                                                       // zajmuje karte (wyjmuje z talii)
    cout << "       trafil na:       ";
    switch( losowanie() )
         {
         case 0: cout << "2-ka trefl    +2 punkty"<<endl; r=2; break;
         case 1: cout << "2-ka karo    +2 punkty"<<endl; r=2; break;
         case 2: cout << "2-ka kier    +2 punkty"<<endl; r=2; break;
         case 3: cout << "2-ka pik    +2 punkty"<<endl; r=2; break;
         case 4: cout << "3-ka trefl    +3 punkty"<<endl; r=3; break;
         case 5: cout << "3-ka karo    +3 punkty"<<endl; r=3; break;
         case 6: cout << "3-ka kier    +3 punkty"<<endl; r=3; break;
         case 7: cout << "3-ka pik    +3 punkty"<<endl; r=3; break;
         case 8: cout << "4-ka trefl    +4 punkty"<<endl; r=4; break;
         case 9: cout << "4-ka karo    +4 punkty"<<endl; r=4; break;
         case 10: cout << "4-ka kier    +4 punkty"<<endl; r=4; break;
         case 11: cout << "4-ka pik    +4 punkty"<<endl; r=4; break;
         case 12: cout << "5-ka trefl    +5 punkty"<<endl; r=5; break;
         case 13: cout << "5-ka karo    +5 punkty"<<endl; r=5; break;
         case 14: cout << "5-ka kier    +5 punkty"<<endl; r=5; break;
         case 15: cout << "5-ka pik    +5 punkty"<<endl; r=5; break;
         case 16: cout << "6-ka trefl    +6 punkty"<<endl; r=6; break;
         case 17: cout << "6-ka karo    +6 punkty"<<endl; r=6; break;
         case 18: cout << "6-ka kier    +6 punkty"<<endl; r=6; break;
         case 19: cout << "6-ka pik    +6 punkty"<<endl; r=6; break;
         case 20: cout << "7-ka trefl    +7 punkty"<<endl; r=7; break;
         case 21: cout << "7-ka karo    +7 punkty"<<endl; r=7; break;
         case 22: cout << "7-ka kier    +7 punkty"<<endl; r=7; break;
         case 23: cout << "7-ka pik    +7 punkty"<<endl; r=7; break;
         case 24: cout << "8-ka trefl    +8 punkty"<<endl; r=8; break;
         case 25: cout << "8-ka karo    +8 punkty"<<endl; r=8; break;
         case 26: cout << "8-ka kier    +8 punkty"<<endl; r=8; break;
         case 27: cout << "8-ka pik    +8 punkty"<<endl; r=8; break;
         case 28: cout << "9-ka trefl    +9 punkty"<<endl; r=9; break;
         case 29: cout << "9-ka karo    +9 punkty"<<endl; r=9; break;
         case 30: cout << "9-ka kier    +9 punkty"<<endl; r=9; break;
         case 31: cout << "9-ka pik    +9 punkty"<<endl; r=9; break;
         case 32: cout << "10-ka trefl    +10 punktow"<<endl; r=10; break;
         case 33: cout << "10-ka karo    +10 punktow"<<endl; r=10; break;
         case 34: cout << "10-ka kier    +10 punktow"<<endl; r=10; break;
         case 35: cout << "10-ka pik    +10 punktow"<<endl; r=10; break;
         case 36: cout << "Walet trefl    +2 punkty"<<endl; r=2; break;
         case 37: cout << "Walet karo    +2 punkty"<<endl; r=2; break;
         case 38: cout << "Walet kier    +2 punkty"<<endl; r=2; break;
         case 39: cout << "Walet pik    +2 punkty"<<endl; r=2; break;
         case 40: cout << "Dama trefl    +3 punkty"<<endl; r=3; break;
         case 41: cout << "Dama karo    +3 punkty"<<endl; r=3; break;
         case 42: cout << "Dama kier    +3 punkty"<<endl; r=3; break;
         case 43: cout << "Dama pik    +3 punkty"<<endl; r=3; break;
         case 44: cout << "Krol trefl    +4 punkty"<<endl; r=4; break;
         case 45: cout << "Krol karo    +4 punkty"<<endl; r=4; break;
         case 46: cout << "Krol kier    +4 punkty"<<endl; r=4; break;
         case 47: cout << "Krol pik    +4 punkty"<<endl; r=4; break;
         case 48: cout << "As trefl    +11 punktow"<<endl; r=11; break;
         case 49: cout << "As karo    +11 punktow"<<endl; r=11; break;
         case 50: cout << "As kier    +11 punktow"<<endl; r=11; break;
         case 51: cout << "As pik    +11 punktow"<<endl; r=11; break;
         default: cout << "NIE MA TAKIEJ KARTY"<<endl; r=0; break;
         };
         cout << endl << endl;
         if ( gracz==1 ) {r0=r0+r;};
         if ( gracz==2 ) {r1=r1+r;};
         if (r0==22){w0=1; stop=1;}; 
         if (r1==22){w1=1; stop=1;};
         if (r0>=23){w1=1; stop=1;}; 
         if (r1>=23){w0=1; stop=1;};
         
// jezeli dr bedzie = 2, to dalej bedzie = 0, oraz obnizy dr o 1, a jezeli dr bedzie rowne 1 to wykona ifa z dalej
    
    cout << "Czy STOP? Jesli tak wpisz 1 i zatwierdz."; cin >> dalej; cout << endl;
    if ( dalej==1 ) {stop=1;};
    };
    } while ( w0==0 && w1==0 );
    
    if ( w0==1 || w1==1 ) {
    cout << "Ture wygral Gracz ";
    if ( w0>w1 ) {cout << "A"; g0++;} 
    else{ 
    if ( w1>w0 ) {cout << "B";} g1++;}           
    };
    w0=0; w1=0;                                                                 // ZEROWANIE WARTOSCI ZWYCIESTWA
    cout << endl; system("PAUSE");
    
    system("cls");
    stat_tur(licz_t, g0, g1);                                                   // GENEROWANIE STATYSTYKI TUR
    stat_akt(r0, r1);                                                           // GENEROWANIE STATYSTYKI AKTUALNEJ TURY     
    przelaczenie_gracza(gracz);                                                 // INFORMUJE ¯E PRZE£¥CZA GRACZA

    if (czy_nastepna_tura()!=0) {break;}                                        // JEŒLI NIE BÊDZIE 0, TO WYJD                                          
    else {system("cls");};                                                      // A JEŒLI BÊDZIE 0 TO CZYSZCZENIE EKRANU

    } // koniec while'a gry
    while (czy_nastepna_tura != 0);


    
    //-------------------------------------------------
    // zrobic funkcje a w niej druga tablice która, bedzie mówi³a jaka jest karta
    // zrobic funkcje a w niej bedzie mechanizm przypisywania wartosci kart
    
    
    system("PAUSE");
    return EXIT_SUCCESS;
}
