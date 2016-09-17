namespace Testies
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.irfButton = new System.Windows.Forms.Button();
            this.linkAggButton = new System.Windows.Forms.Button();
            this.snmpButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // irfButton
            // 
            this.irfButton.BackColor = System.Drawing.Color.Transparent;
            this.irfButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.irfButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.irfButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Menu;
            this.irfButton.FlatAppearance.BorderSize = 0;
            this.irfButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.irfButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.irfButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.irfButton.ForeColor = System.Drawing.Color.Transparent;
            this.irfButton.Image = global::Testies.Properties.Resources.IRF;
            this.irfButton.Location = new System.Drawing.Point(77, 233);
            this.irfButton.Name = "irfButton";
            this.irfButton.Size = new System.Drawing.Size(238, 183);
            this.irfButton.TabIndex = 0;
            this.irfButton.UseVisualStyleBackColor = false;
            this.irfButton.Click += new System.EventHandler(this.irfButton_Click);
            this.irfButton.MouseEnter += new System.EventHandler(this.irfButton_MouseEnter);
            this.irfButton.MouseLeave += new System.EventHandler(this.irfButton_MouseLeave);
            // 
            // linkAggButton
            // 
            this.linkAggButton.BackColor = System.Drawing.Color.Transparent;
            this.linkAggButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.linkAggButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkAggButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Menu;
            this.linkAggButton.FlatAppearance.BorderSize = 0;
            this.linkAggButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.linkAggButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.linkAggButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.linkAggButton.ForeColor = System.Drawing.Color.Transparent;
            this.linkAggButton.Image = global::Testies.Properties.Resources.Link_Agg2;
            this.linkAggButton.Location = new System.Drawing.Point(388, 233);
            this.linkAggButton.Name = "linkAggButton";
            this.linkAggButton.Size = new System.Drawing.Size(238, 183);
            this.linkAggButton.TabIndex = 1;
            this.linkAggButton.UseVisualStyleBackColor = false;
            this.linkAggButton.MouseEnter += new System.EventHandler(this.linkAggButton_MouseEnter);
            this.linkAggButton.MouseLeave += new System.EventHandler(this.linkAggButton_MouseLeave);
            // 
            // snmpButton
            // 
            this.snmpButton.BackColor = System.Drawing.Color.Transparent;
            this.snmpButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.snmpButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.snmpButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Menu;
            this.snmpButton.FlatAppearance.BorderSize = 0;
            this.snmpButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.snmpButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.snmpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.snmpButton.ForeColor = System.Drawing.Color.Transparent;
            this.snmpButton.Image = global::Testies.Properties.Resources.SNMP;
            this.snmpButton.Location = new System.Drawing.Point(699, 233);
            this.snmpButton.Name = "snmpButton";
            this.snmpButton.Size = new System.Drawing.Size(238, 183);
            this.snmpButton.TabIndex = 2;
            this.snmpButton.UseVisualStyleBackColor = false;
            this.snmpButton.MouseEnter += new System.EventHandler(this.snmpButton_MouseEnter);
            this.snmpButton.MouseLeave += new System.EventHandler(this.snmpButton_MouseLeave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.snmpButton);
            this.Controls.Add(this.linkAggButton);
            this.Controls.Add(this.irfButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button irfButton;
        private System.Windows.Forms.Button linkAggButton;
        private System.Windows.Forms.Button snmpButton;
    }
}

