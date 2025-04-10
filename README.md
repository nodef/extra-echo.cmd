Write to stdout like Unix in Windows Console.
> 1. Download [exe file](https://github.com/cmdf/extra-echo/releases/download/1.0.0/eecho.exe).
> 2. Copy to `C:\Program_Files\Scripts`.
> 3. Add `C:\Program_Files\Scripts` to `PATH` environment variable.


```batch
> eecho [--expand|-e] [--no-newline|-n] [<message>...]

:: [] -> optional argument
:: <> -> argument value
```

```batch
:: echo Dr. APJ Abdul Kalam's quote
> eecho You have to dream before your dreams can come true.

:: echo Dr. APJ Abdul Kalam's Ignited Minds paragraph
> eecho --expand "Dream Dream Dream\nDreams transform into throughts\nAnd thoughts result in action."

:: echo "-DREAM-" without new line at the end
> eecho -ne "\-DREAM\-"
```


[![cmdf](https://i.imgur.com/VrefufD.jpg)](https://cmdf.github.io)
![](https://ga-beacon.deno.dev/G-RC63DPBH3P:SH3Eq-NoQ9mwgYeHWxu7cw/github.com/nodef/extra-echo.cmd)
