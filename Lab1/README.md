# What is c#, promenne a podminky

## C#

Striktne typovy obektovy jazyk od Microsoftu. Velmi univerzalni, da se v nem napsat od webovek po hry a jine aplikace. Je soucasti platformy .NET, stejne jako F#, J#, Boo atp... Jedna se o jeden z vyssich programovacich jazyku napriklad oproti c++. Take je jeden z modernejsich jazyku s modernejsi syntaxi a vychytavkami co jine jazyky nemaji (obcas jsou i na skodu)

Kdyz nebudete vedet: https://docs.microsoft.com/cs-cz/dotnet/csharp/tour-of-csharp/

### Postup kompilace C#

![Compilation](https://www.c-sharpcorner.com/UploadFile/8911c4/code-execution-process/Images/Code-Execution-Process.jpg)

## Promenne

**C# striktne typovy jazyk = kazda vec musi mit nejaky typ!** Napriklad musime vzdy uvest jestli se jedna o hrusku, nebo meloun. Nektere jine jazyky toto nepotrebuji a nejsou striktne typove (JS "v ramci mezi").

### Datovy typ

Datovych typu v C# je spousta. Mezi zakladni, ktere by si mel kazdy pamatovat patri:

Ciselne

- int: cele cislo od -2 147 483 648 až 2 147 483 647, napr: **42**
- float: desetinne cislo s presnosti ~6-9 cislic, napr: **6.66f**
- double: desetinne cislo s presnosti ~15-17 cislic, napr: **1.11d nebo 11.11**
- dale pak treba long, uint, byte, short, ulong, sbyte atp...

Jine

- bool: ano, nebo ne, napr: **true / false**
- char: znak abecedy, napr: **'g'**
- string: pole charu neboli vice charu = text, napr: **"Ahoj svete"**

Pote jeste mnoho a mnoho dalsich datovych typu, kterymi se ted nebudeme zabyvat. Rozhodne by jste ale meli mit prehled o int, float, bool, char a string. To je nezbytny zaklad.

-------------------------

### Promenna

Promenna je nejaka nejaka nase hodnota v programu, vzdy pokud ji chceme pouzit tak ji musime **DEKLAROVAT PROMENNOU**

`TYP JMENO;` napriklad `int cisloA;`

V tuto chvili ale jeste nase promenna nema zadnou hodnotu (toto neni uplne pravda ale o tom pomlcime). Proto ji jeste muzeme dat nejakou hodnotu, neboli **INICIALIZOVAT PROMENNOU**

`JMENO = HODNOTA;` napriklad `cisloA = 5;`

Pokud uz ma nase promenna nejakou hodnotu napr. 5 tak ji muzeme zmenit / modifikovat

`JMENO = NOVAHODNOTA;` napriklad `cisloA = 10;`

**!!!!POZOR NEMUZEME INICIALIZOVAT / MODIFIKOVAT PROMENNE, KTERE NEBYLI DEKLAROVANY!!!!**

#### Zkraceni deklarace a inicalizace

Jelikoz chceme co nejvice zkratit a zprehlednit kod tak muzeme deklaraci a inicializaci provest na jednom radku stylem

`TYP JMENO = HODNOTA;` napriklad `int cisloB = 5;`

#### Pozn

Jmena promennych musi zacinat jednim z pismen abecedy (ne cislo) a pote mohou obsahovat jen pismena abecedy, cisla a _

Dve promenne se nemohou jmenovat stejne, jak byjste pak rozlisili misku s hruskama a misku s nudlema, pokud by se obe jmenovali miska = jmeno musi byt vzdy unikatni.

Vzdy musite davat spravnou hodotu do spravneho typu, jinak vam to nepujde zkompilovat. Vcetne napr uvozovek u charu (pozor na '' vs "")!!!

-------------------------
  
## Konverze mezi basic typy

Muze se nam stat, ze potrebujeme prevest hodnotu z jednoho typu na druhy. To se da rozdelit na 3 pripady.

### Datovy typ na string

Pro tuto konverzi muzeme vyuzit metodu *.ToString()* u zakladnich datovych typu. Takze muzeme napriklad udelat toto, aby jsme prevedli int do stringu

```
int mojeCislo = 10;
string mojeCisloText = mojeCislo.ToString();
```

### String na datovy typ

Zde uz je to o neco slozitejsi, jelikoz string je pole (o nich az pozdeji) a je textove, tak jej musime tzv. **parsovat** k tomu pouzijeme prikaz **TryParse**

`VYSTUPNITYP.TryParse(VSTUPNIPROMENNA, out VYSTUPNIPROMENNA);` 

napriklad

```
string mojeCisloText = "20";
int mojeCislo;
int.TryParse(mojeCisloText, out mojeCislo);
```

### Datovy typ na datovy typ

Pro tento typ muzeme pouzit univerzalni **Convert**, pozor na ztratu presnosti napriklad u prevadeni float na int atp... Convert se da vyuzit i na prevod do stringu, ale **oproti TryParse nekonroluje validitu!!!!!** 

```
float desetinneCislo = 3.3f;
int mojeCislo = Convert.ToInt32(desetinneCislo);
```

#### Chyba pri convertu stringu co neni validni!

```
string mojeCisloText = "asd20";
int mojeCislo;
int.TryParse(mojeCisloText, out mojeCislo); //projde
int mojeCislo2 = Convert.ToInt32(mojeCisloText); //chyba
```

-------------------------

## Podminky

Pro ucely nasich programu nam jen ciste promenne nestaci. Potrebujeme i nejake podminky kdy se neco ma odehrat, popripade kdy ne. K tomu slouzi **if**, **else** a **switch** 

### If

If je zakladni podmikovy blok v C#, jeho format

```
if(podminka){
    co se ma stat
}
```

Podminka se vyhodnocuje, jako true / false, pokud je true tak probehne blok. Pokud ne tak pokracuje dal. 

#### Podminka

V podmince muzeme davat ruzne operace, ktere vraci true / false jako 

- x == y, kdyz jsou stejne tak true
- x < y, pokud x mensi nez y
- x <= y, pokud x mensi nebo rovno y
- x > y, pokud x vetsi nez y
- x >= y, pokud x vetsi nebo rovno y **POZOR ZE TO NENI x => y**

Dale muzeme pouzit znak negace pro otoceni true a false '!' napr **!true vrati false**

- x != y, x nerovna se y

Muzeme vyuzit zavorek pro uprednostneni vyhodnocovani podminky

- !(neco == y), x nerovna se y stejne jako v predchozim pripade

V posledni rade muzeme vyuzit znaku nebo '||' a zaroven '&&'

- (x == y) && (x == z), pokud x je rovno y a zaroven z
- (x != y) || (x != z), pokud x neni rovno y nebo x neni rovno z

Z techto ingredienci jsme schopni poskladat velmi slozite podminky napriklad, tato podminka bude true

```
string mujText = "text";
int mojeCislo = 3;
if (mujText == "text" && (mojeCislo != 2 || mojeCislo != 4))
{
    neco
}
```

### Else

Za **if** muzeme jeste dat prikaz else, neboli pokud neprosel if udelej else

```
if(false){
}
else{
    neco
}
```

### Else if

Muze se stat, ze potrebujeme vic podminek po sobe, k tomu slouzi else if, kde retezime podminene bloky za sebe a kontroluji se odshora dolu

```
if(podm1){
}
else if(podm2){
}
```

nebo napr.

```
if(podm1){
}
else if(podm2){
}
...
else if(podm10){
}
else{

}
```

-------------------------

## Projektik na zaver

Pro vyzkouseni si prace s promennymi a podminkami, udelejte jednoduchou console kalkulacku, ktera prijme dve cisla, ktera mohou byt desetinna a pak znak operace, pote provede operaci. **Kontrolujte validitu vstupu!!!**

### Validita

- Zadana cisla musi byt validni, jinak ukoncete program a vypiste upozorneni
- Znak operace musi byt validni, pokud ne ukoncete program a vyhodte hlasku
- Pozor na deleni ;) necim se delit neda, pote taky vyhodte chybovou hlasku, ale jen pokud bych tim delil!!!

