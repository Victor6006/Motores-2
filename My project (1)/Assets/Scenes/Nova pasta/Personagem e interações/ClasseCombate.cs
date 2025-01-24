using System;
public class SistemaCombate
{
    public void Atacar(Personagem alvo, Personagem atacante)
    {
        Console.WriteLine($"{atacante.nome} está atacando {alvo.nome}!");
    }
}