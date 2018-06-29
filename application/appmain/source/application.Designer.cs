namespace appmain
{
    partial class application
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
            this.btn_click = new System.Windows.Forms.Button();
            this.txtbx_Print = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_click
            // 
            this.btn_click.Location = new System.Drawing.Point(55, 60);
            this.btn_click.Name = "btn_click";
            this.btn_click.Size = new System.Drawing.Size(75, 23);
            this.btn_click.TabIndex = 0;
            this.btn_click.Text = "click!";
            this.btn_click.UseVisualStyleBackColor = true;
            this.btn_click.Click += new System.EventHandler(this.btn_click_Click);
            // 
            // txtbx_Print
            // 
            this.txtbx_Print.Location = new System.Drawing.Point(42, 114);
            this.txtbx_Print.Name = "txtbx_Print";
            this.txtbx_Print.Size = new System.Drawing.Size(100, 22);
            this.txtbx_Print.TabIndex = 1;
            // 
            // application
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 254);
            this.Controls.Add(this.txtbx_Print);
            this.Controls.Add(this.btn_click);
            this.Name = "application";
            this.Text = "App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_click;
        private System.Windows.Forms.TextBox txtbx_Print;
    }
}

