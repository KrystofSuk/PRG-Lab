# Cykly, Console

## Postfix Prefix

V C# mame zajimave operatory ++ a -- ktere umoznuji zvysit ci snizit hodnotu o 1. Ty jdou ale aplikovat dvema zpusoby.

### Postfix

Postfixovym zpusob, neboli `x++` ktery zvysi x o jedna, ale **vrati predchozi hodnotu**. Viz ukazka:
```
int x = 0;
int y = x++;
Console.WriteLine(y); // y = 0
Console.WriteLine(x); // x = 1
```
Na toto musime dat pozor, pokud chceme ukladat inkrementovane x do jine promenne!!

### Prefix

Prefixovy zpusob, neboli `++x` ktery zvysi x o jedna a **vrati novou hodnotu**. Viz ukazka:
```
int x = 0;
int y = ++x;
Console.WriteLine(y); // y = 1
Console.WriteLine(x); // x = 1
```
Proto se zamyslete nad tim co provede nasledujici kus kodu:
```
int x = 0;
int y = x++ + ++x;
Console.WriteLine(y); // y = ?
```

-------------------------

## Scoping

Promenna zije jen ve svem bloku a blocich na hlubsi urovni. Nikdy ne nad. Proto pozor kde definujeme promenne. Ukazka na hlubsi urovni.
```
int x = 0;
if(true){
    ConsoleWriteline(x); //x je zde viditelne
}
```
Ale kdyz napriklad vytvorime promennou v podmince, tak v nadrazenem bloku **nebude viditelna** (ona presneji ani nebude deklarovana):

```
if(true){
    int x = 0;
}
ConsoleWriteline(x); //Error x nebylo deklarovano
```


-------------------------

## Cykly

Cast programu ktera se ma nejak opakovat "duh". Je to jeden ze zakladnich stavebnich kamenu programovani ve vetsine jazycich. V C# existuji 3 typy cyklu.

### For

Zakladni cyklus kde specifikujeme hodnotu (nejcastej int) a konecnou podminku + operaci provedenou po kazdem kroku. Cyklus se pote opakuje dokud nebude jeho podminka False.
Struktura foru je nasledujici: `for(promenna; podminka; prikaz)` pote samozdrejme nejaky blok co se ma stat. 
```
for(int i = 0; i < 5; i++){
    5x se neco zopakuje
}
```

Promennou foru muzeme uvnitr bloku **menit / cist** = pozor na nekonecne smycky:

```
for(int i = 0; i < 5; i++){
    Console.WriteLine(i);
}

//Nekonecny for
for(int i = 0; i < 5; i++){
    Console.WriteLine(i);
    i = 1;
}
``` 

### While

Jiny typ cyklu, ktery se opakuje dokud neni podminka False. **Vse ostatni si musime ridit sami, napriklad inkrementaci promenne atp...** Struktura: `while(promenna)` Zde opravdu pozor na **nekonecne cykly**, muzou se velmi snadno stat.

```
bool flag = true;
while(flag){
    ...
    flag = False; //Ukonceni cyklu
}
```
Dale pozor ze i po prepnuti podminky se cyklus **dovykona az do konce jeho bloku**.

```
bool flag = true;
while(flag){
    ...
    flag = False; //Ukonceni cyklu
    Console.WriteLine("I tohle se jeste provede!");
}
```

### Foreach

Tento typ cyklu si zatim podrobne rozebirat nebudeme. Je pro **iteraci skrz kolekce** (pole listy atp...) a jednodusii praci s nimi. Dulezite je jen vedet ze existuje!

### Break a Continue

Obcas se nam muze stat, ze potrebujeme z cyklu odejit drive nez jsme chteli / skipnout nejaky step / podobne. K tomu slouzi `break` a `continue`

#### Break

Zastavi cely cyklus a pokracuje dale. Vhodne napriklad k stopce while cyklu, aby se nam nevykonalo nic dalsiho. 

```
bool flag = true;
while(flag){
    ...
    break;
    Console.WriteLine("Sem nikdy nedojde");
}
```

Pozor na vice vnorenych cyklu!!! Kde break zastavi jen ten kde byl vyvolan.
```
for(int i = 0; i < 5; i++){
    for(int x = 0; x < 5; x++){
        Console.WriteLine(x);
        if(x == 3){
            break; // zastavi jen vnoreny for
        }
    }
    Console.WriteLine("----");
}
```

