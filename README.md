Samostatná práce – Kreslení geometrických obrazců
Téma: Abstraktní třídy, dědičnost, polymorfismus, konstruktory a práce s kolekcemi.
Cíl práce: Dokážete se orientovat v existujícím projektu, navrhnout jeho rozšíření, provést potřebné úpravy a ověřit jejich správnost. Při práci můžete využívat AI jako programátorského asistenta.
Pokyny 
Obdrželi jste funkční aplikaci pro kreslení geometrických obrazců. Program umožňuje vybrat geometrický obrazec, nastavit tloušťku čáry a barvu výplně. Kliknutím na kreslicí plochu se obrazec vykreslí a jeho údaje se zaznamenají do seznamu.
Vaším úkolem je aplikaci postupně rozšířit. Pracujte stále s jedním projektem. Každá následující úroveň navazuje na předchozí.
Než začnete program upravovat, prostudujte si jeho strukturu a vyzkoušejte funkčnost. Po každé dokončené úrovni program spusťte a ověřte, zda se chová podle zadání.
Práce s AI
Při řešení jednotlivých úrovní můžete využívat umělou inteligenci jako programátorského asistenta.
Doporučený postup:
1.	Nejprve si přečtěte zadání a samostatně promyslete, co bude potřeba v programu změnit.
2.	Pokud si nevíte rady, požádejte AI o první nápovědu (ale zkuste nejdříve samostatně). Nežádejte hned kompletní řešení.
3.	Podle nápovědy zkuste program upravit.
4.	Pokud se vám úprava nepodaří, požádejte AI o konkrétnější nápovědu nebo krátkou ukázku kódu.
5.	Po dokončení úpravy požádejte AI o návrh testovacích případů a ověřte funkčnost programu.
6.	Připravte se vysvětlit, jaké změny jste provedli a proč.
Úvodní prompt pro AI
Jsi můj programátorský asistent pro C# a WPF. Pracuji na projektu Kreslení geometrických obrazců a procvičuji objektově orientované programování.
Budu ti postupně posílat jednotlivá zadání a části svého kódu.
Tvým úkolem je navádět mě k samostatnému řešení:
•	Nejprve mi poskytni pouze stručnou nápovědu.
•	Pokud napíšu „další nápověda“, buď konkrétnější.
•	Neprozrazuj mi celé řešení, pokud o něj výslovně nepožádám.
•	Můžeš mi vysvětlovat jednotlivé příkazy a ukazovat krátké příklady.
•	Pokud ti pošlu svůj kód, pomoz mi najít případné chyby.
•	Používej jednoduchý C# a WPF, bez zbytečně složitých postupů.
•	Po dokončení mi pomoz navrhnout testy správnosti.
Začneme následujícím zadáním:
Vloží zadání konkrétní úrovně A, B, C nebo D.
Úroveň A – Využití konstruktorů
Základní úroveň
Zadání
Upravte aplikaci tak, aby se při vytváření geometrického obrazce jeho souřadnice, tloušťka čáry a barva výplně nastavovaly prostřednictvím konstruktoru.
Po provedení úprav musí aplikace fungovat stejně jako původní verze.
Ověření: Vykreslete všechny dostupné obrazce s různými barvami a tloušťkami čáry. Je jejich chování stejné jako před úpravou?
Úroveň B – Rozšíření nabídky obrazců
Navazuje na A
Zadání
Rozšiřte aplikaci o nový geometrický obrazec – kruh.
Nový obrazec musí být možné vybrat v nabídce a vykreslit na kreslicí plochu stejně jako ostatní obrazce. Umožněte také překrývání obrazců.
Dále upravte seznam vytvořených obrazců tak, aby se u každého zobrazovala také informace o barvě výplně.
Ověření: Vykreslete kruh, změňte barvu výplně a vykreslete další kruh na stejné místo. Zkontrolujte údaje v seznamu.
Úroveň C – Společné rozměry obrazců
Navazuje na B
Zadání
Upravte aplikaci tak, aby rozměry geometrických obrazců nebyly pevně zapsané přímo v metodách pro jejich vykreslování.
Navrhněte společné řešení, které umožní nastavit šířku a výšku vytvořených obrazců. Nové rozměry se musí projevit při jejich vykreslování.
Pro tuto úroveň neměňte grafické rozhraní ani stávající konstruktory. Rozměry nastavujte přímo v programu.
Kruh musí i po změně rozměrů zůstat kruhem.
Ověření: Nastavte rozměry 150 × 100 pixelů. Zkontrolujte změnu všech obrazců. Kruh musí mít při šířce 150 pixelů také výšku 150 pixelů.
Úroveň D – Práce s kolekcí a výpočet obsahu
Pokročilá úroveň – navazuje na C
Zadání
Rozšiřte aplikaci o možnost odstranit libovolný vykreslený obrazec výběrem v seznamu. Po odstranění musí ostatní obrazce zůstat na kreslicí ploše, a to i v případě, že se překrývají.
Dále zajistěte, aby každý geometrický obrazec dokázal vypočítat svůj obsah. Vypočítané hodnoty zobrazujte v seznamu obrazců.
Při návrhu využijte principy objektově orientovaného programování a pokuste se omezit opakování kódu.
Ověření: Vykreslete několik překrývajících se obrazců, odstraňte prostřední a zkontrolujte ostatní. Ověřte také obsah obdélníku 150 × 100 pixelů (15 000 px²) a trojúhelníku stejných rozměrů (7 500 px²).
Odevzdání samostatné práce
Po dokončení práce odevzdejte následující:
1.	Upravený projekt WPF (C#) – kompletní projekt se všemi soubory, zabalený do ZIP archivu.
2.	Přehled splněných úrovní – uveďte, které úrovně (A–D) jste dokončili a stručně popište provedené změny.
3.	Použité prompty a odpovědi AI – pokud jste využili AI, zaznamenejte prompty do textového souboru (otázky a odpovědi) a stručně popište, jaké nápovědy nebo řešení vám AI poskytla. Pokud jste AI nevyužili, uveďte tuto skutečnost.
4.	Zhodnocení práce s AI – vysvětlete, zda vám AI pomohla, případně zda jste museli některé její návrhy opravit nebo odmítnout.
5.	Ověření funkčnosti – uveďte alespoň dva testovací případy, které jste vyzkoušeli, včetně očekávaného a skutečného výsledku.

