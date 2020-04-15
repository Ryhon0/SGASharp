# ᓭ⊣ᔑᓭ⍑ᔑ∷!¡ (SGASharp)
 Translate Latin into [Standard Galactic Alphabet](http://www.shikadi.net/keenwiki/Standard_Galactic_Alphabet) (Minecraft Enchanting Table language) and vice versa in C#

## Add to your project
Currently you can add the library to your project by adding the [SGASharp/SGA.cs](SGASharp/SGA.cs) file to your project or by adding the [SGASharp](SGASharp) project to your solution and adding a reference to it

## Example
Example project can be found in [SGASharp.CommandLine](SGASharp.CommandLine)

SGASharp can be used by using the methods in the `SGA` static class or by using `string` extension methods. Here are some examples:

```cs
using SGASharp;

Console.WriteLine("Hello World.".LatinToSGA());
// Prints "⍑ᒷꖎꖎフ ∴フ∷ꖎ↸·-·"

string text = "SGASharp".LatinToSGA();
// Returns "ᓭ⊣ᔑᓭ⍑ᔑ∷!¡"

Console.WriteLine(text.SGAToLatin(true););
// Prints "SGASHARP"
```

You can also modify the character table

```cs
using SGASharp;

"Ryhon".LatinToSGA();
// ∷׀׀⍑フリ

SGA.CharacterTable['y'] = "||";
SGA.CharacterTable['o'] = "J";

"Ryhon".LatinToSGA();
// ∷||⍑Jリ
```

## License
[GNU GPLv3](LICENSE)