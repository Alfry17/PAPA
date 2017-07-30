using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NominaMensual
{
    public partial class CargoEmpleado : Form
    {
        public CargoEmpleado()
        {
            InitializeComponent();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

           //Actualiza nuevas ediciones de registro de la tabla cargos//
            Operaciones op = new Operaciones();
            op.ConsultasinResultado("UPDATE cargo SET cod_cargo = '" + txtCa.Text + "', nombre_cargo = '" + txtCarg.Text + "' WHERE cod_cargo LIKE '%" + txtpu.Text + "%'");
        }



        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if (txtCod_cargo.Text != null)
            {
                //Condiocion de boorar de la de la base de dato//
                Operaciones op = new Operaciones();
                op.ConsultasinResultado("DELETE from empleados WHERE cod_empleado = " + txtCod_cargo.Text);
                
            }
        }



        private void btnCrear_Click(object sender, EventArgs e)
        {
            //Insertar nuevos cargos en la base de datos//
            Operaciones op = new Operaciones();
            op.ConsultasinResultado("INSERT INTO cargo (cod_cargo, nombre_cargo) VALUES ('" + txtCa.Text + "', '" + txtCarg.Text + "')");
        }



        private void btnBus_Click(object sender, EventArgs e)
        {

            Operaciones oper = new Operaciones();
            DataTable dt_cargo = oper.ConsultaconResultado(" SELECT  * FROM cargo where cod_empleado='" + txtCod_cargo.Text + "' ");



            foreach (DataRow dr in dt_cargo.Rows)
            {
                //Esto me permitira buscar en mi base de dato por ID//
                string cod_cargo, nombre_cargo;

               
                cod_cargo = dr["cod_cargo"].ToString();
                nombre_cargo = dr["cod_cargo"].ToString();

                txtCa.Text = cod_cargo;
                txtCarg.Text = nombre_cargo;
              
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtCa.Text = "";
            txtCod_cargo.Text = "";
        }
    }
}
