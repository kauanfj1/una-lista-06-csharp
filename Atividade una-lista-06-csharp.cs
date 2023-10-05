using System;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o seu nome:");
            string nome = Console.ReadLine();

            Console.WriteLine("Informe a sua idade:");
            int idade = int.Parse(Console.ReadLine());

            string cartaoVacina = "";
            int tentativasCartaoVacina = 0;
            while (cartaoVacina != "SIM" && cartaoVacina != "NAO")
            {
                if (tentativasCartaoVacina == 3)
                {
                    Console.WriteLine("Não foi possível realizar o diagnóstico. Gentileza procurar ajuda médica caso apareça algum sintoma.");
                    Console.ReadKey();
                    return;
                }

                if (tentativasCartaoVacina > 0)
                    Console.WriteLine("Resposta inválida. Por favor, informe SIM ou NAO.");

                Console.WriteLine("Seu cartão de vacina está em dia? (SIM/NAO)");
                cartaoVacina = Console.ReadLine().ToUpper();
                tentativasCartaoVacina++;
            }

            string sintomas = "";
            int tentativasSintomas = 0;
            while (sintomas != "SIM" && sintomas != "NAO")
            {
                if (tentativasSintomas == 3)
                {
                    Console.WriteLine("Não foi possível realizar o diagnóstico. Gentileza procurar ajuda médica caso apareça algum sintoma.");
                    Console.ReadKey();
                    return;
                }

                if (tentativasSintomas > 0)
                    Console.WriteLine("Resposta inválida. Por favor, informe SIM ou NAO.");

                Console.WriteLine("Teve algum dos sintomas recentemente? (dor de cabeça, febre, náusea, dor articular, gripe) (SIM/NAO)");
                sintomas = Console.ReadLine().ToUpper();
                tentativasSintomas++;
            }

            string contatoSintomas = "";
            int tentativasContatoSintomas = 0;
            while (contatoSintomas != "SIM" && contatoSintomas != "NAO")
            {
                if (tentativasContatoSintomas == 3)
                {
                    Console.WriteLine("Não foi possível realizar o diagnóstico. Gentileza procurar ajuda médica caso apareça algum sintoma.");
                    Console.ReadKey();
                    return;
                }

                if (tentativasContatoSintomas > 0)
                    Console.WriteLine("Resposta inválida. Por favor, informe SIM ou NAO.");

                Console.WriteLine("Teve contato com pessoas com sintomas gripais nos últimos dias? (SIM/NAO)");
                contatoSintomas = Console.ReadLine().ToUpper();
                tentativasContatoSintomas++;
            }

            string viagemExterior = "";
            int tentativasViagemExterior = 0;
            while (viagemExterior != "SIM" && viagemExterior != "NAO")
            {
                if (tentativasViagemExterior == 3)
                {
                    Console.WriteLine("Não foi possível realizar o diagnóstico. Gentileza procurar ajuda médica caso apareça algum sintoma.");
                    Console.ReadKey();
                    return;
                }

                if (tentativasViagemExterior > 0)
                    Console.WriteLine("Resposta inválida. Por favor, informe SIM ou NAO.");

                Console.WriteLine("Está retornando de viagem realizada no exterior? (SIM/NAO)");
                viagemExterior = Console.ReadLine().ToUpper();
                tentativasViagemExterior++;
            }

            int porcentagemRisco = 0;

            if (cartaoVacina == "NAO")
                porcentagemRisco += 10;

            if (sintomas == "SIM")
                porcentagemRisco += 30;

            if (contatoSintomas == "SIM")
                porcentagemRisco += 30;

            if (viagemExterior == "SIM")
                porcentagemRisco += 30;

            if (porcentagemRisco <= 30)
                Console.WriteLine("Paciente sob observação. Caso apareça algum sintoma, gentileza buscar assistência médica.");
            else if (porcentagemRisco <= 60)
                Console.WriteLine("Paciente com risco de estar infectado. Gentileza aguardar em lockdown por 02 dias para ser acompanhado.");
            else if (porcentagemRisco <= 89)
                Console.WriteLine("Paciente com alto risco de estar infectado. Gentileza aguardar em lockdown por 05 dias para ser acompanhado.");
            else
                Console.WriteLine("Paciente crítico! Gentileza aguardar em lockdown por 10 dias para ser acompanhado.");

            if (viagemExterior == "SIM")
                Console.WriteLine("Você ficará sob observação por 05 dias.");

          
           
          Console.WriteLine("\n\nNOME: "+nome);
          Console.WriteLine("IDADE: "+idade);
          Console.WriteLine("se teve contato com pessoas infectadas: "+cartaoVacina);
          Console.WriteLine("Se teve sintomas recentemente: "+sintomas);
          Console.WriteLine("se a pessoa está retornando de viagem: "+viagemExterior);
          Console.WriteLine("A probabilidade dessa pessoa estar infectada: " + porcentagemRisco + "%");
		  Console.ReadKey();
        }
        
         
            
    }
