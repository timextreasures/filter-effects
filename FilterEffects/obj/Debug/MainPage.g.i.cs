﻿#pragma checksum "C:\test_filter\FilterEffects_v1_0\FilterEffects\FilterEffects\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "3C81F20B7BD554472A148D49AB4FEA9E"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18010
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace FilterEffects {
    
    
    public partial class MainPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Media.Animation.Storyboard CaptureAnimation;
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Canvas VideoCanvas;
        
        internal System.Windows.Media.VideoBrush BackgroundVideoBrush;
        
        internal System.Windows.Media.CompositeTransform VideoBrushTransform;
        
        internal System.Windows.Shapes.Rectangle TitleShade;
        
        internal Microsoft.Phone.Controls.Pivot TitleText;
        
        internal Microsoft.Phone.Shell.ApplicationBarIconButton CaptureButton;
        
        internal Microsoft.Phone.Shell.ApplicationBarIconButton LoadButton;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/FilterEffects;component/MainPage.xaml", System.UriKind.Relative));
            this.CaptureAnimation = ((System.Windows.Media.Animation.Storyboard)(this.FindName("CaptureAnimation")));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.VideoCanvas = ((System.Windows.Controls.Canvas)(this.FindName("VideoCanvas")));
            this.BackgroundVideoBrush = ((System.Windows.Media.VideoBrush)(this.FindName("BackgroundVideoBrush")));
            this.VideoBrushTransform = ((System.Windows.Media.CompositeTransform)(this.FindName("VideoBrushTransform")));
            this.TitleShade = ((System.Windows.Shapes.Rectangle)(this.FindName("TitleShade")));
            this.TitleText = ((Microsoft.Phone.Controls.Pivot)(this.FindName("TitleText")));
            this.CaptureButton = ((Microsoft.Phone.Shell.ApplicationBarIconButton)(this.FindName("CaptureButton")));
            this.LoadButton = ((Microsoft.Phone.Shell.ApplicationBarIconButton)(this.FindName("LoadButton")));
        }
    }
}
