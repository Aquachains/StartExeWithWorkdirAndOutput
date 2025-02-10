## Summary

StartExeWithWorkdirAndOutput.exe expects only the file path of an executable as argument. For example, if you call __StartExeWithWorkdirAndOutput.exe *C:\dev\test.exe*__, it will set "C:\dev" as the working directory and redirect the output of test.exe to your caller.

## But why?

I wanted to run a executable from my simple [PangoC IDE](https://github.com/Aquachains/PangoC_Editor), but I couldn't find a way to call an .exe file with its working directory and simultaneously capture the output in [Godot](https://github.com/godotengine/godot).
