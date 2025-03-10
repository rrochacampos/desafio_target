# Desafio Técnico Target Sistemas

## Sobre

Este repositório contém a solução de um teste prático para uma vaga na Target Sistemas, desenvolvido em **C#**.

Cada desafio do teste possui seu próprio arquivo dentro da pasta `Desafios`. Confira os links abaixo para acessar cada um:

- [Desafio 1](Desafios/Soma.cs)
- [Desafio 2](Desafios/SequenciaFibonacci.cs)
- [Desafio 3](Desafios/FaturamentoDiario.cs)
- [Desafio 4](Desafios/FaturamentoMensal.cs)
- [Desafio 5](Desafios/InverterString.cs)

<details><summary style="color: #007bff; cursor: pointer; font-weight: bold;">Clique aqui para ver as instruções do teste</summary>
  
1 - Observe o trecho de código abaixo:  
int INDICE = 13, SOMA = 0, K = 0;  
Enquanto K < INDICE faça { K = K + 1; SOMA = SOMA + K; }  
Imprimir(SOMA);  
Ao final do processamento, qual será o valor da variável SOMA?  

2 - Dado a sequência de Fibonacci, onde se inicia por 0 e 1 e o próximo valor sempre será a soma dos 2 valores anteriores (exemplo: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34...), escreva um programa na linguagem que desejar onde, informado um número, ele calcule a sequência de Fibonacci e retorne uma mensagem avisando se o número informado pertence ou não a sequência.  

IMPORTANTE: Esse número pode ser informado através de qualquer entrada de sua preferência ou pode ser previamente definido no código;  

3 - Dado um vetor que guarda o valor de faturamento diário de uma distribuidora, faça um programa, na linguagem que desejar, que calcule e retorne:  
• O menor valor de faturamento ocorrido em um dia do mês;  
• O maior valor de faturamento ocorrido em um dia do mês;  
• Número de dias no mês em que o valor de faturamento diário foi superior à média mensal.  

IMPORTANTE:  
a) Usar o json ou xml disponível como fonte dos dados do faturamento mensal;  
b) Podem existir dias sem faturamento, como nos finais de semana e feriados. Estes dias devem ser ignorados no cálculo da média;  

4 - Dado o valor de faturamento mensal de uma distribuidora, detalhado por estado:  
•	SP – R$67.836,43  
•	RJ – R$36.678,66  
•	MG – R$29.229,88  
•	ES – R$27.165,48  
•	Outros – R$19.849,53  

Escreva um programa na linguagem que desejar onde calcule o percentual de representação que cada estado teve dentro do valor total mensal da distribuidora.  

5 - Escreva um programa que inverta os caracteres de um string.  

IMPORTANTE:  
a) Essa string pode ser informada através de qualquer entrada de sua preferência ou pode ser previamente definida no código;  
b) Evite usar funções prontas, como, por exemplo, reverse.  

</details>

## Como executar

Para rodar o projeto na sua máquina, siga os passos abaixo:

1. **Clone o repositório**

   ```sh
   git clone https://github.com/rrochacampos/desafio_target.git
   ```

2. **Acesse a pasta do projeto**

   ```sh
   cd desafio_target
   ```

3. **Certifique-se de ter o .NET SDK instalado**

   - Para verificar:
     ```sh
     dotnet --version
     ```
   - Se não estiver instalado, baixe em: [https://dotnet.microsoft.com/](https://dotnet.microsoft.com/)

4. **Execute o projeto**

   ```sh
   dotnet run
   ```

O projeto será compilado e executado no terminal, permitindo o acesso a cada desafio por meio de um menu principal.

