﻿using System.Windows;
using System.Windows.Forms;
using System.Windows.Media;

namespace BlinkBlink_EyeJoah.Chart._360
{
    public partial class Gauge360Example : Form
    {
        public Gauge360Example()
        {
            InitializeComponent();
            
            //standard gauge
            solidGauge5.From = 0;
            solidGauge5.To = 100;
            solidGauge5.Value = 50;

            //custom fill
            solidGauge5.From = 0;
            solidGauge5.To = 100;
            solidGauge5.Value = 50;
            solidGauge5.Base.LabelsVisibility = Visibility.Hidden;
            solidGauge5.Base.GaugeActiveFill = new LinearGradientBrush
            {
                GradientStops = new GradientStopCollection
                {
                    new GradientStop(Colors.Yellow, 0),
                    new GradientStop(Colors.Orange, .5),
                    new GradientStop(Colors.Red, 1)
                }
            };

            //standard gauge
            solidGauge6.From = 0;
            solidGauge6.To = 100;
            solidGauge6.Value = 50;

            //custom fill
            solidGauge6.From = 0;
            solidGauge6.To = 100;
            solidGauge6.Value = 50;
            solidGauge6.Base.LabelsVisibility = Visibility.Hidden;
            solidGauge6.Base.GaugeActiveFill = new LinearGradientBrush
            {
                GradientStops = new GradientStopCollection
                {
                    new GradientStop(Colors.Yellow, 0),
                    new GradientStop(Colors.Orange, .5),
                    new GradientStop(Colors.Red, 1)
                }
            };

            //standard gauge
            solidGauge7.From = 0;
            solidGauge7.To = 100;
            solidGauge7.Value = 50;

            //custom fill
            solidGauge7.From = 0;
            solidGauge7.To = 100;
            solidGauge7.Value = 50;
            solidGauge7.Base.LabelsVisibility = Visibility.Hidden;
            solidGauge7.Base.GaugeActiveFill = new LinearGradientBrush
            {
                GradientStops = new GradientStopCollection
                {
                    new GradientStop(Colors.Yellow, 0),
                    new GradientStop(Colors.Orange, .5),
                    new GradientStop(Colors.Red, 1)
                }
            };

        }
    }
}