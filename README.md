# WordParser
Customizable parser for extracting words from English text

## Basic Usage

```
var wordParser = new WordParser();
var words = wordParser.Parse("Hello World!");
```

## Advanced Usage

Some of the logic for the word parser is customizable through the use of input parameters to the `WordParser` constructor. The available options are:

`ICharacterIdentification`: Specifies what characters are considered to be part of a word. A default implementation is provided if a value for this argument is not passed.