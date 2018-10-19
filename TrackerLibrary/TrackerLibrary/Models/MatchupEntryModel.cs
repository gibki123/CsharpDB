using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class MatchupEntryModel

    {
        /// <summary>
        /// Represtens one team in the matchup
        /// </summary>
        public TeamModel TeamCompeting { get; set; }
        /// <summary>
        /// Represents the score in actual team
        /// </summary>
        public double Score { get; set; }
        /// <summary>
        /// Represents teh matchup that this team came from as a winner
        /// </summary>
        public MatchupModel ParentMatchup { get; set; }     
    }
}
