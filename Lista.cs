using System;

namespace exercicio
{
    class Lista
    {
        string[] valores;
        int limite;
        int quantidadeAtual;
        int ultimo = 0;
        int primeiro = 0;
        public Lista(int Tamanho)
        {
            valores = new string[Tamanho];
            limite = Tamanho;
            
        }
        public void Inserir(string valor)
        {
            if(ultimo < limite)
            {
                valores[ultimo] = valor;
                ultimo++;
                this.quantidadeAtual ++;
            }
            else
            {
                Console.WriteLine("Lista está cheia!");
            }
        }

        public void Inserir(string valor, int posicao)
        {
            if(ultimo < limite)
            {
                for (int i = ultimo; i >= posicao; i--)
                {
                    valores[i] = valores[(i - 1)];
                }

                valores[posicao - 1] = valor;
                ultimo++;
                this.quantidadeAtual ++;
            }
            else
            {
                Console.WriteLine("A lista está cheia");
            }
        }
        public string[] Listar(){
            return this.valores;
        }
        public int Quantidade () {
            return this.quantidadeAtual;
        }
    }
}
