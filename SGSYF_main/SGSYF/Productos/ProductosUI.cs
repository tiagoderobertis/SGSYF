namespace SGSYF;

public partial class ProductosUI : Form
{
    public ProductosUI()
    {
        InitializeComponent();
        SGSYF_UI formi = new SGSYF_UI();
        formi.Mover();
    }



    private void btn_agregarProducto_Click(object sender, EventArgs e)
    {
        SGSYF_UI ui = new SGSYF_UI();
        if (ui.Validar_Form("Productos") == false)
        {
            AgregarProductoNuevo agregarProductoNuevo = new AgregarProductoNuevo();
            agregarProductoNuevo.MdiParent = this.MdiParent;
            agregarProductoNuevo.Show();
        }
    }

    private void Productos_Load(object sender, EventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {
        EliminarProductoCompletamente eliminarProductoCompletamente = new EliminarProductoCompletamente();
        eliminarProductoCompletamente.MdiParent = this.MdiParent;
        eliminarProductoCompletamente.Show();

    }
}
