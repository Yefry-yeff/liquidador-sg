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
    public partial class ucReLiquidar : DevExpress.DXperience.Demos.TutorialControlBase
    //DevExpress.XtraEditors.XtraUserControl
    {
        public ucReLiquidar()
        {
            InitializeComponent();
            dbOracle cdb = new dbOracle();

            FluentSplashScreenOptions op = new FluentSplashScreenOptions();
            op.Title = "CONSULTANDO DATA ACTUÁL DE LECTURAS ";
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

        //Esta funcion es cuando cargue la página
        private void ucReLiquidar_Load(object sender, EventArgs e)
        {

        }


        private void simpleButton1_Click(object sender, EventArgs e)
        {

            TextBox[] textboxs;
            textboxs = new TextBox[] { textBox1, textBox2, textBox3 };

            bool datosCorrectos = !textboxs.Any(X => String.IsNullOrEmpty(X.Text));

            if (datosCorrectos)
            {

                /*Object[] vDatos = new object[3];
                vDatos = new object[3];

                vDatos[0] = int.Parse(textBox1.Text);
                vDatos[1] = int.Parse(textBox2.Text);
                vDatos[2] = int.Parse(textBox3.Text);*/

                Object[] vDatos2 = new object[2];
                vDatos2 = new object[2];
                vDatos2[0] = int.Parse(textBox3.Text);
                vDatos2[1] = int.Parse(textBox1.Text + 0 + textBox2.Text);
                

                dbOracle cdb = new dbOracle();

                FluentSplashScreenOptions op = new FluentSplashScreenOptions();
                op.Title = "RELIQUIDANDO EL PERIODO " + " " + textBox2.Text + " Y EL DIAL" + " " + textBox3.Text;
                op.RightFooter = "Cargando datos, espere...";
                op.LeftFooter = "";
                op.LoadingIndicatorType = FluentLoadingIndicatorType.Dots;
                op.OpacityColor = Color.FromArgb(56, 85, 122);
                op.Opacity = 130;

                DevExpress.XtraSplashScreen.SplashScreenManager.ShowFluentSplashScreen( op,useFadeIn: true,useFadeOut: true);

                cdb.ejecutarSql(@"        DECLARE
                                        -- Variable declarations
                                        l_LES_ANO       SMALLINT;
                                        l_LES_MES       SMALLINT;
                                        l_LVC_CICLO     VARCHAR2 (32767);
                                        l_LEI_PROCESO   INTEGER;
                                        l_LVC_USUARIO   VARCHAR2 (32767);
                                        BEGIN
                                            -- Variable initializations
                                            l_LES_ANO := " + textBox1.Text + @";
                                            l_LES_MES := " + textBox2.Text + @";
                                            l_LVC_CICLO := " + textBox3.Text + @";
                                            l_LEI_PROCESO := 550;
                                            l_LVC_USUARIO := 'CHECO';

                                            -- Call
                                            SCHON.PKG_LIQUIDACION.LIQUIDAR_CICLO (LES_ANO       => l_LES_ANO,
                                                                                  LES_MES       => l_LES_MES,
                                                                                  LVC_CICLO     => l_LVC_CICLO,
                                                                                  LEI_PROCESO   => l_LEI_PROCESO,
                                                                                  LVC_USUARIO   => l_LVC_USUARIO);

                                            -- Transaction control
                                            COMMIT;
                                        END;

                                ");

                /*DataTable d = new DataTable();
                d = cdb.obtenerConsultas("diferenciaCHAP1", vDatos2);
                this.gridControl1.DataSource = d;
                this.gridControl1.Refresh();*/

                DataTable d = new DataTable();
                d = cdb.obtenerConsultas("dataActualizadaSP");
                this.gridControl1.DataSource = d;
                this.gridControl1.Refresh();


                DevExpress.XtraSplashScreen.SplashScreenManager.CloseForm();
            }
            else
            {
                string message = "No ingresó algún dato, por favor, asegúrese de completar todo el formulario antes de Ejecutar la consulta.";
                string caption = "Formulario Incompleto";

                DialogResult result;

                result = MessageBox.Show(message, caption);
            }
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

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
    }
}
