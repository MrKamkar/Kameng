# Kameng - Kamkar engine
Kameng is a game engine that allows you to create a game that will also be an operating system. It works on a string array because cosmos does not support two-dimensional arrays.

To be able to use it, you must have:
-  Visual Studio with c# language support,
- Cosmos (C# Open Source Managed Operating System),
- Kameng source code with the path assigned to it in visual studio.

## To start
1. Create a new cosmos project
2. Write at the beginning `using KamengOS.Kameng;`

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
public const char Black = '0';
public const char DarkBlue = '1';
public const char DarkGreen = '2';
public const char DarkRed = '3';
public const char DarkMagenta = '4';
public const char DarkYellow = '5';
public const char Gray = '6';
public const char DarkGray = '7';
public const char Blue = '8';
public const char Green = 'A';
public const char Cyan = 'B';
public const char Red = 'C';
public const char Magenta = 'D';
public const char Yellow = 'E';
public const char White = 'F';
```

## Shape
shape is really the most important thing, it can be our character, background or whatever.

#### To create shape:
```cs
Shape <shape>;
```

#### To draw square in shape:
```cs
shape.DrawSquare(<x>, <y>, <side>, Colors.<color>);
```

#### To draw rectangle in shape:
```cs
shape.DrawRectangle(<x>, <y>, <width>, <height>, Colors.<color>);
```
