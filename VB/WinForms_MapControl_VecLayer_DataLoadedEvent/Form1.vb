Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports DevExpress.XtraMap

Namespace WinForms_MapControl_VecLayer_DataLoadedEvent
    Partial Public Class Form1
        Inherits Form

        Private Const filepath As String = "..\..\Earthquakes.xml"

        Private vectorLayer As New VectorItemsLayer()

        Public Sub New()
            InitializeComponent()
            InitializeMap()
        End Sub

        Private Sub InitializeMap()
            Dim map As New MapControl() With {.Dock = DockStyle.Fill}
            Me.Controls.Add(map)

            map.Layers.Add(New ImageTilesLayer() With { _
                .DataProvider = New BingMapDataProvider() With {.BingKey = "YOUR BING KEY"} _
            })
            map.Layers.Add(vectorLayer)

            AddHandler vectorLayer.DataLoaded, AddressOf vectorLayer_DataLoaded
        End Sub

        #Region "#DataLoaded"
        Private Sub vectorLayer_DataLoaded(ByVal sender As Object, ByVal e As DataLoadedEventArgs)
            Dim args As MapItemsLoadedEventArgs = TryCast(e, MapItemsLoadedEventArgs)
            If args Is Nothing Then
                Return
            End If

            lLayerState.Text = args.Items.Count().ToString() & " items loaded."
        End Sub
        #End Region ' #DataLoaded

        Private Function CreateData(ByVal datasource As Object) As IMapDataAdapter
            Dim adapter As New BubbleChartDataAdapter() With {.DataSource = datasource, .ItemMaxSize = 50, .ItemMinSize = 10}
            adapter.Mappings.Latitude = "glat"
            adapter.Mappings.Longitude = "glon"
            adapter.Mappings.Value = "mag"

            Return adapter
        End Function

        Private Function LoadData(ByVal path As String) As DataTable
            Dim ds As New DataSet()
            ds.ReadXml(path)
            Dim table As DataTable = ds.Tables(0)
            Return table
        End Function

        Private Sub bLoadData_Click(ByVal sender As Object, ByVal e As EventArgs) Handles bLoadData.Click
            lLayerState.Text = "Please wait."
            vectorLayer.Data = CreateData(LoadData(filepath))
        End Sub
    End Class
End Namespace
