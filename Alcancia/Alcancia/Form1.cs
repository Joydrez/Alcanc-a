using System;
using System.Drawing;
using System.Windows.Forms;

namespace Alcancia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int peso1 = 1, peso2 = 2, peso5 = 5, peso10 = 10;
        public int peso1Cant, peso2Cant, peso5Cant, peso10Cant, exceso;
        int coso;

        int cantidad;
        Icon a = Properties.Resources.martilloff;
        Icon b = Properties.Resources.martillon;
        private void Form1_Load(object sender, EventArgs e)
        {

            pictureBox2.Cursor = new Cursor(a.Handle);
        }

        public void Agregar(int moneda)
        {
            cantidad += moneda;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (coso == 1)
            {
                pictureBox2.Cursor = new Cursor(a.Handle);
                coso = 0;
                
            }
            
        }

        private void Romper(object sender, EventArgs e)
        {
            pictureBox2.Cursor = new Cursor(b.Handle);
            coso = 1;
            pictureBox2.BackgroundImage = System.Drawing.Image.FromFile(@"C:\Users\johan\source\repos\Alcancia\Alcancia\Resources\alcancia.jpg");
            label3.Text = "";

            MessageBox.Show("El total de dinero recaudado es de: $"+cantidad+".");
            peso1Cant = 0;
            peso2Cant = 0;
            peso5Cant = 0;
            peso10Cant = 0;
            cantidad = 0;
            exceso = 0;

            label1.Text = "Monedas de $1 = " + peso1Cant + ", Monedas de $2 = " + peso2Cant + ", Monedas de $5 = " + peso5Cant +
                ", Monedas de $10 = " + peso10Cant;
            label2.Text = "La cantidad de dinero total es de = " + cantidad;
        }

        public void Texto()
        {
            label1.Text = "Monedas de $1 = " + peso1Cant + ", Monedas de $2 = " + peso2Cant + ", Monedas de $5 = " + peso5Cant +
                ", Monedas de $10 = " + peso10Cant;
            label2.Text = "La cantidad de dinero total es de = " + cantidad;
        }

        public void Exceso()
        {
            exceso++;
            if (exceso == 10)
            {
                pictureBox2.BackgroundImage = System.Drawing.Image.FromFile(@"C:\Users\johan\source\repos\Alcancia\Alcancia\Resources\alcancia-gorda.png");
                label3.Text = "YA ESTOY GORDA!!!!";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Agregar(peso1);
            peso1Cant++;
            Texto();
            Exceso();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Agregar(peso2);
            peso2Cant++;
            Texto();
            Exceso();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Agregar(peso5);
            peso5Cant++;
            Texto();
            Exceso();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Agregar(peso10);
            peso10Cant++;
            Texto();
            Exceso();
        }
    }
}
