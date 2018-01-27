namespace eris
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.ipAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Port = new System.Windows.Forms.TextBox();
            this.scan = new System.Windows.Forms.Button();
            this.stop = new System.Windows.Forms.Button();
            this.OutPut = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.payloadsPath = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.par1 = new System.Windows.Forms.TextBox();
            this.par2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(658, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Estado";
            // 
            // ipAddress
            // 
            this.ipAddress.Location = new System.Drawing.Point(677, 81);
            this.ipAddress.Name = "ipAddress";
            this.ipAddress.Size = new System.Drawing.Size(233, 22);
            this.ipAddress.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(589, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "URL/Puerto:";
            // 
            // Port
            // 
            this.Port.Location = new System.Drawing.Point(917, 81);
            this.Port.Name = "Port";
            this.Port.Size = new System.Drawing.Size(76, 22);
            this.Port.TabIndex = 3;
            // 
            // scan
            // 
            this.scan.Location = new System.Drawing.Point(772, 175);
            this.scan.Name = "scan";
            this.scan.Size = new System.Drawing.Size(75, 30);
            this.scan.TabIndex = 4;
            this.scan.Text = "scan";
            this.scan.UseVisualStyleBackColor = true;
            this.scan.Click += new System.EventHandler(this.scan_Click);
            // 
            // stop
            // 
            this.stop.Location = new System.Drawing.Point(863, 174);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(75, 31);
            this.stop.TabIndex = 5;
            this.stop.Text = "stop";
            this.stop.UseVisualStyleBackColor = true;
            // 
            // OutPut
            // 
            this.OutPut.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.OutPut.Location = new System.Drawing.Point(12, 12);
            this.OutPut.Name = "OutPut";
            this.OutPut.Size = new System.Drawing.Size(513, 410);
            this.OutPut.TabIndex = 6;
            this.OutPut.UseCompatibleStateImageBehavior = false;
            this.OutPut.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Payload";
            this.columnHeader1.Width = 300;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Estatus";
            this.columnHeader2.Width = 200;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(531, 399);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(461, 23);
            this.progressBar1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(579, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Payloads File:";
            // 
            // payloadsPath
            // 
            this.payloadsPath.Location = new System.Drawing.Point(677, 108);
            this.payloadsPath.Name = "payloadsPath";
            this.payloadsPath.Size = new System.Drawing.Size(316, 22);
            this.payloadsPath.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::eris.Properties.Resources.eris;
            this.pictureBox1.Location = new System.Drawing.Point(486, 228);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(424, 165);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // par1
            // 
            this.par1.Location = new System.Drawing.Point(677, 137);
            this.par1.Name = "par1";
            this.par1.Size = new System.Drawing.Size(100, 22);
            this.par1.TabIndex = 11;
            // 
            // par2
            // 
            this.par2.Location = new System.Drawing.Point(783, 137);
            this.par2.Name = "par2";
            this.par2.Size = new System.Drawing.Size(100, 22);
            this.par2.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(586, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Parametros:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1010, 434);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.par2);
            this.Controls.Add(this.par1);
            this.Controls.Add(this.OutPut);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.payloadsPath);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.scan);
            this.Controls.Add(this.Port);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ipAddress);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "eris";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ipAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Port;
        private System.Windows.Forms.Button scan;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.ListView OutPut;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox payloadsPath;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox par1;
        private System.Windows.Forms.TextBox par2;
        private System.Windows.Forms.Label label4;
    }
}

