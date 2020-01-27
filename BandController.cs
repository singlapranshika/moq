using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mock;
namespace Mock
{
    public class BandController
    {
        IRepository repository;
        public BandController(IRepository repository)
        {
            this.repository = repository;
        }
        public void Method()
        {
            var bands = this.repository.GetBands();
            foreach(var band in bands )
            {
                if(band.Name=="Insync Maniacs")
                {
                    Console.WriteLine("favourite");
                }
            }
        }
    }
}
