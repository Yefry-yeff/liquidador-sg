
namespace comprobacion
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.fluentDesignFormContainer = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.accordionControlElementMenuPrincipal = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElementActualizarData = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElementCalcularInconsistencias = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElementAnalisisVarios = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElementPromedioDValor = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElementPromedioDConcepto = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.itemNav = new DevExpress.XtraBars.BarStaticItem();
            this.fluentFormDefaultManager1 = new DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager(this.components);
            this.accordionControlElementReLiquidar = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // fluentDesignFormContainer
            // 
            this.fluentDesignFormContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fluentDesignFormContainer.Location = new System.Drawing.Point(325, 39);
            this.fluentDesignFormContainer.Margin = new System.Windows.Forms.Padding(4);
            this.fluentDesignFormContainer.Name = "fluentDesignFormContainer";
            this.fluentDesignFormContainer.Size = new System.Drawing.Size(1266, 821);
            this.fluentDesignFormContainer.TabIndex = 0;
            // 
            // accordionControl1
            // 
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElementMenuPrincipal});
            this.accordionControl1.Location = new System.Drawing.Point(0, 39);
            this.accordionControl1.Margin = new System.Windows.Forms.Padding(4);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
            this.accordionControl1.Size = new System.Drawing.Size(325, 821);
            this.accordionControl1.TabIndex = 1;
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            this.accordionControl1.Click += new System.EventHandler(this.accordionControl1_Click);
            // 
            // accordionControlElementMenuPrincipal
            // 
            this.accordionControlElementMenuPrincipal.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElementActualizarData,
            this.accordionControlElementReLiquidar,
            this.accordionControlElementAnalisisVarios});
            this.accordionControlElementMenuPrincipal.Expanded = true;
            this.accordionControlElementMenuPrincipal.Name = "accordionControlElementMenuPrincipal";
            this.accordionControlElementMenuPrincipal.Text = "Menú Principal";
            this.accordionControlElementMenuPrincipal.Click += new System.EventHandler(this.accordionControlElementMenuPrincipal_Click);
            // 
            // accordionControlElementActualizarData
            // 
            this.accordionControlElementActualizarData.Name = "accordionControlElementActualizarData";
            this.accordionControlElementActualizarData.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElementActualizarData.Text = "Actualizar Data";
            this.accordionControlElementActualizarData.Click += new System.EventHandler(this.accordionControlElementActualizarData_Click);
            // 
            // accordionControlElementCalcularInconsistencias
            // 
            this.accordionControlElementCalcularInconsistencias.Name = "accordionControlElementCalcularInconsistencias";
            this.accordionControlElementCalcularInconsistencias.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElementCalcularInconsistencias.Text = "Consulta inconsistencias FACT-INCMS";
            this.accordionControlElementCalcularInconsistencias.Click += new System.EventHandler(this.accordionControlElementCalcularInconsistencias_Click);
            // 
            // accordionControlElementAnalisisVarios
            // 
            this.accordionControlElementAnalisisVarios.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElementCalcularInconsistencias,
            this.accordionControlElementPromedioDValor,
            this.accordionControlElementPromedioDConcepto});
            this.accordionControlElementAnalisisVarios.Expanded = true;
            this.accordionControlElementAnalisisVarios.Name = "accordionControlElementAnalisisVarios";
            this.accordionControlElementAnalisisVarios.Text = "Consulas Varias";
            // 
            // accordionControlElementPromedioDValor
            // 
            this.accordionControlElementPromedioDValor.Name = "accordionControlElementPromedioDValor";
            this.accordionControlElementPromedioDValor.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElementPromedioDValor.Text = "Consulta X";
            this.accordionControlElementPromedioDValor.Click += new System.EventHandler(this.accordionControlElementPromedioDValor_Click);
            // 
            // accordionControlElementPromedioDConcepto
            // 
            this.accordionControlElementPromedioDConcepto.Name = "accordionControlElementPromedioDConcepto";
            this.accordionControlElementPromedioDConcepto.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElementPromedioDConcepto.Text = "Resumen Universal";
            this.accordionControlElementPromedioDConcepto.Click += new System.EventHandler(this.accordionControlElementPromedioDConcepto_Click);
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.FluentDesignForm = this;
            this.fluentDesignFormControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.itemNav});
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Manager = this.fluentFormDefaultManager1;
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(1591, 39);
            this.fluentDesignFormControl1.TabIndex = 2;
            this.fluentDesignFormControl1.TabStop = false;
            this.fluentDesignFormControl1.TitleItemLinks.Add(this.itemNav);
            // 
            // itemNav
            // 
            this.itemNav.Caption = "?";
            this.itemNav.Id = 2;
            this.itemNav.Name = "itemNav";
            // 
            // fluentFormDefaultManager1
            // 
            this.fluentFormDefaultManager1.Form = this;
            this.fluentFormDefaultManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.itemNav});
            this.fluentFormDefaultManager1.MaxItemId = 3;
            // 
            // accordionControlElementReLiquidar
            // 
            this.accordionControlElementReLiquidar.Name = "accordionControlElementReLiquidar";
            this.accordionControlElementReLiquidar.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElementReLiquidar.Text = "ReLiquidar";
            this.accordionControlElementReLiquidar.Click += new System.EventHandler(this.accordionControlElementReLiquidar_Click_1);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1591, 860);
            this.ControlContainer = this.fluentDesignFormContainer;
            this.Controls.Add(this.fluentDesignFormContainer);
            this.Controls.Add(this.accordionControl1);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("frmMain.IconOptions.SvgImage")));
            this.Name = "frmMain";
            this.NavigationControl = this.accordionControl1;
            this.Text = "Comparativo Facturaciones";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer fluentDesignFormContainer;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElementMenuPrincipal;
        private DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager fluentFormDefaultManager1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElementActualizarData;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElementCalcularInconsistencias;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElementAnalisisVarios;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElementPromedioDValor;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElementPromedioDConcepto;
        private DevExpress.XtraBars.BarStaticItem itemNav;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElementReLiquidar;
    }
}