﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Wpf;
using System.Drawing;
using System.Windows.Media;
using LiveCharts.Defaults;
using System.Windows;
using ZedGraph;

namespace BlinkBlink_EyeJoah.Chart.PieChart
{
    public partial class DoughnutExample : Form
    {
        public static DoughnutExample doughnut;

        public DoughnutExample()
        {
            doughnut = this;
            
            InitializeComponent();
             
            pieChart1.InnerRadius = 40;
            pieChart1.Series = new SeriesCollection
            {
                new PieSeries
                {
                    Title = "Great",
                    Values = new ChartValues<double> {0}, //값
                    //PushOut = 5, //pushout:: 슬라이스와 슬라이스 사이 간격
                    DataLabels = true,
                    Fill=new SolidColorBrush(System.Windows.Media.Color.FromRgb(1,85,157)),
                },
                new PieSeries
                {
                    Title = "Normal",
                    Values = new ChartValues<double> {0},
                    //PushOut = 5,
                    DataLabels = true,
                        Fill=new SolidColorBrush(System.Windows.Media.Color.FromRgb(0,171,188))
                },
                new PieSeries
                {
                    Title = "Warning",
                    Values = new ChartValues<double> {0},
                    //PushOut = 5,
                    DataLabels = true,
                      Fill=new SolidColorBrush(System.Windows.Media.Color.FromRgb(222,111,39))
                },
            };

        }

        public void updateBlinkPie(double great, double normal, double bad)
        {
            double sum = great + normal + bad;
            double greatArea = Math.Round(great/sum / .01) * .01;
            double normalArea = Math.Round(normal/sum / .01) * .01;
            double badArea = Math.Round(bad/sum / .01) * .01;

            pieChart1.DefaultLegend.Visibility = Visibility.Collapsed;
            pieChart1.DefaultLegend.FontSize = 15;
            pieChart1.DefaultLegend.FontWeight = FontWeights.Bold;
            pieChart1.LegendLocation = LiveCharts.LegendLocation.Bottom;
            //pieChart1.DefaultLegend.BorderThickness = new Thickness(2);
            pieChart1.Series = new SeriesCollection
            {
                new PieSeries
                {
                    Title = "Great",
                    Values = new ChartValues<ObservableValue>
                    {
                        new ObservableValue(greatArea*100),
                    },
                    DataLabels = true,
                    LabelPoint = point => point.Y + "%",
                    FontSize = 19,
                    Fill=new SolidColorBrush(System.Windows.Media.Color.FromRgb(1,85,157))
                    //PushOut = 5, // 슬라이스와 슬라이스 사이 간격
                },
                new PieSeries
                {
                    Title = "Normal",
                    Values = new ChartValues<ObservableValue>
                    {
                        new ObservableValue(normalArea*100),
                    },
                    DataLabels = true,
                    LabelPoint = point => point.Y + "%",
                    FontSize = 19,
                    Fill=new SolidColorBrush(System.Windows.Media.Color.FromRgb(0,171,188))
                },
                new PieSeries
                {
                    Title = "Warning",

                    Values = new ChartValues<ObservableValue>
                    {
                        new ObservableValue(badArea*100),
                    },
                    DataLabels = true,
                    LabelPoint = point => point.Y + "%",
                    FontSize = 19,
                    Fill=new SolidColorBrush(System.Windows.Media.Color.FromRgb(222,111,39))
                },
            };
        }
    }
}
