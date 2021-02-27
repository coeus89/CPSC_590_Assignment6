
namespace FirstWCFClient
{
    partial class Form1
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
            this.btnTestWCFMyMath = new System.Windows.Forms.Button();
            this.btnTestWCFViaProxy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTestWCFMyMath
            // 
            this.btnTestWCFMyMath.Location = new System.Drawing.Point(64, 28);
            this.btnTestWCFMyMath.Name = "btnTestWCFMyMath";
            this.btnTestWCFMyMath.Size = new System.Drawing.Size(197, 40);
            this.btnTestWCFMyMath.TabIndex = 0;
            this.btnTestWCFMyMath.Text = "Test WCF MyMath";
            this.btnTestWCFMyMath.UseVisualStyleBackColor = true;
            this.btnTestWCFMyMath.Click += new System.EventHandler(this.btnTestWCFMyMath_Click);
            // 
            // btnTestWCFViaProxy
            // 
            this.btnTestWCFViaProxy.Location = new System.Drawing.Point(64, 98);
            this.btnTestWCFViaProxy.Name = "btnTestWCFViaProxy";
            this.btnTestWCFViaProxy.Size = new System.Drawing.Size(197, 40);
            this.btnTestWCFViaProxy.TabIndex = 0;
            this.btnTestWCFViaProxy.Text = "Test WCF via Proxy";
            this.btnTestWCFViaProxy.UseVisualStyleBackColor = true;
            this.btnTestWCFViaProxy.Click += new System.EventHandler(this.btnTestWCFViaProxy_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 199);
            this.Controls.Add(this.btnTestWCFViaProxy);
            this.Controls.Add(this.btnTestWCFMyMath);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTestWCFMyMath;
        private System.Windows.Forms.Button btnTestWCFViaProxy;
    }
}

