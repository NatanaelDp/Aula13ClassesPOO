﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula13ClassesPOO
{
    internal class Pessoa
    {
        //ATRIBUTOS(variável)
        public string nome;
        public int idade;
        public string rua;
        public string cidade;

        //MÉTODO CONSTRUTOR
        public  Pessoa(string nome, int idade,string rua , string cidade)
        {
            this.nome = nome;   
            this.idade = idade;
            this.rua = rua;
            this.cidade = cidade;
           
            Console.WriteLine("Salve guys fui criado");
            
        }

        //MÉTODOS(funções)
        public void mostra()
        {
            Console.WriteLine($"Este(a) é o(a) {nome} ele(a) tem {idade} anos e mora na  {rua}  na cidade de {cidade}");
        }

    }
}
