using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Darts.Models
{
    public class Match : BaseModel
    {
        [Required(ErrorMessage = "A game type must be selected")]
        [Display(Name = "Game type")]
        [DataType(DataType.Text)]
        public SelectList GameTypeList { get; set; }
        [Required(ErrorMessage = "Number of sets is required")]
        [Display(Name = "Number of sets")]
        [RegularExpression("([1-3]+)")]
        [Range(1,3)]
        public int NrOfSets { get; set; }
        [Required(ErrorMessage = "Number of legs is required")]
        [Display(Name = "Number of legs")]
        //[RegularExpression("([1-5]+)")]
        [Range(1, 5)]
        public int NrOfLegs { get; set; }
        [Required(ErrorMessage = "Number of players is required")]
        [Display(Name = "Number of players")]
        [RegularExpression("([1-1]+)")]
        [Range(1, 1)]
        public int NrOfPlayers { get; set; }
        [Required(ErrorMessage = "A player must be selected")]
        [Display(Name = "Player 1")]
        public SelectList PlayerList { get; set; }


        //private List<Player> PlayersList;

        public Match()
        {
            this.NrOfPlayers = 1;
            this.NrOfSets = 1;
            this.NrOfLegs = 1;
        }

        /*public Match(List<Player> playersList, int nrOfSets, int nrOfLegs, string gameType)
        {
            PlayersList = playersList;
            this.NrOfPlayers = PlayersList.Count;

            this.GameTypeList = gameType;
            this.NrOfSets = nrOfSets;
            this.NrOfLegs = nrOfLegs;
        }*/
    }
}