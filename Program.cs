// Multiplicação Simples

/*
Você receberá dois valores inteiros. Faça a leitura e em seguida calcule o
produto entre estes dois valores. Atribua esta operação à variável PROD,
mostrando esta de acordo com a mensagem de saída esperada (exemplo abaixo).   
- Entrada
A entrada contém 2 valores inteiros.
- Saída
Exiba a variável PROD conforme exemplo abaixo, tendo obrigatoriamente um espaço
em branco antes e depois da igualdade.
*/

decimal a, b;
decimal valor;
decimal ValorDiv;
Console.WriteLine("Digite o valor para a: ");
a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite o Valor para b: ");
b = Convert.ToInt32(Console.ReadLine());
valor = a * b;
ValorDiv = a / b;

Console.WriteLine("O resultado da multiplicação dos dois valores é: " +  (valor));
Console.WriteLine("A divisão destes dois mesmos numeros inseridos é: " + (ValorDiv));

if(valor >= 1000){
          decimal Resultado = valor + 1000;
          Console.WriteLine("O valor excedeu o limite de 1000 e ganhou mais 1000 pontos!!! " + Resultado + (" (MAX POINTS)"));
}

else if (valor >= 500 && valor <1000){
          decimal Resultado = valor + 500;
          Console.WriteLine("O valor excedeu o limite de 500 e ganhou mais 500 pontos!!! " + Resultado + (" (MEDIUM POINTS)"));
}
else if (valor >=200 && valor <500){
          decimal Resultado = valor + 100;
          Console.WriteLine("O valor concebido pela multiplicação passou de 200 e ganhou 100 pontos!!! " + Resultado + (" (LITTLE'S POINTS)"));
}
if (valor <200){
          decimal Resultado = valor + 50;
          Console.WriteLine("O valor infelizmente não foi alto :/, +50 e você ganhou 50 pontos!!! " + Resultado + (" (EASY POINT)"));
}