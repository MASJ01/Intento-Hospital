using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; 

//REALIZADO POR ALEXIS ZEPEDA SANABRIA           ICO - 401


namespace Proyecto_Hospital
{
    public partial class Form1 : Form
    {
        private struct Pacientes
        {
            public int Numero_afiliacion;
            public string Nombre1;
            public string Edad;
            public string Ocupacion;
            public string Tipo_sangre;
            public string Padecimiento;
            public string Alergias;
            public int Peso;
            public int Altura;
            public string Sustancia_consume;
        }

        private static int nElementos = 100;
        private Pacientes[] Paciente = new Pacientes[nElementos];
        int Numero_afiliacion = 0;



        public Form1()
        {
            InitializeComponent();
            BinaryReader br = null;
            try   // FUNCION PARA DETECTAR ERRORES
            {

                br = new BinaryReader(new FileStream("Paciente.dat", FileMode.Open, FileAccess.Read));
                Numero_afiliacion = 0;


                do
                {

                    Paciente[Numero_afiliacion].Numero_afiliacion = br.ReadInt32(); 
                    Paciente[Numero_afiliacion].Nombre1 = br.ReadString(); 
                    Paciente[Numero_afiliacion].Edad = br.ReadString(); 
                    Paciente[Numero_afiliacion].Ocupacion = br.ReadString();
                    Paciente[Numero_afiliacion].Tipo_sangre = br.ReadString();
                    Paciente[Numero_afiliacion].Padecimiento = br.ReadString();
                    Paciente[Numero_afiliacion].Alergias = br.ReadString();
                    Paciente[Numero_afiliacion].Peso = br.ReadInt32(); 
                    Paciente[Numero_afiliacion].Altura = br.ReadInt32(); 
                    Paciente[Numero_afiliacion].Sustancia_consume = br.ReadString();


                    // Añadir el nombre a la lista 

                    List_Nombres.Items.Add(Paciente[Numero_afiliacion].Nombre1);
                    List_Edad.Items.Add(Paciente[Numero_afiliacion].Edad);
                    List_Ocupacion.Items.Add(Paciente[Numero_afiliacion].Ocupacion);
                    List_Tipo_Sangre.Items.Add(Paciente[Numero_afiliacion].Tipo_sangre);
                    List_Padecimiento.Items.Add(Paciente[Numero_afiliacion].Padecimiento); 
                    Numero_afiliacion++;

                }
                while (true);

            }
            catch (Exception)
            {
                Console.WriteLine("Proceso de carga de la agenda.");
            }
            finally
            {
                // Cerrar el flujo 
                if (!(br == null)) br.Close();
            }
        }

        private void Añadir_Click(object sender, EventArgs e)
        {
            if (Numero_afiliacion == nElementos) return;
            if (TXT_Num_Afilic.Text.Length == 0 || TXT_Nombre.Text.Length == 0 || TXT_Edad.Text.Length == 0 || TXT_Ocupacion.Text.Length == 0 || TXT_Tipo_Sangre.Text.Length == 0 || TXT_Padecimiento.Text.Length == 0 || TXT_Alergias.Text.Length == 0 || TXT_Peso.Text.Length == 0 || TXT_Altura.Text.Length == 0 || TXT_Sustancia_Consume.Text.Length == 0)
            {
                MessageBox.Show("Datos no correctos");
                return;
            }

            Paciente[Numero_afiliacion].Numero_afiliacion = TXT_Num_Afilic.Text.Length;
            Paciente[Numero_afiliacion].Nombre1 = TXT_Nombre.Text;
            Paciente[Numero_afiliacion].Edad = TXT_Edad.Text;
            Paciente[Numero_afiliacion].Ocupacion = TXT_Ocupacion.Text;
            Paciente[Numero_afiliacion].Tipo_sangre = TXT_Tipo_Sangre.Text.ToUpper();
            Paciente[Numero_afiliacion].Padecimiento = TXT_Padecimiento.Text;
            Paciente[Numero_afiliacion].Alergias = TXT_Alergias.Text;
            Paciente[Numero_afiliacion].Peso = TXT_Peso.Text.Length;
            Paciente[Numero_afiliacion].Altura = TXT_Altura.Text.Length;
            Paciente[Numero_afiliacion].Sustancia_consume = TXT_Sustancia_Consume.Text;

            List_Nombres.Items.Add(TXT_Nombre.Text);
            List_Edad.Items.Add(TXT_Edad.Text);
            List_Ocupacion.Items.Add(TXT_Ocupacion.Text);
            List_Tipo_Sangre.Items.Add(TXT_Tipo_Sangre.Text.ToUpper());
            List_Padecimiento.Items.Add(TXT_Padecimiento.Text);

            Numero_afiliacion++;
        }

        void List_Nombres_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indSelec = List_Nombres.SelectedIndex;
            if (indSelec < 0) return;

