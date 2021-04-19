namespace Mandelbrot
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
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.zoomButton = new System.Windows.Forms.Button();
            this.zoomText = new System.Windows.Forms.TextBox();
            this.zoomInfo = new System.Windows.Forms.Label();
            this.currentZoom = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // picCanvas
            // 
            this.picCanvas.Location = new System.Drawing.Point(113, 0);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(800, 800);
            this.picCanvas.TabIndex = 0;
            this.picCanvas.TabStop = false;
            this.picCanvas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picCanvas_MouseClick);
            this.picCanvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picCanvas_MouseMove);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // zoomButton
            // 
            this.zoomButton.Location = new System.Drawing.Point(11, 242);
            this.zoomButton.Name = "zoomButton";
            this.zoomButton.Size = new System.Drawing.Size(75, 23);
            this.zoomButton.TabIndex = 2;
            this.zoomButton.Text = "Set Zoom";
            this.zoomButton.UseVisualStyleBackColor = true;
            this.zoomButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // zoomText
            // 
            this.zoomText.Location = new System.Drawing.Point(11, 271);
            this.zoomText.Name = "zoomText";
            this.zoomText.Size = new System.Drawing.Size(76, 20);
            this.zoomText.TabIndex = 3;
            this.zoomText.Text = "1";
            // 
            // zoomInfo
            // 
            this.zoomInfo.AutoSize = true;
            this.zoomInfo.Location = new System.Drawing.Point(8, 170);
            this.zoomInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.zoomInfo.Name = "zoomInfo";
            this.zoomInfo.Size = new System.Drawing.Size(86, 65);
            this.zoomInfo.TabIndex = 4;
            this.zoomInfo.Text = "This adds to the \r\ncurrent zoom \r\nlevel once you \r\nclick on a point \r\nto zoom in " +
    "on\r\n";
            // 
            // currentZoom
            // 
            this.currentZoom.AutoSize = true;
            this.currentZoom.Location = new System.Drawing.Point(8, 59);
            this.currentZoom.Name = "currentZoom";
            this.currentZoom.Size = new System.Drawing.Size(88, 13);
            this.currentZoom.TabIndex = 5;
            this.currentZoom.Text = "Current Zoom: 1x";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 802);
            this.Controls.Add(this.currentZoom);
            this.Controls.Add(this.zoomInfo);
            this.Controls.Add(this.zoomText);
            this.Controls.Add(this.zoomButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.picCanvas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button zoomButton;
        private System.Windows.Forms.TextBox zoomText;
        private System.Windows.Forms.Label zoomInfo;
        private System.Windows.Forms.Label currentZoom;
    }
}

