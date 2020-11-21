using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    public class MatchupModel
    {
        /// <summary>
        /// Contains the two parties in the matchup
        /// </summary>
        public List<MatchupEntryModel> MyProperty { get; set; } = new List<MatchupEntryModel>();
        /// <summary>
        /// The winner of the matchup
        /// </summary>
        public TeamModel Winner { get; set; }
        /// <summary>
        /// Represents what round this
        /// matchup came from
        /// </summary>
        public int MatchupRound { get; set; }
    }
}
