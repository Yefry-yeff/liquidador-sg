using comprobacion.clases;
using DevExpress.Export;
using DevExpress.Export.Xl;
using DevExpress.XtraEditors;
using DevExpress.XtraPrinting;
using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace comprobacion.UI.Modules
{
    public partial class promDifConc : DevExpress.DXperience.Demos.TutorialControlBase
    //DevExpress.XtraEditors.XtraUserControl
    {
        public promDifConc()
        {
            InitializeComponent();
            this.barButtonItem2.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TextBox[] textboxs;
            textboxs = new TextBox[] { textBox1 };

            bool datosCorrectos = !textboxs.Any(X => String.IsNullOrEmpty(X.Text));

            if (datosCorrectos)
            {

                Object[] vDatos = new object[1];
                vDatos = new object[1];
                vDatos[0] = int.Parse(textBox1.Text);

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

                DataTable d1 = new DataTable();
                d1 = cdb.obtenerConsultas("resumenCiclos", vDatos);

                this.gridControl1.DataSource = d1;
                this.gridControl1.Refresh();


                DataTable d2 = new DataTable();
                d2 = cdb.obtenerConsultas("diferencisConceptos", vDatos);

                this.gridControl2.DataSource = d2;
                this.gridControl2.Refresh();

                DevExpress.XtraSplashScreen.SplashScreenManager.CloseForm();
                this.barButtonItem2.Enabled = true;
            }
            else
            {
                string message = "No ingresó el dato solicitado, por favor, asegúrese de completar todo el formulario antes de Ejecutar la consulta.";
                string caption = "Formulario Incompleto";

                DialogResult result;

                result = MessageBox.Show(message, caption);

            }
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void gridControl1_Click_1(object sender, EventArgs e)
        {

        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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
    }
}
