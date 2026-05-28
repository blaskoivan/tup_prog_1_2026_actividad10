using System.Transactions;
using Ejemplo.Services;
using Ejercicio1.Services;

namespace Ejercicio1;

public partial class FormPrincipal : Form
{
    NumericService servicio = new NumericService();

    public FormPrincipal()
    {

        InitializeComponent();
    }
    public btnRegistrar.Click(){
        int valor=Convert.ToInt32(tbValor.Text);
        servicio.Registrar(valor);
        }
}
