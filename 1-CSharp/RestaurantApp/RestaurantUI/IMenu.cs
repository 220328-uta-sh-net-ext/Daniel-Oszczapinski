using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantUI
{
    internal interface IMenu
    {
        /// <summary>
        /// Will display themenu and user choices in the terminal
        /// </summary>
        void Display();

        /// <summary>
        /// Will record the user's choice and change/route your menu based on that choice
        /// </summary>
        /// <returns>Return the menu that will change your screen</returns>
        string UserChoice();

        string Login();

    }
}
