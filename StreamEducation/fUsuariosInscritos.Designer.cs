﻿
namespace StreamEducation
{
    partial class fUsuariosInscritos
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
            this.bBuscar = new System.Windows.Forms.Button();
            this.tUsuario = new System.Windows.Forms.TextBox();
            this.lUsuarios = new System.Windows.Forms.ListBox();
            this.lExpulsar = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // bBuscar
            // 
            this.bBuscar.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBuscar.Location = new System.Drawing.Point(896, 39);
            this.bBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bBuscar.Name = "bBuscar";
            this.bBuscar.Size = new System.Drawing.Size(93, 34);
            this.bBuscar.TabIndex = 50;
            this.bBuscar.Text = "Buscar";
            this.bBuscar.UseVisualStyleBackColor = true;
            // 
            // tUsuario
            // 
            this.tUsuario.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tUsuario.Location = new System.Drawing.Point(31, 39);
            this.tUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tUsuario.Name = "tUsuario";
            this.tUsuario.Size = new System.Drawing.Size(839, 32);
            this.tUsuario.TabIndex = 49;
            // 
            // lUsuarios
            // 
            this.lUsuarios.BackColor = System.Drawing.SystemColors.Control;
            this.lUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lUsuarios.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lUsuarios.FormattingEnabled = true;
            this.lUsuarios.ItemHeight = 25;
            this.lUsuarios.Location = new System.Drawing.Point(31, 98);
            this.lUsuarios.Margin = new System.Windows.Forms.Padding(4);
            this.lUsuarios.Name = "lUsuarios";
            this.lUsuarios.Size = new System.Drawing.Size(840, 400);
            this.lUsuarios.TabIndex = 48;
            // 
            // lExpulsar
            // 
            this.lExpulsar.BackColor = System.Drawing.SystemColors.Control;
            this.lExpulsar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lExpulsar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lExpulsar.FormattingEnabled = true;
            this.lExpulsar.ItemHeight = 25;
            this.lExpulsar.Location = new System.Drawing.Point(896, 98);
            this.lExpulsar.Margin = new System.Windows.Forms.Padding(4);
            this.lExpulsar.Name = "lExpulsar";
            this.lExpulsar.Size = new System.Drawing.Size(93, 400);
            this.lExpulsar.TabIndex = 51;
            this.lExpulsar.SelectedIndexChanged += new System.EventHandler(this.lExpulsar_SelectedIndexChanged);
            // 
            // fUsuariosInscritos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 558);
            this.Controls.Add(this.lExpulsar);
            this.Controls.Add(this.bBuscar);
            this.Controls.Add(this.tUsuario);
            this.Controls.Add(this.lUsuarios);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "fUsuariosInscritos";
            this.ShowIcon = false;
            this.Text = "fUsuariosInscritos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bBuscar;
        private System.Windows.Forms.TextBox tUsuario;
        private System.Windows.Forms.ListBox lUsuarios;
        private System.Windows.Forms.ListBox lExpulsar;
    }
}