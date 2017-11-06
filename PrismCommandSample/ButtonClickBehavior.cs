using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using Microsoft.Practices.Prism.Interactivity;

namespace PrismCommandSample
{
    public class ButtonClickBehavior : CommandBehaviorBase<ButtonBase>
    {
        public ButtonClickBehavior(ButtonBase targetObject) : base(targetObject)
        {
            targetObject.Click += OnClick;
        }

        private void OnClick(object sender, System.Windows.RoutedEventArgs e)
        {
            ExecuteCommand(null);
        }
    }
}
