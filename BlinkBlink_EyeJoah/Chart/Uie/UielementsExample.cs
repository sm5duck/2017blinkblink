﻿using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using LiveCharts;
using LiveCharts.Wpf;
using Brushes = System.Windows.Media.Brushes;
using HorizontalAlignment = System.Windows.HorizontalAlignment;
using Panel = System.Windows.Controls.Panel;

namespace BlinkBlink_EyeJoah.Chart.Uie
{
    public partial class UielementsExample : Form
    {
        public static UielementsExample uiElement;

        ColumnSeries barSeries;
        ChartValues<double> Values;
       
        public UielementsExample()
        {
            uiElement = this;

            InitializeComponent();
            
            barSeries = new ColumnSeries //막대그래프
            {
                //Values = new ChartValues<double> { 5, 6, 9, 8, 10 },
                Values = new ChartValues<double> { 0, 0, 0, 0, 0 },
                StrokeThickness = 1.5,
                PointGeometry = null,
                MaxColumnWidth = 25,
                 
                Stroke = new SolidColorBrush(Colors.AliceBlue), //가장자리 색상
                Fill = new LinearGradientBrush
                {
                    GradientStops = new GradientStopCollection
                                                                    {
                                                                         new GradientStop(System.Windows.Media.Color.FromRgb(8,80,120),1),
                                                                         new GradientStop(System.Windows.Media.Color.FromRgb(72,149,164),.5),
                                                                         new GradientStop(System.Windows.Media.Color.FromRgb(133,216,206),0)
                                                                    }
                }
            };

            cartesianChart1.Series.Add(barSeries);

            cartesianChart1.VisualElements.Add(new VisualElement
            {
                X = 0.9,
                Y = 8.5,
                HorizontalAlignment = HorizontalAlignment.Center,
                VerticalAlignment = VerticalAlignment.Top,
                UIElement = new TextBlock //notice this property must be a wpf control
                {
                    Text = "WARNING",
                    FontWeight = FontWeights.Bold,
                    FontSize = 16,
                    Foreground = new SolidColorBrush(Color.FromRgb(208, 54, 0)),
                }
            });
            cartesianChart1.VisualElements.Add(new VisualElement
            {
                X = 0.5,
                Y = 14,
                HorizontalAlignment = HorizontalAlignment.Center,
                VerticalAlignment = VerticalAlignment.Top,
                UIElement = new TextBlock //notice this property must be a wpf control
                {
                    Text = "GREAT",
                    FontWeight = FontWeights.Bold,
                    FontSize = 16,
                    Foreground = new SolidColorBrush(Color.FromRgb(1, 85, 157)),
                }
            });
            var uri = new Uri("Cartesian/UielementsExample/warning.png", UriKind.Relative);
            cartesianChart1.VisualElements.Add(new VisualElement
            {
                X = 2.5,
                Y = 8,
                HorizontalAlignment = HorizontalAlignment.Center,
                VerticalAlignment = VerticalAlignment.Bottom,
                UIElement = new System.Windows.Controls.Image
                {
                    Source = new BitmapImage(uri),
                    Width = 40,
                    Height = 40
                }
            });

            //good or bad 영역에 따른 색
            cartesianChart1.AxisY.Add(new Axis
            {
                MinValue = 6,
                MaxValue = 20,
                Foreground = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(1, 1, 1)),
                Separator = new LiveCharts.Wpf.Separator
                {
                    Step = 2,
                    IsEnabled = false
                },
                Sections = new SectionsCollection
                {
                    //warning 점선
                    new AxisSection
                    {
                        Value = 10,
                        //Stroke = Brushes.Crimson,
                        Stroke=new SolidColorBrush(Color.FromRgb(222,111,39)),
                        StrokeThickness = 4,
                        StrokeDashArray = new DoubleCollection(new [] {2d})
                    },
                    //Goog 점선
                    new AxisSection
                    {
                        Value = 14,
                        //Stroke = Brushes.Crimson,
                        Stroke=new SolidColorBrush(Color.FromRgb(1,85,157)),
                        StrokeThickness = 4,
                        StrokeDashArray = new DoubleCollection(new [] {2d})
                    },
                    //good 영역
                        new AxisSection
                    {
                        //Label = "Good",
                        Value = 14,

                        SectionWidth = 6,
                        Fill = new SolidColorBrush
                        {
                            //Color=Colors.White,
                            Color = System.Windows.Media.Color.FromRgb(1,85,157),
                            Opacity = .3
                        }
                    },
                    // normal 영역
                        new AxisSection
                    {
                        //Label = "Good",
                        Value = 10,
                        SectionWidth = 4,
                        Fill = new SolidColorBrush
                        {
                            //Color=Colors.White,
                            Color = System.Windows.Media.Color.FromRgb(0,171,188),
                            Opacity = .2
                        }
                    },
                    //bad 영역
                    new AxisSection
                    {
                        //Label = "Bad",
                        Value = 0,
                        SectionWidth = 10,
                        Fill = new SolidColorBrush
                        {
                            Color = System.Windows.Media.Color.FromRgb(234,168,101),
                            Opacity = .4
                        }
                    }
                }
            });
            cartesianChart1.AxisX.Add(new Axis
            {
                Separator = new LiveCharts.Wpf.Separator
                {
                    Step = 1,
                    IsEnabled = false
                },
                Foreground = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(1, 1, 1)),
                Labels = new[] { "10:30", "40", "50", "11:00", "10 ", "20", "11:30", "40", "50" } //마우스 가까이댔을때 뜨는 라벨
            });
            Panel.SetZIndex(barSeries, 0);
        }

        public void updateBlinkBarValue(double a, double b, double c, double d, double e, double f, double g, double h, double i)
        {
            barSeries.Values = new ChartValues<double> { a,b,c,d,e,f,g,h,i };
        }

    }



}