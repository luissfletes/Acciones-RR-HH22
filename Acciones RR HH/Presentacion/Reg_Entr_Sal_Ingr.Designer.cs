namespace Acciones_RR_HH.Presentacion
{
    partial class Reg_Entr_Sal_Ingr
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtIDEmp = new System.Windows.Forms.TextBox();
            this.btnMarcarEntr = new System.Windows.Forms.Button();
            this.btnMarcarSal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Empleado";
            // 
            // txtIDEmp
            // 
            this.txtIDEmp.Enabled = false;
            this.txtIDEmp.Location = new System.Drawing.Point(87, 12);
            this.txtIDEmp.Name = "txtIDEmp";
            this.txtIDEmp.Size = new System.Drawing.Size(82, 20);
            this.txtIDEmp.TabIndex = 1;
            // 
            // btnMarcarEntr
            // 
            this.btnMarcarEntr.Location = new System.Drawing.Point(12, 38);
            this.btnMarcarEntr.Name = "btnMarcarEntr";
            this.btnMarcarEntr.Size = new System.Drawing.Size(103, 23);
            this.btnMarcarEntr.TabIndex = 2;
            this.btnMarcarEntr.Text = "Marcar Entrada";
            this.btnMarcarEntr.UseVisualStyleBackColor = true;
            // 
            // btnMarcarSal
            // 
            this.btnMarcarSal.Location = new System.Drawing.Point(121, 38);
            this.btnMarcarSal.Name = "btnMarcarSal";
            this.btnMarcarSal.Size = new System.Drawing.Size(94, 23);
            this.btnMarcarSal.TabIndex = 3;
            this.btnMarcarSal.Text = "Marcar Salida";
            this.btnMarcarSal.UseVisualStyleBackColor = true;
            // 
            // Reg_Entr_Sal_Ingr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 110);
            this.Controls.Add(this.btnMarcarSal);
            this.Controls.Add(this.btnMarcarEntr);
            this.Controls.Add(this.txtIDEmp);
            this.Controls.Add(this.label1);
            this.Name = "Reg_Entr_Sal_Ingr";
            this.Text = "Reg_Entr_Sal_Ingr";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIDEmp;
        private System.Windows.Forms.Button btnMarcarEntr;
        private System.Windows.Forms.Button btnMarcarSal;
    }
}