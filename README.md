# ⚙️ MemorySteps
Application used to record and execute a series of mouse clicks and key presses.

## Branches
master -> Electron UI - WIP

WPF -> dead/WIP

WinForms -> Working

## Description

Recording will store for each click:
 - The time in milliseconds until the next click
 - The position of the mouse cursor
 - A list of characters that have been pressed after the mouse click
 - The mouse button that was pressed
 
In the Home tab the "Launch test" will start the AutoClicker execution.
To start an execution a recording has to be manually configured or loaded first.

A manual recording can be started by pressing the "Start manual configuration" button in the 
configuration tab. After the press the form will disappear and the application will start
recording the mouse clicks and key presses. Recording session will end when the ` key has
been pressed. Recordings can be saved and loaded.

