using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Net;
using System.Windows.Forms;
using Ejercicio1.Models;

namespace Ejercicio1
{

    public partial class FormPrincipal : Form
    {
        List<Empleado> empleados = new List<Empleado>();

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnVerEmpleados_Click(object sender, EventArgs e)
        {
            lbxEmpleados.Items.Clear();
            lbxEmpleados.Items.AddRange(empleados.ToArray());
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(openFileDialog1.InitialDirectory))
                openFileDialog1.InitialDirectory = Environment.CurrentDirectory;

            openFileDialog1.Title = "Importación de empleados";
            openFileDialog1.Filter = "Fichero csv|*csv";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                FileStream fs = null;
                StreamReader sr = null;
                try
                {
                    fs = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
                                        
                    sr =new StreamReader(fs);

                    //Tipo:Asalariado;DNI;Nombre;Básico,Aportes provisionales
                    sr.ReadLine();
                    //Tipo: Jornalero; DNI; Nombre; Horas Trabajadas; Importe Por Hora; Retenciones
                    sr.ReadLine();

                    while (sr.EndOfStream==false)
                    { 
                        string linea = sr.ReadLine();

                        #region parseo
                        string[] campos = linea.Split(';');
                        
                        string tipo = campos[0];
                        int dni = Convert.ToInt32(campos[1]);
                        string nombre = campos[2];

                        Empleado empl = null;
                        if (tipo == "Asalariado")
                        {
                            //Asalariado;45654355;Agustín;900456,00;6000,5
                            double basico=Convert.ToDouble(campos[3]);
                            double aportes=Convert.ToDouble(campos[4]);

                            empl = new Asalariado(dni, nombre, basico, aportes);
                        }
                        else if (tipo == "Jornalero")
                        {
                            //Jornalero;32445656;Leticia;10;500,2;100,00
                            int horas = Convert.ToInt32(campos[3]);
                            double importePorHora = Convert.ToDouble(campos[4]);
                            double retencion = Convert.ToDouble(campos[5]);

                            empl = new Jornalero(dni, nombre, horas,importePorHora,retencion);
                        }
                        #endregion

                        #region actualizacion/insercción
                        empleados.Sort();
                        int idx = empleados.BinarySearch(empl);
                        if (idx >= 0)
                        {
                            //empleados[idx] = empl; seria así sino fuera una actualización parcial
                            if (empl is Asalariado)
                            {
                                ((Asalariado)empleados[idx]).Basico = ((Asalariado)empl).Basico;
                            }
                            else if (empl is Jornalero)
                            {
                                ((Jornalero)empleados[idx]).ImportePorHora = ((Jornalero)empl).ImportePorHora;
                            }
                        }
                        else
                        {
                            empleados.Add(empl);
                        }
                        #endregion
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message+"|"+ex.StackTrace,"Error al importar");
                }
                finally
                {
                    if(fs != null) fs.Close();
                    if(sr != null) sr.Close();
                }
            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(saveFileDialog1.InitialDirectory))
                saveFileDialog1.InitialDirectory = Environment.CurrentDirectory;

            saveFileDialog1.FileName = "exportar.csv";
            saveFileDialog1.Title = "Exportación de empleados";
            saveFileDialog1.Filter = "Fichero csv|*csv";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = null;
                StreamWriter sw = null;
                try
                {
                    fs = new FileStream(saveFileDialog1.FileName, FileMode.OpenOrCreate, FileAccess.Write);

                    sw = new StreamWriter(fs);
                    
                    sw.WriteLine("Tipo:Asalariado;DNI;Nombre;Básico,Aportes provisionales");
                    sw.WriteLine("Tipo: Jornalero; DNI; Nombre; Horas Trabajadas; Importe Por Hora; Retenciones");

                    foreach(Empleado empl in empleados)
                    {
                        string linea = "";
                        
                        if (empl is Asalariado)
                        {
                            Asalariado aux= (Asalariado)empl;
                            linea = $"Asalariado;{aux.DNI};{aux.Nombre};{aux.Basico:f2},{aux.AportesPrevisionales}";
                        }
                        else if (empl is Jornalero)
                        {
                            Jornalero aux = (Jornalero)empl;
                            linea = $"Jornelero;{aux.DNI};{aux.Nombre};{aux.HorasTrabajadas:f2},{aux.RetencionesImpositivas}";
                        }
                        sw.WriteLine(linea);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "|" + ex.StackTrace, "Error al importar");
                }
                finally
                {
                    if (sw != null) sw.Close();
                    if (fs != null) fs.Close();
                }
            }
        }

        private void btnRecibos_Click(object sender, EventArgs e)
        {
            
            if(string.IsNullOrEmpty(saveFileDialog1.InitialDirectory))
                saveFileDialog1.InitialDirectory = Environment.CurrentDirectory;

            saveFileDialog1.FileName = "recibos.txt";

            saveFileDialog1.Title = "Generación de recibos";
            saveFileDialog1.Filter = "Fichero txt|*txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = null;
                StreamWriter sw = null;
                try
                {
                    fs = new FileStream(saveFileDialog1.FileName, FileMode.OpenOrCreate, FileAccess.Write);

                    sw = new StreamWriter(fs);

                    foreach (Empleado empl in empleados)
                    {
                        foreach (string linea in empl.GenerarRecibo())
                        { 
                            sw.WriteLine(linea);
                        }
                        sw.WriteLine("---");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "|" + ex.StackTrace, "Error al importar");
                }
                finally
                {
                    if (sw != null) sw.Close();
                    if (fs != null) fs.Close();
                }
            }
        }

        private void lbxEmpleados_SelectedIndexChanged(object sender, EventArgs e)
        {
            Empleado empl=lbxEmpleados.SelectedItem as Empleado;

            FormVer fVer= new FormVer();

            if (empl != null)
            {
                foreach (string linea in empl.GenerarRecibo())
                {
                    fVer.tbVer.Text += linea+Environment.NewLine;
                }
            }
            fVer.ShowDialog();
        }
    }
}
