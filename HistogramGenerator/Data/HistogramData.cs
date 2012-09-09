using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HistogramGenerator
{
    /// <summary>
    /// The HistogramData class handles the data entered or provided from the user.
    /// </summary>
    public class HistogramData
    {
        #region HistogramData fields
        private string dataString;
        private string[] dataStringArray;
        private double[] dataValues;
        #endregion

        #region HistogramData constructor
        /// <summary>
        /// Constructor for HistogramData which accepts a string.
        /// Calls dataValuesArray(), sending a string. 
        /// </summary>
        /// <param name="dataString"></param>
        public HistogramData(string dataString)
        {
            this.dataString = dataString;
            toDelimitedString();
        }
        #endregion

        #region DataString accessor
        /// <summary>
        /// The DataString property gets the dataString member.
        /// </summary>
        public string DataString
        {
            get { return dataString; }
        }
        #endregion

        #region DataValues accessor
        /// <summary>
        /// The DataValues property gets the dataValues member. 
        /// </summary>
        public double[] DataValues
        {
            get { return dataValues; }
        }
        #endregion

        #region Data values string to data values double array
        /// <summary>
        /// Stores a delimited string into a string array.
        /// Converts the strings to double values.
        /// Double values are stored in a double array. 
        /// </summary>
        /// <param name="dataString"></param>
        public void dataStringToDoubleArray()
        {
            dataValues = new double[dataStringArray.Length];

            for (int i = 0; i < dataValues.Length; i++)
            {
                dataValues[i] = Convert.ToDouble(dataStringArray[i]);
            }

            Array.Sort(dataValues);
        }
        #endregion

        #region Entered data string to space delimited data string
        /// <summary>
        /// Converts the entered data values to a space delimited string 
        /// </summary>
        public void toDelimitedString()
        {
            dataStringArray = dataString.Split(new char[] { ';', ',', ' ', ':', '\n' }, StringSplitOptions.RemoveEmptyEntries).ToArray<string>();
            dataString = "";

            for (int i = 0; i < dataStringArray.Length; i++)
            {
                dataString += dataStringArray[i] + " ";
            }
   
        }
        #endregion


    }
}
