# Regular Expressions

Regular expressions is an example of a context-free grammar. This means that as a developer there's little to no constraints on the order and combination of expressions.

In contrast, C# is an example of a *context-bound* programming language. This is where there are rules that say where certain expressions should go. For example, using statements can not go inside of methods.

## Character Classes

Character Classes are used for providing characters you like to match. They are delimited by `[` and `]`. Inside the square brackets you would put a sequence of characters. Character classes, by default, matches one character and are written like: `[abcdef]`. This means "you can match 'a' or 'b' or 'c' or 'd' or 'e' or 'f'".

Character Classes can contain letters, numbers, ranges of numbers (ex. `0-9`) , ranges of letters (ex. `a-z`) or any combination there of. The following is a valid character class that will match any digit or uppercase letter, `[0-9A-Z]`.

Consider the following example. Let's say you want match the first letter of the following string, `f`:

```
french fries
```

Any character class that contains a lowercase `f` will match the first letter in `french`:

```
[abdef] # This works
[fyi] # This also works
[a-z12] # This works too (f is included in a thru z)
```


