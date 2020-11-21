using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    public class PrizeModel
    {
        /// <summary>
        /// Represents the place number this prize is given to
        /// </summary>
        public int PlaceNumber { get; set; }
        /// <summary>
        /// A name for the afformentioned place number
        /// </summary>
        public string PlaceName { get; set; }
        /// <summary>
        /// The amount of money won
        /// </summary>
        public decimal PrizeAmount { get; set; }
        /// <summary>
        /// The percentage of the total prize pool, allocated for this prize
        /// </summary>
        public double PrizePercentage { get; set; }
    }
}
