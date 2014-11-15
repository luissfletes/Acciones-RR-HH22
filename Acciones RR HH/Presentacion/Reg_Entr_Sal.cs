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
        private List<Reg_entrada_salida> entSalList;

        public Reg_Entr_Sal()
        {
            InitializeComponent();
            regEntSalGD.Columns.Add("ID", "ID");
            regEntSalGD.Columns.Add("ID Empleado", "ID Empleado");
            regEntSalGD.Columns.Add("Nombre Empleado", "Nombre Empleado");
            regEntSalGD.Columns.Add("Fecha de Entrada","Fecha de Entrada");
            regEntSalGD.Columns.Add("Fecha de Salida","Fecha de Salida");
            loadRegySal();
            
        }

        private void loadRegySal() {
            using (SISTEMAEntities context = new SISTEMAEntities()) {
                IQueryable<Reg_entrada_salida> entSalRegs = from entsal in context.Reg_entrada_salida.Include("Empleados") select entsal;
                entSalList = entSalRegs.ToList();
                DataTable dt = new DataTable();
                Reg_entrada_salida prueba = entSalList.Find(reg => reg.id == 1);
                
                foreach (var row in entSalList)
                {
                    object[] fila = new object[] { row.id, row.IDEmpleado, row.Empleados.Nombres+" "+ row.Empleados.Apellidos, row.Entrada, row.Salida };
                    regEntSalGD.Rows.Add(fila);
                }
                //from empleado in context.Empleados
                //join entsal in context.Reg_entrada_salida on empleado.IDEmpleado equals entsal.IDEmpleado into regs
                //from regsalempleado in regs
                //select regsalempleado;
                //
            }
        }

        private void regEntSalGD_SelectionChanged(object sender, EventArgs e)
        {
            if (regEntSalGD.SelectedRows.Count != 0) {
                using (SISTEMAEntities context = new SISTEMAEntities())
                {
                    DataGridViewRow row = regEntSalGD.SelectedRows[0];
                    id = Convert.ToInt32(row.Cells[0].Value.ToString());

                    var actReg = entSalList.Find(reg => reg.id == id);
                    regDateEnt.Format = DateTimePickerFormat.Long;
                    regDateSal.Format = DateTimePickerFormat.Long;
                    regId.Text = Convert.ToString(actReg.id);
                    regIdEmp.Text = actReg.IDEmpleado;
                    regEmpNom.Text = actReg.Empleados.Nombres + " " + actReg.Empleados.Apellidos;
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
            DialogResult res = MessageBox.Show("¿Desea actualizar este registro?", "Confirmacion", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
                actualizar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("¿Desea borrar este registro?", "Confirmacion", MessageBoxButtons.YesNo);
            if ( res == DialogResult.Yes )
                borrar();
        }

        private void filterTxt_TextChanged(object sender, EventArgs e)
        {
            if (filterTxt.Text.Length != 0)
            {
                foreach (DataGridViewRow row in regEntSalGD.Rows)
                {

                    for (int i = 0; i < row.Cells.Count; i++) {
                        string s = row.Cells[i].Value.ToString();
                        if (i == 0)
                        {
                            if (!s.StartsWith(filterTxt.Text, true, null))
                                row.Visible = false;
                            else
                                row.Visible = true;
                        }
                        else {
                            if (!row.Visible) {
                                if (!s.StartsWith(filterTxt.Text, true, null))
                                    row.Visible = false;
                                else
                                    row.Visible = true;
                            }
                        }
                        
                    }
                    
                }
            }
            else {
                foreach (DataGridViewRow row in regEntSalGD.Rows) {
                    row.Visible = true;
                }
            }
        }

    }
}
