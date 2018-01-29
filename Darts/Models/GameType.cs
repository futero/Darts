using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Darts.Models
{
    public class GameType : BaseModel
    {
        public string Name { get; set; }
     
        public GameType()
        {

        }
    }
}