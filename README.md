<!-- markdownlint-disable MD033 MD041 -->
<img alt="UCU" src="https://www.ucu.edu.uy/plantillas/images/logo_ucu.svg"
width="150"/>
<!-- markdownlint-enable MD033 MD041 -->

# Universidad Católica del Uruguay

## Facultad de Ingeniería y Tecnologías

### Programación II

# Encuentros futuros de la Tierra Media

En este juego, varios personajes cobrarán vida en la Tierra Media.

## Personajes \[Characters\]

Existen diferentes tipos de personajes provenientes de distintas especies.

### [Magos _[Wizards]_](https://lotr.fandom.com/wiki/Wizards)

Los magos, también conocidos como Istari, tienen el dominio de la magia, que
provee capacidades de ataque y de defensa. La magia es innata a ellos, aunque
pueden adquirir más mediante el estudio de la asignatura, y mediante elementos
que la potencian —por ejemplo, un [bastón
mágico](https://ringsdb.com/bundles/cards/142008.png)—.

### [Elfos _[Elves]_](https://lotr.fandom.com/wiki/Elves)

Los elfos son criaturas supernaturales que también poseen características
mágicas, y en general son conocidos por ayudar a los demás.

### [Enanos _[Dwarves]_](https://lotr.fandom.com/wiki/Dwarves)

Los enanos son seres temperamentales, muy buenos en combate con las armas,
físicamente fuertes, con mucha resistencia y leales a sus amigos.

## Elementos _\[Items\]_

Los personajes necesitan de ciertos elementos para poder combatir con sus
enemigos. Estos elementos pueden ser ropaje —túnica, por ejemplo—, armas —como
un hacha o una espada—, entre otros.

Existe un elemento particularmente interesante, llamado libro de hechizos. El
libro de hechizos es tan poderoso como hechizos tenga en él, y representa el
conocimiento de un mago.

# Desafío

## Parte 0: Repo

Cada equipo deberá crear un repo para el desarrollo de este juego. Todos los
miembros del equipo deberán tener acceso al repo.

## Parte 1: Modelado

En equipo, modelen las clases y las colaboraciones que son necesarias para
representar los elementos del juego mencionados; pueden comenzar usando tarjetas
CRC o directamente haciendo el diagrama de clases UML.

> [!IMPORTANT]
> Recuerden que los personajes deben poder tener items. Por ejemplo, los magos
> pueden tener un bastón mágico, un libro de hechizos —con hechizos—, etc.

Deberán crear y subir al repositorio el modelo, en forma de diagrama de clases,
usando [Mermaid](https://mermaid.live/edit). Hay un ejemplo con un punto de
partida ya hecho en el archivo [DIAGRAM.md](./DIAGRAM.md).

## Parte 2: Creación

Cada equipo deberá crear las clases representadas en el modelo anterior. Cada
integrante deberá crear, al menos:

* Un personaje  🧙‍♂️
* Dos elementos ⚔️ 🛡

> [!IMPORTANT]
> Recuerden crear el libro de hechizos y sus hechizos —existe un solo _tipo_ de
> hechizo por ahora—.

### Personajes

Los personajes tienen, además de sus items, un nombre y una cantidad de vida
limitada.

Sus items pueden además quitarse o cambiarse por otros similares —por ejemplo,
darle a un mago un bastón mágico nuevo, o simplemente quitarle el que tiene—.

### Elementos

Los elementos tienen un valor de ataque y un valor de defensa. Es posible que en
algunos casos alguno de estos valores sea 0. Por ejemplo, un elemento "Armadura"
puede tener valor de ataque 0.

> [!TIP]
> Fuente de [inspiración](https://ringsdb.com/find?q=t%3Aattachment).

## Parte 3: Cobrando poder

Agregar al proyecto el siguiente comportamiento:

* Obtener el valor total de ataque de un personaje. ⚔️
* Obtener el valor total de defensa de un personaje. 🛡
* Atacar a un personaje (disminuir su vida en cierta cantidad) 🗡
* Curar a un personaje (recuperar su vida inicial) 🚑

Justificar con comentarios en el código las decisiones que tomaron para resolver
esta parte del desafío, incluyendo si utilizaron algún patrón o principio.

## Parte 4: Testing

Deberán escribir casos de test para probar su programa. Como equipo tendrán que
evaluar qué casos de test son necesarios, y deberán reflejar qué hace el test
usando la convención de `MethodName_StateUnderTest_ExpectedBehavior` y
opcionalmente un comentario que explique qué es lo que prueba el test.

Todos los integrantes del equipo deben participar de la escritura de tests
—contribuyendo al menos uno de los casos—.

# Usando ![GitHub Copilot](https://img.shields.io/badge/GitHub%20Copilot-000?logo=githubcopilot&logoColor=fff) para aprender

Puedes usar GitHub Copilot en este repositorio. Si no tienes una suscripción a
Copilot, puedes aplicar a una como estudiante de la Universidad Católica del
Uruguay
[aquí](https://docs.github.com/en/education/about-github-education/github-education-for-students/apply-to-github-education-as-a-student).

## Requisito previo

El repositorio está configurado para usar Copilot en Visual Studio Code.
Verifica la instalación siguiendo [Set up Copilot in Visual Studio
Code](https://code.visualstudio.com/docs/copilot/setup-simplified).

## Sugerencias en línea

En este repositorio las sugerencias de código en líneas están inhabilitadas,
para promover que escribas tu propio código. Revisa [Setting up Copilot for
learning to
code](https://docs.github.com/en/get-started/learning-to-code/setting-up-copilot-for-learning-to-code).

## Configuración como tutor

En este repositorio, Copilot está configurado para actuar como tutor y no para
reemplazarte como programador: no deberías pedirle directamente el código que
resuelva el problema —el agente no debería responder esas peticiones—.

¿Qué cosas puedes pedirle a Copilot?

* Explicaciones de fragmentos de código, por ejemplo, qué hace una línea de
  código, un método, o una clase que te damos o que programó otro de los
  miembros de tu equipo.

* Preguntas de práctica de los conceptos relacionados con el ejercicio. Copilot
  también puede corregir tus respuestas.

* Ejercicios para practicar los conceptos relacionados con el ejercicio. Incluso
  puedes pedir ejercicios simples primero, y luego, otros más complejos. Copilot
  puede también corregir tus soluciones.

* Ejemplos de los conceptos relacionados con el ejercicio.

* Qué pasos tendrías que dar para resolver problemas sin código.

* Ayuda para depurar; mira [Learning to debug with GitHub
  Copilot](https://docs.github.com/en/get-started/learning-to-code/learning-to-debug-with-github-copilot).

* Pseudocódigo o algoritmos en lenguaje natural en vez de código
  ejecutable.

* Retroalimentación sobre el código que tú escribas.

* Detección de casos de prueba de escenarios o condiciones que no hayas
  contemplado todavía; revisa [Testing code with Copilot
  Chat](https://docs.github.com/en/copilot/tutorials/copilot-chat-cookbook/testing-code).

* Búsqueda en las API de las clases y métodos que puedes usar para resolver un
  problema.

En definitiva, puedes pedir muchas cosas, incluso que te dé un problema
resuelto; pero si le pides que resuelva un problema por ti, no vas a aprender
nada.

> [!TIP]
> Revisa [Best practices for using GitHub
> Copilot](https://docs.github.com/en/copilot/get-started/best-practices) para
> conocer formas de usar Copilot.
<!--  -->
> [!WARNING]
> Ten en cuenta que las respuestas de Copilot pueden ser incorrectas y que tú
> eres siempre responsable del código que entregas.
<!--  -->
> [!TIP]
> Cuando comiences un chat con Copilot, dile que eres un estudiante, por
> ejemplo, "soy un estudiante que ..."; esto puede mejorar la ayuda que te da
> Copilot.
