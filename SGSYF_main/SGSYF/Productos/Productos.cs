using MySql.Data.MySqlClient;
using SGSYF_clases;
using SGSYF_conexion;

namespace SGSYF;

public partial class Productos : Form
{
    public Productos()
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
            AgregarProductoNuevo segundoFormHijo = new AgregarProductoNuevo();
            segundoFormHijo.MdiParent = this.MdiParent;
            segundoFormHijo.Show();
        }
    }

    private void Productos_Load(object sender, EventArgs e)
    {

    }


}
