using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;
using backend;

namespace PerfÆGt
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        private void softBoiled_Click(object sender, RoutedEventArgs e)
        {
            //Create Egg & add it to memory
            var egg = new Egg(400, "pretty LOL");
            (App.Current as App).EggOne = egg;
        }

        private void smilingBoiled_Click(object sender, RoutedEventArgs e)
        {
            var egg = new Egg(600, "Et smilende æg er så utroligt lækkert!");
        }

        private void hardboiled_Click(object sender, RoutedEventArgs e)
        {
            var egg = new Egg(800, "Et hårdkogt æg kan med fordel puttes i varmt vand.");
        }
    }
}