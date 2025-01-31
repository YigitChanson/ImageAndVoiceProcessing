namespace AIProcessing
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
            this.TrackBarProcess = new System.Windows.Forms.TrackBar();
            this.IslemTipiLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarProcess)).BeginInit();
            this.SuspendLayout();
            // 
            // TrackBarProcess
            // 
            this.TrackBarProcess.AccessibleName = "";
            this.TrackBarProcess.Location = new System.Drawing.Point(27, 132);
            this.TrackBarProcess.Maximum = 1;
            this.TrackBarProcess.Name = "TrackBarProcess";
            this.TrackBarProcess.Size = new System.Drawing.Size(334, 56);
            this.TrackBarProcess.TabIndex = 0;
            this.TrackBarProcess.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.TrackBarProcess.Scroll += new System.EventHandler(this.TrackBarIslem_Scroll);
            // 
            // IslemTipiLabel
            // 
            this.IslemTipiLabel.AutoSize = true;
            this.IslemTipiLabel.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.IslemTipiLabel.Location = new System.Drawing.Point(136, 100);
            this.IslemTipiLabel.Name = "IslemTipiLabel";
            this.IslemTipiLabel.Size = new System.Drawing.Size(138, 31);
            this.IslemTipiLabel.TabIndex = 2;
            this.IslemTipiLabel.Text = "İŞLEM TİPİ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.IslemTipiLabel);
            this.Controls.Add(this.TrackBarProcess);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarProcess)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar TrackBarProcess;
        private System.Windows.Forms.Label IslemTipiLabel;
    }
}

