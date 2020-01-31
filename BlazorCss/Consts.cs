using System.Runtime.Serialization;

namespace BlazorCss
{

    public class OverflowValue
    {
        public const string Visible = @"visible";
        public const string Scroll = @"scroll";
        public const string Hidden = @"hidden";
        public const string Auto = @"auto";
    }

    public class Display
    {
        public const string Inline = @"inline";
        public const string TableRowGroup = @"table-row-group";
        public const string TableRow = @"table-row";
        public const string TableHeaderGroup = @"table-header-group";
        public const string TableFooterGroup = @"table-footer-group";
        public const string TableColumnGroup = @"table-column-group";
        public const string TableColumn = @"table-column";
        public const string TableCell = @"table-cell";
        public const string TableCaption = @"table-caption";
        public const string Table = @"table";
        public const string RunIn = @"run-in";
        public const string None = @"none";
        public const string ListItem = @"list-item";
        public const string InlineTable = @"inline-table";
        public const string InlineFlex = @"inline-flex";
        public const string InlineBlock = @"inline-block";
        public const string InlineGrid = @"inline-grid";
        public const string Flex = @"flex";
        public const string Grid = @"grid";
        public const string Compact = @"compact";
        public const string Block = @"block";
    }

    public class Position
    {
        public const string Static = @"static";
        public const string Relative = @"relative";
        public const string Page = @"page";
        public const string Fixed = @"fixed";
        public const string Center = @"center";
        public const string Absolute = @"absolute";
    }

    public class Float
    {
        public const string None = @"none";
        public const string Right = @"right";
        public const string Left = @"left";
    }

    public class Clear
    {
        public const string None = @"none";
        public const string Right = @"right";
        public const string Left = @"left";
        public const string Both = @"both";
    }

    public class All
    {
        public const string Initial = @"initial";
        public const string Unset = @"unset";
        public const string Inherit = @"inherit";
    }

    public class AnimationDirection
    {
        public const string Normal = @"normal";
        public const string Reverse = @"reverse";
        public const string AlternateReverse = @"alternate-reverse";
        public const string Alternate = @"alternate";
    }

    public class AnimationFillMode
    {
        public const string None = @"none";
        public const string Forwards = @"forwards";
        public const string Both = @"both";
        public const string Backwards = @"backwards";
    }

    public class AnimationPlayMode
    {
        public const string Running = @"running";
        public const string Paused = @"paused";
    }

    public class Visibility
    {
        public const string Visible = @"visible";
        public const string Hidden = @"hidden";
        public const string Collapse = @"collapse";
    }

    public class BackfaceVisibility
    {
        public const string Visible = @"visible";
        public const string Hidden = @"hidden";
    }

    public class BackgroundAttachment
    {
        public const string Scroll = @"scroll";
        public const string Local = @"local";
        public const string Fixed = @"fixed";
    }

    public class BackgroundClip
    {
        public const string BorderBox = @"border-box";
        public const string PaddingBox = @"padding-box";
        public const string ContentBox = @"content-box";
    }

    public class BackgroundOrigin
    {
        public const string PaddingBox = @"padding-box";
        public const string ContentBox = @"content-box";
        public const string BorderBox = @"border-box";
    }

    public class BackgroundRepeat
    {
        public const string Repeat = @"repeat";
        public const string Space = @"space";
        public const string Round = @"round";
        public const string RepeatY = @"repeat-y";
        public const string RepeatX = @"repeat-x";
        public const string Repeat_noRepeat = @"repeat no-repeat";
        public const string NoRepeat = @"no-repeat";
    }

    public class BorderCollapse
    {
        public const string Separate = @"separate";
        public const string Collapse = @"collapse";
    }

    public class BorderImageRepeat
    {
        public const string Stretch = @"stretch";
        public const string Space = @"space";
        public const string Round = @"round";
        public const string Repeat = @"repeat";
    }

    public class BoxDecorationBreak
    {
        public const string Slice = @"slice";
        public const string Clone = @"clone";
    }

    public class BoxSizing
    {
        public const string ContentBox = @"content-box";
        public const string PaddingBox = @"padding-box";
        public const string BorderBox = @"border-box";
    }

    public class BreakBefore
    {
        public const string Auto = @"auto";
        public const string Right = @"right";
        public const string Page = @"page";
        public const string Left = @"left";
        public const string Column = @"column";
        public const string AvoidPage = @"avoid-page";
        public const string AvoidColumn = @"avoid-column";
        public const string Avoid = @"avoid";
        public const string Always = @"always";
    }

