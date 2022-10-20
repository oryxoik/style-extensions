# Style Extensions
A collection of chainable extension methods for styling VisualElements (UIToolkit)

# Install
In the **Package Manager** (Window -> Package Manager), click the `+` icon then click the `Add package from git URL` and use the following link:
`https://github.com/ikr2202/style-extensions.git`

# Without StyleExtensions
```cs
var body = new VisualElement { name = "body" };
body.style.width = new Length(100, LengthUnit.Percent);
body.style.height = new Length(100, LengthUnit.Percent);
body.style.paddingBottom = 20;
body.style.paddingTop = 20;
body.style.paddingRight = 20;
body.style.paddingLeft = 20;
body.style.backgroundColor = new Color(0.15f, 0.15f, 0.15f);

var label = new Label { name = "label", text = "Label" };
label.style.width = new Length(100, LengthUnit.Percent);
label.style.fontSize = 32;
label.style.unityFontStyleAndWeight = FontStyle.Bold;
label.style.color = Color.black;
label.style.unityTextAlign = TextAnchor.MiddleCenter;
label.style.backgroundColor = new Color(0.61f, 0.86f, 0.99f);
label.style.borderTopLeftRadius = 5;
label.style.borderTopRightRadius = 5;
label.style.borderBottomLeftRadius = 5;
label.style.borderBottomRightRadius = 5;
label.style.marginBottom = 20;
label.style.marginTop = 20;
label.style.marginRight = 0;
label.style.marginLeft = 0;
```

# With StyleExtensions
```cs
var body = new VisualElement { name = "body" }
  .WidthPercent(100) 
  .HeightPercent(100)
  .Padding(20)
  .Background("#282828");
  
var label = new Label { name = "label", text = "Label" }
  .FullWidth() // Same as WidthPercent(100)
  .FontSize(32)
  .Bold()
  .Color(Color.black)
  .AlignTextMiddleCenter()
  .Background("#9cdcfe")
  .BorderRadius(5)
  .Margin(20, 0);
  
body.Add(label);
```
# Result
<img width="873" alt="demo" src="https://user-images.githubusercontent.com/102294393/196889613-caf8d575-5f33-4189-8a89-b961908d8f3b.png">
