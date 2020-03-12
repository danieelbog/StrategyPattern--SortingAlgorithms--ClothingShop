using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3FinalDanieelBogdan
{
    class Factory
    {
        public string FactoryName { get; set; }
        public ICharachteristics _charachteristics { get; set; }

        public void SetCharachteristic(ICharachteristics charachteristics)
        {
            _charachteristics = charachteristics;
        }

        public Product CreateObjectToSell(string objectToCreate)
        {
            var objectToSell = _charachteristics.GetClothingType(objectToCreate);
            return objectToSell;
        }

    }
}