    public class BreakAfter
    {
        public const string Auto = @"auto";
        public const string Right = @"right";
        public const string Page = @"page";
        public const string Left = @"left";
        public const string Column = @"column";
        public const string AvoidPage = @"avoid-page";
        public const string AvoidColumn = @"avoid-column";
        public const string Avoid = @"avoid";
        public const string Always = @"always";
    }

    public class BreakInside
    {
        public const string Auto = @"auto";
        public const string AvoidPage = @"avoid-page";
        public const string AvoidColumn = @"avoid-column";
        public const string Avoid = @"avoid";
    }

    public class CaptionSide
    {
        public const string Top = @"top";
        public const string Bottom = @"bottom";
    }

    public class ClearAfter
    {
        public const string None = @"none";
        public const string Top = @"top";
        public const string Start = @"start";
        public const string Right = @"right";
        public const string Outside = @"outside";
        public const string Left = @"left";
        public const string Inside = "inside";
        public const string End = "end";
        public const string Descendants = "descendants";
        public const string Bottom = "bottom";
        public const string Both = "both";
    }

    public class ColumnFill
    {
        public const string Balance = "balance";
        public const string Auto = "auto";
    }

    public class ColumnSpan
    {
        public const string None = "none";
        public const string All = "all";
    }

    public class ColumnRuleStyle
    {
        public const string None = "none";
        public const string Solid = "solid";
        public const string Ridge = "ridge";
        public const string Outset = "outset";
        public const string Inset = "inset";
        public const string Hidden = "hidden";
        public const string Groove = "groove";
        public const string Double = "double";
        public const string Dotted = "dotted";
        public const string Dashed = "dashed";
    }

    public class EmptyCells
    {
        public const string Show = "show";
        public const string Hide = "hide";
    }

    public class FlexDirection
    {
        public const string Row = "row";
        public const string RowReverse = "row-reverse";
        public const string ColumnReverse = "column-reverse";
        public const string Column = "column";
    }

    public class FlexWrap
    {
        public const string Nowrap = "nowrap";
        public const string WrapReverse = "wrap-reverse";
        public const string Wrap = "wrap";
    }

    public class JustifyContent
    {
        public const string FlexStart = "flex-start";
        public const string SpaceBetween = "space-between";
        public const string SpaceAround = "space-around";
        public const string FlexEnd = "flex-end";
        public const string Center = "center";
    }

    public class AlignItems
    {
        public const string Stretch = "stretch";
        public const string FlexStart = "flex-start";
        public const string FlexEnd = "flex-end";
        public const string Center = "center";
        public const string Baseline = "baseline";
    }

    public class AlignSelf
    {
        public const string Auto = "auto";
        public const string Stretch = "stretch";
        public const string FlexStart = "flex-start";
        public const string FlexEnd = "flex-end";
        public const string Center = "center";
        public const string Baseline = "baseline";
    }

    public class AlignContent
    {
        public const string Stretch = "stretch";
        public const string SpaceBetween = "space-between";
        public const string SpaceAround = "space-around";
        public const string FlexStart = "flex-start";
        public const string FlexEnd = "flex-end";
        public const string Center = "center";
    }

    public class FontStretch
    {
        public const string Normal = "normal";
        public const string UltraExpanded = "ultra-expanded";
        public const string UltraCondensed = "ultra-condensed";
        public const string SemiExpanded = "semi-expanded";
        public const string SemiCondensed = "semi-condensed";
        public const string ExtraExpanded = "extra-expanded";
        public const string ExtraCondensed = "extra-condensed";
        public const string Expanded = "expanded";
        public const string Condensed = "condensed";
    }

    public class FontSynthesis
    {
        public const string Weight_style = "weight style";
        public const string Weight = "weight";
        public const string Style = "style";
        public const string None = "none";
    }

    public class FontKerning
    {
        public const string Auto = "auto";
        public const string Normal = "normal";
        public const string None = "none";
    }

    public class FontVariant
    {
        public const string Normal = "normal";
        public const string Unicase = "unicase";
        public const string TitlingCaps = "titling-caps";
        public const string SmallCaps = "small-caps";
        public const string PetiteCaps = "petite-caps";
        public const string AllSmallCaps = "all-small-caps";
        public const string AllPetiteCaps = "all-petite-caps";
    }

    public class FontVariantCaps
    {
        public const string Normal = "normal";
        public const string Unicase = "unicase";
        public const string TitlingCaps = "titling-caps";
        public const string SmallCaps = "small-caps";
        public const string PetiteCaps = "petite-caps";
        public const string AllSmallCaps = "all-small-caps";
        public const string AllPetiteCaps = "all-petite-caps";
    }

