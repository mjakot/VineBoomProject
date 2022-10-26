using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace VineBoomProject
{
    public partial class MainWindow : Window
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"Resources/Sounds/Vine Boom Sound Effect.wav");
        DoubleAnimation fade = new DoubleAnimation()
        {
            From = 1,
            To = 0,
            Duration = new Duration(TimeSpan.FromMilliseconds(700))
        };

        public MainWindow()
        {
            InitializeComponent();
        }

        void OnClick(object sender, RoutedEventArgs e)
        {
            player.Play();
            image1.BeginAnimation(OpacityProperty, fade);
        }
    }
}
