using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace HistogramGenerator
{
    /// <summary>
    /// The HistogramImage class handles only pixel related information needed to create a histogram bitmap image.
    /// </summary>
    class HistogramImage
    {
        #region HistogramImage fields
        /// <summary>
        /// Width in pixels of the histogram.
        /// </summary>
        private int pixWidth;
        /// <summary>
        /// Height in pixels of the histogram.
        /// </summary>
        private int pixHeight;
        /// <summary>
        /// Width in pixels of the histogram background border.
        /// </summary>
        private int bgBorderPixWidth;
        /// <summary>
        /// Size in pixels of the histogram background top margin.
        /// </summary>
        private int bgPixTM;
        /// <summary>
        /// Size in pixels of the histogram background bottom margin.
        /// </summary>
        private int bgPixBM;
        /// <summary>
        /// Size in pixels of the histogram background left margin.
        /// </summary>
        private int bgPixLM;
        /// <summary>
        /// Size in pixels of the histogram background right margin.
        /// </summary>
        private int bgPixRM;
        /// <summary>
        /// 
        /// </summary>
        private int frameBorderPixWidth;
        /// <summary>
        /// 
        /// </summary>
        private int framePixTM;
        /// <summary>
        /// 
        /// </summary>
        private int framePixLM;
        /// <summary>
        /// 
        /// </summary>
        private int framePixRM;
        /// <summary>
        /// 
        /// </summary>
        private int vertTickPixWidth;
        /// <summary>
        /// 
        /// </summary>
        private int vertTickPixHeight;
        /// <summary>
        /// 
        /// </summary>
        private int horizTickPixWidth;
        /// <summary>
        /// 
        /// </summary>
        private int horizTickPixHeight;
        /// <summary>
        /// 
        /// </summary>
        private int fullBGPixLM;
        /// <summary>
        /// 
        /// </summary>
        private int fullBGPixBM;
        /// <summary>
        /// 
        /// </summary>
        private int framePixWidth;
        /// <summary>
        /// 
        /// </summary>
        private int framePixHeight;
        /// <summary>
        /// 
        /// </summary>
        private int firstBarXAxis;
        /// <summary>
        /// 
        /// </summary>
        private int barPixWidth;
        /// <summary>
        /// 
        /// </summary>
        private int barsMaxPixWidth;
        /// <summary>
        /// 
        /// </summary>
        private int barsMaxPixHeight;
        /// <summary>
        /// 
        /// </summary>
        private int barsMaxHeightYAxis;
        /// <summary>
        /// 
        /// </summary>
        private float classPixWidth;
        /// <summary>
        /// 
        /// </summary>
        private float classPixHeight;
        /// <summary>
        /// 
        /// </summary>
        private Histogram histogram;
        /// <summary>
        /// 
        /// </summary>
        private Bitmap histogramBitmap;
        /// <summary>
        /// 
        /// </summary>
        private Graphics histogramGraphic;
        /// <summary>
        /// 
        /// </summary>
        private Brush blackBrush = new SolidBrush(Color.Black);
        /// <summary>
        /// 
        /// </summary>
        private Font fontRegular = new Font("Calibri", 9, FontStyle.Regular);
        /// <summary>
        /// 
        /// </summary>
        private SizeF maxLabelPixSize;
        #endregion

        #region HistogramImage constructor
        /// <summary>
        /// Initializes a new instance of the HistogramImage class.
        /// Constructor accepts two integers, a width and a height.
        /// Initializes pixel values, fonts, colors, and etc. needed to structure a histogram bitmap image.
        /// </summary>
        /// <param name="width"></param>
        /// <param name="height"></param>
        public HistogramImage(int width, int height)
        {
            this.pixWidth = width;
            this.pixHeight = height;
            histogram = new Histogram();
            histogramBitmap = new Bitmap(width, height);
            histogramGraphic = Graphics.FromImage(histogramBitmap);
            maxLabelPixSize = histogramGraphic.MeasureString("100", fontRegular);
            bgBorderPixWidth = 1;
            bgPixTM = 20;
            bgPixBM = 5;
            bgPixLM = 5;
            bgPixRM = 20;
            frameBorderPixWidth = 1;
            framePixTM = 5;
            framePixLM = 5;
            framePixRM = 5;
            vertTickPixWidth = 6;
            vertTickPixHeight = 1;
            horizTickPixWidth = 1;
            horizTickPixHeight = 6;
            fullBGPixLM = Convert.ToInt32(maxLabelPixSize.Width) + bgPixLM + vertTickPixWidth + 2;
            fullBGPixBM = Convert.ToInt32(maxLabelPixSize.Height) + bgPixBM + horizTickPixHeight + 2;
            framePixWidth = pixWidth - fullBGPixLM - bgPixRM;
            framePixHeight = pixHeight - fullBGPixBM - bgPixTM;
            firstBarXAxis = fullBGPixLM + framePixLM;
            barsMaxPixWidth = framePixWidth - framePixLM - framePixRM;
            barsMaxPixHeight = height - bgPixTM - framePixTM - fullBGPixBM;
            barsMaxHeightYAxis = bgPixTM + framePixTM;
        }
        #endregion

        #region Histogram accesssor
        /// <summary>
        /// The Histogram property gets the histogram member from the HistogramImage class.
        /// </summary>
        public Histogram Histogram
        {
            get { return histogram; }
        }
        #endregion

        #region Histogram bitmap accessor
        /// <summary>
        /// The HistogramBitmap property gets the histogramBitmap member from the HistogramImage class.
        /// </summary>
        public Bitmap HistogramBitmap
        {
            get { return histogramBitmap; }
        }
        #endregion

        #region Default histogram
        /// <summary>
        /// Initializes pixel values for the default histogram.
        /// Calls initializeHistogramProperties() in the Histogram class.
        /// </summary>
        /// <param name="dataValues"></param>
        public void histogramIntialization()
        {
            histogram.initializeHistogramProperties();
            barPixWidth = barsMaxPixWidth / histogram.NumOfBars;
            classPixWidth = barsMaxPixWidth / (histogram.NumOfHorizTicks - 1.0f);
            classPixHeight = barsMaxPixHeight / (histogram.NumOfVertTicks - 1.0f);
        }
        #endregion

        #region Histogram background
        /// <summary>
        /// Creates the histogram background.
        /// </summary>
        public void background()
        {
            Brush lightTanBrush = new SolidBrush(Color.FromArgb(245, 238, 215));
            histogramGraphic.FillRectangle(lightTanBrush, bgBorderPixWidth, bgBorderPixWidth,
                pixWidth - 2 * bgBorderPixWidth, pixHeight - 2 * bgBorderPixWidth);
        }
        #endregion

        #region Histogram background border
        /// <summary>
        /// Creates the histogram background border.
        /// </summary>
        public void backgroundBorder()
        {
            histogramGraphic.FillRectangle(blackBrush, 0, 0, pixWidth, pixHeight);
        }
        #endregion

        #region Histogram frame
        /// <summary>
        /// Creates the histogram frame.
        /// </summary>
        public void frame()
        {
            Brush whiteBrush = new SolidBrush(Color.White);
            histogramGraphic.FillRectangle(whiteBrush, fullBGPixLM, bgPixTM, framePixWidth, framePixHeight);
        }
        #endregion

        #region Histogram frame border
        /// <summary>
        /// Creates the histogram frame border.
        /// </summary>
        public void frameBorder()
        {
            histogramGraphic.FillRectangle(blackBrush, fullBGPixLM - frameBorderPixWidth,
                bgPixTM - frameBorderPixWidth, framePixWidth + 2 * frameBorderPixWidth, framePixHeight + 2 * frameBorderPixWidth);
        }
        #endregion

        #region Histogram bars and bar borders
        /// <summary>
        /// Creates the histogram bars and bar borders.
        /// </summary>
        public void bars()
        {
            Brush cornflowerBlueBrush = new SolidBrush(Color.CornflowerBlue);

            double freqPerPix = histogram.MaxRelativeFrequency / barsMaxPixHeight;

            for (int i = 0; i < histogram.NumOfBars; i++)
            {
                histogramGraphic.FillRectangle(blackBrush, (float)(firstBarXAxis + (i * classPixWidth)),
                   (float)(pixHeight - fullBGPixBM - histogram.RelativeFrequenciesArray[i] / freqPerPix), 
                   (float)classPixWidth + 1, (float)(histogram.RelativeFrequenciesArray[i] / freqPerPix));

                histogramGraphic.FillRectangle(cornflowerBlueBrush, (float)(firstBarXAxis + (i * classPixWidth) + 1),
                    (float)(pixHeight - fullBGPixBM - histogram.RelativeFrequenciesArray[i] / freqPerPix + 1),
                    (float)classPixWidth - 1, (float)(histogram.RelativeFrequenciesArray[i] / freqPerPix - 1)); 
            }
        }
        #endregion

        #region Histogram vertical ticks
        /// <summary>
        /// Creates the histogram vertical ticks.
        /// </summary>
        public void verticalTicks()
        {
            for (int i = 0; i < histogram.NumOfVertTicks; i++)
            {
                histogramGraphic.FillRectangle(blackBrush, fullBGPixLM - vertTickPixWidth, 
                    pixHeight - fullBGPixBM - (i * classPixHeight), vertTickPixWidth, vertTickPixHeight);
            }
        }
        #endregion

        #region Histogram horizontal ticks
        /// <summary>
        /// Creates the histogram horizontal ticks.
        /// </summary>
        public void horizontalTicks()
        {
            for (int i = 0; i < histogram.NumOfHorizTicks; i++)
            {
                histogramGraphic.FillRectangle(blackBrush, firstBarXAxis + (i * classPixWidth),
                    pixHeight - fullBGPixBM, horizTickPixWidth, horizTickPixHeight);
            }

        }
        #endregion

        #region Histogram vertical tick labels
        /// <summary>
        /// Creates the histogram vertical tick labels.
        /// </summary>
        public void verticalTickLabels()
        {   
            for (int i = 0; i < histogram.NumOfVertTicks; i++)
            {
                SizeF labelPixSize = histogramGraphic.MeasureString((0.0 + (histogram.FrequencyClassWidth * i)).ToString("0"), fontRegular);
                int verTickLabelXAxis = pixWidth - bgPixRM - framePixWidth - vertTickPixWidth - 2 - (int)labelPixSize.Width; 

                histogramGraphic.DrawString((0.0 + (histogram.FrequencyClassWidth * i)).ToString("0"), fontRegular, blackBrush,
                verTickLabelXAxis, pixHeight - fullBGPixBM - (i * classPixHeight) - (labelPixSize.Height) / 2 + 1.5f);
            }
        }

        public void verticalTickLabels(String selectedItem)
        {
            String dec=selectedItem;

            for (int i = 0; i < histogram.NumOfVertTicks; i++)
            {
                SizeF labelPixSize = histogramGraphic.MeasureString((0.0 + (histogram.FrequencyClassWidth * i)).ToString(dec), fontRegular);
                int verTickLabelXAxis = pixWidth - bgPixRM - framePixWidth - vertTickPixWidth - 2 - (int)labelPixSize.Width;

                histogramGraphic.DrawString((0.0 + (histogram.FrequencyClassWidth * i)).ToString(dec), fontRegular, blackBrush,
                verTickLabelXAxis, pixHeight - fullBGPixBM - (i * classPixHeight) - (labelPixSize.Height) / 2 + 1.5f);
            }
        }
        #endregion

        #region Histogram horizontal tick labels
        /// <summary>
        /// Creates the histogram horizontal tick labels
        /// </summary>
        public void horizontalTickLabels()
        {   
            for (int i = 0; i < histogram.NumOfHorizTicks; i++)
            {
                SizeF labelSize = histogramGraphic.MeasureString((histogram.FirstBarLCL + (histogram.DataClassWidth * i)).ToString("0.0"), fontRegular);

                histogramGraphic.DrawString((histogram.FirstBarLCL + (histogram.DataClassWidth * i)).ToString("0.0"),
                    fontRegular, blackBrush, firstBarXAxis + (i * classPixWidth) - labelSize.Width / 2,
                    pixHeight - fullBGPixBM + horizTickPixHeight);
            }

        }

        public void horizontalTickLabels(string selectedIndex)
        {
            string dec = selectedIndex;
            for (int i = 0; i < histogram.NumOfHorizTicks; i++)
            {
                SizeF labelSize = histogramGraphic.MeasureString((histogram.FirstBarLCL + (histogram.DataClassWidth * i)).ToString(dec), fontRegular);

                histogramGraphic.DrawString((histogram.FirstBarLCL + (histogram.DataClassWidth * i)).ToString(dec),
                    fontRegular, blackBrush, firstBarXAxis + (i * classPixWidth) - labelSize.Width / 2,
                    pixHeight - fullBGPixBM + horizTickPixHeight);
            }

        }
        #endregion
    }
}
