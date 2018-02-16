namespace Interview
{
    partial class DesignPatterns
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
            this.Strategy = new System.Windows.Forms.Button();
            this.SingletonButton = new System.Windows.Forms.Button();
            this.Observer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Strategy
            // 
            this.Strategy.Location = new System.Drawing.Point(12, 12);
            this.Strategy.Name = "Strategy";
            this.Strategy.Size = new System.Drawing.Size(75, 23);
            this.Strategy.TabIndex = 0;
            this.Strategy.Text = "Strategy";
            this.Strategy.UseVisualStyleBackColor = true;
            this.Strategy.Click += new System.EventHandler(this.Strategy_Click);
            // 
            // SingletonButton
            // 
            this.SingletonButton.Location = new System.Drawing.Point(93, 12);
            this.SingletonButton.Name = "SingletonButton";
            this.SingletonButton.Size = new System.Drawing.Size(75, 23);
            this.SingletonButton.TabIndex = 1;
            this.SingletonButton.Text = "Singleton";
            this.SingletonButton.UseVisualStyleBackColor = true;
            this.SingletonButton.Click += new System.EventHandler(this.Singleton_Click);
            // 
            // Observer
            // 
            this.Observer.Location = new System.Drawing.Point(12, 57);
            this.Observer.Name = "Observer";
            this.Observer.Size = new System.Drawing.Size(75, 23);
            this.Observer.TabIndex = 2;
            this.Observer.Text = "Observer";
            this.Observer.UseVisualStyleBackColor = true;
            this.Observer.Click += new System.EventHandler(this.Observer_Click);
            // 
            // DesignPatterns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Observer);
            this.Controls.Add(this.SingletonButton);
            this.Controls.Add(this.Strategy);
            this.Name = "DesignPatterns";
            this.Text = "DesignPatterns";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Strategy;
        private System.Windows.Forms.Button SingletonButton;
        private System.Windows.Forms.Button Observer;
    }
}