using static psc_lista_06_2025.Models.Atividades;

int menu = 0;
bool exit = false;

while (!exit)
{
    try
    {
        Console.Clear();
        Console.WriteLine("Menu:");
        Console.WriteLine("1. Atividade 1");
        Console.WriteLine("2. Atividade 2");
        Console.WriteLine("3. Atividade 3");
        Console.WriteLine("4. Atividade 4");
        Console.WriteLine("5. Atividade 5");
        Console.WriteLine("6. Atividade 6");
        Console.WriteLine("7. Atividade 7");
        Console.WriteLine("8. Atividade 8");
        menu = Convert.ToInt32(Console.ReadLine());
        switch (menu)
        {
            case 1:
                Atividade1();
                break;
            case 2:
                Atividade2();
                break;
            case 3:
                Atividade3();
                break;
            case 4:
                Atividade4();
                break;
            case 5:

                break;
            case 6:

                break;
            case 7:

                break;
            case 8:

                break;
            default:
                exit = true;
                break;
        }
    }
    catch (FormatException)
    {
        Console.WriteLine("Por favor, insira um número válido.");
    }
    catch (Exception ex)
    {
        Console.WriteLine("Ocorreu um erro: " + ex.Message);
    }
    Console.WriteLine("Clique em qualquer tecla para continuar...");
    Console.ReadKey();
}