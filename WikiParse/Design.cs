namespace WikiParse
{
    partial class WikiParse
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if(disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        #region Windows Form Designer generated code

        private void InitializeCompent()
        {
            this.Input = new System.Windows.Forms.TextBox();
            this.Output = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // Input
            this.Input.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Input.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Input.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Input.Location = new System.Drawing.Point(24, 34);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(800, 20);
            this.Input.TabIndex = 0;
            this.Input.Text = "Type here";
            this.Input.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Input_KeyDown);
            // Output
            this.Output.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Output.Location = new System.Drawing.Point(24, 78);
            this.Output.Multiline = true;
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(800, 480);
            this.Output.TabIndex = 2;
            this.Output.Text = "Type something to get result.";
            // Wiki
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.Input);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "WikiParse";
            this.Text = "WikiParse";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion


        private System.Windows.Forms.TextBox Input;
        private System.Windows.Forms.TextBox Output;
    }
}
