namespace Tarea_3_LP3
{
    partial class FrmUsuario
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
            this.ListarButton = new System.Windows.Forms.Button();
            this.ListarDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ListarDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ListarButton
            // 
            this.ListarButton.Location = new System.Drawing.Point(319, 275);
            this.ListarButton.Name = "ListarButton";
            this.ListarButton.Size = new System.Drawing.Size(92, 35);
            this.ListarButton.TabIndex = 0;
            this.ListarButton.Text = "Mostrar Usuarios";
            this.ListarButton.UseVisualStyleBackColor = true;
            this.ListarButton.Click += new System.EventHandler(this.ListarButton_Click);
            // 
            // ListarDataGridView
            // 
            this.ListarDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListarDataGridView.Location = new System.Drawing.Point(86, 49);
            this.ListarDataGridView.Name = "ListarDataGridView";
            this.ListarDataGridView.RowHeadersWidth = 62;
            this.ListarDataGridView.RowTemplate.Height = 28;
            this.ListarDataGridView.Size = new System.Drawing.Size(594, 209);
            this.ListarDataGridView.TabIndex = 1;
            // 
            // FrmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ListarDataGridView);
            this.Controls.Add(this.ListarButton);
            this.Name = "FrmUsuario";
            this.Text = "FrmUsuario";
            ((System.ComponentModel.ISupportInitialize)(this.ListarDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ListarButton;
        private System.Windows.Forms.DataGridView ListarDataGridView;
    }
}