namespace Acciones_RR_HH.Presentacion
{
    partial class Reg_Entr_Sal
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
            this.components = new System.ComponentModel.Container();
            this.sISTEMAEntitiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.regEntSalGD = new System.Windows.Forms.DataGridView();
            this.regId = new System.Windows.Forms.TextBox();
            this.regIdEmp = new System.Windows.Forms.TextBox();
            this.regDateEnt = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.regDateSal = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sISTEMAEntitiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.regEntSalGD)).BeginInit();
            this.SuspendLayout();
            // 
            // sISTEMAEntitiesBindingSource
            // 
            this.sISTEMAEntitiesBindingSource.DataSource = typeof(Acciones_RR_HH.Datos.SISTEMAEntities);
            // 
            // regEntSalGD
            // 
            this.regEntSalGD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.regEntSalGD.Location = new System.Drawing.Point(29, 217);
            this.regEntSalGD.Name = "regEntSalGD";
            this.regEntSalGD.Size = new System.Drawing.Size(695, 150);
            this.regEntSalGD.TabIndex = 0;
            this.regEntSalGD.SelectionChanged += new System.EventHandler(this.regEntSalGD_SelectionChanged);
            // 
            // regId
            // 
            this.regId.Enabled = false;
            this.regId.Location = new System.Drawing.Point(90, 37);
            this.regId.Name = "regId";
            this.regId.Size = new System.Drawing.Size(81, 20);
            this.regId.TabIndex = 1;
            // 
            // regIdEmp
            // 
            this.regIdEmp.Enabled = false;
            this.regIdEmp.Location = new System.Drawing.Point(249, 37);
            this.regIdEmp.Name = "regIdEmp";
            this.regIdEmp.Size = new System.Drawing.Size(89, 20);
            this.regIdEmp.TabIndex = 2;
            // 
            // regDateEnt
            // 
            this.regDateEnt.Location = new System.Drawing.Point(29, 86);
            this.regDateEnt.Name = "regDateEnt";
            this.regDateEnt.Size = new System.Drawing.Size(200, 20);
            this.regDateEnt.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Id Registro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(177, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Id Empleado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Fecha Entrada";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(246, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Fecha Salida";
            // 
            // regDateSal
            // 
            this.regDateSal.Location = new System.Drawing.Point(249, 86);
            this.regDateSal.Name = "regDateSal";
            this.regDateSal.Size = new System.Drawing.Size(200, 20);
            this.regDateSal.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(641, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(641, 67);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Borrar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Reg_Entr_Sal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 394);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.regDateSal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.regDateEnt);
            this.Controls.Add(this.regIdEmp);
            this.Controls.Add(this.regId);
            this.Controls.Add(this.regEntSalGD);
            this.Name = "Reg_Entr_Sal";
            this.Text = "Reg_Entr_Sal";
            ((System.ComponentModel.ISupportInitialize)(this.sISTEMAEntitiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.regEntSalGD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource sISTEMAEntitiesBindingSource;
        private System.Windows.Forms.DataGridView regEntSalGD;
        private System.Windows.Forms.TextBox regId;
        private System.Windows.Forms.TextBox regIdEmp;
        private System.Windows.Forms.DateTimePicker regDateEnt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker regDateSal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}