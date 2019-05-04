﻿using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazui.Component.Radio
{
    public class RadioBase : ComponentBase
    {
        [Parameter]
        public RenderFragment ChildContent { get; set; }

        [Parameter]
        public EventCallback<string> SelectedValueChanged { get; set; }
        [Parameter]
        public string SelectedValue { get; set; }

        [Parameter]
        public string Value { get; set; }
        

        protected void OnRadioChanged(UIMouseEventArgs e)
        {
            SelectedValue = Value;
        }
    }
}
