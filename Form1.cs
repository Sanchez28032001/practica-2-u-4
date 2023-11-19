namespace practica_2_u_4
{
    public partial class Form1 : Form
    {
        //'Declaracion de variables de cantidad
        int CantidadHamburguesas;
        int CantidadHotDog;
        int CantidadSandwich;
        int CantidadTe;
        int CantidadRefresco;
        int CantidadPapas;

        double TotalVta;
        double CostoHamburguesa;
        double CostoHotDog;
        double CostoSandwich;
        double CostoTe;
        double CostoRefresco;
        double CostoPapas;



        //'Inicializar las variables con los precios de los productos
        double Hamburguesa = 20.5;
        double HotDog = 19.25;
        double Sandwich = 17.5;
        double PapasFritas = 4.5;
        double Refresco = 4;
        double Te = 5;
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //Paquete No.1 de Comida
            txtTotal.Text = "";
            if (radioButton1.Checked == true)
            {
                CantidadHamburguesas = 1;
                CantidadRefresco = 1;
                CantidadPapas = 1;
                CantidadHotDog = 0;
                CantidadSandwich = 0;
                CantidadTe = 0;
                //Inicializar valores
                txtHamburguesa.Text = CantidadHamburguesas.ToString();
                txtRefresco.Text = CantidadRefresco.ToString();
                txtPapas.Text = CantidadPapas.ToString();



                //Activar las cajas de texto del paquete
                txtHamburguesa.Enabled = true;
                txtRefresco.Enabled = true;
                txtPapas.Enabled = true;



                //'Desactivar las otras cajas
                txtHotDog.Enabled = false;
                txtHotDog.Enabled = false;
                txtTe.Enabled = false;
                txtSandwich.Enabled = false;



                //'Limpiar las cajas de texto
                txtHotDog.Text = "";
                txtTe.Text = "";
                txtSandwich.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //'Multiplicando la cantidad por el precio y sumando el total
            CostoHamburguesa = (CantidadHamburguesas * Hamburguesa);
            CostoHotDog = (CantidadHotDog * HotDog);
            CostoSandwich = (CantidadSandwich * Sandwich);
            CostoTe = (CantidadTe * Te);
            CostoRefresco = (CantidadRefresco * Refresco);
            CostoPapas = (CantidadPapas * PapasFritas);
            TotalVta = CostoHamburguesa + CostoHotDog + CostoSandwich + CostoTe + CostoRefresco + CostoPapas;
            txtTotal.Text = TotalVta.ToString();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            //Paquete No.2 de Comida
            txtTotal.Text = "";
            if (radioButton2.Checked == true)
            {
                CantidadRefresco = 1;
                CantidadPapas = 1;
                CantidadHotDog = 1;
                CantidadSandwich = 0;

                //Inicializar valores
                txtHotDog.Text = CantidadHotDog.ToString();
                txtRefresco.Text = CantidadRefresco.ToString();
                txtPapas.Text = CantidadPapas.ToString();

                //Activar las cajas de texto del paquete
                txtHotDog.Enabled = true;
                txtRefresco.Enabled = true;
                txtPapas.Enabled = true;



                //'Desactivar las otras cajas
                txtHamburguesa.Enabled = false;
                txtTe.Enabled = false;
                txtSandwich.Enabled = false;



                //'Limpiar las cajas de texto
                //txtHotDog.Text = "";
                txtHamburguesa.Text = "";

                txtSandwich.Text = "";
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            //Paquete No.3 de Comida
            txtTotal.Text = "";
            if (radioButton3.Checked == true)
            {
                CantidadHamburguesas = 0;
                CantidadRefresco = 1;
                CantidadPapas = 1;
                CantidadHotDog = 0;
                CantidadSandwich = 1;
                CantidadTe = 0;
                //Inicializar valores
                txtSandwich.Text = CantidadSandwich.ToString();
                txtRefresco.Text = CantidadRefresco.ToString();
                txtPapas.Text = CantidadPapas.ToString();



                //Activar las cajas de texto del paquete
                txtSandwich.Enabled = true;
                txtRefresco.Enabled = true;
                txtPapas.Enabled = true;



                //'Desactivar las otras cajas



                txtHotDog.Enabled = false;
                txtTe.Enabled = false;
                txtHamburguesa.Enabled = false;



                //'Limpiar las cajas de texto
                txtHamburguesa.Text = "";
                txtTe.Text = "";
                txtHotDog.Text = "";
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            //Opcion otro pedido
            txtTotal.Text = "";



            if (radioButton4.Checked == true)
            {
                //'Habilitar todas las entradas
                txtHamburguesa.Enabled = true;
                txtHotDog.Enabled = true;
                txtSandwich.Enabled = true;
                txtTe.Enabled = true;
                txtRefresco.Enabled = true;
                txtPapas.Enabled = true;
                /*
                txtHamburguesa.Text = "";
                txtHotDog.Text = "";
                txtSandwich.Text = "";
                txtTe.Text = "";
                txtRefresco.Text = "";
                txtPapas.Text = "";*/

                double CantidadHamburguesas = int.Parse(txtHamburguesa.Text);
                double CantidadHotDog = int.Parse(txtHotDog.Text);
                double CantidadSandwich = int.Parse(txtSandwich.Text);
                double CantidadTe = int.Parse(txtTe.Text);
                double CantidadRefresco = int.Parse(txtRefresco.Text);
                double CantidadPapas = int.Parse(txtPapas.Text);
            }

        }
    }
}