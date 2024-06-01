using System.Data;

namespace RegistroLibro
{
    public partial class RegistroLibros : System.Web.UI.Page
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conexionBD"].ConnectionString);
        void Limpiar()
        {
            tbTitulo.Text = "";
            tbAño.Text = "";
            tbGenero.Text = "";
            tbNumerodePagina.Text = "";
            tbAutor.Text = "";
            tbNombreCompleto.Text = "";
            tbFechaNacimiento.Text = "";
            tbCiudaddeProcedencia.Text = "";
            tbCorreoElectronico.Text = "";
        }
    protected void BtnRegistrar_Click(Object sender, EventArgs e)
    {
        if (tbTitulo.Text == "" || tbAño.Text == "" || tbGenero.Text == "" || NumerodePagina.Text == "" || tbAutor.Text == "" || tbNombreCompleto.Text == "" || tbFechaNacimint.Text == "" || tbFechaNacimiento.Text == "" || tbCiudaddeProcedencia.Text == "" || tbCorreoElectronico.Text == "")
        {
            lblError.Text = "Ningun campo puede quedar vacío!";
        }
           else
                {
                    lblError.Text = "El Libro " + tbTitulo.Text + " ya existe!";
                    tbTitulo.Text = "";
                }
           }
    }

    void LeerDatos()
    {
        SqlCommand leerdatos = new SqlCommand("Select * from Libros", conexion);
        SqlDataAdapter da = new SqlDataAdapter(leerdatos);
        DataTable dt = new DataTable();
        da.Fill(dt);
        object value = gvTitulo.DataSource = dt;
            object value =  gvTitulo.DataBind();
    }
}
}