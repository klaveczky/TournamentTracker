using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    public class TournamentModel
    {
        /// <summary>
        /// Name of tournament
        /// </summary>
        public string TournamentName { get; set; }
        /// <summary>
        /// Cost of entering the tournament
        /// </summary>
        public decimal EntryFee { get; set; }
        /// <summary>
        /// List of entered teams 
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();
        /// <summary>
        /// List of prizes
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();
        /// <summary>
        /// List of matchups in the tournament
        /// </summary>
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();
    }
}
