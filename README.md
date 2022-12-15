# .NET MAUI Layouts [DotNet MAUI Layouts]

Watch Tutorial Video: https://www.youtube.com/watch?v=fR5I7NroL5s

 In this video, we'll discuss about different types of layouts [DotNet MAUI Layouts] that we can use in .NET MAUI. You'll learn how to create MAUI Responsive Layout.
 
 The demo project showing in the video is developed in Visual Studio 2022 with .NET 7 & C# (C Sharp).
 
 .NET Multi-platform App UI (.NET MAUI) layout classes allow you to arrange and group UI controls in your application. Choosing a layout class requires knowledge of how the layout positions its child elements, and how the layout sizes its child elements. In addition, it may be necessary to nest layouts to create your desired layout.

1. MAUI StackLayout:

DotNet MAUI StackLayout organizes elements in a one-dimensional stack, either horizontally or vertically. The Orientation property specifies the direction of the elements, and the default orientation is Vertical. StackLayout is typically used to arrange a subsection of the UI on a page.

1.a. MAUI VerticalStackLayout:

DotNet MAUI VerticalStackLayout organizes child views in a one-dimensional vertical stack, and is a more performant alternative to a StackLayout. In addition, a VerticalStackLayout can be used as a parent layout that contains other child layouts.

1.b. MAUI HorizontalStackLayout:

DotNet MAUI HorizontalStackLayout organizes child views in a one-dimensional horizontal stack, and is a more performant alternative to a StackLayout. In addition, a HorizontalStackLayout can be used as a parent layout that contains other child layouts.

2. MAUI Grid:

DotNet MAUI Grid, is a layout that organizes its children into rows and columns, which can have proportional or absolute sizes. By default, a Grid contains one row and one column. In addition, aGrid can be used as a parent layout that contains other child layouts.
The MAUI Grid should not be confused with tables, and is not intended to present tabular data. Unlike HTML tables, a Grid is intended for laying out content.

3. MAUI AbsoluteLayout:

DotNet MAUI AbsoluteLayout is used to position and size children using explicit values. The position is specified by the upper-left corner of the child relative to the upper-left corner of the AbsoluteLayout, in device-independent units. MAUI AbsoluteLayout also implements a proportional positioning and sizing feature. In addition, unlike some other layout classes, AbsoluteLayout is able to position children so that they overlap.
An AbsoluteLayout should be regarded as a special-purpose layout to be used only when you can impose a size on children, or when the element's size doesn't affect the positioning of other children.

4. MAUI FlexLayout:

DotNet MAUI FlexLayout is a layout that can arrange its children horizontally and vertically in a stack, and can also wrap its children if there are too many to fit in a single row or column. In addition, FlexLayout can control orientation and alignment, and adapt to different screen sizes.

#dotnetmaui #netmaui #visualstudio2022 #maui #codingdroplets #dotnet6 #dotnet7
