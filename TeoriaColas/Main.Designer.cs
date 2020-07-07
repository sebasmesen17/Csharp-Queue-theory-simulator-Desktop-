namespace TeoriaColas
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbUnidadMedida = new System.Windows.Forms.ComboBox();
            this.txtMiu = new System.Windows.Forms.TextBox();
            this.txtLambda = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtn5 = new System.Windows.Forms.TextBox();
            this.btnSimular = new System.Windows.Forms.Button();
            this.txtn4 = new System.Windows.Forms.TextBox();
            this.txtn3 = new System.Windows.Forms.TextBox();
            this.txtn2 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtWq = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtn1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtP = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtL = new System.Windows.Forms.TextBox();
            this.txtW = new System.Windows.Forms.TextBox();
            this.txtLq = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.datosGrupo = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dateTimeCalendar = new System.Windows.Forms.DateTimePicker();
            this.btnEnviarCorreo = new System.Windows.Forms.Button();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 89);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(499, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite el número de barcazas que se pueden atender por periodo (μ):";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(452, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Digite el número medio de llegada de barcazas por periodo (λ):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 24);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Unidad de medida:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 71);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha del reporte:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // cbUnidadMedida
            // 
            this.cbUnidadMedida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUnidadMedida.FormattingEnabled = true;
            this.cbUnidadMedida.Location = new System.Drawing.Point(520, 24);
            this.cbUnidadMedida.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbUnidadMedida.Name = "cbUnidadMedida";
            this.cbUnidadMedida.Size = new System.Drawing.Size(174, 25);
            this.cbUnidadMedida.TabIndex = 5;
            // 
            // txtMiu
            // 
            this.txtMiu.Location = new System.Drawing.Point(520, 93);
            this.txtMiu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMiu.Name = "txtMiu";
            this.txtMiu.Size = new System.Drawing.Size(174, 24);
            this.txtMiu.TabIndex = 6;
            // 
            // txtLambda
            // 
            this.txtLambda.Location = new System.Drawing.Point(520, 57);
            this.txtLambda.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLambda.Name = "txtLambda";
            this.txtLambda.Size = new System.Drawing.Size(174, 24);
            this.txtLambda.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.pictureBox8);
            this.panel1.Controls.Add(this.pictureBox7);
            this.panel1.Controls.Add(this.pictureBox6);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.txtn5);
            this.panel1.Controls.Add(this.btnSimular);
            this.panel1.Controls.Add(this.txtn4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtn3);
            this.panel1.Controls.Add(this.txtMiu);
            this.panel1.Controls.Add(this.txtn2);
            this.panel1.Controls.Add(this.txtLambda);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.cbUnidadMedida);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.txtWq);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtn1);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtPo);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txtP);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.txtL);
            this.panel1.Controls.Add(this.txtW);
            this.panel1.Controls.Add(this.txtLq);
            this.panel1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(91, 95);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(706, 692);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(40, 446);
            this.pictureBox8.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(29, 30);
            this.pictureBox8.TabIndex = 32;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(40, 392);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(29, 30);
            this.pictureBox7.TabIndex = 31;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(40, 351);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(29, 30);
            this.pictureBox6.TabIndex = 30;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(40, 297);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(29, 28);
            this.pictureBox5.TabIndex = 29;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(13, 254);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(22, 23);
            this.pictureBox4.TabIndex = 28;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(67, 254);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(22, 23);
            this.pictureBox3.TabIndex = 27;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(40, 254);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(22, 23);
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(40, 206);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 23);
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // txtn5
            // 
            this.txtn5.Enabled = false;
            this.txtn5.Location = new System.Drawing.Point(280, 656);
            this.txtn5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtn5.Name = "txtn5";
            this.txtn5.Size = new System.Drawing.Size(174, 24);
            this.txtn5.TabIndex = 24;
            // 
            // btnSimular
            // 
            this.btnSimular.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnSimular.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimular.Location = new System.Drawing.Point(246, 140);
            this.btnSimular.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSimular.Name = "btnSimular";
            this.btnSimular.Size = new System.Drawing.Size(80, 33);
            this.btnSimular.TabIndex = 10;
            this.btnSimular.Text = "Simular";
            this.btnSimular.UseVisualStyleBackColor = false;
            this.btnSimular.Click += new System.EventHandler(this.btnSimular_Click);
            // 
            // txtn4
            // 
            this.txtn4.Enabled = false;
            this.txtn4.Location = new System.Drawing.Point(280, 628);
            this.txtn4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtn4.Name = "txtn4";
            this.txtn4.Size = new System.Drawing.Size(174, 24);
            this.txtn4.TabIndex = 23;
            // 
            // txtn3
            // 
            this.txtn3.Enabled = false;
            this.txtn3.Location = new System.Drawing.Point(280, 596);
            this.txtn3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtn3.Name = "txtn3";
            this.txtn3.Size = new System.Drawing.Size(174, 24);
            this.txtn3.TabIndex = 22;
            // 
            // txtn2
            // 
            this.txtn2.Enabled = false;
            this.txtn2.Location = new System.Drawing.Point(280, 566);
            this.txtn2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtn2.Name = "txtn2";
            this.txtn2.Size = new System.Drawing.Size(174, 24);
            this.txtn2.TabIndex = 21;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(37, 661);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(118, 17);
            this.label17.TabIndex = 20;
            this.label17.Text = "Probabilidad=5:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(37, 570);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(118, 17);
            this.label16.TabIndex = 19;
            this.label16.Text = "Probabilidad=2:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(37, 597);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(118, 17);
            this.label15.TabIndex = 18;
            this.label15.Text = "Probabilidad=3:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(37, 630);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(118, 17);
            this.label14.TabIndex = 17;
            this.label14.Text = "Probabilidad=4:";
            // 
            // txtWq
            // 
            this.txtWq.Enabled = false;
            this.txtWq.Location = new System.Drawing.Point(481, 351);
            this.txtWq.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtWq.Name = "txtWq";
            this.txtWq.Size = new System.Drawing.Size(174, 24);
            this.txtWq.TabIndex = 10;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(37, 542);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(118, 17);
            this.label13.TabIndex = 16;
            this.label13.Text = "Probabilidad=1:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(109, 206);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(344, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Número promedio de barcazas en el puerto (L):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(158, 503);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Probabilidad Pn>k:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(109, 453);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(317, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "Porcentaje de que nadie use el sistema(Po):";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(109, 355);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(331, 17);
            this.label8.TabIndex = 3;
            this.label8.Text = "Tiempo promedio de barcazas en la cola(Wq):";
            // 
            // txtn1
            // 
            this.txtn1.Enabled = false;
            this.txtn1.Location = new System.Drawing.Point(280, 538);
            this.txtn1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtn1.Name = "txtn1";
            this.txtn1.Size = new System.Drawing.Size(174, 24);
            this.txtn1.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(109, 303);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(197, 17);
            this.label9.TabIndex = 4;
            this.label9.Text = "Tiempo total de espera(W)";
            // 
            // txtPo
            // 
            this.txtPo.Enabled = false;
            this.txtPo.Location = new System.Drawing.Point(481, 446);
            this.txtPo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPo.Name = "txtPo";
            this.txtPo.Size = new System.Drawing.Size(174, 24);
            this.txtPo.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(109, 400);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(363, 17);
            this.label10.TabIndex = 5;
            this.label10.Text = "Probabilidad de que el puerto se esté ocupando(P)";
            // 
            // txtP
            // 
            this.txtP.Enabled = false;
            this.txtP.Location = new System.Drawing.Point(481, 400);
            this.txtP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtP.Name = "txtP";
            this.txtP.Size = new System.Drawing.Size(174, 24);
            this.txtP.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(109, 254);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(294, 17);
            this.label11.TabIndex = 6;
            this.label11.Text = "Barcazas en espera a ser atendidos(Lq):";
            // 
            // txtL
            // 
            this.txtL.Enabled = false;
            this.txtL.Location = new System.Drawing.Point(481, 204);
            this.txtL.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtL.Name = "txtL";
            this.txtL.Size = new System.Drawing.Size(174, 24);
            this.txtL.TabIndex = 7;
            // 
            // txtW
            // 
            this.txtW.Enabled = false;
            this.txtW.Location = new System.Drawing.Point(481, 303);
            this.txtW.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtW.Name = "txtW";
            this.txtW.Size = new System.Drawing.Size(174, 24);
            this.txtW.TabIndex = 9;
            // 
            // txtLq
            // 
            this.txtLq.Enabled = false;
            this.txtLq.Location = new System.Drawing.Point(481, 254);
            this.txtLq.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLq.Name = "txtLq";
            this.txtLq.Size = new System.Drawing.Size(174, 24);
            this.txtLq.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.datosGrupo);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.dateTimeCalendar);
            this.panel2.Controls.Add(this.btnEnviarCorreo);
            this.panel2.Controls.Add(this.txtCorreo);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(802, 95);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(355, 692);
            this.panel2.TabIndex = 9;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // datosGrupo
            // 
            this.datosGrupo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.datosGrupo.BackColor = System.Drawing.Color.LightSlateGray;
            this.datosGrupo.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datosGrupo.Location = new System.Drawing.Point(124, 615);
            this.datosGrupo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.datosGrupo.Name = "datosGrupo";
            this.datosGrupo.Size = new System.Drawing.Size(117, 63);
            this.datosGrupo.TabIndex = 20;
            this.datosGrupo.Text = "Información del grupo.";
            this.datosGrupo.UseVisualStyleBackColor = false;
            this.datosGrupo.Click += new System.EventHandler(this.datosGrupo_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.BackColor = System.Drawing.Color.LightSlateGray;
            this.button2.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(196, 229);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 30);
            this.button2.TabIndex = 18;
            this.button2.Text = "Limpiar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dateTimeCalendar
            // 
            this.dateTimeCalendar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimeCalendar.Enabled = false;
            this.dateTimeCalendar.Location = new System.Drawing.Point(146, 71);
            this.dateTimeCalendar.Name = "dateTimeCalendar";
            this.dateTimeCalendar.Size = new System.Drawing.Size(200, 20);
            this.dateTimeCalendar.TabIndex = 17;
            // 
            // btnEnviarCorreo
            // 
            this.btnEnviarCorreo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEnviarCorreo.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnEnviarCorreo.Enabled = false;
            this.btnEnviarCorreo.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviarCorreo.Location = new System.Drawing.Point(46, 229);
            this.btnEnviarCorreo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEnviarCorreo.Name = "btnEnviarCorreo";
            this.btnEnviarCorreo.Size = new System.Drawing.Size(94, 30);
            this.btnEnviarCorreo.TabIndex = 16;
            this.btnEnviarCorreo.Text = "Enviar reporte";
            this.btnEnviarCorreo.UseVisualStyleBackColor = false;
            this.btnEnviarCorreo.Click += new System.EventHandler(this.btnEnviarCorreo_Click);
            // 
            // txtCorreo
            // 
            this.txtCorreo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCorreo.Enabled = false;
            this.txtCorreo.Location = new System.Drawing.Point(149, 158);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(200, 20);
            this.txtCorreo.TabIndex = 15;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(14, 158);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 17);
            this.label12.TabIndex = 14;
            this.label12.Text = "Correo:";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1109, 701);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simulación teoría colas, métodos cuantitativos para la toma de decisiones.";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbUnidadMedida;
        private System.Windows.Forms.TextBox txtMiu;
        private System.Windows.Forms.TextBox txtLambda;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSimular;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtn1;
        private System.Windows.Forms.TextBox txtPo;
        private System.Windows.Forms.TextBox txtP;
        private System.Windows.Forms.TextBox txtWq;
        private System.Windows.Forms.TextBox txtW;
        private System.Windows.Forms.TextBox txtLq;
        private System.Windows.Forms.TextBox txtL;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtn5;
        private System.Windows.Forms.TextBox txtn4;
        private System.Windows.Forms.TextBox txtn3;
        private System.Windows.Forms.TextBox txtn2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnEnviarCorreo;
        private System.Windows.Forms.DateTimePicker dateTimeCalendar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button datosGrupo;
    }
}

