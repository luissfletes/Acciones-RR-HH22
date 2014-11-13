using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Acciones_RR_HH.Datos;

namespace Acciones_RR_HH.Presentacion
{
    public partial class Reg_Entr_Sal : Form
    {
        private int id;
        public Reg_Entr_Sal()
        {
            InitializeComponent();
            loadRegySal();
        }

        private void loadRegySal() {
            using (SISTEMAEntities context = new SISTEMAEntities()) { 
                IQueryable<Reg_entrada_salida> entSalRegs = from q in context.Reg_entrada_salida select q;
                List<Reg_entrada_salida> entSalList = entSalRegs.ToList();
                //nombre data grid . source = lista de regs
                regEntSalGD.DataSource = entSalList;
            }
        }

        private void regEntSalGD_SelectionChanged(object sender, EventArgs e)
        {
            /*foreach (DataGridViewRow row in regEntSalGD.SelectedRows) {
                id = Convert.ToInt32(row.Cells[1].Value.ToString());  //idTrans
            }*/

            if (regEntSalGD.SelectedRows.Count != 0) {
                using (SISTEMAEntities context = new SISTEMAEntities())
                {
                    DataGridViewRow row = regEntSalGD.SelectedRows[0];
                    id = Convert.ToInt32(row.Cells[0].Value.ToString());
                    IQueryable<Reg_entrada_salida> entSalRegs = from q in context.Reg_entrada_salida where q.id == id select q;
                    List<Reg_entrada_salida> entSalList = entSalRegs.ToList();

                    var actReg = entSalList[0];
                    regDateEnt.Format = DateTimePickerFormat.Long;
                    regDateSal.Format = DateTimePickerFormat.Long;
                    regId.Text = Convert.ToString(actReg.id);
                    regIdEmp.Text = actReg.IDEmpleado;
                    if (actReg.Entrada != null)
                    {
                        regDateEnt.Value = (DateTime)actReg.Entrada;
                    }
                    else {
                        regDateEnt.Format = DateTimePickerFormat.Custom;
                        regDateEnt.CustomFormat = " ";
                    }
                    if (actReg.Salida != null)
                    {
                        regDateSal.Value = (DateTime)actReg.Salida;
                    }
                    else
                    {
                        regDateSal.Format = DateTimePickerFormat.Custom;
                        regDateSal.CustomFormat = " ";
                    }
                    
                }
            }
            
        }
        private void actualizar() {
            try
            {
                if (id != null) // chekiar esto later
                {
                    using (SISTEMAEntities context = new SISTEMAEntities())
                    {
                        Reg_entrada_salida regToAct = context.Reg_entrada_salida.SingleOrDefault(p => p.id == id);

                        regToAct.Entrada = regDateEnt.Value;
                        regToAct.Salida = regDateSal.Value;

                        context.SaveChanges();
                    }
                }
            }
            catch (Exception e) {
                MessageBox.Show("Error");
            }
            finally{
                loadRegySal();
            }
            
        }

        private void borrar() {
            try {
                using (SISTEMAEntities context = new SISTEMAEntities())
                {
                    Reg_entrada_salida regToBor = context.Reg_entrada_salida.SingleOrDefault(p => p.id == id);

                    context.Reg_entrada_salida.DeleteObject(regToBor);
                    context.SaveChanges();
                }
                
            }
            catch (Exception e) {
                MessageBox.Show("Error");
            }
            finally {
                loadRegySal();
            }
        }

        /*private void insertar() {
            try
            {
                using (SISTEMAEntities context = new SISTEMAEntities())
                {
                    Reg_entrada_salida regToIns = new Reg_entrada_salida{
                        //Aqui los Fields
                        //Fecha = algo, etc
                    }
                    context.Reg_entrada_salida.AddObject(regToIns);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error");
            }
            finally
            {
                loadRegySal();
            }
        }*/

        private void button1_Click(object sender, EventArgs e)
        {
            actualizar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            borrar();
        }

    }
}
