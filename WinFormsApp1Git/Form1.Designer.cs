namespace WinFormsApp1Git
{
    partial class frmPrincipal
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
            btn_aceptar = new Button();
            btnsegundo = new Button();
            btnTercer = new Button();
            SuspendLayout();
            // 
            // btn_aceptar
            // 
            btn_aceptar.Location = new Point(108, 62);
            btn_aceptar.Name = "btn_aceptar";
            btn_aceptar.Size = new Size(94, 29);
            btn_aceptar.TabIndex = 0;
            btn_aceptar.Text = "Aceptar";
            btn_aceptar.UseVisualStyleBackColor = true;
            // 
            // btnsegundo
            // 
            btnsegundo.Location = new Point(315, 62);
            btnsegundo.Name = "btnsegundo";
            btnsegundo.Size = new Size(94, 29);
            btnsegundo.TabIndex = 1;
            btnsegundo.Text = "Cancelar";
            btnsegundo.UseVisualStyleBackColor = true;
            btnsegundo.Click += button1_Click;
            // 
            // btnTercer
            // 
            btnTercer.Location = new Point(531, 62);
            btnTercer.Name = "btnTercer";
            btnTercer.Size = new Size(94, 29);
            btnTercer.TabIndex = 2;
            btnTercer.Text = "Tercero";
            btnTercer.UseVisualStyleBackColor = true;
            btnTercer.Click += button1_Click_1;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1067, 450);
            Controls.Add(btnTercer);
            Controls.Add(btnsegundo);
            Controls.Add(btn_aceptar);
            Name = "frmPrincipal";
            Text = "formularioPrincipal";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_aceptar;
        private Button btnsegundo;
        private Button btnTercer;
    }
}