﻿namespace lab08
{
    partial class fMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbAircraftInfo = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAddAircraft = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbCarInfo
            // 
            this.tbAircraftInfo.Location = new System.Drawing.Point(26, 29);
            this.tbAircraftInfo.Multiline = true;
            this.tbAircraftInfo.Name = "tbAircraftInfo";
            this.tbAircraftInfo.ReadOnly = true;
            this.tbAircraftInfo.Size = new System.Drawing.Size(618, 370);
            this.tbAircraftInfo.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(651, 359);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(137, 29);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Закрити";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAddCar
            // 
            this.btnAddAircraft.Location = new System.Drawing.Point(651, 41);
            this.btnAddAircraft.Name = "btnAddAircraft";
            this.btnAddAircraft.Size = new System.Drawing.Size(137, 29);
            this.btnAddAircraft.TabIndex = 1;
            this.btnAddAircraft.Text = "Додати літак";
            this.btnAddAircraft.UseVisualStyleBackColor = true;
            this.btnAddAircraft.Click += new System.EventHandler(this.btnAddAircraft_Click);
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAddAircraft);
            this.Controls.Add(this.tbAircraftInfo);
            this.MaximizeBox = false;
            this.Name = "fMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лабораторна робота №8";
            this.Load += new System.EventHandler(this.fMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbAircraftInfo;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAddAircraft;
    }
}

