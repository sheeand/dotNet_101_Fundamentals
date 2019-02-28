using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Badge_Exercise
{
    class Program_UI
    {
        private Badge_Repository _badgeRepo = new Badge_Repository();
        private int _badgeId;
        private List<string> _doorNameList;
        private Dictionary<int, List<string>> _badgeList;
        private Badge _badge = new Badge();

        List<string> rooms = new List<string>();
        string room = "";
        int badgeId = 0;

        public void Run()
        {
            Console.WriteLine("Hello Security Admin!");

            int selection = ShowMainMenu();

            while (selection > 0 && selection < 4)
            {
                if (selection > 0 && selection < 4)
                {
                    switch (selection)
                    {
                        case 1:
                            AddNewBadge();
                            selection = ShowMainMenu();
                            break;

                        case 3:
                            ShowAllBadges();
                            selection = ShowMainMenu();
                            break;
                    }
                }
            }
        }

        private int ShowMainMenu()
        {
            Console.WriteLine("\n What would you like to do?" +
                              "\n 1 - Add a badge" +
                              "\n 2 - Edit a badge" +
                              "\n 3 - List all Badges\n");

            int selection = int.Parse(Console.ReadLine());
            return selection;
        }

        private void AddNewBadge()
        {

            Console.WriteLine("\n What is the Badge ID? ");
            badgeId = int.Parse(Console.ReadLine());

            Console.WriteLine("\n What is the room? ");
            room = Console.ReadLine();
            rooms.Add(room);

            Console.WriteLine("\n Is there another room (y or n)? ");
            string answer = Console.ReadLine();
            while (answer == "y")
            {
                Console.WriteLine("\n What is the room? ");
                room = Console.ReadLine();
                rooms.Add(room);

                Console.WriteLine("\n Is there another room (y or n)? ");
                answer = Console.ReadLine();
            }

            _badgeRepo.AddBadgeToList(_badge);
            Console.WriteLine($"\n Badge {_badge} has {rooms.Count} rooms.");

        }

        private void ShowAllBadges()
        {
            Console.WriteLine("\n Key" +
                "\n Badge # \t Door Access");

            _badgeList = _badgeRepo.GetAllBadges();
            foreach (KeyValuePair<int, List<string>> b in _badgeList)
            {
                StringBuilder sb = new StringBuilder();
                string badgeIdString = b.Key.ToString();
                List<string> roomList = b.Value;
                foreach (string room in roomList)
                {
                    sb.Append(room);
                }

                Console.WriteLine($"{badgeIdString} \t {sb.ToString()}");
            }
        }

        private void UpdateBadge(int BadgeId)
        {

        }
    }
}
