﻿#pragma checksum "D:\Test\SilverlightMap\SilverlightMap\PushPinPopup.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "F72A454C9F834164812F63153A702929"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.235
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

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


namespace ExsunSilverlightMap {
    
    
    public partial class PushPinPopup : System.Windows.Controls.Grid {
        
        internal System.Windows.Controls.Grid popup;
        
        internal System.Windows.Media.Animation.Storyboard Storyboard1;
        
        internal System.Windows.Media.Animation.Storyboard Storyboard2;
        
        internal System.Windows.Controls.Grid info;
        
        internal System.Windows.Controls.TextBlock txtTitle;
        
        internal System.Windows.Controls.HyperlinkButton hlbClose;
        
        internal System.Windows.Controls.TextBlock txtContent;
        
        internal System.Windows.Controls.HyperlinkButton hbToHistory;
        
        internal System.Windows.Controls.Grid history;
        
        internal System.Windows.Controls.TextBlock txtTitle2;
        
        internal System.Windows.Controls.HyperlinkButton hlbClose2;
        
        internal System.Windows.Controls.HyperlinkButton hbToCurrent;
        
        internal System.Windows.Controls.DatePicker dpStart;
        
        internal System.Windows.Controls.DatePicker dpEnd;
        
        internal System.Windows.Controls.TextBlock textBlock1;
        
        internal System.Windows.Controls.TextBlock textBlock2;
        
        internal System.Windows.Controls.Button btnOK;
        
        internal System.Windows.Controls.ComboBox cmbStartTime;
        
        internal System.Windows.Controls.ComboBox cmbEndTime;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/ExsunSilverlightMap;component/PushPinPopup.xaml", System.UriKind.Relative));
            this.popup = ((System.Windows.Controls.Grid)(this.FindName("popup")));
            this.Storyboard1 = ((System.Windows.Media.Animation.Storyboard)(this.FindName("Storyboard1")));
            this.Storyboard2 = ((System.Windows.Media.Animation.Storyboard)(this.FindName("Storyboard2")));
            this.info = ((System.Windows.Controls.Grid)(this.FindName("info")));
            this.txtTitle = ((System.Windows.Controls.TextBlock)(this.FindName("txtTitle")));
            this.hlbClose = ((System.Windows.Controls.HyperlinkButton)(this.FindName("hlbClose")));
            this.txtContent = ((System.Windows.Controls.TextBlock)(this.FindName("txtContent")));
            this.hbToHistory = ((System.Windows.Controls.HyperlinkButton)(this.FindName("hbToHistory")));
            this.history = ((System.Windows.Controls.Grid)(this.FindName("history")));
            this.txtTitle2 = ((System.Windows.Controls.TextBlock)(this.FindName("txtTitle2")));
            this.hlbClose2 = ((System.Windows.Controls.HyperlinkButton)(this.FindName("hlbClose2")));
            this.hbToCurrent = ((System.Windows.Controls.HyperlinkButton)(this.FindName("hbToCurrent")));
            this.dpStart = ((System.Windows.Controls.DatePicker)(this.FindName("dpStart")));
            this.dpEnd = ((System.Windows.Controls.DatePicker)(this.FindName("dpEnd")));
            this.textBlock1 = ((System.Windows.Controls.TextBlock)(this.FindName("textBlock1")));
            this.textBlock2 = ((System.Windows.Controls.TextBlock)(this.FindName("textBlock2")));
            this.btnOK = ((System.Windows.Controls.Button)(this.FindName("btnOK")));
            this.cmbStartTime = ((System.Windows.Controls.ComboBox)(this.FindName("cmbStartTime")));
            this.cmbEndTime = ((System.Windows.Controls.ComboBox)(this.FindName("cmbEndTime")));
        }
    }
}

