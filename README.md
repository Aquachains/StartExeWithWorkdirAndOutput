## Summary

StartExeWithWorkdirAndOutput.exe expects only a filepath of an executable. If you call __StartExeWithWorkdirAndOutput.exe *C:\dev\test.exe*__ "C:\dev\" will be the working directory and you get the output of "test.exe" redirected to your caller.
