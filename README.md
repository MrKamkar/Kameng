# Kameng - Kamkar engine
Kameng is a game engine that allows you to create a game that will also be an operating system. It works on a string array because cosmos does not support two-dimensional arrays.

To be able to use it, you must have:
-  Visual Studio with c# language support,
- Cosmos (C# Open Source Managed Operating System),
- Kameng source code with the path assigned to it in visual studio.

## To start
1. Create a new cosmos project in Visual Studio
2. Write at the beginning `using Kameng` and `using `Kameng.<directory>;`

Now you are ready to start!

## Canvas
Canvas is something like a scene. You use it when you want to create a new drawing area.

#### To create canvas:
```cs
Canvas <canvas>;
```

#### To add (draw) something to canvas:
```cs
canvas.Draw(shape)
```
shape have to be an object from Shape class

#### To clear surface from canvas:
```cs
canvas.Clear();
```

#### To fill the canvas with some color
```cs
canvas.Fill(Colors.<color>)
```

`<color>` is a color from Colors.cs
##### All colors:
```cs
Black = '0';
DarkBlue = '1';
DarkGreen = '2';
DarkRed = '3';
DarkMagenta = '4';
DarkYellow = '5';
Gray = '6';
DarkGray = '7';
Blue = '8';
Green = 'A';
Cyan = 'B';
Red = 'C';
Magenta = 'D';
Yellow = 'E';
White = 'F';
```

## Shape
shape is really the most important thing, it can be our character, background or whatever.

#### To create shape:
```cs
Shape <shape>;
```

#### To draw square in shape:
```cs
shape.DrawSquare(<position>, <side>, Colors.<color>);
```

#### To draw rectangle in shape:
```cs
shape.DrawRectangle(<position>, <width>, <height>, Colors.<color>);
```
