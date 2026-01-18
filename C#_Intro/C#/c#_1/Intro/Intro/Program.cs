


// C# Limbaj OOP (Orientat pe obiecte)

// Structura Minima:
public class Program
{
    // Tipuri de variabile: (Cele mai importante)
    // Na i nevoie sa cunosti capacitatea lor ca tot o sa le uiti finca e nefolositor, poate daca e sa lucrezi la banca
    // O sa iti explic deja in fata doar unele chestii dupa ce o sa te mai dai intai cu informatia de baza

    private int varA = 5;
    private float varB = 89.2345f; // Pentru variabile float se pune "f" la sfarsit ca programul sa stie ca e un numar float
    private string nume = "Numeleee";
    private bool onGround = true; // true sau false doar

    // Functia Main este ce a apelata prima oara, este gasita de porgram dupa numele functia "Main"
    // Ce e important ca metoda Main trebuie sa fie static, care e diferenta intre static si non-static:
    // Static insemna ca exista doar una
    // Non-static insemna ca exista per obiect
    // Foarte important functiile statice lucreaza doar cu alte functii statice sau variabile statice
    // Nu poti interactiona dintro functie statica apeland o functie non-statica in mod direct

    // In unity nu va mai exista functia Main, dar in limbaj curat precum pentru consola, toate limbajele au
    // aceasta functie
    public static void Main()
    {
        // Pentru a scrie un sir de caractere in consola:
        Console.WriteLine("csarp-ele");

        //Apelarea unei functii 
        Calculeaza();
        Loopuri();
        CreemUnObiect();
        AfisamDateleDespreObiect();
    }

    // Din nou creem variabile dar de data asta de tip static-ce
    // Pentru a putea lucra cu ele in mod direct intro functie statica
    private static int a = 20;
    private static float b = -30.214f;

    // Crearea unei functii: (Dupa cum vezi e o functie statica astfel ea poate fi apelata directa)
    private static void Calculeaza()
    {
        //Conditie:
        //Variabila int in comparatie cu variabila float create mai sus de tip statice
        if (a > b)
        {
            Console.WriteLine("A este mai mare ca B: " + a + " > " + b);
        }
        else
        {
            Console.WriteLine("B este mai mare ca A: " + a + " < " + b);
        }
    }

    private static void Loopuri()
    {
        // Aveam loopuri precum: for, while, foreach
        // Cel mai folosit este for si while
        // Lopurile sunt folosite pentru a pargurje un sir de date precum o lista sau un array
        // O sa declaram aici o lista si o sa o initializam fiecare element din lista iar apoi o vom afisa
        // Lista de tip int, deci aceasta lista poate detine doar variabile de tip int
        List<int> list = new List<int>();

        // O vom initializa o cu for
        // Structura unui for e asa, prima "int i = 0" initializam o variabila de obieci cand e primul 
        // se initializaeaza o variabila int cu numele "i", apoi daca mai exista un for in for al doilea for 
        // se delcara cu o variabila cu numele "j", iar daca exista si al treile for in for for, atunci
        // se declara o variabila cu numele "k", e o "lege" ne scrisa dar sa tii cont
        // A doua parte a unei for e conditia, exact ca intrun if
        // Iar a treia parte e incrimetarea adica "i++" ca exemplu
        // 1. Initializarea unei variabile, 2. Conditia, 3. Incrimetarea
        // Daca conditia din for e true, atunci va intra in for, daca nu atunci va iesi
        for (int i = 0; i < 10; i++)
        {
             // Adaugam elementle in lista
             list.Add(i);
        }

        // Acum vom afisa dar deja folosint while
        // Putem sa facem asta si cu for doar ca logicele sunt diferite un pic intre ele
        // si sa vezi cum se face cu for si cum cu while

        // Un while are doar conditia, de aceia in cazul dat vom crea o variabila inafara pe care sa o folosim
        // Vom delcara o variabila cu numele j finca avem declararea unui int cu numele "i" deja mai sus
        int j = 0;
        while (j < list.Count)
        {
            // Aici afisam datele din lista dupa iandexare, ca sa accesam elementul 0 facem asa
            // Scriem numele listei si in parantezele patrate specificam elementul dorit
            // NumeleListei[0]
            Console.WriteLine(list[j]);

            // Aici la fel trebuie de incrementat variabila data pentru a trece la urmatorul element
            j++;
        }
    }

    // Crearea unei clase
    // Clasele reprezinta obiectele
    // O clasa e ca un obiect, iar acest obiect detine anumte date care vrem noi
    // Ca un exemplu avem un joc cu masini, cream clasa masina, iar in clasa data declaram numele, culoarea marimea marca
    // si etc...
    private class Masina
    {
        // Setam variabile pe publice pentru a avea acces la ele dinafara
        // Aici se poate de facut si cu un constructor darr.... data viitoare
        public string marca;
        public float pretul;
        public int km;
    }

    // Vom crea o lista de tipul Masina pentru a putea accesa obiectul creat
    private static List<Masina> masineliMele = new List<Masina>();
    private static void CreemUnObiect()
    {
        // Crearea unui obiect se scrie numele clasei "Masina" numele variabelei "newMasina" ca exemplu,
        // Apoi " = new " si din nou numele clasei "Masina" iar la sfarsit "();"
        Masina newMasina = new Masina();

        // Accesam variabile din obiect si le setam
        // Se face in felul urmator
        // Numele variabelei dorite, apoi se pune "." iar daca variabila e pe publica o sa ai acces la ea
        newMasina.marca = "Elecopter";
        newMasina.pretul = 100000;
        newMasina.km = 600;

        //Apoi adaigam din nou elementul in lista cum am facut la primul exemplu
        masineliMele.Add(newMasina);
    }

    private static void AfisamDateleDespreObiect()
    {
        // Aici vom afisa datele despre obiecte
        // Vom folosit de data asta foreach, cum am zis avem for, while si foreach
        // Un foreach este cu mult mai eficinet pentru accesarea elementelor deja existente intro lista
        // Structura:
        // 1. Tipul variabelei listei noastre pe care dorim sa o parcurgem
        // 2. Numele variabelei
        // 3. "in" si numele listei noastre dorite
        foreach (Masina masina in masineliMele)
        {
            Console.WriteLine("Marca: " + masina.marca);
            Console.WriteLine("Pretul: " + masina.pretul);
            Console.WriteLine("Km: " + masina.km);
        }
    }

    // !!! Task simplu: !!!
    // Creaza un proiect nou
    // Iar in acest proiect sa creezi o class cu numele "Item;
    // Aceasta clasa sa detina cel putin 3 variabile precum, numele, valoarea, raritatea.
    // Creezi 3 obiecte de acest tip si le adaugi intr o lista corespunzatoare
    // Apoi afisezi aceste elemente
    // Logicele le face asa cum le ai inteles tu, cum vrei tu, cum tii comod tie
    // Dupa o sa analizam impreuna 

    // Recomandare...
    // Daca te folosesti de GPT folosesti maxim doar pentru explicatii
    // Daca ii ceri exemple atunci sa nu dai nici o data copy-paste
    // Poti sa il folosesti pentru inspiratie dar scrie cu mana ta
}