            TXT_Nombre.Text = Paciente[indSelec].Nombre1; 
            TXT_Edad.Text = Paciente[indSelec].Edad;
            TXT_Ocupacion.Text = Paciente[indSelec].Ocupacion;
            TXT_Tipo_Sangre.Text = Paciente[indSelec].Tipo_sangre;
            TXT_Padecimiento.Text = Paciente[indSelec].Padecimiento;
        }

       
        private void Guardar_Click(object sender, EventArgs e)
        {
            BinaryWriter bw = null;

             try
             {
                 bw = new BinaryWriter(new FileStream("Paciente.dat", FileMode.Create, FileAccess.Write));
                 Numero_afiliacion = 0;

                 while (Paciente[Numero_afiliacion].Numero_afiliacion != 0)
                 {
                     if (Paciente[Numero_afiliacion].Numero_afiliacion != 0)
                     {

                         bw.Write(Paciente[Numero_afiliacion].Numero_afiliacion);
                         bw.Write(Paciente[Numero_afiliacion].Nombre1);
                         bw.Write(Paciente[Numero_afiliacion].Edad);
                         bw.Write(Paciente[Numero_afiliacion].Ocupacion);
                         bw.Write(Paciente[Numero_afiliacion].Tipo_sangre);
                         bw.Write(Paciente[Numero_afiliacion].Padecimiento);
                         bw.Write(Paciente[Numero_afiliacion].Alergias);
                         bw.Write(Paciente[Numero_afiliacion].Peso);
                         bw.Write(Paciente[Numero_afiliacion].Altura);
                         bw.Write(Paciente[Numero_afiliacion].Sustancia_consume);


                     }

                     if (Paciente[Numero_afiliacion].Numero_afiliacion == 0)
                     {
                         bw.Write(Paciente[Numero_afiliacion].Numero_afiliacion= 0);
                         bw.Write(Paciente[Numero_afiliacion].Nombre1 = " ");
                         bw.Write(Paciente[Numero_afiliacion].Edad = " ");
                         bw.Write(Paciente[Numero_afiliacion].Ocupacion = " ");
                         bw.Write(Paciente[Numero_afiliacion].Tipo_sangre = " ");
                         bw.Write(Paciente[Numero_afiliacion].Padecimiento = " ");
                         bw.Write(Paciente[Numero_afiliacion].Alergias = " ");
                         bw.Write(Paciente[Numero_afiliacion].Peso = 0);
                         bw.Write(Paciente[Numero_afiliacion].Altura = 0);
                         bw.Write(Paciente[Numero_afiliacion].Sustancia_consume = " ");
                     }

                     Numero_afiliacion++;

                 }

                 MessageBox.Show("Los datos se guardaron");

             }
             finally
             {
                // Cerrar el flujo
                if (!(bw == null)) bw.Close();
             }
        }

        private void Modificar_Click(object sender, EventArgs e)
        {
            int indSelec = List_Nombres.SelectedIndex;
            if (indSelec < 0) return;

            Paciente[indSelec].Nombre1 = TXT_Nombre.Text;
            Paciente[indSelec].Edad = TXT_Edad.Text;
            Paciente[indSelec].Ocupacion = TXT_Ocupacion.Text;
            Paciente[indSelec].Tipo_sangre = TXT_Tipo_Sangre.Text;
            Paciente[indSelec].Padecimiento = TXT_Padecimiento.Text;

            List_Nombres.Items[indSelec] = TXT_Nombre.Text;
            List_Edad.Items[indSelec] = TXT_Edad.Text;
            List_Ocupacion.Items[indSelec] = TXT_Ocupacion.Text;
            List_Tipo_Sangre.Items[indSelec] = TXT_Tipo_Sangre.Text;
            List_Padecimiento.Items[indSelec] = TXT_Padecimiento.Text; 
            
        }

        private void BTN_ELIMINAR_Click(object sender, EventArgs e)
        {

            int indSelec = List_Nombres.SelectedIndex;
            if (indSelec < 0) return;

            Paciente[indSelec].Numero_afiliacion = 0;
            Paciente[indSelec].Nombre1 = " ";
            Paciente[indSelec].Edad = " ";
            Paciente[indSelec].Ocupacion = " ";
            Paciente[indSelec].Tipo_sangre = " ";
            Paciente[indSelec].Padecimiento = " ";

            List_Nombres.Items[indSelec] = TXT_Nombre.Text;
            List_Edad.Items[indSelec] = TXT_Edad.Text;
            List_Ocupacion.Items[indSelec] = TXT_Ocupacion.Text;
            List_Tipo_Sangre.Items[indSelec] = TXT_Tipo_Sangre.Text;
            List_Padecimiento.Items[indSelec] = TXT_Padecimiento.Text; 

        }

        private void Salir_Click(object sender, EventArgs e)
        {

            this.Close(); 

        }


        private void BTN_Limipiar_Click(object sender, EventArgs e)
        {
            this.TXT_Num_Afilic.Clear();
            this.TXT_Nombre.Clear();
            this.TXT_Edad.Clear();
            this.TXT_Ocupacion.Clear();
            this.TXT_Tipo_Sangre.Clear();
            this.TXT_Padecimiento.Clear();
            this.TXT_Alergias.Clear();
            this.TXT_Peso.Clear();
            this.TXT_Altura.Clear();
            this.TXT_Sustancia_Consume.Clear(); 
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aplicación Agenda. Versión 1.0",
                 "Acerca de Agenda",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Information); 
        }

        
    }
}
