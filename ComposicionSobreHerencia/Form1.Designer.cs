namespace ComposicionSobreHerencia
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtVehicle = new TextBox();
            comboBoxDriver = new ComboBox();
            comboBoxEngine = new ComboBox();
            btnCreate = new Button();
            txtResults = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(237, 25);
            label1.TabIndex = 0;
            label1.Text = "Ingrese nombre del vehiculo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 65);
            label2.Name = "label2";
            label2.Size = new Size(242, 25);
            label2.TabIndex = 1;
            label2.Text = "Seleccione tipo de conductor";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 125);
            label3.Name = "label3";
            label3.Size = new Size(211, 25);
            label3.TabIndex = 2;
            label3.Text = "Seleccione tipo de motor";
            // 
            // txtVehicle
            // 
            txtVehicle.Location = new Point(311, 12);
            txtVehicle.Name = "txtVehicle";
            txtVehicle.Size = new Size(150, 31);
            txtVehicle.TabIndex = 3;
            // 
            // comboBoxDriver
            // 
            comboBoxDriver.FormattingEnabled = true;
            comboBoxDriver.Items.AddRange(new object[] { "Humano", "Robot" });
            comboBoxDriver.Location = new Point(311, 65);
            comboBoxDriver.Name = "comboBoxDriver";
            comboBoxDriver.Size = new Size(182, 33);
            comboBoxDriver.TabIndex = 9;
            // 
            // comboBoxEngine
            // 
            comboBoxEngine.FormattingEnabled = true;
            comboBoxEngine.Items.AddRange(new object[] { "Combustion", "Electrico" });
            comboBoxEngine.Location = new Point(311, 125);
            comboBoxEngine.Name = "comboBoxEngine";
            comboBoxEngine.Size = new Size(182, 33);
            comboBoxEngine.TabIndex = 10;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(12, 175);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(112, 34);
            btnCreate.TabIndex = 11;
            btnCreate.Text = "Crear";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // txtResults
            // 
            txtResults.Location = new Point(12, 249);
            txtResults.Name = "txtResults";
            txtResults.Size = new Size(776, 31);
            txtResults.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtResults);
            Controls.Add(btnCreate);
            Controls.Add(comboBoxEngine);
            Controls.Add(comboBoxDriver);
            Controls.Add(txtVehicle);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtVehicle;
        private ComboBox comboBoxDriver;
        private ComboBox comboBoxEngine;
        private Button btnCreate;
        private TextBox txtResults;
    }
}
