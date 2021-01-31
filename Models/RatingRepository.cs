using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;


namespace OPG.Models
{
    public class RatingRepository : IRatingRepository
    {
   
        public void AddRating()
        {
            string input = Interaction.InputBox("Leave feedback", "Rating", "Default Text");
        }
    }
}
