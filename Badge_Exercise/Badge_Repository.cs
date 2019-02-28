using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Badge_Exercise
{
    public class Badge_Repository
    {
        //private int _badgeId;
        private List<string> _doorNameList;
        //private KeyValuePair<int, string> _badge;
        private Dictionary<int, List<string>> _badgeDictionary;

        public Badge_Repository()
        {
           _badgeDictionary = new Dictionary<int, List<string>>();
        }

        // add a badge
        // add door to list
        // remove door from list
        // get door list by id
        // get all doors
        // remove all doors from list

        public void AddBadgeToList(Badge model)
        {
            _badgeDictionary.Add(model.BadgeId, model.DoorNameList);
        }


        public List<string> GetDoorsByBadge(int badgeId)
        {
            List<string> doorList = new List<string>();
            var badgeList = _badgeDictionary.Where(x => x.Key == badgeId);
            foreach (KeyValuePair<int, List<string>> badges in badgeList)
            {
                if (badges.Key == badgeId)
                {
                    doorList = badges.Value;
                    break;
                }
            }
            return doorList;
        }

        public List<string> GetDoorsByBadge2(int badgeId)
        {
            _badgeDictionary.TryGetValue(badgeId, out _doorNameList);
            return _doorNameList;
        }


        public Dictionary<int, List<string>> GetAllBadges()
        {
            return _badgeDictionary;
        }
    }
}
