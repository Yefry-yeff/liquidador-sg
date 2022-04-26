
using comprobacion.clases;
using DevExpress.Export;
using DevExpress.Export.Xl;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraPrinting;
using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace comprobacion.UI.Modules
{
    public partial class ucAnalisisIncoherencias : DevExpress.DXperience.Demos.TutorialControlBase
        //DevExpress.XtraEditors.XtraUserControl
    {
        public ucAnalisisIncoherencias()
        {
            InitializeComponent();
            this.simpleButton2.Enabled = false;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            TextBox[] textboxs;
            textboxs = new TextBox[] { textBox1 , textBox2 };

            bool datosCorrectos = !textboxs.Any(X => String.IsNullOrEmpty(X.Text));

            if (datosCorrectos)
            {
                Object[] vDatos = new object[2];
                vDatos = new object[2];

                vDatos[0] = int.Parse(textBox1.Text);
                vDatos[1] = int.Parse(textBox2.Text);

                dbOracle cdb = new dbOracle();

                FluentSplashScreenOptions op = new FluentSplashScreenOptions();
                op.Title = "CONSULTANDO RESUMEN DE PERIODO " + " " + textBox1.Text;
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
                d = cdb.obtenerConsultas("diferenciaCHAP1", vDatos);
                this.gridControl1.DataSource = d;
                this.gridControl1.Refresh();

                DevExpress.XtraSplashScreen.SplashScreenManager.CloseForm();

                this.simpleButton2.Enabled = true;
            }
            else
            {
                string message = "No ingresó ningún dato, por favor, asegúrese de completar el formulario antes de Ejecutar la consulta.";
                string caption = "Formulario Incompleto";

                DialogResult result;

                result = MessageBox.Show(message, caption);
            }

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            XlsxExportOptionsEx options = new XlsxExportOptionsEx() { UnboundExpressionExportMode = DevExpress.Export.UnboundExpressionExportMode.AsFormula, LayoutMode = LayoutMode.Table };
            options.BeforeExportTable += options_BeforeExportTable;
            this.gridControl1.ExportToXlsx("Document.xlsx", options);
            System.Diagnostics.Process.Start("Document.xlsx");
        }

        void options_BeforeExportTable(BeforeExportTableEventArgs e)
        {
            e.Table.Style.Name = XlBuiltInTableStyleId.Light1;
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
