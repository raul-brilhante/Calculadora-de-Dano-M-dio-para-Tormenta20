namespace CalculadoraDanoT20
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TextBox txtDadosArma;
        private System.Windows.Forms.TextBox txtDadosExtras;
        private System.Windows.Forms.NumericUpDown numMargem;
        private System.Windows.Forms.NumericUpDown numMultiplicador;
        private System.Windows.Forms.NumericUpDown numBonusFlat;
        private System.Windows.Forms.Label lblRes1, lblRes2, lblRes3, lblRes4, lblRes5, lblRes6, lblRes7, lblRes8;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 700);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Name = "Form1";
            this.Text = "Calculadora de Dano Médio - Tormenta20";
            this.ResumeLayout(false);
        }
    }
}