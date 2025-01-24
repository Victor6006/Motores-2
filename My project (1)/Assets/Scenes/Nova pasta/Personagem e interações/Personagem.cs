using System;
public class Personagem
{
    public string nome;
    private Inventario inventario;
    private SistemaCombate combate;

    public Personagem(string nome)
    {
        this.nome = nome;
        this.inventario = new Inventario();
        this.combate = new SistemaCombate(); //Composição: colocar outras classes dentro de outra como objetos daquela classe
    }

    public void PegarItem(string item)
    {
        inventario.AdicionarItem(item);
    }

    public void LargarItem(string item)
    {
        inventario.RemoverItem(item);
    }

    public void Atacar(Personagem alvo)
    {
        combate.Atacar(alvo, this); //Delegação: uma classe passa a responsabilidade para outra, usando o próprio método para chamar o da outra
    }

    public void MostrarInventario()
    {
        Console.WriteLine($"Inventário de {nome}:");
        inventario.ExibirItens();
    }
}