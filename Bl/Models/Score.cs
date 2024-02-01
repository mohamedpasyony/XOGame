using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bl.Models
{
    public class Score
    {
        public int id {  get; set; }
        public int Player1Score {  get; set; }
        public int Player2Score { get; set;}
        public string Winner { get; set; }
        public int PlayerId {  get; set; }
    }
}
