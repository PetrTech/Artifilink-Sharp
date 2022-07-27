using System;
using System.Windows.Input;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtifilinkSharp
{
    class Action
    {
        public enum actionType { integer, text, floatingPoint }; actionType currentActionType;

        public dynamic actionValue;

        public Action(actionType actionType, dynamic value)
        {
            actionValue = value;
        }
    }
}
