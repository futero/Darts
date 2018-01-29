using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Darts.Models
{
    public class Player : BaseModel
    {
        [Display(Name = "Nick name")]
        [DataType(DataType.Text)]
        public string NickName { get; set; }
        [Required(ErrorMessage = "First name is required")]
        [Display(Name = "First name")]
        [DataType(DataType.Text)]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Sur name is required")]
        [Display(Name = "Sur name")]
        public string SurName { get; set; }
        [Required(ErrorMessage = "Gender is required")]
        [RegularExpression(@"^Man|Vrouw{1}$")]
        public string Gender { get; set; }
        [Required(ErrorMessage = "Birthdate is required")]
        [DataType(DataType.Date)]
        [Display(Name = "Birth date")]
        public DateTime Birthdate { get; set; }
        //[NotMapped]
        //public string FullName { get; set; }

        public Player()
        {
            
        }

        public Player(string firstName, string surName, string nickName, string gender, DateTime birthdate)
        {
            this.FirstName = firstName;
            this.SurName = surName;
            this.NickName = nickName;
            this.Gender = gender;
            this.Birthdate = birthdate;

           // CreateFullName();
        }

        /**
         * Returns the full name of the player.
         */
        /*private void CreateFullName()
        {
            this.FullName = this.FirstName + " " + this.SurName;
        }*/

        /**
         * Returns the age of the player, taking leap years into account
         */
        public byte GetAge()
        {
            DateTime today = DateTime.Today;
            byte age = (byte)(today.Year - this.Birthdate.Year);
            // Go back to the year the person was born in case of a leap year
            if (this.Birthdate > today.AddYears(-age)) age--;

            return age;
        }
    }
}
