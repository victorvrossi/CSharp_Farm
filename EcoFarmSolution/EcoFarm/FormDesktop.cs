using EcoFarm.@class;

namespace EcoFarm
{
    public partial class FormDesktop : Form
    {
        private UtilForm util;
        public FormDesktop()
        {
            util = new UtilForm();
            InitializeComponent();

        }


        private void button1_Click(object sender, EventArgs e)
        {
            util.openForm(this.panelDesktop, new FormGerenciarProduto(), null);
        }

    }
}
