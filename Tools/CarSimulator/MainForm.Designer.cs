﻿namespace CarSimulator
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.listPorts = new System.Windows.Forms.ListBox();
            this.timerUpdate = new System.Windows.Forms.Timer(this.components);
            this.checkBoxMoving = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(96, 12);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(75, 23);
            this.buttonConnect.TabIndex = 0;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // listPorts
            // 
            this.listPorts.FormattingEnabled = true;
            this.listPorts.Location = new System.Drawing.Point(12, 12);
            this.listPorts.Name = "listPorts";
            this.listPorts.Size = new System.Drawing.Size(78, 56);
            this.listPorts.TabIndex = 1;
            // 
            // timerUpdate
            // 
            this.timerUpdate.Interval = 500;
            this.timerUpdate.Tick += new System.EventHandler(this.timerUpdate_Tick);
            // 
            // checkBoxMoving
            // 
            this.checkBoxMoving.AutoSize = true;
            this.checkBoxMoving.Location = new System.Drawing.Point(97, 42);
            this.checkBoxMoving.Name = "checkBoxMoving";
            this.checkBoxMoving.Size = new System.Drawing.Size(59, 17);
            this.checkBoxMoving.TabIndex = 2;
            this.checkBoxMoving.Text = "Fahren";
            this.checkBoxMoving.UseVisualStyleBackColor = true;
            this.checkBoxMoving.CheckedChanged += new System.EventHandler(this.checkBoxMoving_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.checkBoxMoving);
            this.Controls.Add(this.listPorts);
            this.Controls.Add(this.buttonConnect);
            this.Name = "MainForm";
            this.Text = "Car Simulator";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.ListBox listPorts;
        private System.Windows.Forms.Timer timerUpdate;
        private System.Windows.Forms.CheckBox checkBoxMoving;

    }
}