    public class FontStyle
    {
        public const string Normal = "normal";
        public const string Oblique = "oblique";
        public const string Italic = "italic";
    }

    public class FontWeight
    {
        public const string Normal = "normal";
        public const string Lighter = "lighter";
        public const string Bolder = "bolder";
        public const string Bold = "bold";
    }

    public class HangingPunctuation
    {
        public const string None = "none";
        public const string Last_forceEnd = "last force-end";
        public const string Last_allowEnd = "last allow-end";
        public const string Last = "last";
        public const string ForceEnd = "force-end";
        public const string First_forceEnd = "first force-end";
        public const string First_allowEnd = "first allow-end";
        public const string First = "first";
        public const string AllowEnd = "allow-end";
    }

    public class Hyphens
    {
        public const string Manual = "manual";
        public const string None = "none";
        public const string Auto = "auto";
    }

    public class ImageResolution
    {
        public const string _1dppx = "1dppx";
        public const string FromImage = "from-image";
    }

    public class LineBreak
    {
        public const string Auto = "auto";
        public const string Strict = "strict";
        public const string Normal = "normal";
        public const string Loose = "loose";
    }

    public class ListStylePosition
    {
        public const string Outside = "outside";
        public const string Inside = "inside";
    }

    public class ListStyleType
    {
        public const string Disc = "disc";
        public const string UpperRoman = "upper-roman";
        public const string UpperLatin = "upper-latin";
        public const string UpperAlpha = "upper-alpha";
        public const string Square = "square";
        public const string None = "none";
        public const string LowerRoman = "lower-roman";
        public const string LowerLatin = "lower-latin";
        public const string LowerGreek = "lower-greek";
        public const string LowerAlpha = "lower-alpha";
        public const string Georgian = "georgian";
        public const string DecimalLeadingZero = "decimal-leading-zero";
        public const string Decimal = "decimal";
        public const string Circle = "circle";
        public const string Armenian = "armenian";
    }

    public class ObjectFit
    {
        public const string Fill = "fill";
        public const string ScaleDown = "scale-down";
        public const string None = "none";
        public const string Cover = "cover";
        public const string Contain = "contain";
    }

    public class OutlineStyle
    {
        public const string None = "none";
        public const string Solid = "solid";
        public const string Ridge = "ridge";
        public const string Outset = "outset";
        public const string Inset = "inset";
        public const string Groove = "groove";
        public const string Double = "double";
        public const string Dotted = "dotted";
        public const string Dashed = "dashed";
        public const string Auto = "auto";
    }

    public class OverflowWrap
    {
        public const string Normal = "normal";
        public const string BreakWord = "break-word";
    }

    public class PageBreakAfter
    {
        public const string Auto = "auto";
        public const string Right = "right";
        public const string Left = "left";
        public const string Avoid = "avoid";
        public const string Always = "always";
    }

    public class PageBreakBefore
    {
        public const string Auto = "auto";
        public const string Right = "right";
        public const string Left = "left";
        public const string Avoid = "avoid";
        public const string Always = "always";
    }

    public class PageBreakInside
    {
        public const string Auto = "auto";
        public const string Avoid = "avoid";
    }

    public class PointerEvents
    {
        public const string Auto = "auto";
        public const string None = "none";
    }

    public class Resize
    {
        public const string None = "none";
        public const string Vertical = "vertical";
        public const string Horizontal = "horizontal";
        public const string Alwbothays = "alwbothays";
    }

    public class TableLayout
    {
        public const string Auto = "auto";
        public const string Fixed = "fixed";
    }

    public class TextAlignLast
    {
        public const string Auto = "auto";
        public const string Start = "start";
        public const string Right = "right";
        public const string Left = "left";
        public const string Justify = "justify";
        public const string End = "end";
        public const string Center = "center";
    }

    public class TextDecorationLine
    {
        public const string None = "none";
        public const string Underline = "underline";
        public const string Overline = "overline";
        public const string LineThrough = "line-through";
        public const string Blink = "blink";
    }

    public class TextDecorationSkip
    {
        public const string None = "none";
        public const string Spaces = "spaces";
        public const string Objects = "objects";
        public const string Ink = "ink";
        public const string Edges = "edges";
        public const string BoxDecoration = "box-decoration";
    }

    public class TextDecorationPosition
    {
        public const string Auto = "auto";
        public const string Under_right = "under right";
        public const string Under_left = "under left";
        public const string Under = "under";
        public const string Right = "right";
        public const string Left = "left";
    }

