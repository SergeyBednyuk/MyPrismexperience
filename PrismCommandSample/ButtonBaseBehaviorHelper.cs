using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;

namespace PrismCommandSample
{
    public class ButtonBaseBehaviorHelper
    {
        private static readonly DependencyProperty ButtonCommandBehaviorProperty
            = DependencyProperty.RegisterAttached(
            "ButtonCommandBehavior",
            typeof(ButtonClickBehavior),
            typeof(ButtonBaseBehaviorHelper),
            null);

        public static readonly DependencyProperty CommandProperty
              = DependencyProperty.RegisterAttached(
              "Command",
              typeof(ICommand),
              typeof(ButtonBaseBehaviorHelper),
              new PropertyMetadata(OnSetCommandCallback));

        public static readonly DependencyProperty CommandParameterProperty
              = DependencyProperty.RegisterAttached(
              "CommandParameter",
              typeof(object),
              typeof(ButtonBaseBehaviorHelper),
              new PropertyMetadata(OnSetCommandParameterCallback));

        public static ICommand GetCommand(Control control)
        {
            return control.GetValue(CommandProperty) as ICommand;
        }

        public static void SetCommand(Control control, ICommand command)
        {
            control.SetValue(CommandProperty, command);
        }

        public static void SetCommandParameter(Control control, object parameter)
        {
            control.SetValue(CommandParameterProperty, parameter);
        }

        public static object GetCommandParameter(Control control)
        {
            return control.GetValue(CommandParameterProperty);
        }

        private static void OnSetCommandCallback
              (DependencyObject dependencyObject, DependencyPropertyChangedEventArgs e)
        {
            var control = dependencyObject as Control;
            if (control != null)
            {
                ButtonClickBehavior behavior = GetOrCreateBehavior(control);
                behavior.Command = e.NewValue as ICommand;
            }
        }

        private static void OnSetCommandParameterCallback
              (DependencyObject dependencyObject, DependencyPropertyChangedEventArgs e)
        {
            var control = dependencyObject as Control;
            if (control != null)
            {
                ButtonClickBehavior behavior = GetOrCreateBehavior(control);
                behavior.CommandParameter = e.NewValue;
            }
        }

        private static ButtonClickBehavior GetOrCreateBehavior(Control control)
        {
            var behavior =
                   control.GetValue(ButtonCommandBehaviorProperty) as ButtonClickBehavior;
            if (behavior == null)
            {
                behavior = new ButtonClickBehavior((ButtonBase)control);
                control.SetValue(ButtonCommandBehaviorProperty, behavior);
            }
            return behavior;
        }
    }
}
