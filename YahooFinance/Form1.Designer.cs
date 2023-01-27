namespace YahooFinance
{
    partial class YahooFinanceParser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YahooFinanceParser));
            this.textBox_input = new System.Windows.Forms.TextBox();
            this.button_ok = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.SuspendLayout();



            this.textBox_input.Location = new System.Drawing.Point(511, 120);
            this.textBox_input.Name = "textBox_input";
            this.textBox_input.Size = new System.Drawing.Size(241, 27);
            this.textBox_input.TabIndex = 0;
            this.textBox_input.TextChanged += new System.EventHandler(this.textBox1_TextChanged);



            this.button_ok.Location = new System.Drawing.Point(587, 173);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(94, 29);
            this.button_ok.TabIndex = 1;
            this.button_ok.Text = "OK";
            this.button_ok.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button_ok.UseVisualStyleBackColor = true;
            this.button_ok.Click += new System.EventHandler(this.button1_Click);



            this.label.BackColor = System.Drawing.Color.Transparent;
            this.label.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label.Location = new System.Drawing.Point(43, 39);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(462, 369);
            this.label.TabIndex = 2;
            this.label.Text = resources.GetString("label.Text");



            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::YahooFinance.Properties.Resources.grunge_paint_background;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label);
            this.Controls.Add(this.button_ok);
            this.Controls.Add(this.textBox_input);
            this.Name = "YahooFinanceParser";
            this.Text = "YahooFinanceParser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox_input;
        private Button button_ok;
        private Label label;
    }
}