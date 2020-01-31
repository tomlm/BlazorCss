<p align="center">
  <img src="https://github.com/tomlm/BlazorCss/raw/master/icon256.png"/>
</p>

# BlazorCss
This is a Blazor Library which adds data bound style rules to the BlazorStyled library (see https://blazorstyled.io/) 

With this library you get
* Component for defining a rule
* CSS properties are autocompleted
* Constants are available for auto completion

![alt text](https://github.com/tomlm/BlazorCss/raw/master/NameCompletion.png)
![alt text](https://github.com/tomlm/BlazorCss/raw/master/ValueCompletion.png)


## Installation
```
dotnet add package BlazorCss 
```

## Usage
There are 2 ways to use it, as a way to define the properties of the Styled component it is in, or as a way to define
a specific selector and the style properties of the selector.

### Root level rule
As a root level rule.  All attributes on the rule apply to the class name of the Styled tag

```html
<Styled @bind-ClassName="@foo">
    <Rule background="@Colors.Pink"
          display="@Display.Grid"
          height="300px" />
</Styled>
```

This generates:
```css
  .foo {
    background: Pink;
    display: grid;
    height: 300px;
  }
```

### Selector based rule
If you use the Selector attribute you can define a selector for the attributes.

```html
<Styled>
    <Rule Selector="#blat"
          display="grid"
          align_content="@AlignContent.SpaceAround"
          background="yellow" />
</Styled>
```

In this case it generates a CSS selector rule for the element with Id **blat**:
```css
  #blat {
    display: grid;
    background: yello;
    align-content: space-around;
  }
```
Any valid CSS selector can be put into the Selector property, such as 
* *div > a*
* *.foo,.bar*
* etc.

> NOTE: Backing properties in C# can't have a dash in the name, so the attributes with dash are represented with underscore.
> align_content ==> align-content in the css

