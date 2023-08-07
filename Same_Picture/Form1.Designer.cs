namespace Same_Picture
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            imageList1 = new System.Windows.Forms.ImageList(components);
            label1 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // imageList1
            // 
            imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            imageList1.ImageStream = (System.Windows.Forms.ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = System.Drawing.Color.Transparent;
            imageList1.Images.SetKeyName(0, "1.jpg");
            imageList1.Images.SetKeyName(1, "2.jpg");
            imageList1.Images.SetKeyName(2, "3.jpg");
            imageList1.Images.SetKeyName(3, "4.jpg");
            imageList1.Images.SetKeyName(4, "5.jpg");
            imageList1.Images.SetKeyName(5, "6.jpg");
            imageList1.Images.SetKeyName(6, "7.jpg");
            imageList1.Images.SetKeyName(7, "8.jpg");
            imageList1.Images.SetKeyName(8, "null.jpg");
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(280, 10);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(59, 25);
            label1.TabIndex = 2;
            label1.Text = "Score";
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(784, 461);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label1;
    }
}
