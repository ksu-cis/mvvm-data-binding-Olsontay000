using System;
using System.Collections.Generic;
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
using CashRegister;

namespace MVVMDataBinding
{
    /// <summary>
    /// Interaction logic for DollarControl.xaml
    /// </summary>
    public partial class DollarControl : UserControl
    {
        /// <summary>
        /// The DependencyProperty for the DenominationProperty
        /// </summary>
        public static readonly DependencyProperty DenominationProperty =
            DependencyProperty.Register(
                    "Denomination",
                    typeof(Bills),
                    typeof(DollarControl),
                    new PropertyMetadata(Bills.One)
                );
        /// <summary>
        /// Them Denomination this control displays and modifies
        /// </summary>
        public Bills Denomination
        {
            get
            {
                return (Bills)GetValue(DenominationProperty);
            }
            set
            {
                SetValue(DenominationProperty, value);
            }
        }

        /// <summary>
        /// The DependencyProperty for Quantity
        /// </summary>
        public static readonly DependencyProperty QuantityProperty =
            DependencyProperty.Register(
                "Quantity",
                typeof(int),
                typeof(DollarControl),
                new FrameworkPropertyMetadata(0, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault)
                );
        /// <summary>
        /// The Quantity this control displays and modifies
        /// </summary>
        public int Quantity
        {
            get => (int)GetValue(QuantityProperty);
            set => SetValue(QuantityProperty, value);
        }
        public DollarControl()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Event handler for increasing the amount of a coin
        /// </summary>
        /// <param name="sender">The button pressed</param>
        /// <param name="e">Event args</param>
        public void OnIncreaseClicked(object sender, RoutedEventArgs e)
        {
            Quantity++;
        }
        /// <summary>
        /// Event handler for decreasing the amount of a coin
        /// </summary>
        /// <param name="sender">The button pressed</param>
        /// <param name="e">Event args</param>
        public void OnDecreaseClicked(object sender, RoutedEventArgs e)
        {
            Quantity--;
        }
    }
}
