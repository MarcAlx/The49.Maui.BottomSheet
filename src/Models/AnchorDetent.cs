﻿using Maui.BindableProperty.Generator.Core;

namespace The49.Maui.BottomSheet;

public partial class AnchorDetent: Detent
{
    double _height = 0;
    [AutoBindable]
    readonly VisualElement anchor;
    public override double GetHeight(BottomSheetPage page, double maxSheetHeight)
    {
        UpdateHeight(page, maxSheetHeight);
        return _height;
    }

    partial void UpdateHeight(BottomSheetPage page, double maxSheetHeight);
}
