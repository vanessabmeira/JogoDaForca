using System;

namespace projetoFinal
{   
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem Vindo ao Racha Cuca\n\n" +
            "Jogo da Forca\n" +
            "Desafie-se tentando descobrir qual é a palavra oculta antes que esgotem as suas 5 tentativas.\n" +
            "Uma nova palavra, de um tema diferente, é adicionada pelo seu amigono inicio do game.\n\n");
            Console.WriteLine(" ____ ");
            Console.WriteLine("|    |");
            Console.WriteLine("|    O  ");
            Console.WriteLine("|   -|-  ");
            Console.WriteLine("|   / \\  ");
            Console.WriteLine("|  F O R C A     ");
            Console.WriteLine("Digite uma palavra para ser adivinhada.");
            string palavraForca=Console.ReadLine();
            palavraForca = palavraForca.ToLower();
            string[] resultado = new string[palavraForca.Length];

        
            int erros = 0, acertos = 0, verificar = 0;
            Console.Clear(); 

            Console.WriteLine("Digite uma letra para tentar formar a palavra.");
            
            while (erros != 6 && verificar != resultado.Length)
            {
                try
                {
                    char letra = char.Parse(Console.ReadLine());
                    if (!Char.IsLetter(letra))
                    {
                        Console.WriteLine("Favor digitar uma letra válida");
                        continue;

                    }
                    letra = Char.ToLower(letra);
                    int ocorrencias = palavraForca.IndexOf(letra);
                    int chances = 0;
                    if (ocorrencias == -1)
                    {
                        Console.Clear(); 
                        erros++;
                        chances = 6 - erros;
                        Console.WriteLine($"Esta letra NÃO existe na palavra tente novamente! {chances} chances restantes.");
                    }
                    else
                    {
                        Console.Clear(); 
                        chances = 6 - erros;
                        Console.WriteLine($"Você acertou! {chances} chances restantes."); 

                        acertos++;

                        for (int i = 0; i < palavraForca.Length; i++) // percorre a String para encontrar a letra
                        {
                            if (palavraForca[i].ToString() == letra.ToString())
                            {
                                resultado[i] = letra.ToString(); 


                                if (resultado[i] != null && resultado[i] != "_")
                                {
                                    verificar++; 
                                }

                            }
                            else if (resultado[i] is null)
                            {
                                resultado[i] = "_";
                            }

                        }

                    }

                    foreach (string item in resultado)
                    {
                        Console.Write(item);
                    }
                    Console.WriteLine();


                    switch (erros)
                    {
                        case 0:

                            Console.WriteLine(" ____ ");
                            Console.WriteLine("|    |");
                            Console.WriteLine("|     ");
                            Console.WriteLine("|     ");
                            Console.WriteLine("|     ");
                            Console.WriteLine("|     ");


                            break;
                        case 1:

                            Console.WriteLine(" ____ ");
                            Console.WriteLine("|    |");
                            Console.WriteLine("|    O ");
                            Console.WriteLine("|     ");
                            Console.WriteLine("|     ");
                            Console.WriteLine("|     ");


                            break;

                        case 2:
                            Console.WriteLine(" ____ ");
                            Console.WriteLine("|    |");
                            Console.WriteLine("|    O ");
                            Console.WriteLine("|    | ");
                            Console.WriteLine("|       ");
                            Console.WriteLine("|       ");

                            break;
                        case 3:
                            Console.WriteLine(" ____ ");
                            Console.WriteLine("|    |");
                            Console.WriteLine("|    O ");
                            Console.WriteLine("|    |- ");
                            Console.WriteLine("|       ");
                            Console.WriteLine("|       ");
                            break;
                        case 4:
                            Console.WriteLine(" ____ ");
                            Console.WriteLine("|    |");
                            Console.WriteLine("|    O ");
                            Console.WriteLine("|   -|- ");
                            Console.WriteLine("|       ");
                            Console.WriteLine("|       ");
                            break;
                        case 5:
                            Console.WriteLine(" ____ ");
                            Console.WriteLine("|    |");
                            Console.WriteLine("|    O ");
                            Console.WriteLine("|   -|- ");
                            Console.WriteLine("|   / ");
                            Console.WriteLine("|       ");
                            break;
                        case 6:
                            Console.WriteLine(" ____ ");
                            Console.WriteLine("|    |");
                            Console.WriteLine("|    O ");
                            Console.WriteLine("|   -|- ");
                            Console.WriteLine("|   / \\");
                            Console.WriteLine("|       ");
                            break;

                    }

                    if (erros == 6)
                    {
                        Console.WriteLine("VOCE FOI ENFORCADO!!");
                    }
                    else if (verificar == resultado.Length)
                    {
                        Console.WriteLine("PARABÉNS, VOCE GANHOU !!");
                    }
                    else
                    {
                        Console.WriteLine("Erros:{0} e Acertos {1}\n", erros, acertos);
                    }
                }
                catch (FormatException f)
                {
                    Console.WriteLine("Por favor insira apenas uma letra de cada vez");
                }
            }
        }
    }
}


