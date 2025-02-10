## Summary

StartExeWithWorkdirAndOutput.exe expects only a filepath of an executable. If you call __StartExeWithWorkdirAndOutput.exe *C:\dev\test.exe*__ "C:\dev\" will be the working directory and you get the output of "test.exe" redirected to your caller.

## But why?

I wanted to call a builded executable from my simple [PangoC IDE](https://github.com/Aquachains/PangoC_Editor), but i could'nt find a way to call a exe with it's working directory and getting the output at the same time.
