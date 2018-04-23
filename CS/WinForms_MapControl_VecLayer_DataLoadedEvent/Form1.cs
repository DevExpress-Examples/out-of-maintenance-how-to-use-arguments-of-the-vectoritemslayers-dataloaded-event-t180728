using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraMap;

namespace WinForms_MapControl_VecLayer_DataLoadedEvent {
    public partial class Form1 : Form {
        const string filepath = "..\\..\\Earthquakes.xml";

        VectorItemsLayer vectorLayer = new VectorItemsLayer();

        public Form1() {
            InitializeComponent();
            InitializeMap();
        }

        private void InitializeMap() {
            MapControl map = new MapControl() { Dock = DockStyle.Fill };
            this.Controls.Add(map);

            map.Layers.Add(new ImageTilesLayer() {
                DataProvider = new BingMapDataProvider() {
                    BingKey = "YOUR BING KEY"
                }
            });
            map.Layers.Add(vectorLayer);

            vectorLayer.DataLoaded += vectorLayer_DataLoaded;
        }

        #region #DataLoaded
        void vectorLayer_DataLoaded(object sender, DataLoadedEventArgs e) {
            MapItemsLoadedEventArgs args = e as MapItemsLoadedEventArgs;
            if (args == null) return;

            lLayerState.Text = args.Items.Count().ToString() + " items loaded.";
        }
        #endregion #DataLoaded

        IMapDataAdapter CreateData(object datasource) {
            BubbleChartDataAdapter adapter = new BubbleChartDataAdapter() { DataSource = datasource, ItemMaxSize = 50, ItemMinSize = 10 };
            adapter.Mappings.Latitude = "glat";
            adapter.Mappings.Longitude = "glon";
            adapter.Mappings.Value = "mag";

            return adapter;
        }

        private DataTable LoadData(string path) {
            DataSet ds = new DataSet();
            ds.ReadXml(path);
            DataTable table = ds.Tables[0];
            return table;
        }

        private void bLoadData_Click(object sender, EventArgs e) {
            lLayerState.Text = "Please wait.";
            vectorLayer.Data = CreateData(LoadData(filepath));
        }
    }
}
