# Style Extensions
A collection of chainable extension methods for styling VisualElements (UIToolkit)

# Install
In the **Package Manager** (Window -> Package Manager), click the `+` icon then click the `Add package from git URL` and use the following link:
`https://github.com/ikr2202/style-extensions.git`

# Example
```cs
var body = new VisualElement { name = "body" }
  .FullWidth() // Same as WidthPercent(100)
  .FullHeight() // Same as HeightPercent(100)
  .Padding(20)
  .Background("#282828");
  
var label = new Label { name = "label", text = "Label" }
  .WidthPercent(100)
  .FontSize(32)
  .Bold()
  .Color(Color.black)
  .AlignTextMiddleCenter()
  .Background("#9cdcfe")
  .BorderRadius(5)
  .Margin(20, 0);
  
body.Add(label);
```

<img width="873" alt="demo" src="https://user-images.githubusercontent.com/102294393/196889613-caf8d575-5f33-4189-8a89-b961908d8f3b.png">
