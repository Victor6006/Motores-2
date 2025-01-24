using System;
using System.Collections.Generic;

public class Inventario
{
    private List<string> itens = new List<string>();
    public void AdicionarItem(string item)
    {
        itens.Add(item);
        Console.WriteLine($"Item '{item}' adicionado ao inventário.");
    }

    public void RemoverItem(string item)
    {
        if (itens.Remove(item))
        {
            Console.WriteLine($"Item '{item}' removido do inventário.");
        }

        else
        {
            Console.WriteLine($"Item '{item}' não encontrado no inventário.");
        }
    }

    public void ExibirItens()
    {
        Console.WriteLine("Itens no inventário:");
        foreach (var item in itens) Console.WriteLine($"- {item}");
    }

}