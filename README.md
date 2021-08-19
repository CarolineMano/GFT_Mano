<h1 align="center">Desafios de código</h1>

## :memo: Descrição dos exercícios 

## Idiomas

**Desafio**  

Utilizando conceitos de herança, crie uma classe abstrata chamada Idioma com um
atributo chamado nomeDoIdioma e um método abstrato chamado saudacao() que imprime
o nome do idioma e uma saudação na tela, em seguida, crie as classes que herdam Idioma
e suas respectivas saudações.

Em seguida, crie uma classe com método Main , instancie as classes e chame o método
saudacao().


[Visualizar Código](https://github.com/CarolineMano/GFT_Mano/tree/master/Idiomas)  

---

## PresentesGFT

**Desafio**  

A cada período de tempo de casa na GFT, o funcionário recebe um presente. Crie um
programa para mostrar qual presente o funcionário vai receber.
Esse programa deverá receber o ano de entrada deste funcionário e considerar o ano
atual (2021)
Os presentes são:
- 1 ano = Vale Presente
- 2 anos = Smart Watch
- 5 anos = Fone Bluetooth
- 10 anos = Vale Jantar
- 15 anos = Vale Jantar Top
Caso o funcionário não esteja dentro de nenhum desses anos, o programa deverá
imprimir em tela: “Esse ano não vai ter presente”

[Visualizar Código](https://github.com/CarolineMano/GFT_Mano/tree/master/PresentesGFT)  

---

## Animais

**Desafio**  

Crie uma classe Abstrata chamada Animal com os atributos nome e peso, sendo que no
construtor você deverá passar o nome e o peso do animal e crie dois métodos abstratos:
som() e quantidadeDeRacao() . Em seguida, crie duas classes herdando de Animal: Cachorro
e Gato.
- O método som() deverá retornar o som que cada animal faz. (“auau” para cachorro e
“miau” para gato)
- O método quantidadeDeRacao() deverá retornar quanta ração o animal come por
dia, observando as seguintes regras
    - Gatos abaixo ou igual a 4kg consomem 12g por cada kg do seu peso
    - Gatos acima de 4kg consomem 15g por cada kg do seu peso
    - Cachorros abaixo ou igual a 3kg consomem 35g por cada kg do seu peso
    - Cachorros acima 3kg e abaixo ou igual a 10kg consomem 45g por cada kg do
seu peso
    - Cachorros acima de 10kg consomem 50g por cada kg do seu peso
- Exemplos:
    - Um gato de 5kg consome: 15 x 5 = 75g de ração por dia
    - Um cachorro de 7kg consome: 45 x 7 = 315g de ração por dia

Crie uma classe com método Main(), e crie os seguintes: animais:
- Uma gata de 20kg chamada Coca
- Uma gata de 3kg chamada Foxy
- Um cachorro de 10kg chamado Einstein
- Um gato de 5kg chamado Edward
Some a quantidade de ração consumida por todos os animais e exiba na tela.

[Visualizar Código](https://github.com/CarolineMano/GFT_Mano/tree/master/Animais)  

---

## Notas Musicais

**Desafio**

Existem 7 notas musicais: “Dó Ré Mi Fá Sol Lá Si” que se repetem infinitamente.
Associando essas notas a numerais:
Dó = 0 | Ré = 1 | Mi = 2 | Fá = 3 | Sol = 4 | Lá = 5 | Si = 6

Crie um programa que receba um número inicial e um número final, e imprima todas as notas
desse intervalo, quando chegar a 7, deverá recomeçar a impressão de notas a partir de Dó.

[Visualizar código](https://github.com/CarolineMano/GFT_Mano/tree/master/NotasMusicais)

---

