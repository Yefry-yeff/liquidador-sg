using comprobacion.clases;
using DevExpress.XtraEditors;
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
    public partial class promDifVaFact : DevExpress.DXperience.Demos.TutorialControlBase 
        //DevExpress.XtraEditors.XtraUserControl
    {
        public promDifVaFact()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Object[] vDatos = new object[3];
            vDatos = new object[3];

 
            dbOracle cdb = new dbOracle();

            DataTable d = new DataTable();
            d = cdb.obtenerConsultas("diferenciaCHAP1", vDatos);

        }

        private void promDifVaFact_Load(object sender, EventArgs e)
        {

        }
    }
}
