using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HistogramGenerator
{
    /// <summary>
    /// The Histogram class provides all needed to generate a mathematical representation of a histogram.
    /// </summary>
    public class Histogram
    {
        #region Histogram fields
        private HistogramData histogramData;
        private string type;
        private int numOfBars;
        private int numOfVertTicks;
        private int numOfHorizTicks;
        private double firstBarLCL;
        private double lastBarUCL;
        private double dataClassWidth;
        private int frequencyClassWidth;
        private double[] relativeFrequenciesArray;
        private double maxRelativeFrequency;
        #endregion

        #region Histogram constructor
        /// <summary>
        /// Histogram class constructor.
        /// </summary>
        /// <param name="dataValues"></param>
        public Histogram()
        {
        }
        #endregion

        #region HistogramData accessor and mutator
        /// <summary>
        /// The HistogramData property gets the histogramData member.
        /// </summary>
        public HistogramData HistogramData
        {
            get { return histogramData; }
            set { histogramData = value; }
        }
        #endregion

        #region Type accessor and mutator
        /// <summary>
        /// The Type property gets and sets the type member from the Histogram class.
        /// </summary>
        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        #endregion

        #region NumOfBars accessor and mutator
        /// <summary>
        /// The NumOfBars property gets and sets the numOfBars member from the Histogram class. 
        /// </summary>
        public int NumOfBars
        {
            get { return numOfBars; }
            set { numOfBars = value; }
        }
        #endregion

        #region NumOfVertTicks accessor and mutator
        /// <summary>
        /// The NumOfVertTicks property gets and sets the numOfVertTicks member from the Histogram class. 
        /// </summary>
        public int NumOfVertTicks
        {
            get { return numOfVertTicks; }
            set { numOfVertTicks = value; }
        }
        #endregion

        #region NumOfHorizTicks accessor and mutator
        /// <summary>
        /// The NumOfHorizTicks property gets and sets the numOfHorizTicks member from the Histogram class. 
        /// </summary>
        public int NumOfHorizTicks
        {
            get { return numOfHorizTicks; }
            set { numOfHorizTicks = value; }
        }
        #endregion

        #region FirstBarLCL accessor
        /// <summary>
        /// The FirstBarLCL property gets the firstBarLCL member from the Histogram class.
        /// </summary>
        public double FirstBarLCL
        {
            get { return firstBarLCL; }
        }
        #endregion

        #region LastBarUCL accessor
        /// <summary>
        /// The LastBarUCL property gets the lastBarUCL member from the Histogram class. 
        /// </summary>
        public double LastBarUCL
        {
            get { return lastBarUCL; }
        }
        #endregion

        #region DataClassWidth accessor
        /// <summary>
        /// The DataClassWidth property gets the dataClassWidth member from the Histogram class.
        /// </summary>
        public double DataClassWidth
        {
            get { return dataClassWidth; }
        }
        #endregion

        #region FrequencyClassWidth accessor
        /// <summary>
        /// The FrequencyClassWidth property gets the frequencyClassWidth member from the Histogram class.
        /// </summary>
        public double FrequencyClassWidth
        {
            get { return frequencyClassWidth; }
        }
        #endregion

        #region RelativeFrequenciesArray accessor
        /// <summary>
        /// The RelativeFrequenciesArray property gets relativeFrequenciesArray member from the Histogram class. 
        /// </summary>
        public double[] RelativeFrequenciesArray
        {
            get { return relativeFrequenciesArray; }
        }
        #endregion

        #region MaxRelativeFrequency accessor
        /// <summary>
        /// The MaxRelativeFrequency property gets the maxRelativeFrequency member from the Histogram class.
        /// </summary>
        public double MaxRelativeFrequency
        {
            get { return maxRelativeFrequency; }
        }
        #endregion

        #region Histogram properties initialization
        /// <summary>
        /// Performs calculations needed to initialize a histogram.
        /// </summary>
        public void initializeHistogramProperties()
        {
            // Checks if the type of histogram is "Default"
            if (type.Equals("Default"))
            {
                numOfBars = (int)(Math.Sqrt(histogramData.DataValues.Length)); // Sets number of bars to square root of number of data entered
                numOfVertTicks = 6; // Sets the number of vertical ticks to the default
                firstBarLCL = histogramData.DataValues[0]; // Sets the lower class limit of the first bar to the minimum
                lastBarUCL = histogramData.DataValues[histogramData.DataValues.Length - 1]; // Sets the upper class limit of the last bar to the maximum
            }
            else
            {
            }

            numOfBarsInitialization();
            numOfHorizTicks = numOfBars + 1;
            dataClassWidth = (lastBarUCL - firstBarLCL) / numOfBars; // Calculates and sets class width of the data entered
            relativeFrequenciesArray = new double[numOfBars]; // Creates and sets the length of this array by number of bars
            frequencies();
            frequencyClassWidth = (int)Math.Ceiling(maxRelativeFrequency / (numOfVertTicks - 1));
            maxRelativeFrequency = frequencyClassWidth * (numOfVertTicks - 1);
        }
        #endregion

        #region Number of Bars
        /// <summary>
        /// Sets the minimum and maximum values for the number of bars.
        /// </summary>
        public void numOfBarsInitialization()
        {
            if (numOfBars < 4)
            {
                numOfBars = 4; // Minimum number of bars
            }
            else if (numOfBars > 20)
            {
                numOfBars = 20; // Maximum number of bars
            }
        }
        #endregion

        #region Frequencies calculations
        /// <summary>
        /// Calculates the relative and max frequencies.
        /// </summary>
        public void frequencies()
        {
            int frequency = 0;
            maxRelativeFrequency = 0;
            int i = 0;
            int j = 0;

            if ((firstBarLCL == lastBarUCL))
            {
                for (int k = 0; k < relativeFrequenciesArray.Length; k++)
                {
                    relativeFrequenciesArray[k] = 100.0;
                }

                maxRelativeFrequency = relativeFrequenciesArray[j];
            }
            else
            {
                while (i < histogramData.DataValues.Length)
                {
                    if ((j * dataClassWidth + firstBarLCL) == (lastBarUCL - dataClassWidth))
                    {
                        frequency++;

                        if (i == histogramData.DataValues.Length - 1)
                        {
                            relativeFrequenciesArray[j] = (double)frequency / histogramData.DataValues.Length * 100.0;

                            if (maxRelativeFrequency < relativeFrequenciesArray[j])
                            {
                                maxRelativeFrequency = relativeFrequenciesArray[j];
                            }
                            j++;
                            frequency = 0;
                        }

                        i++;
                    }
                    else if ((histogramData.DataValues[i] >= (j * dataClassWidth + firstBarLCL)) && (histogramData.DataValues[i] < ((1 + j) * dataClassWidth + firstBarLCL)))
                    {
                        frequency++;
                        i++;
                    }

                    else
                    {
                        relativeFrequenciesArray[j] = (double)frequency / histogramData.DataValues.Length * 100.0;

                        if (maxRelativeFrequency < relativeFrequenciesArray[j])
                        {
                            maxRelativeFrequency = relativeFrequenciesArray[j];
                        }

                        j++;
                        frequency = 0;
                    }
                }
            }
        }
        #endregion
    }
}
