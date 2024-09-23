public class Pilha {
    public No topo;  /

    public Pilha() {
        this.topo = null;
    }

    public Boolean estaVazia() {
        return this.topo == null;
    }

    public void push(string nome, string extensao, int tamanho) {
        No novoNo = new No(nome, extensao, tamanho);

        // Se a pilha estiver vazia, o novo nó será o topo
        if (this.estaVazia()) {
            this.topo = novoNo;
        } else {
            // Caso contrário, o novo nó aponta para o antigo topo
            novoNo.prox = this.topo;
            this.topo = novoNo; // E o novo nó se torna o topo
        }
    }

    // Remove o topo da pilha (operação POP)
    public No pop() {
        if (this.estaVazia()) {
            return null;  // Retorna nulo se a pilha estiver vazia
        } else {
            No aux = this.topo;  // Armazena o nó removido
            this.topo = this.topo.prox;  // O próximo nó se torna o topo
            aux.prox = null;  // Remove a referência ao próximo nó
            return aux;  // Retorna o nó removido
        }
    }

    // Consulta um documento na pilha
    public Boolean consulta(string nome, string extensao, ref No noAtual, ref No noAnterior) {
        noAtual = this.topo;
        noAnterior = null;

        while (noAtual != null) {
            // Verifica se o nome e a extensão coincidem
            if (noAtual.nomeDoArquivo == nome && noAtual.extensaoDoArquivo == extensao) {
                return true;  // Documento encontrado
            }
            noAnterior = noAtual;
            noAtual = noAtual.prox;
        }
        return false;  // Documento não encontrado
    }

    // Imprime todos os documentos da pilha
    public void imprimir() {
        No noAtual = this.topo;

        if (noAtual == null) {
            Console.WriteLine("Pilha vazia.");
        } else {
            while (noAtual != null) {
                noAtual.imprimir();
                noAtual = noAtual.prox;
            }
        }
        Console.WriteLine();
    }

    // Retorna a quantidade de documentos na pilha
    public int retornarQuantidadePilha() {
        No noAtual = this.topo;
        int qtd = 0;

        while (noAtual != null) {
            qtd++;
            noAtual = noAtual.prox;
        }
        return qtd;
    }

    // Conta quantos documentos possuem tamanho ímpar
    public int contarImpares() {
        No noAtual = this.topo;
        int qtdImpares = 0;

        while (noAtual != null) {
            if (noAtual.tamanhoDoArquivo % 2 != 0) {
                qtdImpares++;
            }
            noAtual = noAtual.prox;
        }
        return qtdImpares;
    }

    // Separa números positivos em uma pilha2 e negativos em pilha3
    public void separarPositivosNegativos(Pilha pilha2, Pilha pilha3) {
        No noAtual = this.topo;

        while (noAtual != null) {
            if (noAtual.tamanhoDoArquivo > 0) {
                pilha2.push(noAtual.nomeDoArquivo, noAtual.extensaoDoArquivo, noAtual.tamanhoDoArquivo);
            } else {
                pilha3.push(noAtual.nomeDoArquivo, noAtual.extensaoDoArquivo, noAtual.tamanhoDoArquivo);
            }
            noAtual = noAtual.prox;
        }
    }

    // Inverte a ordem dos elementos da pilha
    public void inverterPilha() {
        Pilha pilhaAuxiliar = new Pilha();

        while (!this.estaVazia()) {
            No noRemovido = this.pop();
            pilhaAuxiliar.push(noRemovido.nomeDoArquivo, noRemovido.extensaoDoArquivo, noRemovido.tamanhoDoArquivo);
        }

        this.topo = pilhaAuxiliar.topo;
    }

    // Verifica se a pilha forma um palíndromo
    public Boolean verificarPalindromo() {
        Pilha pilhaAuxiliar = new Pilha();
        No noAtual = this.topo;

        // Copia a pilha para a auxiliar
        while (noAtual != null) {
            pilhaAuxiliar.push(noAtual.nomeDoArquivo, noAtual.extensaoDoArquivo, noAtual.tamanhoDoArquivo);
            noAtual = noAtual.prox;
        }

        noAtual = this.topo;

        // Verifica se a ordem inversa é igual à original
        while (noAtual != null) {
            No noAux = pilhaAuxiliar.pop();
            if (noAtual.nomeDoArquivo != noAux.nomeDoArquivo) {
                return false;
            }
            noAtual = noAtual.prox;
        }
        return true;
    }

    // Transfere elementos de uma pilha para outra, mantendo a ordem
    public void transferirElementos(Pilha pilhaDestino) {
        Pilha pilhaAuxiliar = new Pilha();

        while (!this.estaVazia()) {
            pilhaAuxiliar.push(this.pop().nomeDoArquivo, this.pop().extensaoDoArquivo, this.pop().tamanhoDoArquivo);
        }

        while (!pilhaAuxiliar.estaVazia()) {
            pilhaDestino.push(pilhaAuxiliar.pop().nomeDoArquivo, pilhaAuxiliar.pop().extensaoDoArquivo, pilhaAuxiliar.pop().tamanhoDoArquivo);
        }
    }
}
