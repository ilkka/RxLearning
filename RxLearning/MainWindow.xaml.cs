﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections.ObjectModel;

namespace RxLearning
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<String> _MessageCollection = new ObservableCollection<String>();
        
        public MainWindow()
        {
            InitializeComponent();
            _MessageCollection.Add("Moro");
        }

        public ObservableCollection<String> MessageCollection { get { return _MessageCollection; } }
    }
}
