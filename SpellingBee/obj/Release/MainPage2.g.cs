﻿#pragma checksum "C:\Users\Amrit Singh\Desktop\wp\SpellingBee\SpellingBee\MainPage2.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "5383A5B4E9AB1FFC32095E32AC41D2D4"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.32559
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
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


namespace SpellingBee {
    
    
    public partial class MainPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Media.Animation.Storyboard scoreplus;
        
        internal System.Windows.Media.Animation.Storyboard lifeplus;
        
        internal System.Windows.Media.Animation.Storyboard speakerplus2;
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.StackPanel TitlePanel;
        
        internal System.Windows.Controls.TextBlock scoredisplay;
        
        internal System.Windows.Controls.TextBlock lifedisplay;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.TextBlock wordGuessed;
        
        internal System.Windows.Controls.Image image1;
        
        internal System.Windows.Controls.Image image2;
        
        internal System.Windows.Controls.Image image3;
        
        internal System.Windows.Controls.Image image4;
        
        internal System.Windows.Controls.Image image;
        
        internal System.Windows.Controls.Image image5;
        
        internal System.Windows.Controls.MediaElement sound_main1;
        
        internal System.Windows.Controls.MediaElement sound_main2;
        
        internal System.Windows.Controls.MediaElement sound_main3;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/SpellingBee;component/MainPage2.xaml", System.UriKind.Relative));
            this.scoreplus = ((System.Windows.Media.Animation.Storyboard)(this.FindName("scoreplus")));
            this.lifeplus = ((System.Windows.Media.Animation.Storyboard)(this.FindName("lifeplus")));
            this.speakerplus2 = ((System.Windows.Media.Animation.Storyboard)(this.FindName("speakerplus2")));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.TitlePanel = ((System.Windows.Controls.StackPanel)(this.FindName("TitlePanel")));
            this.scoredisplay = ((System.Windows.Controls.TextBlock)(this.FindName("scoredisplay")));
            this.lifedisplay = ((System.Windows.Controls.TextBlock)(this.FindName("lifedisplay")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.wordGuessed = ((System.Windows.Controls.TextBlock)(this.FindName("wordGuessed")));
            this.image1 = ((System.Windows.Controls.Image)(this.FindName("image1")));
            this.image2 = ((System.Windows.Controls.Image)(this.FindName("image2")));
            this.image3 = ((System.Windows.Controls.Image)(this.FindName("image3")));
            this.image4 = ((System.Windows.Controls.Image)(this.FindName("image4")));
            this.image = ((System.Windows.Controls.Image)(this.FindName("image")));
            this.image5 = ((System.Windows.Controls.Image)(this.FindName("image5")));
            this.sound_main1 = ((System.Windows.Controls.MediaElement)(this.FindName("sound_main1")));
            this.sound_main2 = ((System.Windows.Controls.MediaElement)(this.FindName("sound_main2")));
            this.sound_main3 = ((System.Windows.Controls.MediaElement)(this.FindName("sound_main3")));
        }
    }
}

