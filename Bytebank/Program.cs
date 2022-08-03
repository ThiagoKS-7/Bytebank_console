using System;
using Bytebank.controllers;

class Program
{
    static void Main(string[] args)
    {
        ProgramController.runProgram();
    }
}

/* 
 * Igualar valores retorna true, mas comparar objetos
 * retorna false, mesmo que o conteúdo deles seja igual
 * Isso se dá por conta do endereço de cada obj, q é diferente na memória.
 * se conta1 receber conta2 (conta1 = conta2) ele passa a ser ponteiro da conta2
 * 
 * cw + 2tabs
 */