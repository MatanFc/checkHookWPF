using System;
using System.Windows;
//using System.Windows.Input;
using System.Windows.Forms;

namespace CheckHookOnWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        globalKeyboardHook gkh = new globalKeyboardHook();


        public MainWindow()
        {
            InitializeComponent();

            Loaded += new RoutedEventHandler(Wpf_Load);
        }

        private void Wpf_Load(object sender, EventArgs e)
        {
            gkh.HookedKeys.Add(Keys.LWin);
            gkh.HookedKeys.Add(Keys.RWin);
            gkh.HookedKeys.Add(Keys.Escape);
            gkh.HookedKeys.Add(Keys.Alt);
            gkh.HookedKeys.Add(Keys.LControlKey);
            gkh.HookedKeys.Add(Keys.RControlKey);
            gkh.HookedKeys.Add(Keys.Control);
            gkh.HookedKeys.Add(Keys.ControlKey);
            gkh.HookedKeys.Add(Keys.LShiftKey);
            gkh.HookedKeys.Add(Keys.RShiftKey);
            gkh.HookedKeys.Add(Keys.Shift);
            gkh.HookedKeys.Add(Keys.F4);
            gkh.HookedKeys.Add(Keys.Delete);

            gkh.KeyDown += new KeyEventHandler(gkh_KeyDown);
            gkh.KeyUp += new KeyEventHandler(gkh_KeyUp);
        }

        void gkh_KeyUp(object sender, KeyEventArgs e)
        {
            //lstLog.Items.Add("Up\t" + e.KeyCode.ToString());
            e.Handled = true;
        }

        void gkh_KeyDown(object sender, KeyEventArgs e)
        {
            //lstLog.Items.Add("Down\t" + e.KeyCode.ToString());
            e.Handled = true;
        }
    }
}
