using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace NominaMensual
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }


       
        public static string xcedula;
        public static string xnombre;
        public static string xapellido;
        public static string xdireccion;
        public static string xsexo;
        public static string xsueldo;
        public static string xfecha_de_necimeinto;
        public static string xfecha_de_ingreso;
        public static string xcod_cargo;




        private void btnCrear_Click(object sender, EventArgs e)
        {
            //Llamado al formulario empleado//
            Form formulario = new Empleado();
            formulario.Show();          
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Operaciones ope = new Operaciones();


            //Condicion buscar para de esta mandera elegir como buscar, si por nombre, id, apellido o cedula//
            if (comboBox1.Text.Length == 0)
            {

                DataTable dt = ope.ConsultaconResultado(" SELECT  * FROM empleados ");
                dataGridView1.DataSource = dt;
                return;
            }

            if (radioButton1.Checked == true)
            {
                DataTable dt = ope.ConsultaconResultado(" SELECT  * FROM empleados WHERE cod_empleado = '" + comboBox1.Text.Trim() + "' ");
                dataGridView1.DataSource = dt;
                return;
            }

            if (radioButton2.Checked == true)
            {
                DataTable dt = ope.ConsultaconResultado(" SELECT  * FROM empleados WHERE nombre like '%" + comboBox1.Text.Trim() + "%' ");
                dataGridView1.DataSource = dt;
                return;
            }

            if (radioButton3.Checked == true)
            {
                DataTable dt = ope.ConsultaconResultado(" SELECT  * FROM empleados WHERE apellido like '%" + comboBox1.Text.Trim() + "%' ");
                dataGridView1.DataSource = dt;
                return;
            }

            if (radioButton4.Checked == true)
            {
                DataTable dt = ope.ConsultaconResultado(" SELECT  * FROM empleados WHERE cedula like '%" + comboBox1.Text.Trim() + "%' ");
                dataGridView1.DataSource = dt;
                return;

            }


        }


        private void btnConex_Click(object sender, EventArgs e)
        {
            //Estableciendo conxion a la base de dato con un mensaje por si hace una cosa o la otra//
            Operaciones op = new Operaciones();
            
            String resultado=op.Conectar();
            MessageBox.Show(resultado);
            

            DataTable dt_empleado = op.ConsultaconResultado(" SELECT  * FROM empleados where id=1 ");
            foreach (DataRow dr in dt_empleado.Rows)
            {
                string nombre, apellidos;
                nombre = dr["nombre"].ToString();
                apellidos = dr["apellidos"].ToString();
                comboBox1.Text = nombre + " " + apellidos;
            }


        }

       

        private void dataGridViewA_CellContentClick(object sender, DataGridViewCellEventArgs e)

        {
            //Evento del click en el datagriview//
            System.Data.DataTable res = new System.Data.DataTable();
            Operaciones op = new Operaciones();

            dataGridView1.DataSource = op.ConsultaconResultado(" SELECT *FROM empleados");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            //Cerrar formulario//
            this.Close();
        }

       
    private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            //Click del radio//
            Operaciones ope = new Operaciones();

              if (radioButton1.Checked == true)

               {
                    DataTable dt = ope.ConsultaconResultado(" SELECT  * FROM empleados WHERE nombre like '%" + comboBox1.Text.Trim() + "%' ");
                       dataGridView1.DataSource = dt;
                         return;
               }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //limpia todos los comBoBox//
            int x = 0;
            string borrado;

            borrado = comboBox1.Text;
            x = borrado.Length - 1;
            borrado = borrado.Substring(0, x);
            comboBox1.Text = borrado;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Barra el todo del Combox de la calculadora//
            comboBox1.Clear();    
        }

        

        private void button3_Click(object sender, EventArgs e)
        {
         }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                //Las celdas de datagriview para cuando doy click
                Empleado.xcod_cargo = row.Cells[0].Value.ToString();
                Empleado.xcedula = row.Cells[0].Value.ToString();
                Empleado.xnombre = row.Cells[1].Value.ToString();
                Empleado.xapellido = row.Cells[2].Value.ToString();
                Empleado.xdireccion = row.Cells[0].Value.ToString();
                Empleado.xsexo = row.Cells[3].Value.ToString();
                Empleado.xsueldo = row.Cells[0].Value.ToString();
                Empleado.xfecha_de_necimeinto = row.Cells[4].Value.ToString();
                Empleado.xfecha_de_ingreso = row.Cells[5].Value.ToString();
                Empleado.xcod_cargo = row.Cells[6].Value.ToString();

                //Y luego llamo al formulario donde agrego nuevos registros//
                Form formulario = new Empleado();
                formulario.Show();


            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

 }
    

