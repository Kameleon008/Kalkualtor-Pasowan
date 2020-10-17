using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator_Pasowan
{
    class ToleratedSize
    {
        private Double nominalDimension;
        private Double itTolerance;
        private Double upperDeviation;
        private Double loverDeviation;
        private Char holeToleranceLocation;
        private Char rollerToleranceLocation;
        private String typeOfDimension;

        public ToleratedSize()
        {
            nominalDimension = 0;
            itTolerance = 0;
            upperDeviation = 0;
            loverDeviation = 0;
            itTolerance = 0;
        }

        public void ChangeDimmension(Double newDimension)
        {
            nominalDimension = newDimension;
        }

        public Double GetNominalDimension()
        {
            return nominalDimension; 
        }
    }
}
