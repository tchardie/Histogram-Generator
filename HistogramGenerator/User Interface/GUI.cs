using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace HistogramGenerator
{
    /// <summary>
    /// The GUI class provides a fully functioning graphical interface.
    /// </summary>
    public partial class GUI : Form
    {
        #region GUI fields
        private HistogramImage histogramImage;
        private bool noTBInteraction; // Data textbox interaction
        #endregion

        #region GUI constructor
        /// <summary>
        /// GUI no-arg constructor.
        /// Initializes a new instance of the GUI class.
        /// </summary>
        public GUI()
        {
            InitializeComponent();
            noTBInteraction = true; // There is no data textbox interaction
            histogramImage = new HistogramImage(histogramPB.Width, histogramPB.Height); // Creates a new histogramImage with the current width and height of the histogram picturebox 
        }
        #endregion

        #region Open text file 
        /// <summary>
        /// Event for opening a text file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openToolStripMainMenuItem_Click(object sender, EventArgs e)
        {
           if (openTextFileDialog.ShowDialog() == DialogResult.OK)
           {
                System.IO.StreamReader streamReader;
                streamReader = new System.IO.StreamReader(openTextFileDialog.FileName,
                System.Text.Encoding.GetEncoding("windows-1252"));
                dataTextBox.Text = streamReader.ReadToEnd();
                streamReader.Close();
           }
        }
        #endregion

        #region Save to text file
        /// <summary>
        /// Event for saving data to a text file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataToTextFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveTextFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter streamwriter =
                new System.IO.StreamWriter(saveTextFileDialog.FileName, false,
                System.Text.Encoding.GetEncoding("utf-8"));
                streamwriter.Write(histogramImage.Histogram.HistogramData.DataString);
                streamwriter.Close();
            }
        }
        #endregion

        #region Save to bitmap image
        /// <summary>
        /// Event for saving the histogram image to a bitmap.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void histogramImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveBitmapDialog.ShowDialog() == DialogResult.OK)
            {
                histogramImage.HistogramBitmap.Save(saveBitmapDialog.FileName, ImageFormat.Bmp);
            }
        }
        #endregion

        #region About window
        /// <summary>
        /// Event for the about window. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AboutBox dlg = new AboutBox(); // Create a new aboutbox
            dlg.ShowDialog(); // Show the aboutbox

        }
        #endregion

        #region Exit application
        /// <summary>
        /// Event for exiting the application.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMainMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Exit the application
        }
        #endregion

        #region Default histogram button
        /// <summary>
        /// Event for clicking the "Create Default Histogram" button. 
        /// Calls histogramIntialization(), sending "Default" as an argument.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void defaultHistogramButton_Click(object sender, EventArgs e)
        {
            histogramImage.Histogram.Type = "Default"; // Sets the histogram type to "Default"
            intializeDefaultHistogramImage();
        }
        #endregion

        #region Scrolling number of bars track bar
        /// <summary>
        /// Event for scrolling the "number of bars" track bar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numOfBarsTrackBar_Scroll(object sender, EventArgs e)
        {
            numOfBarsTextBox.Text = Convert.ToString(numOfBarsTrackBar.Value); // Displays the current number of bars track bar value 
            histogramImage.Histogram.Type = ""; // Resets the histogram type
            histogramImage.Histogram.NumOfBars = numOfBarsTrackBar.Value; // Sets the number of bars to the current number of bars track bar value 
            histogramImage.histogramIntialization();
            createHistogramImage();
        }
        #endregion

        #region Scrolling number of vertical ticks track bar
        /// <summary>
        /// Event for scrolling the "number of vertical ticks" track bar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numOfVertTicTrackBar_Scroll(object sender, EventArgs e)
        {
            numOfVertTicTextBox.Text = Convert.ToString(numOfVertTicTrackBar.Value); // Displays the current number of vertical ticks track bar value 
            histogramImage.Histogram.Type = ""; // Resets the histogram type
            histogramImage.Histogram.NumOfVertTicks = numOfVertTicTrackBar.Value; // Sets the number of vertical ticks to the current number of ticks track bar value
            histogramImage.histogramIntialization();
            createHistogramImage();
        }
        #endregion

        #region Data text changed
        /// <summary>
        /// Event for text changes in the data textbox.
        /// Checks if data exists in the data textbox.
        /// Allows certain features to be enabled based on whether data in the data textbox exists or not.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataTextBox_TextChanged(object sender, EventArgs e)
        {
            // Checks if the textbox is not empty
            if (dataTextBox.Text != "")
            {
                noTBInteraction = false; // Textbox has interaction
                defaultHistogramButton.Enabled = true; // The default histogram button is executable
                dataToTextFileToolStripMenuItem.Enabled = true; // Saving the data to a text file is enabled 
                histogramImage.Histogram.HistogramData = new HistogramData(dataTextBox.Text); // A new histogramData is created with the values from the data textbox
            }
            else
            {
                defaultHistogramButton.Enabled = false; // The default histogram button is not executable
                dataToTextFileToolStripMenuItem.Enabled = false; // Saving the data to a text file is not enabled
            }
        }
        #endregion

        #region Data textbox focus
        /// <summary>
        /// Event for the data textbox receiving focus.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataTextBox_Enter(object sender, EventArgs e)
        {
            // Chescks if the data text box has no interaction
            if (noTBInteraction)
            {
                dataTextBox.Text = ""; // Clears the data textbox
                noTBInteraction = false; // Data textbox interaction has occured
            }
        }
        #endregion

        #region Histogram image initialization
        /// <summary>.
        /// Calls dataStringToDoubleArray() from HistogramData
        /// Checks for valid data. 
        /// Calls createHistogramImage(). 
        /// </summary>
        /// <param name="type"></param>
        private void intializeDefaultHistogramImage()
        {
            // Checks if the entered data is valid
            try
            {
                histogramImage.Histogram.HistogramData.dataStringToDoubleArray();
                invalidAlertLabel.Visible = false; // Invalid data alert is hidden
                histogramImage.histogramIntialization();
                createHistogramImage();

                numOfBarsTrackBar.Value = histogramImage.Histogram.NumOfBars;
                numOfBarsTextBox.Text = Convert.ToString(numOfBarsTrackBar.Value);
                numOfVertTicTrackBar.Value = histogramImage.Histogram.NumOfVertTicks;
                numOfVertTicTextBox.Text = Convert.ToString(numOfVertTicTrackBar.Value);
            }
            catch
            {
                numAlertLabel.Visible = false; // Number of values alert is hidden
                invalidAlertLabel.Visible = true; // Invalid data alert is displayed
            }
        }
        #endregion

        #region Histogram image creation
        /// <summary>
        /// Checks for an entry of at least ten numbers. 
        /// Calls all methods in the HistogramImage class needed to build a histogram image from pixels. 
        /// Displays the histogram. 
        /// </summary>
        private void createHistogramImage()
        {
            // Checks if the number of entered data values is less than ten 
            if (histogramImage.Histogram.HistogramData.DataValues.Length < 10)
            {
                numAlertLabel.Visible = true; // Number of values alert is displayed 
            }
            else
            {
                numAlertLabel.Visible = false; // Number of values alert is hidden 

                histogramImage.backgroundBorder();
                histogramImage.background();
                histogramImage.frameBorder();
                histogramImage.frame();
                histogramImage.bars();
                histogramImage.verticalTicks();
                histogramImage.horizontalTicks();
                //histogramImage.verticalTickLabels();
                //histogramImage.horizontalTickLabels();

                histogramImage.verticalTickLabels(VTbox.SelectedItem.ToString());
                histogramImage.horizontalTickLabels(HTbox.SelectedItem.ToString());

                histogramPB.Image = histogramImage.HistogramBitmap; // Displays the histogram image in the picture box 

                histogramImageToolStripMenuItem.Enabled = true; // Saving the histogram image to a bitmap image is enabled
                numOfBarsTrackBar.Enabled = true; // Modifying the number of bars is enabled
                numOfVertTicTrackBar.Enabled = true; // Modifying the number of vertical ticks is enabled
            }
        }
        #endregion

    }
}
