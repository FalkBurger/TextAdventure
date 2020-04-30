using System;
using System.Collections.Generic;
using System.Text;

namespace Joe_Quest
{
    class CommandHandler
    {

        public void Look(int room = 0, string specdec = "default")
        {
            Program MainObj = new Program();
            Locations LocalObj = new Locations();

            switch (room)
            {
                case 0:
                    LocalObj.Outside("look", specdec);
                    break;
                case 1:
                    LocalObj.Inside("look", specdec);
                    break;
                case 2:
                    LocalObj.Garden("look", specdec);
                    break;
            }
        }

        public void Move(int room = 0, string specdec = "North")
        {
            Locations LocalObj = new Locations();

            switch (room)
            {
                case 0:
                    LocalObj.Outside("move", specdec);
                    break;
                case 1:
                    LocalObj.Inside("move", specdec);
                    break;
                case 2:
                    LocalObj.Garden("move", specdec);
                    break;
            }
        }

        public void Take(int room, string specdec)
        {
            Locations LocalObj = new Locations();

            switch (room)
            {
                case 0:
                    LocalObj.Outside("take", specdec);
                    break;
                case 1:
                    LocalObj.Outside("take", specdec);
                    break;
                case 2:
                    LocalObj.Outside("take", specdec);
                    break;

            }
        }
    }
}
