using System;

namespace Pilhanha {

    class Program {
        static void Main(string[] args) {
            
            Pilha pilhaDocumentos = new Pilha();

            // Verificar se a pilha está vazia
            //Console.WriteLine("Pilha está vazia? " + pilhaDocumentos.estaVazia());

            // Adicionando documentos à pilha (operação PUSH)
            // pilhaDocumentos.push("Relatorio", "docx", 120);

            // Imprimindo a pilha de documentos
            Console.WriteLine("Conteúdo da pilha:");
            pilhaDocumentos.imprimir();

            // Removendo documentos da pilha (operação POP)
            // Console.WriteLine("Removendo o documento do topo da pilha:");
            // pilhaDocumentos.pop();
            // pilhaDocumentos.imprimir();

            // Consultar se um documento específico está na pilha
            // No noAnterior = null, noAtual = null;
            // bool encontrou = pilhaDocumentos.consulta("Planilha", "docx", ref noAtual, ref noAnterior);
            // if (encontrou) {
            //     Console.WriteLine("O documento 'Planilha.docx' foi encontrado!");
            // } else {
            //     Console.WriteLine("O documento 'Planilha.docx' NÃO foi encontrado!");
            // }

            // Exibir a quantidade de documentos na pilha
            //Console.WriteLine("Quantidade de documentos na pilha: " + pilhaDocumentos.retornarQuantidadePilha());

            // Contar documentos cujo tamanho é ímpar
            //Console.WriteLine("Quantidade de documentos com tamanho ímpar: " + pilhaDocumentos.contarImpares());

            // Separar documentos positivos e negativos em pilhas separadas (exemplo com tamanho de arquivos positivos/negativos)
            Pilha pilhaPositivos = new Pilha();
            Pilha pilhaNegativos = new Pilha();
            Pilha pilhaNumeros = new Pilha();

            // Exemplo com números positivos e negativos (para o exercício 4)
            pilhaNumeros.push("Arquivo1", "txt", 1);
            pilhaNumeros.push("Arquivo2", "txt", -2);

            pilhaNumeros.separarPositivosNegativos(pilhaPositivos, pilhaNegativos);

            // Console.WriteLine("Pilha de números positivos:");
            // pilhaPositivos.imprimir();
            // Console.WriteLine("Pilha de números negativos:");
            // pilhaNegativos.imprimir();

            // Inverter uma pilha de letras
            Pilha pilhaLetras = new Pilha();
            pilhaLetras.push("E", "letra", 0);
            pilhaLetras.push("U", "letra", 0);
            pilhaLetras.push("A", "letra", 0);
            pilhaLetras.push("M", "letra", 0);
            pilhaLetras.push("O", "letra", 0);
            pilhaLetras.push("P", "letra", 0);
            pilhaLetras.push("R", "letra", 0);
            pilhaLetras.push("O", "letra", 0);
            pilhaLetras.push("G", "letra", 0);
            pilhaLetras.push("R", "letra", 0);
            pilhaLetras.push("A", "letra", 0);
            pilhaLetras.push("R", "letra", 0);

            // Console.WriteLine("Pilha de letras original:");
            // pilhaLetras.imprimir();

            // pilhaLetras.inverterPilha();

            // Console.WriteLine("Pilha de letras invertida:");
            // pilhaLetras.imprimir();

            // Verificar se uma palavra é palíndromo
            Pilha palindromoPilha = new Pilha();
            palindromoPilha.push("R", "letra", 0);
            palindromoPilha.push("A", "letra", 0);
            palindromoPilha.push("M", "letra", 0);
            palindromoPilha.push("A", "letra", 0);
            palindromoPilha.push("R", "letra", 0);
            palindromoPilha.push("G", "letra", 0);
            palindromoPilha.push("O", "letra", 0);
            palindromoPilha.push("R", "letra", 0);
            palindromoPilha.push("P", "letra", 0);
            palindromoPilha.push("O", "letra", 0);
            palindromoPilha.push("M", "letra", 0);
            palindromoPilha.push("A", "letra", 0);
            palindromoPilha.push("U", "letra", 0);
            palindromoPilha.push("E", "letra", 0);

            // bool ehPalindromo = palindromoPilha.verificarPalindromo();
            // if (ehPalindromo) {
            //     Console.WriteLine("A palavra formada na pilha é um palíndromo.");
            // } else {
            //     Console.WriteLine("A palavra formada na pilha NÃO é um palíndromo.");
            // }

            // Transferir elementos de uma pilha1 para pilha2, mantendo a ordem
            Pilha pilha1 = new Pilha();
            Pilha pilha2 = new Pilha();

            pilha1.push("Arquivo1", "txt", 12);
            pilha1.push("Arquivo2", "txt", 5);
            pilha1.push("Arquivo3", "txt", 7);
            pilha1.push("Arquivo4", "txt", 10);

            Console.WriteLine("Pilha 1 original:");
            pilha1.imprimir();

            pilha1.transferirElementos(pilha2);

            Console.WriteLine("Pilha 2 após a transferência (mesma ordem):");
            pilha2.imprimir();
        }
    }
}
