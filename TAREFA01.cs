using System;
using System.Collections.Generic;

class Program
{
    // Estruturas de dados globais
    static int[] vetor = new int[10];
    static int qtdVetor = 0;

    static int[,] matriz = new int[3, 3];
    static int qtdMatriz = 0;

    static List<int> lista = new List<int>();
    static Queue<int> fila = new Queue<int>();
    static Stack<int> pilha = new Stack<int>();

    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("==== MENU PRINCIPAL ====");
            Console.WriteLine("1. Vetores");
            Console.WriteLine("2. Matrizes");
            Console.WriteLine("3. Trabalhar com Lista");
            Console.WriteLine("4. Trabalhar com Fila");
            Console.WriteLine("5. Trabalhar com Pilha");
            Console.WriteLine("6. Algoritmos de Pesquisa");
            Console.WriteLine("0. Encerrar");
            Console.Write("Escolha uma opção: ");
            string op = Console.ReadLine();

            switch (op)
            {
                case "1": MenuVetor(); break;
                case "2": MenuMatriz(); break;
                case "3": MenuLista(); break;
                case "4": MenuFila(); break;
                case "5": MenuPilha(); break;
                case "6": MenuPesquisa(); break;
                case "0": Console.WriteLine("Encerrando..."); return;
                default: Console.WriteLine("Opção inválida!"); Pause(); break;
            }
        }
    }

    // ================= VETOR =================
    static void MenuVetor()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("==== MENU VETOR ====");
            Console.WriteLine("1. Inserir elemento");
            Console.WriteLine("2. Remover elemento");
            Console.WriteLine("3. Exibir todos os elementos");
            Console.WriteLine("4. Consultar elemento");
            Console.WriteLine("0. Voltar");
            Console.Write("Escolha uma opção: ");
            string op = Console.ReadLine();

            switch (op)
            {
                case "1": InserirVetor(); break;
                case "2": RemoverVetor(); break;
                case "3": ExibirVetor(); break;
                case "4": ConsultarVetor(); break;
                case "0": return;
                default: Console.WriteLine("Opção inválida!"); break;
            }
            Pause();
        }
    }

    static void InserirVetor()
    {
        if (qtdVetor >= vetor.Length)
        {
            Console.WriteLine("Vetor cheio!");
            return;
        }
        Console.Write("Digite o valor a inserir: ");
        if (int.TryParse(Console.ReadLine(), out int valor))
        {
            vetor[qtdVetor++] = valor;
            Console.WriteLine("Valor inserido!");
        }
        else
            Console.WriteLine("Valor inválido!");
    }

    static void RemoverVetor()
    {
        if (qtdVetor == 0)
            Console.WriteLine("Vetor vazio!");
        else
        {
            qtdVetor--;
            Console.WriteLine("Último elemento removido!");
        }
    }

    static void ExibirVetor()
    {
        Console.Write("Vetor: ");
        for (int i = 0; i < qtdVetor; i++)
            Console.Write(vetor[i] + " ");
        Console.WriteLine();
    }

    static void ConsultarVetor()
    {
        Console.Write("Digite o valor a buscar: ");
        if (int.TryParse(Console.ReadLine(), out int valor))
        {
            for (int i = 0; i < qtdVetor; i++)
            {
                if (vetor[i] == valor)
                {
                    Console.WriteLine($"Valor encontrado na posição {i}!");
                    return;
                }
            }
            Console.WriteLine("Valor não encontrado!");
        }
        else
            Console.WriteLine("Valor inválido!");
    }

    // ================= MATRIZ =================
    static void MenuMatriz()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("==== MENU MATRIZ ====");
            Console.WriteLine("1. Inserir elemento");
            Console.WriteLine("2. Remover elemento");
            Console.WriteLine("3. Exibir todos os elementos");
            Console.WriteLine("4. Consultar elemento");
            Console.WriteLine("0. Voltar");
            Console.Write("Escolha uma opção: ");
            string op = Console.ReadLine();

            switch (op)
            {
                case "1": InserirMatriz(); break;
                case "2": RemoverMatriz(); break;
                case "3": ExibirMatriz(); break;
                case "4": ConsultarMatriz(); break;
                case "0": return;
                default: Console.WriteLine("Opção inválida!"); break;
            }
            Pause();
        }
    }

    static void InserirMatriz()
    {
        if (qtdMatriz >= 9)
        {
            Console.WriteLine("Matriz cheia!");
            return;
        }
        Console.Write("Digite o valor a inserir: ");
        if (int.TryParse(Console.ReadLine(), out int valor))
        {
            int linha = qtdMatriz / 3;
            int coluna = qtdMatriz % 3;
            matriz[linha, coluna] = valor;
            qtdMatriz++;
            Console.WriteLine("Valor inserido!");
        }
        else
            Console.WriteLine("Valor inválido!");
    }

    static void RemoverMatriz()
    {
        if (qtdMatriz == 0)
            Console.WriteLine("Matriz vazia!");
        else
        {
            qtdMatriz--;
            int linha = qtdMatriz / 3;
            int coluna = qtdMatriz % 3;
            matriz[linha, coluna] = 0;
            Console.WriteLine("Último elemento removido!");
        }
    }

    static void ExibirMatriz()
    {
        Console.WriteLine("Matriz:");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
                Console.Write(matriz[i, j] + "\t");
            Console.WriteLine();
        }
    }

    static void ConsultarMatriz()
    {
        Console.Write("Digite o valor a buscar: ");
        if (int.TryParse(Console.ReadLine(), out int valor))
        {
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    if (matriz[i, j] == valor)
                    {
                        Console.WriteLine($"Valor encontrado na posição [{i},{j}]!");
                        return;
                    }
            Console.WriteLine("Valor não encontrado!");
        }
        else
            Console.WriteLine("Valor inválido!");
    }

    // ================= LISTA =================
    static void MenuLista()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("==== MENU LISTA ====");
            Console.WriteLine("1. Inserir elemento");
            Console.WriteLine("2. Remover elemento");
            Console.WriteLine("3. Exibir todos os elementos");
            Console.WriteLine("4. Consultar elemento");
            Console.WriteLine("0. Voltar");
            Console.Write("Escolha uma opção: ");
            string op = Console.ReadLine();

            switch (op)
            {
                case "1": InserirLista(); break;
                case "2": RemoverLista(); break;
                case "3": ExibirLista(); break;
                case "4": ConsultarLista(); break;
                case "0": return;
                default: Console.WriteLine("Opção inválida!"); break;
            }
            Pause();
        }
    }

    static void InserirLista()
    {
        Console.Write("Digite o valor a inserir: ");
        if (int.TryParse(Console.ReadLine(), out int valor))
        {
            lista.Add(valor);
            Console.WriteLine("Valor inserido!");
        }
        else
            Console.WriteLine("Valor inválido!");
    }

    static void RemoverLista()
    {
        if (lista.Count == 0)
        {
            Console.WriteLine("Lista vazia!");
            return;
        }
        Console.Write("Digite o valor a remover: ");
        if (int.TryParse(Console.ReadLine(), out int valor))
        {
            if (lista.Remove(valor))
                Console.WriteLine("Valor removido!");
            else
                Console.WriteLine("Valor não encontrado!");
        }
        else
            Console.WriteLine("Valor inválido!");
    }

    static void ExibirLista()
    {
        Console.Write("Lista: ");
        foreach (var item in lista)
            Console.Write(item + " ");
        Console.WriteLine();
    }

    static void ConsultarLista()
    {
        Console.Write("Digite o valor a buscar: ");
        if (int.TryParse(Console.ReadLine(), out int valor))
        {
            int pos = lista.IndexOf(valor);
            if (pos >= 0)
                Console.WriteLine($"Valor encontrado na posição {pos}!");
            else
                Console.WriteLine("Valor não encontrado!");
        }
        else
            Console.WriteLine("Valor inválido!");
    }

    // ================= FILA =================
    static void MenuFila()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("==== MENU FILA ====");
            Console.WriteLine("1. Inserir elemento");
            Console.WriteLine("2. Remover elemento");
            Console.WriteLine("3. Exibir todos os elementos");
            Console.WriteLine("4. Consultar elemento");
            Console.WriteLine("0. Voltar");
            Console.Write("Escolha uma opção: ");
            string op = Console.ReadLine();

            switch (op)
            {
                case "1": InserirFila(); break;
                case "2": RemoverFila(); break;
                case "3": ExibirFila(); break;
                case "4": ConsultarFila(); break;
                case "0": return;
                default: Console.WriteLine("Opção inválida!"); break;
            }
            Pause();
        }
    }

    static void InserirFila()
    {
        Console.Write("Digite o valor a inserir: ");
        if (int.TryParse(Console.ReadLine(), out int valor))
        {
            fila.Enqueue(valor);
            Console.WriteLine("Valor inserido!");
        }
        else
            Console.WriteLine("Valor inválido!");
    }

    static void RemoverFila()
    {
        if (fila.Count == 0)
            Console.WriteLine("Fila vazia!");
        else
            Console.WriteLine($"Valor {fila.Dequeue()} removido!");
    }

    static void ExibirFila()
    {
        Console.Write("Fila: ");
        foreach (var item in fila)
            Console.Write(item + " ");
        Console.WriteLine();
    }

    static void ConsultarFila()
    {
        Console.Write("Digite o valor a buscar: ");
        if (int.TryParse(Console.ReadLine(), out int valor))
        {
            if (fila.Contains(valor))
                Console.WriteLine("Valor encontrado na fila!");
            else
                Console.WriteLine("Valor não encontrado!");
        }
        else
            Console.WriteLine("Valor inválido!");
    }

    // ================= PILHA =================
    static void MenuPilha()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("==== MENU PILHA ====");
            Console.WriteLine("1. Inserir elemento");
            Console.WriteLine("2. Remover elemento");
            Console.WriteLine("3. Exibir todos os elementos");
            Console.WriteLine("4. Consultar elemento");
            Console.WriteLine("0. Voltar");
            Console.Write("Escolha uma opção: ");
            string op = Console.ReadLine();

            switch (op)
            {
                case "1": InserirPilha(); break;
                case "2": RemoverPilha(); break;
                case "3": ExibirPilha(); break;
                case "4": ConsultarPilha(); break;
                case "0": return;
                default: Console.WriteLine("Opção inválida!"); break;
            }
            Pause();
        }
    }

    static void InserirPilha()
    {
        Console.Write("Digite o valor a inserir: ");
        if (int.TryParse(Console.ReadLine(), out int valor))
        {
            pilha.Push(valor);
            Console.WriteLine("Valor inserido!");
        }
        else
            Console.WriteLine("Valor inválido!");
    }

    static void RemoverPilha()
    {
        if (pilha.Count == 0)
            Console.WriteLine("Pilha vazia!");
        else
            Console.WriteLine($"Valor {pilha.Pop()} removido!");
    }

    static void ExibirPilha()
    {
        Console.Write("Pilha: ");
        foreach (var item in pilha)
            Console.Write(item + " ");
        Console.WriteLine();
    }

    static void ConsultarPilha()
    {
        Console.Write("Digite o valor a buscar: ");
        if (int.TryParse(Console.ReadLine(), out int valor))
        {
            if (pilha.Contains(valor))
                Console.WriteLine("Valor encontrado na pilha!");
            else
                Console.WriteLine("Valor não encontrado!");
        }
        else
            Console.WriteLine("Valor inválido!");
    }

    // ================= PESQUISA =================
    static void MenuPesquisa()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("==== MENU PESQUISA ====");
            Console.WriteLine("1. Pesquisa Linear em Vetor");
            Console.WriteLine("2. Pesquisa Binária em Vetor (ordenado)");
            Console.WriteLine("0. Voltar");
            Console.Write("Escolha uma opção: ");
            string op = Console.ReadLine();

            switch (op)
            {
                case "1": PesquisaLinearVetor(); break;
                case "2": PesquisaBinariaVetor(); break;
                case "0": return;
                default: Console.WriteLine("Opção inválida!"); break;
            }
            Pause();
        }
    }

    static void PesquisaLinearVetor()
    {
        if (qtdVetor == 0)
        {
            Console.WriteLine("Vetor vazio!");
            return;
        }
        Console.Write("Digite o valor a buscar: ");
        if (int.TryParse(Console.ReadLine(), out int valor))
        {
            for (int i = 0; i < qtdVetor; i++)
            {
                if (vetor[i] == valor)
                {
                    Console.WriteLine($"Valor encontrado na posição {i}!");
                    return;
                }
            }
            Console.WriteLine("Valor não encontrado!");
        }
        else
            Console.WriteLine("Valor inválido!");
    }

    static void PesquisaBinariaVetor()
    {
        if (qtdVetor == 0)
        {
            Console.WriteLine("Vetor vazio!");
            return;
        }
        int[] copia = new int[qtdVetor];
        Array.Copy(vetor, copia, qtdVetor);
        Array.Sort(copia);

        Console.Write("Digite o valor a buscar: ");
        if (int.TryParse(Console.ReadLine(), out int valor))
        {
            int inicio = 0, fim = qtdVetor - 1;
            while (inicio <= fim)
            {
                int meio = (inicio + fim) / 2;
                if (copia[meio] == valor)
                {
                    Console.WriteLine($"Valor encontrado na posição {meio} (no vetor ordenado)!");
                    return;
                }
                else if (valor < copia[meio])
                    fim = meio - 1;
                else
                    inicio = meio + 1;
            }
            Console.WriteLine("Valor não encontrado!");
        }
        else
            Console.WriteLine("Valor inválido!");
    }

    // ===== Método auxiliar para pausa =====
    static void Pause()
    {
        Console.WriteLine("Pressione qualquer tecla para continuar...");
        Console.ReadKey();
    }
}