### Operace 

- '*' = a * b
- '+' = a + b
- '-' = a - b
- '/' = a / b
- '^' = a na b (mocnina)

### Kontrolni data

```
Vstup: 3 3 *
Vystup: 9 
```
```
Vstup: -3,88 40 +
Vystup: 36.22
```
```
Vstup: 6 1,5 /
Vystup: 4 
```
```
Vstup: -3 -3,6 -
Vystup: 0.6 
```
```
Vstup: 2 3 ^
Vystup: 8
```
```
Vstup: a
Vystup: Spatny vstup 
```
```
Vstup: 3 t
Vystup: Spatny vstup 
```
```
Vstup: 4 3 h
Vystup: Spatna operace 
```

### Hinty

`TryParse()` vraci hodnotu bool, pokud byl validni vstup, muzete udelat napr `bool valid = TryParse(...);`<br>
Pozor na desetinne hodnoty v consoli, dle nastaveni windows jsou na vstupu bud s '.' nebo s ','<br>
Nacist z console muzete pomoci `Console.ReadLine()`<br>
Vypsat do console muzete pomoci `Console.WriteLine(...)`<br>
Pro mocninu pouzijte `Math.Pow(...)`<br>
`retrun;` muzete v nasem pripade ukoncit program<br>
Spoustejte program pomoci `ctrl+f5` aby se vam hned nezavrelo okno

Kdyz si nebudete vedet rady kouknete do example reseni :) ale zkuste sami, google taky dost pomuze kdyz si nebudete vedet rady