    public class TextDecorationStyle
    {
        public const string Solid = "solid";
        public const string Wavy = "wavy";
        public const string Double = "double";
        public const string Dotted = "dotted";
        public const string Dashed = "dashed";
    }

    public class TextEmphasisPosition
    {
        public const string Over_right = "over right";
        public const string Over_left = "over left";
        public const string Below_right = "below right";
        public const string Below_left = "below left";
    }

    public class TextJustify
    {
        public const string Auto = "auto";
        public const string None = "none";
        public const string InterWord = "inter-word";
        public const string Distribute = "distribute";
    }

    public class TextOrientation
    {
        public const string Mixed = "mixed";
        public const string UseGlyphOrientation = "use-glyph-orientation";
        public const string Upright = "upright";
        public const string SidewaysRight = "sideways-right";
        public const string SidewaysLeft = "sideways-left";
        public const string Sideways = "sideways";
    }

    public class TransformStyle
    {
        public const string Flat = "flat";
        public const string Preserve3d = "preserve-3d";
    }

    public class TextTransform
    {
        public const string None = "none";
        public const string Uppercase = "uppercase";
        public const string Lowercase = "lowercase";
        public const string FullWidth = "full-width";
        public const string Capitalize = "capitalize";
    }

    public class UnicodeBidi
    {
        public const string Normal = "normal";
        public const string Embed = "embed";
        public const string BidiOverride = "bidi-override";
    }

    public class WhiteSpace
    {
        public const string Normal = "normal";
        public const string PreWrap = "pre-wrap";
        public const string PreLine = "pre-line";
        public const string Pre = "pre";
        public const string Nowrap = "nowrap";
    }

    public class WordBreak
    {
        public const string Normal = "normal";
        public const string KeepAll = "keep-all";
        public const string BreakAll = "break-all";
    }

    public class WordWrap
    {
        public const string Normal = "normal";
        public const string BreakWord = "break-word";
    }

    public class WritingMode
    {
        public const string HorizontalTb = "horizontal-tb";
        public const string VerticalRl = "vertical-rl";
        public const string VerticalLr = "vertical-lr";
    }

