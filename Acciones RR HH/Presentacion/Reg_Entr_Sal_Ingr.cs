using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Objects;
using Acciones_RR_HH.Datos;

namespace Acciones_RR_HH.Presentacion
{
    public partial class Reg_Entr_Sal_Ingr : Form
    {
        private String idEmpleado = "LF220";

        public Reg_Entr_Sal_Ingr()
        {
            InitializeComponent();
            loadEmpleadoReg();
        }

        private void loadEmpleadoReg() {
            using (SISTEMAEntities context = new SISTEMAEntities()) {

                //Reg_entrada_salida regToAct = context.Reg_entrada_salida.FirstOrDefault
                //    (p => p.IDEmpleado == idEmpleado && DateTime.Parse(p.Entrada.ToString()).Date == DateTime.Now.Date);
                IQueryable<Reg_entrada_salida> regEmp = from entsal
                                                        in context.Reg_entrada_salida.Include("Empleados")
                                                        where entsal.IDEmpleado == idEmpleado &&
                                                        entsal.Entrada.Value.Year == DateTime.Now.Year &&
                                                        entsal.Entrada.Value.Month == DateTime.Now.Month && 
                                                        entsal.Entrada.Value.Day == DateTime.Now.Day 
                                                        select entsal;
                List<Reg_entrada_salida> list = regEmp.ToList();
                //MessageBox.Show( list.Count.ToString());
                //foreach (var reg in list)
                //{
                //    MessageBox.Show(reg.Empleados.Apellidos);
                //}
                //
            }
        }

    }
}
