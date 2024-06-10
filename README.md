# AcrylicUI.Examples

## [Chapter 01 - Start](./Chapter01/Start/)

A Simple WebForms App with 2 way binding between TextBox and ViewModel that raises OnPropertyChanged Event.
Make Sure you build and run this version first and understand what's happening here with the 2 way binding.

## [Chapter 01 - Completed](./Chapter01/Completed/)

Modified to turn into an Acrylic UI App

Specifically:

 1. Change the Form to AcrylicForm
 1. Add AcrylicUI NuGet Package

This is all you need to get started. 


The following are necessary if you have a high DPI monitor (Basically, you are running your display higher than 1080p and have your scaling set to greater than 100%). 

 1. Change HighDpiMode.PerMonitorV2
 1. Set AutoScaleDimensions
 1. Set AutoScaleMode.Dpi

 This is necessary, or the designer will start to resize and change the scale and dimensions of your WinForms app and will totally mess up your display. 
 
 You can also Force the Designer to Dpi Unaware in the csproj file as follows: 
```
    <ApplicationHighDpiMode>SystemAware</ApplicationHighDpiMode>
    <ForceDesignerDpiUnaware>true</ForceDesignerDpiUnaware>
 ```
 Learn More about Dpi Unaware for the Designer [here](https://github.com/dotnet/winforms/blob/main/docs/designer/designer-high-dpi-mode.md
 )

Now, that we are finished with the setup, we can work on the asethetics:

 1. Reset the BackColor
 1. Make IsAcrylic true
 1. Label -> AcrylicLabel
 1. TextBox -> AcrylicTextbox 

That's it. Now build and run your first AcrylicUI App




