using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elise_Core_API
{
    internal static class FirstAmazonExercise
    {
        public static int GetCoveredHouseCount()
        {
            var buildingPeople = new List<int>() { 1, 5, 6, 7, 8, 3, 4 };

            var routePosition = new List<int>() { 1, 3, 5, 6, 7 };

            var routeRange = new List<int>() { 2, 4, 3, 6, 7 };

            var buildingCounts = new List<BuildingEntry>();

            for (int i = 0; i < buildingPeople.Count - 1; i++)
            {
                buildingCounts.Add(new BuildingEntry()
                {
                    RouterCount = 0,
                    ResidentCount = buildingPeople[i],
                    BuildingIndex = i,
                });
            }

            return buildingCounts.Count(x => x.IsCovered);
        }

        private class BuildingEntry
        {
            public int RouterCount { get; set; }

            public int BuildingIndex { get; init; }

            public int ResidentCount { get; init; }

            public bool IsCovered => ResidentCount <= RouterCount;
        }
    }
}
