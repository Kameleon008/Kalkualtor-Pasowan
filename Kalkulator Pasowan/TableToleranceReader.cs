using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator_Pasowan
{
    class TableToleranceReader
    {
        List<String> readedDataTolerances;
        List<String> readedDataDimensions = new List<String>(System.IO.File.ReadAllLines(@"Data\dim.csv"));
        Double dimmension;
        Int16 dimmensionIndex;

        public string[] ReadAvalibleITClasses(string positionOfTolerance)
        {
            try
            {
                string FilePath = "";
                char[] separators = new char[] { ';' };
                if (isAnyUpperCase(positionOfTolerance) == true)
                {
                    FilePath = @"Data\hole\" + positionOfTolerance + ".csv";
                }
                else if (isAnyUpperCase(positionOfTolerance) == false)
                {
                    FilePath = @"Data\shaft\" + positionOfTolerance + ".csv";
                }
                readedDataTolerances = new List<string>(System.IO.File.ReadLines(FilePath));
                string avaibleITClassesStr = readedDataTolerances[0];
                string[] avaibleITClasses = avaibleITClassesStr.Split(separators);
                for (int i = 0; i < avaibleITClasses.Length; i++)
                {
                    if (checkNameOfPosition(avaibleITClasses[i]) == true)
                    {
                        avaibleITClasses[i] = avaibleITClasses[i].Remove(0, 2);
                    }
                    else
                    {
                        avaibleITClasses[i] = avaibleITClasses[i].Remove(0, 1);
                    }
                    
                }

                return avaibleITClasses;
            }
            catch
            {
                return null;
            }

        }
        private int readDimmensionIndex(string dim)
        {
            try
            {
                for(int i=0;i<readedDataDimensions.Count;i++)
                {
                    string[] bothRange = readedDataDimensions[i].Split(';');
                    double lowerRange = Convert.ToDouble(bothRange[0]);
                    double upperRange = Convert.ToDouble(bothRange[1]);
                    double actualDim = Convert.ToDouble(dim);
                    if( (actualDim >= lowerRange) && (actualDim <  upperRange))
                    {
                        return i+1;
                    }
                }
                return 0;
            }
            catch
            {
                return -1;
            }
            
        }
        private bool checkNameOfPosition(string name)
        {
            try
            {
                string newName = name.Substring(0, 2);
                string[] table = { "js", "za", "zb", "zc", "JS", "ZA", "ZB", "ZC" };
                for(int i=0;i<table.Length; i++)
                {
                    if(newName == table[i])
                    {
                        return true;
                    }
                }
                return false;
            }
            catch
            {
                return false;
            }
            
        }
        private bool isAnyUpperCase(string str)
        {
            try
            {
                foreach(char ch in str)
                {
                    if(ch >= 65 && ch<=90)
                    {
                        return true;
                    }
                }
                return false;
            }
            catch
            {
                return false;
            }
        }
        private double countDeviation(string dim, string dev)
        {
            try
            {
                double dimDouble = Convert.ToDouble(dim);
                double devDouble = Convert.ToDouble(dev);
                dimDouble = dimDouble + (devDouble / 1000);
                return dimDouble;
            }
            catch
            {
                return 0;
            }
        }
        public string readUpperDeviation(string dim, int indexClass)
        {
            try
            {
                string readedRow = readedDataTolerances[readDimmensionIndex(dim)*2];
                string[] readedValues = readedRow.Split(';');
                return readedValues[indexClass];
            }
            catch
            {
                return null;
            }
        }
        public string readLowerDeviation(string dim, int indexClass)
        {
            try
            {
                string readedRow = readedDataTolerances[readDimmensionIndex(dim) * 2+1];
                string[] readedValues = readedRow.Split(';');
                return readedValues[indexClass];
            }
            catch
            {
                return null;
            }
        }
        public string readRangeOfTolleration(string dim, int indexClass)
        {
            try
            {
                string upperDeviationStr = readUpperDeviation(dim,indexClass);
                string lowerDeviationStr = readLowerDeviation(dim,indexClass);
                double upperDimensionDouble = countDeviation(dim, upperDeviationStr);
                double lowerDimensionDouble = countDeviation(dim, lowerDeviationStr);
                string resultString = "("+lowerDimensionDouble+" - " + upperDimensionDouble + ") mm";
                return resultString;
            }
            catch
            {
                return null;
            }
        }
        

    }

   
}
