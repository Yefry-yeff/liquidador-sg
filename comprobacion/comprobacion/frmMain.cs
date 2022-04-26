using DevExpress.DXperience.Demos;
using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace comprobacion
{
    public partial class frmMain : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        async Task LoadModuleAsync(ModuleInfo module)
        {
            await Task.Factory.StartNew(() =>
            {
                if (!fluentDesignFormContainer.Controls.ContainsKey(module.Name))
                {
                    TutorialControlBase control = module.TModule as TutorialControlBase;
                    if (control != null)
                    {
                        control.Dock = DockStyle.Fill;
                        control.CreateWaitDialog();
                        fluentDesignFormContainer.Invoke(new MethodInvoker(delegate ()
                        {
                            fluentDesignFormContainer.Controls.Add(control);
                            control.BringToFront();
                        }));
                    }
                }
                else
                {
                    var control = fluentDesignFormContainer.Controls.Find(module.Name, true);
                    if (control.Length == 1)
                        fluentDesignFormContainer.Invoke(new MethodInvoker(delegate () { control[0].BringToFront(); }));
                }
            });
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.itemNav.Caption = $"{accordionControlElementMenuPrincipal.Text}";


        }

        private void accordionControl1_Click(object sender, EventArgs e)
        {

        }

        private async void accordionControlElementMenuPrincipal_Click(object sender, EventArgs e)
        {

        }

        private async void accordionControlElementReLiquidar_Click_1(object sender, EventArgs e)
        {
            this.itemNav.Caption = $"{accordionControlElementMenuPrincipal.Text}/{accordionControlElementReLiquidar.Text}";
            if (ModulesInfo.GetItem("ucReLiquidar") == null)
                ModulesInfo.Add(new ModuleInfo("ucReLiquidar", "comprobacion.UI.Modules.ucReLiquidar"));
            await LoadModuleAsync(ModulesInfo.GetItem("ucReLiquidar"));
        }

        private async void accordionControlElementActualizarData_Click(object sender, EventArgs e)
        {
            /*this.itemNav.Caption = $"{accordionControlElementMenuPrincipal.Text}/{accordionControlElementActualizarData.Text}";
            if (ModulesInfo.GetItem("ucActualizarData") == null)
                ModulesInfo.Add(new ModuleInfo("ucActualizarData", "comprobacion.UI.Modules.ucActualizarData"));
            await LoadModuleAsync(ModulesInfo.GetItem("ucActualizarData"));*/

            this.itemNav.Caption = $"{accordionControlElementMenuPrincipal.Text}/{accordionControlElementActualizarData.Text}";
            if (ModulesInfo.GetItem("ucActualizarData") == null)
                ModulesInfo.Add(new ModuleInfo("ucActualizarData", "comprobacion.UI.Modules.ucActualizarData"));
            await LoadModuleAsync(ModulesInfo.GetItem("ucActualizarData"));


        }

        private async void accordionControlElementCalcularInconsistencias_Click(object sender, EventArgs e)
        {
            this.itemNav.Caption = $"{accordionControlElementMenuPrincipal.Text}/{accordionControlElementCalcularInconsistencias.Text}";
            if (ModulesInfo.GetItem("ucAnalisisIncoherencias") == null)
                ModulesInfo.Add(new ModuleInfo("ucAnalisisIncoherencias", "comprobacion.UI.Modules.ucAnalisisIncoherencias"));
            await LoadModuleAsync(ModulesInfo.GetItem("ucAnalisisIncoherencias"));
        }

        private async void accordionControlElementPromedioDValor_Click(object sender, EventArgs e)
        {
            this.itemNav.Caption = $"{accordionControlElementMenuPrincipal.Text}/{accordionControlElementAnalisisVarios.Text}/{accordionControlElementPromedioDValor.Text}";
            if (ModulesInfo.GetItem("promDifVaFact") == null)
                ModulesInfo.Add(new ModuleInfo("promDifVaFact", "comprobacion.UI.Modules.promDifVaFact"));
            await LoadModuleAsync(ModulesInfo.GetItem("promDifVaFact"));
        }

        private async void accordionControlElementPromedioDConcepto_Click(object sender, EventArgs e)
        {
            this.itemNav.Caption = $"{accordionControlElementMenuPrincipal.Text}/{accordionControlElementAnalisisVarios.Text}/{accordionControlElementPromedioDConcepto.Text}";
            if (ModulesInfo.GetItem("promDifConc") == null)
                ModulesInfo.Add(new ModuleInfo("promDifConc", "comprobacion.UI.Modules.promDifConc"));
            await LoadModuleAsync(ModulesInfo.GetItem("promDifConc"));
        }

    }
}
