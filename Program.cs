using System;

namespace AtividadeAula1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine("--------------- PERSEUS APP -------------------------------");
            Console.WriteLine("");
            Console.WriteLine(" Escolha o que deseja realizar abaixo: ");
            Console.WriteLine(" 1 - Detalhar a data atual ou digitada");
            Console.WriteLine(" 2 - Calcular valor de salario e INSS");
            Console.WriteLine("");
            Console.WriteLine("");
            int opcaoEscolhida = int.Parse(Console.ReadLine());

            switch(opcaoEscolhida)
            {
                case 1:
                
                    DetalharData();
                break;

                case 2:
                
                    CalcularDescontoINSS();
                break;

                default:
                    Console.WriteLine(" Opcao invalida!!!");
                break;
            }

        }
        public static void DetalharData()
        {
            Console.WriteLine("--------------- DETALHES DA DATA --------------------------");
            Console.WriteLine("");
            //mensagem para o usuário digitar uma data
            Console.WriteLine("---- Digite uma data: ");
            
            //armazene em uma variável compativel
            DateTime DataTeste = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("");
            //formatação para imprimir na tela qual o dia da Semana(nome)
            Console.WriteLine(DataTeste.ToString("ddddddd"));

            // qual o nome do mês por extenso
            Console.WriteLine(DataTeste.ToString("MMMM"));

            //Comparar o dia da semana da data
            DayOfWeek DataDia = DataTeste.DayOfWeek;
            
            //se for um domingo, imprimir na tela a hora atual com os minutos (EX: 14:35)
            if(DataDia == DayOfWeek.Sunday)
            {
                var HoraAtual = String.Format("Hora atual: {0:HH:mm}", DateTime.Now);

                Console.WriteLine(HoraAtual);
            }
            Console.WriteLine("");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("");
        }

        public static void CalcularDescontoINSS()
        {
            Console.WriteLine("--------------- CALCULADORA DE SALARIO --------------------");
            Console.WriteLine("");
            Console.WriteLine("----------- Digite seu salario(ex: 1.000,00):");
            float Salario = float.Parse(Console.ReadLine()); Console.WriteLine("");

            if(Salario <= 1212) // Desconto de 7,5% do salario
            {
                float Desconto = (float)(Salario * 0.075);
                float SalarioLiquido = Salario-Desconto;
                Console.WriteLine($" Salario Bruto: R${Salario}");
                Console.WriteLine($" Salario Liquido: R${SalarioLiquido}");
                Console.WriteLine($" Desconto INSS: R${Desconto}");
            }
            else if(1212.01 < Salario && Salario < 2427.35)    // Desconto de 9%
            {
                float Desconto = (float)(Salario * 0.09); 
                float SalarioLiquido = Salario-Desconto;
                Console.WriteLine($" Salario Bruto: R${Salario}");
                Console.WriteLine($" Salario Liquido: R${SalarioLiquido}");
                Console.WriteLine($" Descontado INSS: R${Desconto}");
            }
            else if(2427.36 < Salario && Salario < 3641.03)    // Desconto de 12%
            {
                float Desconto = (float)(Salario * 0.12);
                float SalarioLiquido = Salario-Desconto;
                Console.WriteLine($" Salario Bruto: R${Salario}");
                Console.WriteLine($" Salario Liquido: R${SalarioLiquido}");
                Console.WriteLine($" Descontado INSS: R${Desconto}");
            }
            else                                    // Desconto de 14%
            {
                float Desconto = (float)(Salario * 0.14);
                float SalarioLiquido = Salario-Desconto;
                Console.WriteLine($" Salario Bruto: R${Salario}");
                Console.WriteLine($" Salario Liquido: R${SalarioLiquido}");
                Console.WriteLine($" Descontado INSS: R${Desconto}");
            }
            Console.WriteLine("");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("");
        

        }
    }
}