#### Continue

Slouzi pro nedokonceni soucasneho cyklu (stejne jako break), ale narozdil od nej **pokracuje dale v cyklu** = vlastne takovy skip.

```
for(int i = 0; i < 5; i++){
    for(int x = 0; x < 5; x++){
        if(x == 3){
            continue; // Pri 3 preskoci vypis
        }
        Console.WriteLine(x);
    }
    Console.WriteLine("----");
}
```

### Pozn

Pozor na vnorene cykly, funguje zde **scoping a deklarace promennych = nesmi se napr ve dvou vnorenych forech jmenovat stejne!!!**

Jeste existuje `return` ten ukonci celou metodu (v nasem pripade program)

-------------------------
  
## Console

Uz jiste znate `Console.WriteLine` a `ReadLine`. To ale neni vse co Console nabizi. 

### Barvicky

Muzeme obarvovat text a jeho pozadi pomoci `Console.ForegroundColor` a `Console.BackgroundColor` a jejich nastaveni na specificky enum z nabidky. Napr
```
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Hello");
```
Pokud se budeme chtit zbavit zbarveni staci zavolat `Console.ResetColor()`

### Vypis bez zalomeni

Muzeme vypisovat i bez zaomeni radku pomoci `Console.Write(...)` Pokud by jsme chteli zalomit radek, staci pridat na misto zalomeni '\n'

### Stisk klavesy

Muzeme pockat nez uzivatel stiskne klavesu pomoci `Console.ReadKey()` tuto klavesu si take muzeme nacist a nejak na ni reagovat timto zpusobem:

```
ConsoleKeyInfo klavesa = Console.ReadKey();
if(klavesa.Key == ConsoleKey.Escape)
{
    //Napriklad pro escape
}
```

### Pipnuti 

Muzeme pipnout / vydat zvuk consoli (historicky duvod) `Console.Beep(frekvence, delka)`

### Nastaveni rozmeru console

Muzeme prepnout velikost console podle nasich pozadavku (velikost je v poctu znaku)
```
Console.WindowHeight = 2;
Console.WindowWidth = 20;
Console.WriteLine("Hello"); //Okno 20 x 2
```

### Vymazani

Pokud chceme vymazat consoli tak muzeme pouzit `Console.Clear()` vymaze to ale uplne vse tak pozor na to.

-------------------------

## Projektik na zaver

Pro vyzkouseni si prace s cykly, udelejte jednoduchou console appku. Prijmu cele cislo a pote muzu bud prijmout druhe cele cislo a pote udelat mocninu prvniho na druhe. Nebo prijmu znak '!' pote udelam faktorial prvniho cisla. Toto budu moci opakovat dokud nedostanu 'e' misto druheho cisla. Tudiz i pokud dostanu upozorneni muzu pokracovat!!! **Nepouzivejte Math a kontrolujte validitu vstupu!!!**

### Validita

- Zadana cislo/a musi byt validni, jinak ukoncete program a vypiste upozorneni
- Druhy paramer musi byt bud cislo nebo '!' nic jineho, jinak vypiste upozorneni


### Kontrolni data

```
Vstup: 3 !
Vystup: 6
```
```
Vstup: 2 3
Vystup: 8
```
```
Vstup: 2 e
Vystup: Konec app
```
```
Vstup: 2 f
Vystup: Spatny vstup 
```
```
Vstup: a 
Vystup: Spatny vstup 
```

### Hinty

Podivejte se na minoulou laborku a jeji hinty pokud si nebudete vedet rady<br>
Pozor na desetinne hodnoty v consoli, dle nastaveni windows jsou na vstupu bud s '.' nebo s ','<br>
Druhe cislo / operaci nacitejte do stringu a ten pote parsujte / porovnejte s "!"<br>
Nacist z console muzete pomoci `Console.ReadLine()`<br>
Vypsat do console muzete pomoci `Console.WriteLine(...)`<br>
Pro mocninu a faktorial pouzijte for / while cyklus<br>
Spoustejte program pomoci `ctrl+f5` aby se vam hned nezavrelo okno

Kdyz si nebudete vedet rady kouknete do example reseni :) ale zkuste sami, google taky dost pomuze kdyz si nebudete vedet rady
