#Region "LICENSE"
'
' Copyright (c) Microncode.com
' 
' This source is subject to the Microsoft Public License. 
' See https://opensource.org/licenses/ms-pl.html.
' All other rights reserved. 
' 
' THIS CODE And INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND, 
' EITHER EXPRESSED Or IMPLIED, INCLUDING BUT Not LIMITED TO THE IMPLIED 
' WARRANTIES OF MERCHANTABILITY And/Or FITNESS FOR A PARTICULAR PURPOSE. 
'
#End Region

''' <summary>
''' The main example of using the CSAudioVisualization library.
''' </summary>
Public Class frmAudioVisualization

    ''' <summary>
    ''' Form load
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub frmAudioVisualization_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        AudioVisualization1.UserName = "Your email"
        AudioVisualization1.UserKey = "Your registration key"

        'Mode
        For Each mode As CSAudioVisualization.Mode In [Enum].GetValues(GetType(CSAudioVisualization.Mode))
            cboRecorderMode.Items.Add(AudioVisualization1.GetEnumValue(mode))
        Next

        cboRecorderMode.SelectedItem = AudioVisualization1.GetEnumValue(AudioVisualization1.Mode)

    End Sub

    ''' <summary>
    ''' Stop the visualization.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click

        AudioVisualization1.[Stop]()

    End Sub

    ''' <summary>
    ''' Start the visualization.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click

        'Set the mode:
        AudioVisualization1.Mode = CType([Enum].Parse(GetType(CSAudioVisualization.Mode), cboRecorderMode.Text), CSAudioVisualization.Mode)

        'Set the device index:
        AudioVisualization1.DeviceIndex = cboAudioSource.SelectedIndex

        'Set the quality:
        AudioVisualization1.HighQuality = True

        'Set the interval:
        AudioVisualization1.Interval = 40

        'Set the background color:
        AudioVisualization1.BackColor = Color.Black

        'Set the base color:
        AudioVisualization1.ColorBase = Color.Green

        'Set the max color:
        AudioVisualization1.ColorMax = Color.Red

        'Start:
        AudioVisualization1.Start()

    End Sub

    ''' <summary>
    ''' Safe exit.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub frmAudioVisualization_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        AudioVisualization1.[Stop]()
        AudioVisualization1.Dispose()
        AudioVisualization1 = Nothing

    End Sub

    ''' <summary>
    ''' Get and set the audio devices according to the capture mode.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cboRecorderMode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboRecorderMode.SelectedIndexChanged

        Dim mode As CSAudioVisualization.Mode = CType([Enum].Parse(GetType(CSAudioVisualization.Mode), cboRecorderMode.Text), CSAudioVisualization.Mode)
        cboAudioSource.DataSource = AudioVisualization1.GetDevices(mode)
        Dim default_device_index As Integer = AudioVisualization1.GetDeviceDefaultIndex(mode)

        If default_device_index <> -1 Then
            cboAudioSource.SelectedIndex = default_device_index
        Else
            cboAudioSource.SelectedIndex = 0
        End If

    End Sub

    ''' <summary>
    ''' Check the license.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cmdOrderLicense_Click(sender As Object, e As EventArgs) Handles cmdOrderLicense.Click

        ' In order to get your own UserName and RegKey and to distribute this library
        ' with your own projects for commercial or any other purpose, please order a license at:
        ' https://www.microncode.com/developers/cs-audio-visualization/?cmd=order

        System.Diagnostics.Process.Start("https://www.microncode.com/developers/cs-audio-visualization/?cmd=order")

    End Sub

End Class
