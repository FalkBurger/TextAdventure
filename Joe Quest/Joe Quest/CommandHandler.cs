using System;
using System.Collections.Generic;
using System.Text;

namespace Joe_Quest
{
    class CommandHandler
    {

        public void Look(int room = 0)
        {
            Program MainObj = new Program();
            Locations LocalObj = new Locations();

            switch (room)
            {
                case 0:
                    LocalObj.Outside("look", "default");
                    break;
                case 1:
                    LocalObj.Inside("look", "default");
                    break;
                case 2:
                    LocalObj.Garden("look","default");
                    break;
            }
        }

        public void Move(int room = 0, string direction = "North")
        {
            Locations LocalObj = new Locations();

            switch (room)
            {
                case 0:
                    LocalObj.Outside("move", direction);
                    break;
                case 1:
                    LocalObj.Inside("move", direction);
                    break;
                case 2:
                    LocalObj.Garden("move", direction);
                    break;
            }
        }
    }
}
