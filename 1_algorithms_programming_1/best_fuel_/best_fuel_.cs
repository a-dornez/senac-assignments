using System;
namespace BEST_FUEL_ {
    class Program {
        static void Main(string[] args){
           float gasolinePrice, ethanolPrice, ratio, bestDealIndicator = 0.7f; string repeat = "s"; 
                  
           while (repeat == "s" || repeat == "S") {

            Console.WriteLine("Insira o preço da Gasolina: ");
            gasolinePrice = float.Parse(Console.ReadLine());
            Console.WriteLine("Insira o preço do Álcool");
            ethanolPrice = float.Parse(Console.ReadLine());

            ratio = ethanolPrice / gasolinePrice;
            Console.WriteLine("Relação entre preços: {0}", ratio);

            if(ratio > bestDealIndicator){
                Console.WriteLine("Gasolina possui o melhor custo benefício.");
            } else if(ratio < bestDealIndicator){
                    Console.WriteLine("Álcool possui o melhor custo benefício.");
                } else if (ratio == bestDealIndicator) {
                        Console.WriteLine("O custo benefício é igual. Escolha qualquer um."); 
                        }
            Console.WriteLine("Deseja realizar outra comparação? 's' para sim, 'n' para não.");
            repeat = Console.ReadLine();        
           }             
        }
    }
}