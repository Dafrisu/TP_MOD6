// See https://aka.ms/new-console-template for more information

using tpmodul6_1302223156;

class Program() {
    static void Main(String[] args) { 
        SayaTubeVideo a = new SayaTubeVideo("Tutorial Design By Contract-{DAFA_RAIMI_SUANDI}");
        for (int i=0;i<=1000;i++){
            a.increasePlayCount(9999999);
 
        }
        a.PrintVideoDetails();
    }
}
