
namespace CBClient
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
            this.lblA = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.btnTestCallback = new System.Windows.Forms.Button();
            this.lblClientID = new System.Windows.Forms.Label();
            this.txtClientID = new System.Windows.Forms.TextBox();
            this.btnSubscribe = new System.Windows.Forms.Button();
            this.btnUnsubscribe = new System.Windows.Forms.Button();
            this.btnChangePrice = new System.Windows.Forms.Button();
            this.txtNewPrice = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(36, 101);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(17, 17);
            this.lblA.TabIndex = 0;
            this.lblA.Text = "A";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(260, 101);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(17, 17);
            this.lblB.TabIndex = 0;
            this.lblB.Text = "B";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(60, 98);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(110, 22);
            this.txtA.TabIndex = 1;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(283, 98);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(110, 22);
            this.txtB.TabIndex = 1;
            // 
            // btnTestCallback
            // 
            this.btnTestCallback.Location = new System.Drawing.Point(158, 37);
            this.btnTestCallback.Name = "btnTestCallback";
            this.btnTestCallback.Size = new System.Drawing.Size(140, 40);
            this.btnTestCallback.TabIndex = 2;
            this.btnTestCallback.Text = "Test Callback";
            this.btnTestCallback.UseVisualStyleBackColor = true;
            this.btnTestCallback.Click += new System.EventHandler(this.btnTestCallback_Click);
            // 
            // lblClientID
            // 
            this.lblClientID.AutoSize = true;
            this.lblClientID.Location = new System.Drawing.Point(111, 144);
            this.lblClientID.Name = "lblClientID";
            this.lblClientID.Size = new System.Drawing.Size(56, 17);
            this.lblClientID.TabIndex = 0;
            this.lblClientID.Text = "ClientID";
            // 
            // txtClientID
            // 
            this.txtClientID.Location = new System.Drawing.Point(173, 141);
            this.txtClientID.Name = "txtClientID";
            this.txtClientID.Size = new System.Drawing.Size(110, 22);
            this.txtClientID.TabIndex = 1;
            // 
            // btnSubscribe
            // 
            this.btnSubscribe.Location = new System.Drawing.Point(474, 37);
            this.btnSubscribe.Name = "btnSubscribe";
            this.btnSubscribe.Size = new System.Drawing.Size(140, 40);
            this.btnSubscribe.TabIndex = 2;
            this.btnSubscribe.Text = "Subscribe";
            this.btnSubscribe.UseVisualStyleBackColor = true;
            this.btnSubscribe.Click += new System.EventHandler(this.btnSubscribe_Click);
            // 
            // btnUnsubscribe
            // 
            this.btnUnsubscribe.Location = new System.Drawing.Point(710, 37);
            this.btnUnsubscribe.Name = "btnUnsubscribe";
            this.btnUnsubscribe.Size = new System.Drawing.Size(140, 40);
            this.btnUnsubscribe.TabIndex = 2;
            this.btnUnsubscribe.Text = "Unsubscribe";
            this.btnUnsubscribe.UseVisualStyleBackColor = true;
            this.btnUnsubscribe.Click += new System.EventHandler(this.btnUnsubscribe_Click);
            // 
            // btnChangePrice
            // 
            this.btnChangePrice.Location = new System.Drawing.Point(474, 121);
            this.btnChangePrice.Name = "btnChangePrice";
            this.btnChangePrice.Size = new System.Drawing.Size(140, 40);
            this.btnChangePrice.TabIndex = 2;
            this.btnChangePrice.Text = "Change Price";
            this.btnChangePrice.UseVisualStyleBackColor = true;
            this.btnChangePrice.Click += new System.EventHandler(this.btnChangePrice_Click);
            // 
            // txtNewPrice
            // 
            this.txtNewPrice.Location = new System.Drawing.Point(710, 139);
            this.txtNewPrice.Name = "txtNewPrice";
            this.txtNewPrice.Size = new System.Drawing.Size(110, 22);
            this.txtNewPrice.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 450);
            this.Controls.Add(this.btnUnsubscribe);
            this.Controls.Add(this.btnChangePrice);
            this.Controls.Add(this.btnSubscribe);
            this.Controls.Add(this.btnTestCallback);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtNewPrice);
            this.Controls.Add(this.txtClientID);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblClientID);
            this.Controls.Add(this.lblA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Button btnTestCallback;
        private System.Windows.Forms.Label lblClientID;
        private System.Windows.Forms.TextBox txtClientID;
        private System.Windows.Forms.Button btnSubscribe;
        private System.Windows.Forms.Button btnUnsubscribe;
        private System.Windows.Forms.Button btnChangePrice;
        private System.Windows.Forms.TextBox txtNewPrice;
    }
}

