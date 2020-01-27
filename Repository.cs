using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mock
{
    public class Repository : IRepository
    {
        public List<Band> GetBands ()
        {
            List<Band> listOfBands = new List<Band>();
            listOfBands.Add(new Band
            {
                Name = "Insync Maniacs",
                song="Fir Kabhi",
                genre= "emotional"
            }) ;
            return listOfBands;
        }
    }
}
