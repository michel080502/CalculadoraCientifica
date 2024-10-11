namespace Calculadora
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
            textScreen = new TextBox();
            btnSuma = new Button();
            btnResta = new Button();
            btnMulti = new Button();
            btnDivi = new Button();
            btnN1 = new Button();
            btnN2 = new Button();
            btnN3 = new Button();
            btnLimpiar = new Button();
            btnN4 = new Button();
            btnN5 = new Button();
            btnN6 = new Button();
            btnBorrar = new Button();
            btnN7 = new Button();
            btnN8 = new Button();
            btnN9 = new Button();
            btnIgual = new Button();
            btnN0 = new Button();
            btnPunto = new Button();
            textBox1 = new TextBox();
            btnMasMenos = new Button();
            btnPorcentaje = new Button();
            btnRaiz = new Button();
            btnLimpiarTodo = new Button();
            btnSin = new Button();
            btnTan = new Button();
            btnCos = new Button();
            btnSqrt = new Button();
            btnThrd = new Button();
            btnRaise = new Button();
            btnRaizTercera = new Button();
            btnRaizY = new Button();
            button9 = new Button();
            btnEXP = new Button();
            btnLog = new Button();
            btn10x = new Button();
            SuspendLayout();
            // 
            // textScreen
            // 
            textScreen.BorderStyle = BorderStyle.None;
            textScreen.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textScreen.Location = new Point(40, 65);
            textScreen.Multiline = true;
            textScreen.Name = "textScreen";
            textScreen.ReadOnly = true;
            textScreen.Size = new Size(642, 40);
            textScreen.TabIndex = 0;
            textScreen.Text = "0";
            textScreen.TextAlign = HorizontalAlignment.Right;
            // 
            // btnSuma
            // 
            btnSuma.BackColor = SystemColors.ControlDark;
            btnSuma.Font = new Font("Arial Rounded MT Bold", 15.75F);
            btnSuma.ForeColor = SystemColors.ButtonFace;
            btnSuma.Location = new Point(283, 175);
            btnSuma.Name = "btnSuma";
            btnSuma.Size = new Size(75, 58);
            btnSuma.TabIndex = 1;
            btnSuma.Text = "+";
            btnSuma.UseVisualStyleBackColor = false;
            btnSuma.Click += btnSuma_Click;
            // 
            // btnResta
            // 
            btnResta.BackColor = SystemColors.ControlDark;
            btnResta.Font = new Font("Arial Rounded MT Bold", 15.75F);
            btnResta.ForeColor = SystemColors.ButtonFace;
            btnResta.Location = new Point(283, 239);
            btnResta.Name = "btnResta";
            btnResta.Size = new Size(75, 58);
            btnResta.TabIndex = 2;
            btnResta.Text = "-";
            btnResta.UseVisualStyleBackColor = false;
            btnResta.Click += btnResta_Click;
            // 
            // btnMulti
            // 
            btnMulti.BackColor = SystemColors.ControlDark;
            btnMulti.Font = new Font("Arial Rounded MT Bold", 15.75F);
            btnMulti.ForeColor = SystemColors.ButtonFace;
            btnMulti.Location = new Point(283, 304);
            btnMulti.Name = "btnMulti";
            btnMulti.Size = new Size(75, 58);
            btnMulti.TabIndex = 3;
            btnMulti.Text = "x";
            btnMulti.UseVisualStyleBackColor = false;
            btnMulti.Click += btnMulti_Click;
            // 
            // btnDivi
            // 
            btnDivi.BackColor = SystemColors.ControlDark;
            btnDivi.FlatAppearance.BorderColor = SystemColors.WindowText;
            btnDivi.Font = new Font("Arial Rounded MT Bold", 15.75F);
            btnDivi.ForeColor = SystemColors.ButtonFace;
            btnDivi.Location = new Point(283, 367);
            btnDivi.Name = "btnDivi";
            btnDivi.Size = new Size(75, 58);
            btnDivi.TabIndex = 4;
            btnDivi.Text = "/";
            btnDivi.UseVisualStyleBackColor = false;
            btnDivi.Click += btnDivi_Click;
            // 
            // btnN1
            // 
            btnN1.BackColor = Color.MediumSlateBlue;
            btnN1.Font = new Font("Arial Rounded MT Bold", 15.75F);
            btnN1.ForeColor = SystemColors.ButtonFace;
            btnN1.Location = new Point(364, 175);
            btnN1.Name = "btnN1";
            btnN1.Size = new Size(75, 58);
            btnN1.TabIndex = 5;
            btnN1.Text = "1";
            btnN1.UseVisualStyleBackColor = false;
            btnN1.Click += btnN1_Click;
            // 
            // btnN2
            // 
            btnN2.BackColor = Color.MediumSlateBlue;
            btnN2.Font = new Font("Arial Rounded MT Bold", 15.75F);
            btnN2.ForeColor = SystemColors.ButtonFace;
            btnN2.Location = new Point(445, 175);
            btnN2.Name = "btnN2";
            btnN2.Size = new Size(75, 58);
            btnN2.TabIndex = 6;
            btnN2.Text = "2";
            btnN2.UseVisualStyleBackColor = false;
            btnN2.Click += btnN2_Click;
            // 
            // btnN3
            // 
            btnN3.BackColor = Color.MediumSlateBlue;
            btnN3.Font = new Font("Arial Rounded MT Bold", 15.75F);
            btnN3.ForeColor = SystemColors.ButtonFace;
            btnN3.Location = new Point(526, 175);
            btnN3.Name = "btnN3";
            btnN3.Size = new Size(75, 58);
            btnN3.TabIndex = 7;
            btnN3.Text = "3";
            btnN3.UseVisualStyleBackColor = false;
            btnN3.Click += btnN3_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = SystemColors.ControlLightLight;
            btnLimpiar.Font = new Font("Arial Rounded MT Bold", 15.75F);
            btnLimpiar.Location = new Point(40, 111);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(156, 58);
            btnLimpiar.TabIndex = 8;
            btnLimpiar.Text = "CE";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnN4
            // 
            btnN4.BackColor = Color.MediumSlateBlue;
            btnN4.Font = new Font("Arial Rounded MT Bold", 15.75F);
            btnN4.ForeColor = SystemColors.ButtonFace;
            btnN4.Location = new Point(364, 239);
            btnN4.Name = "btnN4";
            btnN4.Size = new Size(75, 58);
            btnN4.TabIndex = 9;
            btnN4.Text = "4";
            btnN4.UseVisualStyleBackColor = false;
            btnN4.Click += btnN4_Click;
            // 
            // btnN5
            // 
            btnN5.BackColor = Color.MediumSlateBlue;
            btnN5.Font = new Font("Arial Rounded MT Bold", 15.75F);
            btnN5.ForeColor = SystemColors.ButtonFace;
            btnN5.Location = new Point(445, 239);
            btnN5.Name = "btnN5";
            btnN5.Size = new Size(75, 58);
            btnN5.TabIndex = 10;
            btnN5.Text = "5";
            btnN5.UseVisualStyleBackColor = false;
            btnN5.Click += btnN5_Click;
            // 
            // btnN6
            // 
            btnN6.BackColor = Color.MediumSlateBlue;
            btnN6.Font = new Font("Arial Rounded MT Bold", 15.75F);
            btnN6.ForeColor = SystemColors.ButtonFace;
            btnN6.Location = new Point(526, 239);
            btnN6.Name = "btnN6";
            btnN6.Size = new Size(75, 58);
            btnN6.TabIndex = 11;
            btnN6.Text = "6";
            btnN6.UseVisualStyleBackColor = false;
            btnN6.Click += btnN6_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.BackColor = SystemColors.ControlLightLight;
            btnBorrar.Font = new Font("Arial Rounded MT Bold", 15.75F);
            btnBorrar.Location = new Point(526, 111);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(156, 58);
            btnBorrar.TabIndex = 12;
            btnBorrar.Text = "←";
            btnBorrar.UseVisualStyleBackColor = false;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // btnN7
            // 
            btnN7.BackColor = Color.MediumSlateBlue;
            btnN7.Font = new Font("Arial Rounded MT Bold", 15.75F);
            btnN7.ForeColor = SystemColors.ButtonFace;
            btnN7.Location = new Point(364, 303);
            btnN7.Name = "btnN7";
            btnN7.Size = new Size(75, 58);
            btnN7.TabIndex = 13;
            btnN7.Text = "7";
            btnN7.UseVisualStyleBackColor = false;
            btnN7.Click += btnN7_Click;
            // 
            // btnN8
            // 
            btnN8.BackColor = Color.MediumSlateBlue;
            btnN8.Font = new Font("Arial Rounded MT Bold", 15.75F);
            btnN8.ForeColor = SystemColors.ButtonFace;
            btnN8.Location = new Point(445, 303);
            btnN8.Name = "btnN8";
            btnN8.Size = new Size(75, 58);
            btnN8.TabIndex = 14;
            btnN8.Text = "8";
            btnN8.UseVisualStyleBackColor = false;
            btnN8.Click += btnN8_Click;
            // 
            // btnN9
            // 
            btnN9.BackColor = Color.MediumSlateBlue;
            btnN9.Font = new Font("Arial Rounded MT Bold", 15.75F);
            btnN9.ForeColor = SystemColors.ButtonFace;
            btnN9.Location = new Point(526, 303);
            btnN9.Name = "btnN9";
            btnN9.Size = new Size(75, 58);
            btnN9.TabIndex = 15;
            btnN9.Text = "9";
            btnN9.UseVisualStyleBackColor = false;
            btnN9.Click += btnN9_Click;
            // 
            // btnIgual
            // 
            btnIgual.BackColor = SystemColors.ControlLightLight;
            btnIgual.Font = new Font("Arial Rounded MT Bold", 15.75F);
            btnIgual.Location = new Point(607, 239);
            btnIgual.Name = "btnIgual";
            btnIgual.Size = new Size(75, 187);
            btnIgual.TabIndex = 16;
            btnIgual.Text = "=";
            btnIgual.UseVisualStyleBackColor = false;
            btnIgual.Click += btnIgual_Click;
            // 
            // btnN0
            // 
            btnN0.BackColor = Color.MediumSlateBlue;
            btnN0.Font = new Font("Arial Rounded MT Bold", 15.75F);
            btnN0.ForeColor = SystemColors.ButtonFace;
            btnN0.Location = new Point(364, 367);
            btnN0.Name = "btnN0";
            btnN0.Size = new Size(156, 58);
            btnN0.TabIndex = 17;
            btnN0.Text = "0";
            btnN0.UseVisualStyleBackColor = false;
            btnN0.Click += btnN0_Click;
            // 
            // btnPunto
            // 
            btnPunto.BackColor = Color.MediumSlateBlue;
            btnPunto.Font = new Font("Arial Rounded MT Bold", 15.75F);
            btnPunto.ForeColor = SystemColors.ButtonFace;
            btnPunto.Location = new Point(526, 367);
            btnPunto.Name = "btnPunto";
            btnPunto.Size = new Size(75, 58);
            btnPunto.TabIndex = 18;
            btnPunto.Text = ".";
            btnPunto.UseVisualStyleBackColor = false;
            btnPunto.Click += btnPunto_Click;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(40, 34);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(642, 36);
            textBox1.TabIndex = 19;
            textBox1.TextAlign = HorizontalAlignment.Right;
            // 
            // btnMasMenos
            // 
            btnMasMenos.BackColor = SystemColors.ControlDark;
            btnMasMenos.Font = new Font("Arial Rounded MT Bold", 15.75F);
            btnMasMenos.ForeColor = SystemColors.ButtonFace;
            btnMasMenos.Location = new Point(445, 111);
            btnMasMenos.Name = "btnMasMenos";
            btnMasMenos.Size = new Size(75, 58);
            btnMasMenos.TabIndex = 20;
            btnMasMenos.Text = "±";
            btnMasMenos.UseVisualStyleBackColor = false;
            btnMasMenos.Click += btnMasMenos_Click;
            // 
            // btnPorcentaje
            // 
            btnPorcentaje.BackColor = SystemColors.ControlDark;
            btnPorcentaje.Font = new Font("Arial Rounded MT Bold", 15.75F);
            btnPorcentaje.ForeColor = SystemColors.ButtonFace;
            btnPorcentaje.Location = new Point(364, 111);
            btnPorcentaje.Name = "btnPorcentaje";
            btnPorcentaje.Size = new Size(75, 58);
            btnPorcentaje.TabIndex = 21;
            btnPorcentaje.Text = "%";
            btnPorcentaje.UseVisualStyleBackColor = false;
            btnPorcentaje.Click += btnPorcentaje_Click;
            // 
            // btnRaiz
            // 
            btnRaiz.BackColor = SystemColors.ControlDark;
            btnRaiz.Font = new Font("Arial Rounded MT Bold", 15.75F);
            btnRaiz.ForeColor = SystemColors.ButtonFace;
            btnRaiz.Location = new Point(607, 175);
            btnRaiz.Name = "btnRaiz";
            btnRaiz.Size = new Size(75, 58);
            btnRaiz.TabIndex = 22;
            btnRaiz.Text = "√";
            btnRaiz.UseVisualStyleBackColor = false;
            btnRaiz.Click += btnRaiz_Click;
            // 
            // btnLimpiarTodo
            // 
            btnLimpiarTodo.BackColor = SystemColors.ControlLightLight;
            btnLimpiarTodo.Font = new Font("Arial Rounded MT Bold", 15.75F);
            btnLimpiarTodo.Location = new Point(202, 111);
            btnLimpiarTodo.Name = "btnLimpiarTodo";
            btnLimpiarTodo.Size = new Size(156, 58);
            btnLimpiarTodo.TabIndex = 23;
            btnLimpiarTodo.Text = "C";
            btnLimpiarTodo.UseVisualStyleBackColor = false;
            btnLimpiarTodo.Click += btnLimpiarTodo_Click;
            // 
            // btnSin
            // 
            btnSin.BackColor = SystemColors.MenuHighlight;
            btnSin.Font = new Font("Arial Rounded MT Bold", 15.75F);
            btnSin.ForeColor = SystemColors.ButtonFace;
            btnSin.Location = new Point(40, 175);
            btnSin.Name = "btnSin";
            btnSin.Size = new Size(75, 58);
            btnSin.TabIndex = 24;
            btnSin.Text = "sin";
            btnSin.UseVisualStyleBackColor = false;
            btnSin.Click += btnSin_Click;
            // 
            // btnTan
            // 
            btnTan.BackColor = SystemColors.MenuHighlight;
            btnTan.Font = new Font("Arial Rounded MT Bold", 15.75F);
            btnTan.ForeColor = SystemColors.ButtonFace;
            btnTan.Location = new Point(202, 175);
            btnTan.Name = "btnTan";
            btnTan.Size = new Size(75, 58);
            btnTan.TabIndex = 25;
            btnTan.Text = "tan";
            btnTan.UseVisualStyleBackColor = false;
            btnTan.Click += btnTan_Click_1;
            // 
            // btnCos
            // 
            btnCos.BackColor = SystemColors.MenuHighlight;
            btnCos.Font = new Font("Arial Rounded MT Bold", 15.75F);
            btnCos.ForeColor = SystemColors.ButtonFace;
            btnCos.Location = new Point(121, 175);
            btnCos.Name = "btnCos";
            btnCos.Size = new Size(75, 58);
            btnCos.TabIndex = 26;
            btnCos.Text = "cos";
            btnCos.UseVisualStyleBackColor = false;
            btnCos.Click += btnCos_Click;
            // 
            // btnSqrt
            // 
            btnSqrt.BackColor = SystemColors.MenuHighlight;
            btnSqrt.Font = new Font("Arial Rounded MT Bold", 15.75F);
            btnSqrt.ForeColor = SystemColors.ButtonFace;
            btnSqrt.Location = new Point(121, 239);
            btnSqrt.Name = "btnSqrt";
            btnSqrt.Size = new Size(75, 58);
            btnSqrt.TabIndex = 29;
            btnSqrt.Text = "x^2";
            btnSqrt.UseVisualStyleBackColor = false;
            btnSqrt.Click += btnSqrt_Click;
            // 
            // btnThrd
            // 
            btnThrd.BackColor = SystemColors.MenuHighlight;
            btnThrd.Font = new Font("Arial Rounded MT Bold", 15.75F);
            btnThrd.ForeColor = SystemColors.ButtonFace;
            btnThrd.Location = new Point(202, 239);
            btnThrd.Name = "btnThrd";
            btnThrd.Size = new Size(75, 58);
            btnThrd.TabIndex = 28;
            btnThrd.Text = "x^3";
            btnThrd.UseVisualStyleBackColor = false;
            btnThrd.Click += btnThrd_Click;
            // 
            // btnRaise
            // 
            btnRaise.BackColor = SystemColors.MenuHighlight;
            btnRaise.Font = new Font("Arial Rounded MT Bold", 15.75F);
            btnRaise.ForeColor = SystemColors.ButtonFace;
            btnRaise.Location = new Point(40, 239);
            btnRaise.Name = "btnRaise";
            btnRaise.Size = new Size(75, 58);
            btnRaise.TabIndex = 27;
            btnRaise.Text = "x^y";
            btnRaise.UseVisualStyleBackColor = false;
            btnRaise.Click += button6_Click;
            // 
            // btnRaizTercera
            // 
            btnRaizTercera.BackColor = SystemColors.MenuHighlight;
            btnRaizTercera.Font = new Font("Arial Rounded MT Bold", 15.75F);
            btnRaizTercera.ForeColor = SystemColors.ButtonFace;
            btnRaizTercera.Location = new Point(121, 304);
            btnRaizTercera.Name = "btnRaizTercera";
            btnRaizTercera.Size = new Size(75, 58);
            btnRaizTercera.TabIndex = 32;
            btnRaizTercera.Text = "3√x";
            btnRaizTercera.UseVisualStyleBackColor = false;
            btnRaizTercera.Click += btnRaizTercera_Click;
            // 
            // btnRaizY
            // 
            btnRaizY.BackColor = SystemColors.MenuHighlight;
            btnRaizY.Font = new Font("Arial Rounded MT Bold", 15.75F);
            btnRaizY.ForeColor = SystemColors.ButtonFace;
            btnRaizY.Location = new Point(202, 304);
            btnRaizY.Name = "btnRaizY";
            btnRaizY.Size = new Size(75, 58);
            btnRaizY.TabIndex = 31;
            btnRaizY.Text = "y√x";
            btnRaizY.UseVisualStyleBackColor = false;
            btnRaizY.Click += btnRaizY_Click_1;
            // 
            // button9
            // 
            button9.BackColor = SystemColors.MenuHighlight;
            button9.Font = new Font("Arial Rounded MT Bold", 15.75F);
            button9.ForeColor = SystemColors.ButtonFace;
            button9.Location = new Point(40, 304);
            button9.Name = "button9";
            button9.Size = new Size(75, 58);
            button9.TabIndex = 30;
            button9.Text = "(π)";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click_1;
            // 
            // btnEXP
            // 
            btnEXP.BackColor = SystemColors.MenuHighlight;
            btnEXP.Font = new Font("Arial Rounded MT Bold", 15.75F);
            btnEXP.ForeColor = SystemColors.ButtonFace;
            btnEXP.Location = new Point(121, 367);
            btnEXP.Name = "btnEXP";
            btnEXP.Size = new Size(75, 58);
            btnEXP.TabIndex = 35;
            btnEXP.Text = "EXP";
            btnEXP.UseVisualStyleBackColor = false;
            btnEXP.Click += btnEXP_Click;
            // 
            // btnLog
            // 
            btnLog.BackColor = SystemColors.MenuHighlight;
            btnLog.Font = new Font("Arial Rounded MT Bold", 15.75F);
            btnLog.ForeColor = SystemColors.ButtonFace;
            btnLog.Location = new Point(202, 367);
            btnLog.Name = "btnLog";
            btnLog.Size = new Size(75, 58);
            btnLog.TabIndex = 34;
            btnLog.Text = "log";
            btnLog.UseVisualStyleBackColor = false;
            btnLog.Click += btnLog_Click;
            // 
            // btn10x
            // 
            btn10x.BackColor = SystemColors.MenuHighlight;
            btn10x.Font = new Font("Arial Rounded MT Bold", 15.75F);
            btn10x.ForeColor = SystemColors.ButtonFace;
            btn10x.Location = new Point(40, 367);
            btn10x.Name = "btn10x";
            btn10x.Size = new Size(75, 58);
            btn10x.TabIndex = 33;
            btn10x.Text = "10^x";
            btn10x.UseVisualStyleBackColor = false;
            btn10x.Click += btn10x_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(721, 461);
            Controls.Add(btnEXP);
            Controls.Add(btnLog);
            Controls.Add(btn10x);
            Controls.Add(btnRaizTercera);
            Controls.Add(btnRaizY);
            Controls.Add(button9);
            Controls.Add(btnSqrt);
            Controls.Add(btnThrd);
            Controls.Add(btnRaise);
            Controls.Add(btnCos);
            Controls.Add(btnTan);
            Controls.Add(btnSin);
            Controls.Add(btnLimpiarTodo);
            Controls.Add(btnRaiz);
            Controls.Add(btnPorcentaje);
            Controls.Add(btnMasMenos);
            Controls.Add(textBox1);
            Controls.Add(btnPunto);
            Controls.Add(btnN0);
            Controls.Add(btnIgual);
            Controls.Add(btnN9);
            Controls.Add(btnN8);
            Controls.Add(btnN7);
            Controls.Add(btnBorrar);
            Controls.Add(btnN6);
            Controls.Add(btnN5);
            Controls.Add(btnN4);
            Controls.Add(btnLimpiar);
            Controls.Add(btnN3);
            Controls.Add(btnN2);
            Controls.Add(btnN1);
            Controls.Add(btnDivi);
            Controls.Add(btnMulti);
            Controls.Add(btnResta);
            Controls.Add(btnSuma);
            Controls.Add(textScreen);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textScreen;
        private Button btnSuma;
        private Button btnResta;
        private Button btnMulti;
        private Button btnDivi;
        private Button btnN1;
        private Button btnN2;
        private Button btnN3;
        private Button btnLimpiar;
        private Button btnN4;
        private Button btnN5;
        private Button btnN6;
        private Button btnBorrar;
        private Button btnN7;
        private Button btnN8;
        private Button btnN9;
        private Button btnIgual;
        private Button btnN0;
        private Button btnPunto;
        private TextBox textBox1;
        private Button btnMasMenos;
        private Button btnPorcentaje;
        private Button btnRaiz;
        private Button btnLimpiarTodo;
        private Button btnSin;
        private Button btnTan;
        private Button btnCos;
        private Button btnSqrt;
        private Button btnThrd;
        private Button btnRaise;
        private Button btnRaizTercera;
        private Button btnRaizY;
        private Button button9;
        private Button btnEXP;
        private Button btnLog;
        private Button btn10x;
    }
}
