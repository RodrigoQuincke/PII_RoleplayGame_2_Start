# Diagrama de clases

Completa a continuación tu diagrama de clases usando
[Mermaid](https://mermaid.live/edit). Debes completar el diagrama agregando las
clases y sus atributos, operaciones y relaciones faltantes. La ventaja de usar
**Mermaid** es que el diagrama es simplemente texto en un archivo
[Markdown](https://www.markdownguide.org) como este, y no gráficos ni imágenes.

```mermaid
classDiagram
    %% Relaciones de Wizard
    Wizard "1" --> "1" SpellsBook : has
    Wizard "1" --> "1" Staff : has

    %% Relaciones de Dwarf
    Dwarf "1" --> "1" Axe : has
    Dwarf "1" --> "1" Shield : has
    Dwarf "1" --> "1" Helmet : has

    %% Relaciones de Knight
    Knight "1" --> "1" Sword : has
    Knight "1" --> "1" Shield : has
    Knight "1" --> "1" Armor : has

    %% Relaciones de Archer
    Archer "1" --> "1" Bow : has
    Archer "1" --> "1" Helmet : has

    %% Relación de SpellsBook con Spell
    SpellsBook "1" --> "*" Spell : contiene

    %% Clase Wizard
    class Wizard{
      +string Name
      +SpellsBook SpellsBook
      +Staff Staff
      +int AttackValue
      +int DefenseValue
      +int Health
      +Wizard(string name)
      +ReceiveAttack(int power)
      +Cure()
    }

    %% Clase Dwarf
    class Dwarf{
      +string Name
      +Axe Axe
      +Shield Shield
      +Helmet Helmet
      +int AttackValue
      +int DefenseValue
      +int Health
      +Dwarf(string name)
      +ReceiveAttack(int power)
      +Cure()
    }

    %% Clase Knight
    class Knight{
      +string Name
      +Sword Sword
      +Shield Shield
      +Armor Armor
      +int AttackValue
      +int DefenseValue
      +int Health
      +Knight(string name)
      +ReceiveAttack(int power)
      +Cure()
    }

    %% Clase Archer
    class Archer{
      +string Name
      +Bow Bow
      +Helmet Helmet
      +int AttackValue
      +int DefenseValue
      +int Health
      +Archer(string name)
      +ReceiveAttack(int power)
      +Cure()
    }

    %% Clase SpellsBook
    class SpellsBook{
      ICollection<Spell> Spells
      +int AttackValue
      +int DefenseValue
    }

    %% Clase Spell
    class Spell{
      +int AttackValue
      +int DefenseValue
    }

    %% Armas
    class Axe{
      +int AttackValue
    }

    class Sword{
      +int AttackValue
    }

    class Bow{
      +int AttackValue
    }

    class Staff{
      +int AttackValue
      +int DefenseValue
    }

    %% Defensas
    class Shield{
      +int DefenseValue
    }

    class Armor{
      +int DefenseValue
    }

    class Helmet{
      +int DefenseValue
    }
```
