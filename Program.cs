﻿using static System.Console;

char op;
double um, dois, resultado;

Write("Digite o primeiro número: ");
um = Convert.ToDouble(ReadLine());
Write("Digite o segundo número: ");
dois = Convert.ToDouble(ReadLine());
Write("Qual a operação (+, -, *, /): ");
op = (char)Read();

switch (op)
{
    
    case '+':
        resultado = um + dois;
        WriteLine("{0} + {1} = {2}", um, dois, resultado);
        break;
    case '-':
        resultado = um - dois;
        WriteLine("{0} - {1} = {2}", um, dois, resultado);
        break;
    case '*':
        resultado = um * dois;
        WriteLine("{0} * {1} = {2}", um, dois, resultado);
        break;
    case '/':
        resultado = um / dois;
        WriteLine("{0} / {1} = {2}", um, dois, resultado);
        break;
    default:
        WriteLine("Operador Inválido");
        break;
}