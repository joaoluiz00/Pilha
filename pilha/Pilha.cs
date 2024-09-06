public class Pilha{
    public No topo;

    public Pilha(){
        this.topo = null;
    }

    public Boolean estaVazia(){
        if(this.topo ==null){
            return true;
        }
        return false;
    }

    public void push(int valor){ // inserindo um elemento na pilha
        No novoNo = new No(valor);

        if(this.estaVazia() == true){
            this.topo = novoNo;
        }
        else{
            novoNo.prox = this.topo;
            this.topo = novoNo;
        }
    }

    public No pop(){ // retirando um elemento da pilha

        No aux = null;

        if(this.estaVazia() == true){
            return(null);
        }
        else{
            aux = this.topo;
            this.topo = this.topo.prox;
            aux.prox = null;
            return(aux);
        }
    }

    public Boolean consulta(int valor, ref No noAtual, ref No noAnterior){ //BUSCA ELEMENTO NA LISTA 
        
        noAtual = this.topo; //Copia da lista
        while(noAtual != null){ //Percorrer lista
            if(noAtual.valor == valor){
                return(true);
            }
            noAtual = noAtual.prox;
        }
        return(false);
    }

    public void imprimir(){

        No noAtual = this.topo;

            while(noAtual != null){
                Console.Write(noAtual.valor + "-> ");
                noAtual = noAtual.prox;
            }
            Console.WriteLine("\n");
    
        }
    public int retornarQuantidadePilha() { 

        No noAtual = this.topo;

        int qtd = 0;
        while(noAtual != null){
            qtd++;
            noAtual = noAtual.prox;
        }
        return qtd;
    }

     public int contarImpares() {
        No noAtual = topo;
        int qtdImpares = 0;

        while (noAtual != null) {
            if (noAtual.valor % 2 != 0) {  // Verifica se o valor é ímpar
                qtdImpares++;
            }
            noAtual = noAtual.prox;
        }

        return qtdImpares;
    }


}