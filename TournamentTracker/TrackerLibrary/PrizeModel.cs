using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    /// <summary>
    /// Represents a prize that can be awarded in the tournament.
    /// </summary>
    public class PrizeModel
    {
        /// <summary>
        /// Represents the place number (1st, 2nd, 3rd, etc.) that this prize is associated with.
        /// </summary>
        public int PlaceNumber { get; set; }

        /// <summary>
        /// Represents the name of the place (e.g., "Champion", "Runner-up", "Third Place", etc.) 
        /// that this prize is associated with.
        /// </summary>
        public string PlaceName { get; set; }

        /// <summary>
        /// Represents the fixed amount of money that this prize is worth. 
        /// </summary>
        public decimal PrizeAmount { get; set; }

        /// <summary>
        /// Represents the percentage of the total prize pool that this prize is worth.
        /// </summary>
        public double PrizePercentage { get; set; }
    }
}   