# Material Message Box

A WPF Message Box implementing material design.

Latest release link.
[![Release](https://img.shields.io/github/release/Gigas002/Material-Message-Box.svg)](https://github.com/Gigas002/Material-Message-Box/releases/latest)

:arrow_forward: [Download original package from Nuget](https://www.nuget.org/packages/MaterialMessageBox/)

:arrow_forward: Install from Package manager Console
> Install-Package MaterialMessageBox



## :sparkle: Main Features
The message box has the following custom features:

:white_check_mark: Material Theme design

:white_check_mark: Custom styles for border window, message foreground and background, etc

:white_check_mark: Button to copy message box details to clipboard

:white_check_mark: Scrollable message box content

:white_check_mark: Message content is .NET UIElement which can host any content



## :sparkle: Usage

> Creating a simple message box

```c#
MaterialMessageBox.Show("Your cool message here");
```
![Simple Message](./MaterialMessageBoxDemo/Screenshots/Simple-Message-Box.png?raw=true "Creating a simple message box")

> Showing an error message

```c#            
MaterialMessageBox.ShowError(@"This is an error message");
```
![Error Message](https://raw.github.com/Gigas002/Material-Message-Box/master/MaterialMessageBoxDemo/Screenshots/Error-Message-Box.png)


> Capturing Message Box Results

```c#    
var result = MaterialMessageBox.ShowWithCancel($"This is a simple message with a cancel button. You can listen to the return value");
```
![Capturing Message Box Results](https://raw.github.com/Gigas002/Material-Message-Box/master/MaterialMessageBoxDemo/Screenshots/Message-Box-With-Cancel-Button.png)


> Styling a message box

```c#    
CustomMaterialMessageBox msg = new CustomMaterialMessageBox
 {
    MessageTextBlock = { Text = "Do you like white wine?", Foreground = Brushes.White },
    OkButton = { Content = "Yes" },
    CancelButton = { Content = "Noooo" },
    MainGrid = { Background = Brushes.Red },
    BorderBrush = Brushes.BlueViolet,
    BorderThickness = new Thickness(4, 4, 4, 4)
};
msg.Show();
var results = msg.Result;
```
![Capturing Message Box Results](https://raw.github.com/Gigas002/Material-Message-Box/master/MaterialMessageBoxDemo/Screenshots/Styled-Message-Box.png)


## :sparkle: Contributing to this project
If you've improved Material Message Box and think that other people would enjoy it, submit a pull request. Anyone and everyone is welcome to contribute.

* You could always contact me through Email for any feature or issue. :star:

* You need [Visual Studio 2015 Community/Enterprise Edition](<https://www.visualstudio.com/>) to build the solution.


## :sparkle: Toolkits used
I have implemented these awesome toolkits while creating this control. Hands up to these guys who have made the most beautiful controls for WPF. They have crossed the oceans on foot!

- [mahApps.Metro](https://github.com/MahApps/MahApps.Metro) A toolkit for creating Metro/Modern UI styled WPF apps (used only in demo and original library by https://github.com/Denpalrius)
- [MaterialDesignInXamlToolkit](https://github.com/ButchersBoy/MaterialDesignInXamlToolkit) Google Material Design in XAML & WPF, for C# & VB.Net

----------

## :sparkle: Licence
The MIT License (MIT)

Copyright (c) 2016, Bespoke Fusion

Permission is hereby granted, free of charge, to any person obtaining a copy
 of this software and associated documentation files (the "Software"), to deal
 in the Software without restriction, including without limitation the rights
 to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 copies of the Software, and to permit persons to whom the Software is
 furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in
 all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
 THE SOFTWARE.



:heart:
