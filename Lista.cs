using System;

namespace exercicio
{
    class Lista
    {
        string[] valores;
        int limite;
        int quantidadeAtual = 0;
        int ultimo = 0;
        public Lista(int Tamanho)
        {
            valores = new string[Tamanho];
            limite = Tamanho;
        }
        public void Inserir(string valor)
        {
            if (ultimo < limite)
            {
                valores[ultimo] = valor;
                ultimo++;
                this.quantidadeAtual += 1;
            }
            else
            {
                Console.WriteLine("Lista está cheia!");
            }
        }

        public void Remover(int posicao)
        {
            if (posicao < limite && posicao >= 0)
            {
                for (int i = posicao; i < limite - 1; i++)
                {
                    string temporaria = valores[i];
                    valores[i] = valores[i + 1];
                    valores[i + 1] = temporaria;
                }
                this.quantidadeAtual--;
                this.ultimo--;
            }
            else
            {
                Console.WriteLine("A posição é inválida");
            }
        }
        public string[] Listar()
        {
            string[] valores = new string[this.quantidadeAtual];
            for (int i = 0; i < this.ultimo; i++)
            {
                valores[i] = this.valores[i];
            }
            return valores;
        }
        public void Alterar(int indice, string valor)
        {
            this.valores[indice] = valor;
        }
        public void Ordernar(int sentido = -1)
        {
            for (int i = 0; i < this.valores.Length; i++)
            {
                for (int j = i; j < this.valores.Length; j++)
                {
                    int comparacao = string.Compare(this.valores[i],this.valores[j]); 
                    if (comparacao == sentido)
                    {
                        string temporaria = this.valores[i];
                        this.valores[i] = this.valores[j];
                        this.valores[j] = temporaria;
                    }
                }
            }
        }
        public int Quantidade()
        {
            return this.quantidadeAtual;
        }
    }
}