    public class Colors
    {
        public const string AliceBlue = "AliceBlue";
        public const string AntiqueWhite = "AntiqueWhite";
        public const string Aqua = "Aqua";
        public const string Aquamarine = "Aquamarine";
        public const string Azure = "Azure";
        public const string Beige = "Beige";
        public const string Bisque = "Bisque";
        public const string Black = "Black";
        public const string BlanchedAlmond = "BlanchedAlmond";
        public const string Blue = "Blue";
        public const string BlueViolet = "BlueViolet";
        public const string Brown = "Brown";
        public const string BurlyWood = "BurlyWood";
        public const string CadetBlue = "CadetBlue";
        public const string Chartreuse = "Chartreuse";
        public const string Chocolate = "Chocolate";
        public const string Coral = "Coral";
        public const string CornflowerBlue = "CornflowerBlue";
        public const string Cornsilk = "Cornsilk";
        public const string Crimson = "Crimson";
        public const string Cyan = "Cyan";
        public const string DarkBlue = "DarkBlue";
        public const string DarkCyan = "DarkCyan";
        public const string DarkGoldenRod = "DarkGoldenRod";
        public const string DarkGray = "DarkGray";
        public const string DarkGrey = "DarkGrey";
        public const string DarkGreen = "DarkGreen";
        public const string DarkKhaki = "DarkKhaki";
        public const string DarkMagenta = "DarkMagenta";
        public const string DarkOliveGreen = "DarkOliveGreen";
        public const string Darkorange = "Darkorange";
        public const string DarkOrchid = "DarkOrchid";
        public const string DarkRed = "DarkRed";
        public const string DarkSalmon = "DarkSalmon";
        public const string DarkSeaGreen = "DarkSeaGreen";
        public const string DarkSlateBlue = "DarkSlateBlue";
        public const string DarkSlateGray = "DarkSlateGray";
        public const string DarkSlateGrey = "DarkSlateGrey";
        public const string DarkTurquoise = "DarkTurquoise";
        public const string DarkViolet = "DarkViolet";
        public const string DeepPink = "DeepPink";
        public const string DeepSkyBlue = "DeepSkyBlue";
        public const string DimGray = "DimGray";
        public const string DimGrey = "DimGrey";
        public const string DodgerBlue = "DodgerBlue";
        public const string FireBrick = "FireBrick";
        public const string FloralWhite = "FloralWhite";
        public const string ForestGreen = "ForestGreen";
        public const string Fuchsia = "Fuchsia";
        public const string Gainsboro = "Gainsboro";
        public const string GhostWhite = "GhostWhite";
        public const string Gold = "Gold";
        public const string GoldenRod = "GoldenRod";
        public const string Gray = "Gray";
        public const string Grey = "Grey";
        public const string Green = "Green";
        public const string GreenYellow = "GreenYellow";
        public const string HoneyDew = "HoneyDew";
        public const string HotPink = "HotPink";
        public const string IndianRed = "IndianRed";
        public const string Indigo = "Indigo";
        public const string Ivory = "Ivory";
        public const string Khaki = "Khaki";
        public const string Lavender = "Lavender";
        public const string LavenderBlush = "LavenderBlush";
        public const string LawnGreen = "LawnGreen";
        public const string LemonChiffon = "LemonChiffon";
        public const string LightBlue = "LightBlue";
        public const string LightCoral = "LightCoral";
        public const string LightCyan = "LightCyan";
        public const string LightGoldenRodYellow = "LightGoldenRodYellow";
        public const string LightGray = "LightGray";
        public const string LightGrey = "LightGrey";
        public const string LightGreen = "LightGreen";
        public const string LightPink = "LightPink";
        public const string LightSalmon = "LightSalmon";
        public const string LightSeaGreen = "LightSeaGreen";
        public const string LightSkyBlue = "LightSkyBlue";
        public const string LightSlateGray = "LightSlateGray";
        public const string LightSlateGrey = "LightSlateGrey";
        public const string LightSteelBlue = "LightSteelBlue";
        public const string LightYellow = "LightYellow";
        public const string Lime = "Lime";
        public const string LimeGreen = "LimeGreen";
        public const string Linen = "Linen";
        public const string Magenta = "Magenta";
        public const string Maroon = "Maroon";
        public const string MediumAquaMarine = "MediumAquaMarine";
        public const string MediumBlue = "MediumBlue";
        public const string MediumOrchid = "MediumOrchid";
        public const string MediumPurple = "MediumPurple";
        public const string MediumSeaGreen = "MediumSeaGreen";
        public const string MediumSlateBlue = "MediumSlateBlue";
        public const string MediumSpringGreen = "MediumSpringGreen";
        public const string MediumTurquoise = "MediumTurquoise";
        public const string MediumVioletRed = "MediumVioletRed";
        public const string MidnightBlue = "MidnightBlue";
        public const string MintCream = "MintCream";
        public const string MistyRose = "MistyRose";
        public const string Moccasin = "Moccasin";
        public const string NavajoWhite = "NavajoWhite";
        public const string Navy = "Navy";
        public const string OldLace = "OldLace";
        public const string Olive = "Olive";
        public const string OliveDrab = "OliveDrab";
        public const string Orange = "Orange";
        public const string OrangeRed = "OrangeRed";
        public const string Orchid = "Orchid";
        public const string PaleGoldenRod = "PaleGoldenRod";
        public const string PaleGreen = "PaleGreen";
        public const string PaleTurquoise = "PaleTurquoise";
        public const string PaleVioletRed = "PaleVioletRed";
        public const string PapayaWhip = "PapayaWhip";
        public const string PeachPuff = "PeachPuff";
        public const string Peru = "Peru";
        public const string Pink = "Pink";
        public const string Plum = "Plum";
        public const string PowderBlue = "PowderBlue";
        public const string Purple = "Purple";
        public const string Red = "Red";
        public const string RosyBrown = "RosyBrown";
        public const string RoyalBlue = "RoyalBlue";
        public const string SaddleBrown = "SaddleBrown";
        public const string Salmon = "Salmon";
        public const string SandyBrown = "SandyBrown";
        public const string SeaGreen = "SeaGreen";
        public const string SeaShell = "SeaShell";
        public const string Sienna = "Sienna";
        public const string Silver = "Silver";
        public const string SkyBlue = "SkyBlue";
        public const string SlateBlue = "SlateBlue";
        public const string SlateGray = "SlateGray";
        public const string SlateGrey = "SlateGrey";
        public const string Snow = "Snow";
        public const string SpringGreen = "SpringGreen";
        public const string SteelBlue = "SteelBlue";
        public const string Tan = "Tan";
        public const string Teal = "Teal";
        public const string Thistle = "Thistle";
        public const string Tomato = "Tomato";
        public const string Turquoise = "Turquoise";
        public const string Violet = "Violet";
        public const string Wheat = "Wheat";
        public const string White = "White";
        public const string WhiteSmoke = "WhiteSmoke";
        public const string Yellow = "Yellow";
        public const string YellowGreen = "YellowGreen";
    }
}

