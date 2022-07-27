using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtifilinkSharp
{
    class Action
    {
        public enum setActionType {
            keyPress,
            moveMouse,
            lmbMouse,
            rmbMouse,
            mmbMouse,
            integer,
            text,
            floatingPoint
        };

        public setActionType actionType;

        // key press
        public Action()
        {

        }
    }
}
