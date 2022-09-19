#region LICENSE
//
// Copyright (c) Microncode.com
// 
// This source is subject to the Microsoft Public License. 
// See https://opensource.org/licenses/ms-pl.html.
// All other rights reserved. 
// 
// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND, 
// EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE IMPLIED 
// WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR PURPOSE. 
//
#endregion

namespace CSAudioVisualizationExample
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    /// <summary>
    /// The main example of using the CSAudioVisualization library.
    /// </summary>
    public partial class frmAudioVisualization : Form
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        public frmAudioVisualization()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Form load.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAudioVisualization_Load(object sender, EventArgs e)
        {
            audioVisualization1.UserName = "Your email";
            audioVisualization1.UserKey = "Your registration key";

            //Mode
            foreach (CSAudioVisualization.Mode mode in Enum.GetValues(typeof(CSAudioVisualization.Mode)))
            {
                cboRecorderMode.Items.Add(audioVisualization1.GetEnumValue(mode));
            }
            cboRecorderMode.SelectedItem = audioVisualization1.GetEnumValue(audioVisualization1.Mode);
        }

        /// <summary>
        /// Stop the visualization.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStop_Click(object sender, EventArgs e)
        {
            audioVisualization1.Stop();
        }

        /// <summary>
        /// Start the visualization.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStart_Click(object sender, EventArgs e)
        {
            //Set the mode:
            audioVisualization1.Mode = (CSAudioVisualization.Mode)Enum.Parse(typeof(CSAudioVisualization.Mode), cboRecorderMode.Text);

            //Set the device index:
            audioVisualization1.DeviceIndex = cboAudioSource.SelectedIndex;

            //Set the quality:
            audioVisualization1.HighQuality = true;

            //Set the interval:
            audioVisualization1.Interval = 40;

            //Set the background color:
            audioVisualization1.BackColor = Color.Black;

            //Set the base color:
            audioVisualization1.ColorBase = Color.Green;

            //Set the max color:
            audioVisualization1.ColorMax = Color.Red;

            //Start:
            audioVisualization1.Start();
        }

        /// <summary>
        /// Safe exit.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAudioVisualization_FormClosing(object sender, FormClosingEventArgs e)
        {
            audioVisualization1.Stop();

            audioVisualization1.Dispose();

            audioVisualization1 = null;
        }
        
        /// <summary>
        /// Get and set the audio devices according to the capture mode.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboRecorderMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Get the selected capture mode:
            CSAudioVisualization.Mode mode = (CSAudioVisualization.Mode)Enum.Parse(typeof(CSAudioVisualization.Mode), cboRecorderMode.Text);

            //Get the audio devices:
            cboAudioSource.DataSource = audioVisualization1.GetDevices(mode);

            //Try to set the default device:
            int default_device_index = audioVisualization1.GetDeviceDefaultIndex(mode);

            if (default_device_index != -1)
                //Set the default device index:
                cboAudioSource.SelectedIndex = default_device_index;
            else
                //LineIn will always return -1:
                cboAudioSource.SelectedIndex = 0;

        }

        /// <summary>
        /// Order a license.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdOrderLicense_Click(object sender, EventArgs e)
        {
            /// In order to get your own UserName and RegKey and to distribute this library
            /// with your own projects for commercial or any other purpose, please order a license at:
            /// https://www.microncode.com/developers/cs-audio-visualization/?cmd=order

            System.Diagnostics.Process.Start("https://www.microncode.com/developers/cs-audio-visualization/?cmd=order");
        }
    }
}
