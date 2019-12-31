# CmdQueue
## Introduction
CmdQueue is a small Windows application designed to add basic queue functionality to Windows command-line programs.

It was born out of a requirement to be able to run commands, in order, from a custom Directory Opus toolbar button.

## Installation
You can download the Visual Studio 2019 solution from this repository and build it yourself, or you can download the .msi installer from https://gazchap.com/cmdqueue

## Usage
The application has two modes of usage - the graphical user interface, and some command-line options.

### GUI
The application will always open its GUI as this is how you view the queue's progress.

You can add commands (jobs) to the queue using the controls at the top of the GUI.

You can change the order of commands in the queue using the Up and Down controls, and remove items from the queue using the Remove button.

To start the Queue processing, hit the Start button. The first item in the list will immediately run.

You can halt the queue using the Stop button. This will *not* terminate the process currently running, but will stop the application from starting the next command when the running process finishes.

### Command Line Usage
You can pass some parameters to the CmdQueue.exe application. Mostly this will be to add a new command into the queue without using the GUI to do so.

**/START**

This parameter will start the queue when the application loads.

**/STOP**

This parameter will stop the queue when the application loads.

**/NAME <name>**

If set, this parameter will set the description of the job added to the queue. Use with /ADD. If the name you are passing has spaces, you *MUST* enclose the name with quotation marks.

**/STARTIN <path>**

If set, this parameter will set the working directory of the command added to the queue. Use with /ADD. If the path you are passing has spaces, you *MUST* enclose it with quotation marks.

**/ADD <command>**

This parameter must be the *LAST* parameter in the command line.

Anything that follows /ADD will be considered as part of the command to be run.

#### Examples of Command Line Usage

`CmdQueue.exe /START`

Start the application, and immediately start the queue.

`CmdQueue.exe /ADD notepad.exe`

Start the application and add "notepad.exe" to the command queue - but do not start the queue. Note, if the queue is already running, it will continue to run.

`CmdQueue.exe /START /ADD notepad.exe "C:\test document.txt"`

Start the application, add "notepad.exe" to the command queue with "C:\test document.txt" as an argument, and start the queue running if it isn't already.

`CmdQueue.exe /START /NAME "Notepad Test" /ADD notepad.exe "C:\test document.txt"`

Start the application, add "notepad.exe" to the command queue with "C:\test document.txt" as an argument, with the description "Notepad Test" and start the queue running if it isn't already.

**Note: CmdQueue.exe will need to be in your system PATH environment variable to use on the command-line without the full path to the .exe every time.**

## (Un)License

This is free and unencumbered software released into the public domain.

Anyone is free to copy, modify, publish, use, compile, sell, or distribute this software, either in source code form or as a compiled binary, for any purpose, commercial or non-commercial, and by any means.

In jurisdictions that recognize copyright laws, the author or authors of this software dedicate any and all copyright interest in the software to the public domain. We make this dedication for the benefit of the public at large and to the detriment of our heirs and successors. We intend this dedication to be an overt act of relinquishment in perpetuity of all present and future rights to this software under copyright law.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

For more information, please refer to <http://unlicense.org/>
