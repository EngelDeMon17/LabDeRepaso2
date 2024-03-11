using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabDeRepaso2
{
    public partial class Form1 : Form
    {
        List<Cliente> clientes = new List<Cliente>();
        List<Vehiculo> vehiculos = new List<Vehiculo>();
        List<Alquiler> alquilers = new List<Alquiler>();

        public Form1()
        {
            InitializeComponent();
        }

        public void CargarClientes()
        {
            //Leer el archivo y cargarlo a la lista
            //no se cargha al Datagridview por las operaciones que debemos realizar
            string fileName = "Clientes.txt";

            FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            while (reader.Peek() > -1)
            {
                //leer los datos del empleado
                Cliente cliente = new Cliente();
                cliente.Nit = Convert.ToInt32(reader.ReadLine());
                cliente.Nombre = reader.ReadLine();
                cliente.Direccion = reader.ReadLine();
               
                //guardar el empleado en la lista de empleados
                clientes.Add(cliente);
            }
            reader.Close();

        }

        public void MostrarClientes()
        {
            //Mostrar la lista de empleados en el gridview
            dataGridViewCliente.DataSource = null;
            dataGridViewCliente.DataSource = clientes;
            dataGridViewCliente.Refresh();

        }

        public void CargarVehiculo()
        {
            int Preciokm;
            int.TryParse(textBoxPreciokm.Text, out Preciokm);

            using (StreamWriter sw = new StreamWriter("Vehiculos.txt", true))
            {
                sw.Write(textBoxPlaca.Text + Environment.NewLine);
                sw.Write(textBoxMarca.Text + Environment.NewLine);
                sw.Write(textBoxModelo.Text + Environment.NewLine);
                sw.Write(textBoxColor.Text + Environment.NewLine);
                sw.Write(Preciokm + Environment.NewLine);
            }
            //Leer el archivo y cargarlo a la lista
            //no se cargha al Datagridview por las operaciones que debemos realizar
            string fileName = "Vehiculos.txt";

            FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);


           

            while (reader.Peek() > -1)
            {
                //leer los datos del empleado
                Vehiculo vehiculo = new Vehiculo();
                vehiculo.Placa = reader.ReadLine();
                vehiculo.Marca = reader.ReadLine();
                vehiculo.Modelo = reader.ReadLine();
                vehiculo.Color = reader.ReadLine();
                //vehiculo.PrecioKilometro = Convert.ToInt32(reader.ReadLine());
                //guardar el empleado en la lista de empleados
                vehiculos.Add(vehiculo);
            }
            reader.Close();

        }

        public void MostrarVehiculo()
        {
            //Mostrar la lista de empleados en el gridview
            dataGridViewVehiculo.DataSource = null;
            dataGridViewVehiculo.DataSource = vehiculos;
            dataGridViewVehiculo.Refresh();

        }

        private void buttonMostrar_Click(object sender, EventArgs e)
        {
            CargarClientes();
            MostrarClientes();
            MostrarVehiculo();
        }

        private void buttonIngresarVehiculo_Click(object sender, EventArgs e)
        {
            CargarVehiculo();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        
    }
}
