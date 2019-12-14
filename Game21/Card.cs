using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game21
{
    public class Card
    {
        public Card()
        {
            Suit = "Spades";
            Face = "Two";
        }
        public String Suit { get; set; }
        public String Face { get; set; }
    }
}
