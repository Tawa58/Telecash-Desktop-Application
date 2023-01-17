namespace sample
{
    partial class Airtime
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtAirtime = new System.Windows.Forms.TextBox();
            this.Self = new System.Windows.Forms.RadioButton();
            this.Others = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(116, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Amount($)";
            // 
            // txtAirtime
            // 
            this.txtAirtime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAirtime.Location = new System.Drawing.Point(280, 101);
            this.txtAirtime.Name = "txtAirtime";
            this.txtAirtime.Size = new System.Drawing.Size(100, 29);
            this.txtAirtime.TabIndex = 1;
            this.txtAirtime.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // Self
            // 
            this.Self.AutoSize = true;
            this.Self.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Self.Location = new System.Drawing.Point(57, 45);
            this.Self.Name = "Self";
            this.Self.Size = new System.Drawing.Size(131, 28);
            this.Self.TabIndex = 2;
            this.Self.TabStop = true;
            this.Self.Text = "Buy for self";
            this.Self.UseVisualStyleBackColor = true;
            // 
            // Others
            // 
            this.Others.AutoSize = true;
            this.Others.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Others.Location = new System.Drawing.Point(258, 45);
            this.Others.Name = "Others";
            this.Others.Size = new System.Drawing.Size(157, 28);
            this.Others.TabIndex = 3;
            this.Others.TabStop = true;
            this.Others.Text = "Buy for others";
            this.Others.UseVisualStyleBackColor = true;
            this.Others.CheckedChanged += new System.EventHandler(this.Others_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(292, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 33);
            this.button1.TabIndex = 4;
            this.button1.Text = "BUY";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Airtime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 182);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Others);
            this.Controls.Add(this.Self);
            this.Controls.Add(this.txtAirtime);
            this.Controls.Add(this.label1);
            this.Name = "Airtime";
            this.Text = "BuyAirtime";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAirtime;
        private System.Windows.Forms.RadioButton Self;
        private System.Windows.Forms.RadioButton Others;
        private System.Windows.Forms.Button button1;
    }
}