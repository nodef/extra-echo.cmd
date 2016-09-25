# oecho

Write to stdout like Unix in Windows Console.


## usage

```batch
> oecho [--expand|-e] [--no-newline|-n] [<message>...]

:: [] -> optional argument
:: <> -> argument value
```

```batch
:: echo Dr. APJ Abdul Kalam's quote
> oecho You have to dream before your dreams can come true.

:: echo Dr. APJ Abdul Kalam's Ignited Minds paragraph
> oecho --expand "Dream Dream Dream\nDreams transform into throughts\nAnd thoughts result in action."

:: echo "-DREAM-" without new line at the end
> oecho -ne "\-DREAM\-"
```
