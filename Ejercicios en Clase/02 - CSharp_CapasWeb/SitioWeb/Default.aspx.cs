
using System;
using System.Data;
using LogicaNegocio;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SitioWeb
{
    public partial class Default : System.Web.UI.Page
    {


        private void CargarListaDataSet(string condicion = "", string orden = "")
        {
            //carga el datagridview con el dataset
            BLCliente logica = new BLCliente(clsconfiguracion.getConnectionString);
            DataSet DSClientes;

            try
            {
                DSClientes = logica.ListarClientes(condicion, orden);
                grdLista.DataSource = DSClientes;
                grdLista.DataMember = DSClientes.Tables["Clientes"].TableName;
                grdLista.DataBind();
                //en la tabla con nombre Clientes del dataset
            }
            catch (Exception)
            {
                throw;
            }
        }// fin CargarListaDataSet

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {
                    CargarListaDataSet();
                }
            }
            catch (Exception)
            {
                //throw
            }
        }
    }
}