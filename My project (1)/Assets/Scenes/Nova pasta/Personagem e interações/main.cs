class Principal
{
    static void Main()
    {
        //Criando um personagem
        Personagem jogador = new Personagem("Herói");
         Personagem alvo = new Personagem("Inimigo");

        //Interagindo com o inventário
        jogador.PegarItem("Espada");
        jogador.PegarItem("Poção de Vida");
        jogador.MostrarInventario();

        jogador.Atacar(alvo);
        jogador.LargarItem("Espada");
        jogador.MostrarInventario();
    }
}