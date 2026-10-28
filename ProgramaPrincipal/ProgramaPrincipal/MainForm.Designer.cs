/*
 * Creado por SharpDevelop.
 * Usuario: CC2_PC12
 * Fecha: 28/10/2026
 * Hora: 07:58 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace ProgramaPrincipal
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.btnLlevar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(106, 27);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(281, 51);
			this.label1.TabIndex = 0;
			this.label1.Text = "MENU PRINCIPAL";
			// 
			// btnLlevar
			// 
			this.btnLlevar.Location = new System.Drawing.Point(157, 205);
			this.btnLlevar.Name = "btnLlevar";
			this.btnLlevar.Size = new System.Drawing.Size(177, 61);
			this.btnLlevar.TabIndex = 1;
			this.btnLlevar.Text = "Llevar";
			this.btnLlevar.UseVisualStyleBackColor = true;
			this.btnLlevar.Click += new System.EventHandler(this.BtnLlevarClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(475, 290);
			this.Controls.Add(this.btnLlevar);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "Menu Principal💋";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button btnLlevar;
		private System.Windows.Forms.Label label1;
	}
}
