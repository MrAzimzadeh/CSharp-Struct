public class Program
{
    private static void Main(string[] args)
    {
        //Struct lari cagirma 

        MyClass nesne =  new();
        nesne.a =55;
        MyStruct myStruct  = new();
        myStruct.x =  20;
        Console.WriteLine(nesne.a);
        Console.WriteLine(myStruct.x);
    }
    /*
        ?  16Bayt liq data lar stack da daha coxu isse Heap de saclanilir 
        ! Eger kecerse StackOwerfloow erroru verir 
        ?  Struct un da esas menqiqi bu du ki icerisin de kicik melumatlar saxlanilmalidi \
        * Struct larin diger esas xususiyyetlerinden biri de Deqiq olmasidir sonradan deyisisilmemelidir 
        * Structlarin defaoult olaraq Classlardaki kimi constructoru yocdur 
        * Claass da OLan Destructorlar Structlarda olmur 
    
    */
    struct MyStruct //! deyer Tipi
    //  RAM ->> Stack
    {
        // 
        public int x;
        //  defaolut deyer vere bilmirik
        // public int a = 5; //! Error  
    }
    class MyClass //? referans Tip
    //  RAM ->> Heap
    {
        public int a = 5;
        public int aa;
        // CONSTRUCTOR 
        public MyClass()
        {

        }
        //todo =>> Destructor  
        ~MyClass()
        {

        }
    }
}