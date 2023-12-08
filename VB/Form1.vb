Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraCharts

' ...
Namespace CombineSeveralCharts3D

    Public Partial Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
            ' Create an empty chart.
            Dim combinedChart As ChartControl = New ChartControl()
            ' Create two series of different types.
            Dim series1 As Series = New Series("Area Series", ViewType.Spline3D)
            Dim series2 As Series = New Series("Line Series", ViewType.Bar3D)
            ' Add points to them.
            series1.Points.Add(New SeriesPoint(1, New Double() {10}))
            series1.Points.Add(New SeriesPoint(2, New Double() {2}))
            series1.Points.Add(New SeriesPoint(3, New Double() {14}))
            series1.Points.Add(New SeriesPoint(4, New Double() {17}))
            series2.Points.Add(New SeriesPoint(1, New Double() {5}))
            series2.Points.Add(New SeriesPoint(2, New Double() {16}))
            series2.Points.Add(New SeriesPoint(3, New Double() {4}))
            series2.Points.Add(New SeriesPoint(4, New Double() {11}))
            ' Add the series to the chart.
            combinedChart.Series.Add(series2)
            combinedChart.Series.Add(series1)
            ' Hide the legend (if necessary).
            combinedChart.Legend.Visible = False
            ' Add the chart to the form.
            combinedChart.Dock = DockStyle.Fill
            Me.Controls.Add(combinedChart)
        End Sub
    End Class
End Namespace
