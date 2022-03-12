// See https://aka.ms/new-console-template for more information
class Program
{
    static void Main(string[] args)
    {
        KodeBuah table_Kodebuah = new KodeBuah();
        Console.WriteLine("========= MEMANGGIL KODE BUAH =========");
        Console.WriteLine("Masukan Kode BUAH: ");
        string buah = Console.ReadLine();
        Console.WriteLine("========= OUTPUT ========= ");
        table_Kodebuah.getKodeBuah(buah);
        Console.WriteLine("==== JAWABAN NO 3 C ====");
        table_Kodebuah.getAllKodeBuah();
        PosisiKarakterGame tombol = new PosisiKarakterGame();
        tombol.button();
    }

}
class KodeBuah
{
    Dictionary<string, string > dic = new Dictionary<string, string>()
    {
            {"Apel", "A00"},
            {"Aprikot" ,"B00"},
            {"Aplukat","C00"},
            {"Pisang","D00"},
            {"Paprika","E00"},
            {"Blackberry","F00"},
            {"Ceri","H0"},
            {"Kelapa","I00"},
            {"Jagung","J00"},
            {"Kurma","K00"},
            {"Durian","L00"},
            {"Anggur","M00"},
            {"Melon","N00"},
            {"Semangka","O00"}
    };

    public void getKodeBuah(string fruit)
    {
        if (dic.ContainsKey(fruit))
        {
            Console.WriteLine(fruit + " : " + dic[fruit]);
        }
        else
        {
            Console.WriteLine("Buah " + fruit + " Not Found");
        }
    }

    public void getAllKodeBuah()
    {
        foreach (KeyValuePair<string, string> codeB in dic)
        {
            Console.WriteLine("{0:20} \t\t\t {1:20}", codeB.Key, codeB.Value);
        }
    }
  
}

class PosisiKarakterGame
{
    enum State { Terbang, Jongkok, Berdiri };
    public void button()
    {
        State state = State.Terbang;

        String[] screenName = { "Terbang", "Jongkok", "Berdiri" };
        do
        {
            Console.WriteLine("\nPOSISI " + screenName[(int)state]);
            Console.WriteLine("Kode No 1 : (dari posisi Terbang) TombolX -> Jongkok\nKode No 1 Alternatif: (dari posisi Terbang) TombolS ->  Berdiri, TombolS -> Jongkok \n\nKode No 2 : (dari posisi Jongkok) TombolW -> Berdiri, TombolW -> Terbang -> ENDprogram  \nKode No 2 Alternatif: (dari posisi Terbang) TombolS -> Berdiri, TombolW -> Terbang -> ENDprogram");
            Console.Write("Masukan Kode : ");
            String command = Console.ReadLine();
            switch (state)
            {
                case State.Terbang:
                    if (command == "TombolX")
                    {
                        Console.WriteLine("====== OUTPUT ======");
                        state = State.Jongkok;
                        Console.WriteLine("posisi landing");
                    }
                    else if (command == "TombolS")
                    {
                        Console.WriteLine("====== OUTPUT ======");
                        state = State.Berdiri;

                    }
                break;
                case State.Jongkok:
                    if (command == "TombolW")
                    {
                        Console.WriteLine("====== OUTPUT ======");
                        state = State.Berdiri;
                        
                    }
                break;
                case State.Berdiri:
                    if (command == "TombolW")
                    {
                        Console.WriteLine("====== OUTPUT ======");
                        state = State.Terbang;
                        Console.WriteLine("posisi take off");
                    }
                    if (command == "TombolS")
                    {
                        Console.WriteLine("====== OUTPUT ======");
                        state = State.Jongkok;
                        
                    }
                    break;
            }
        } while (state != State.Terbang);
    }
}

