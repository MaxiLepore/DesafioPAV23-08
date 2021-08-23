
namespace PruebaLogin
{
    partial class FrmLogin
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
            this.TxtLoginUser = new System.Windows.Forms.TextBox();
            this.TxtLoginPass = new System.Windows.Forms.TextBox();
            this.LblLoginUser = new System.Windows.Forms.Label();
            this.LblLoginPass = new System.Windows.Forms.Label();
            this.BtnIngresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtLoginUser
            // 
            this.TxtLoginUser.Location = new System.Drawing.Point(105, 30);
            this.TxtLoginUser.Name = "TxtLoginUser";
            this.TxtLoginUser.Size = new System.Drawing.Size(157, 20);
            this.TxtLoginUser.TabIndex = 1;
            // 
            // TxtLoginPass
            // 
            this.TxtLoginPass.Location = new System.Drawing.Point(105, 82);
            this.TxtLoginPass.Name = "TxtLoginPass";
            this.TxtLoginPass.Size = new System.Drawing.Size(157, 20);
            this.TxtLoginPass.TabIndex = 2;
            this.TxtLoginPass.UseSystemPasswordChar = true;
            // 
            // LblLoginUser
            // 
            this.LblLoginUser.AccessibleName = "";
            this.LblLoginUser.AutoSize = true;
            this.LblLoginUser.Location = new System.Drawing.Point(51, 30);
            this.LblLoginUser.Name = "LblLoginUser";
            this.LblLoginUser.Size = new System.Drawing.Size(46, 13);
            this.LblLoginUser.TabIndex = 3;
            this.LblLoginUser.Text = "Usuario:";
            this.LblLoginUser.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // LblLoginPass
            // 
            this.LblLoginPass.AutoSize = true;
            this.LblLoginPass.Location = new System.Drawing.Point(41, 82);
            this.LblLoginPass.Name = "LblLoginPass";
            this.LblLoginPass.Size = new System.Drawing.Size(64, 13);
            this.LblLoginPass.TabIndex = 4;
            this.LblLoginPass.Text = "Contraseña:";
            // 
            // BtnIngresar
            // 
            this.BtnIngresar.Location = new System.Drawing.Point(113, 119);
            this.BtnIngresar.Name = "BtnIngresar";
            this.BtnIngresar.Size = new System.Drawing.Size(87, 35);
            this.BtnIngresar.TabIndex = 5;
            this.BtnIngresar.Text = "Ingresar";
            this.BtnIngresar.UseVisualStyleBackColor = true;
            this.BtnIngresar.Click += new System.EventHandler(this.BtnIngresar_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 166);
            this.Controls.Add(this.BtnIngresar);
            this.Controls.Add(this.LblLoginPass);
            this.Controls.Add(this.LblLoginUser);
            this.Controls.Add(this.TxtLoginPass);
            this.Controls.Add(this.TxtLoginUser);
            this.Name = "FrmLogin";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtLoginUser;
        private System.Windows.Forms.TextBox TxtLoginPass;
        private System.Windows.Forms.Label LblLoginUser;
        private System.Windows.Forms.Label LblLoginPass;
        private System.Windows.Forms.Button BtnIngresar;
    }
}

