namespace OpenProgamSet
{
    partial class Client
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
            this.components = new System.ComponentModel.Container();
            this.IPTEXT = new System.Windows.Forms.TextBox();
            this.IP = new System.Windows.Forms.Label();
            this.PORT = new System.Windows.Forms.Label();
            this.PORTTEXT = new System.Windows.Forms.TextBox();
            this.ConnetButton = new System.Windows.Forms.Button();
            this.SSButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // IPTEXT
            // 
            this.IPTEXT.Font = new System.Drawing.Font("Impact", 24F);
            this.IPTEXT.Location = new System.Drawing.Point(285, 208);
            this.IPTEXT.Name = "IPTEXT";
            this.IPTEXT.Size = new System.Drawing.Size(381, 56);
            this.IPTEXT.TabIndex = 0;
            this.IPTEXT.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // IP
            // 
            this.IP.AutoSize = true;
            this.IP.Font = new System.Drawing.Font("Impact", 24F);
            this.IP.Location = new System.Drawing.Point(33, 211);
            this.IP.Name = "IP";
            this.IP.Size = new System.Drawing.Size(219, 48);
            this.IP.TabIndex = 1;
            this.IP.Text = "IP ADDRESS :";
            // 
            // PORT
            // 
            this.PORT.AutoSize = true;
            this.PORT.Font = new System.Drawing.Font("Impact", 24F);
            this.PORT.Location = new System.Drawing.Point(135, 298);
            this.PORT.Name = "PORT";
            this.PORT.Size = new System.Drawing.Size(117, 48);
            this.PORT.TabIndex = 2;
            this.PORT.Text = "PORT :";
            this.PORT.Click += new System.EventHandler(this.PORT_Click);
            // 
            // PORTTEXT
            // 
            this.PORTTEXT.Font = new System.Drawing.Font("Impact", 24F);
            this.PORTTEXT.Location = new System.Drawing.Point(285, 290);
            this.PORTTEXT.Name = "PORTTEXT";
            this.PORTTEXT.Size = new System.Drawing.Size(381, 56);
            this.PORTTEXT.TabIndex = 3;
            // 
            // ConnetButton
            // 
            this.ConnetButton.Font = new System.Drawing.Font("Impact", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConnetButton.Location = new System.Drawing.Point(285, 95);
            this.ConnetButton.Name = "ConnetButton";
            this.ConnetButton.Size = new System.Drawing.Size(154, 53);
            this.ConnetButton.TabIndex = 4;
            this.ConnetButton.Text = "CONNECT";
            this.ConnetButton.UseVisualStyleBackColor = true;
            this.ConnetButton.Click += new System.EventHandler(this.ConnetButton_Click);
            // 
            // SSButton
            // 
            this.SSButton.Font = new System.Drawing.Font("Impact", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SSButton.Location = new System.Drawing.Point(454, 95);
            this.SSButton.Name = "SSButton";
            this.SSButton.Size = new System.Drawing.Size(212, 53);
            this.SSButton.TabIndex = 5;
            this.SSButton.Text = "SHOWSCREEN";
            this.SSButton.UseVisualStyleBackColor = true;
            this.SSButton.Click += new System.EventHandler(this.SSButton_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OpenProgamSet.Properties.Resources.umballa_wallpaper;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SSButton);
            this.Controls.Add(this.ConnetButton);
            this.Controls.Add(this.PORTTEXT);
            this.Controls.Add(this.PORT);
            this.Controls.Add(this.IP);
            this.Controls.Add(this.IPTEXT);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Client";
            this.Text = "Remote Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox IPTEXT;
        private System.Windows.Forms.Label IP;
        private System.Windows.Forms.Label PORT;
        private System.Windows.Forms.TextBox PORTTEXT;
        private System.Windows.Forms.Button ConnetButton;
        private System.Windows.Forms.Button SSButton;
        private System.Windows.Forms.Timer timer1;
    }
}