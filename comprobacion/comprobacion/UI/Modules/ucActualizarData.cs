using comprobacion.clases;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace comprobacion.UI.Modules
{
    public partial class ucActualizarData : DevExpress.DXperience.Demos.TutorialControlBase
    {
        public ucActualizarData()
        {
            InitializeComponent();

            dbOracle cdb = new dbOracle();

            FluentSplashScreenOptions op = new FluentSplashScreenOptions();
            op.Title = "CONSULTANDO DATA ACTUÁL DE LECTURAS POR DIAL ";
            op.RightFooter = "Cargando datos, espere...";
            op.LeftFooter = "";
            op.LoadingIndicatorType = FluentLoadingIndicatorType.Dots;
            op.OpacityColor = Color.FromArgb(56, 85, 122);
            op.Opacity = 130;

            DevExpress.XtraSplashScreen.SplashScreenManager.ShowFluentSplashScreen(
                op,
                useFadeIn: true,
                useFadeOut: true
            );

            DataTable d = new DataTable();
            d = cdb.obtenerConsultas("dataActualizadaSP");
            this.gridControl1.DataSource = d;
            this.gridControl1.Refresh();

            DevExpress.XtraSplashScreen.SplashScreenManager.CloseForm();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ucActualizarData_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            dbOracle cdb = new dbOracle();

            FluentSplashScreenOptions op = new FluentSplashScreenOptions();
            op.Title = "ACTUALIZANDO DATA DEL MES EN CURSO";
            op.RightFooter = "Cargando datos, espere...";
            op.LeftFooter = "";
            op.LoadingIndicatorType = FluentLoadingIndicatorType.Dots;
            op.OpacityColor = Color.FromArgb(56, 85, 122);
            op.Opacity = 130;

            DevExpress.XtraSplashScreen.SplashScreenManager.ShowFluentSplashScreen(
                op,
                useFadeIn: true,
                useFadeOut: true
            );

            DataSet ds = obtenerDataSetOracle(@"exec SYS.SP_ACTUALIZA_LC_TLECTURAS;");

            DataTable d = new DataTable();
            d = cdb.obtenerConsultas("dataActualizadaSP");
            this.gridControl1.DataSource = d;
            this.gridControl1.Refresh();

            DevExpress.XtraSplashScreen.SplashScreenManager.CloseForm();
        }

        public DataSet obtenerDataSetOracle(string pQuery, int pCmdTimeOut = 30, string pConnectionString = "INDRA")
        {
            DataSet ds = new DataSet();

            try
            {
                string conStr = "";
                //cadena de conexión
                conStr = "Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = 192.168.100.33)(PORT = 1521)) (CONNECT_DATA =(SERVER = DEDICATED) (SERVICE_NAME = SGPROD))); User Id = USRSGDESA; Password = USRSGDESA; ";//ConfigurationManager.AppSettings[pConnectionString].ToString();

                OracleConnection sqlCon = new OracleConnection(conStr);
                sqlCon.Open();
                OracleCommand sqlComm = new OracleCommand(pQuery, sqlCon);

                OracleDataAdapter sqlAdap = new OracleDataAdapter(sqlComm);
                sqlAdap.SelectCommand.CommandTimeout = pCmdTimeOut;
                sqlAdap.Fill(ds);
                sqlCon.Close();
                sqlCon.Dispose();
            }
            catch (Exception ex)
            {
            }

            return ds;
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
