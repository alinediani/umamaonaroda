namespace ETEC.sisdecontroledevalor.UI
{
    partial class Slides
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Slides));
            this.imgPicture = new System.Windows.Forms.PictureBox();
            this.tmrNextImage = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.imgPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // imgPicture
            // 
            this.imgPicture.ErrorImage = ((System.Drawing.Image)(resources.GetObject("imgPicture.ErrorImage")));
            this.imgPicture.Image = global::ETEC.sisdecontroledevalor.UI.Properties.Resources.Logo3;
            this.imgPicture.Location = new System.Drawing.Point(0, 0);
            this.imgPicture.Name = "imgPicture";
            this.imgPicture.Size = new System.Drawing.Size(704, 388);
            this.imgPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPicture.TabIndex = 0;
            this.imgPicture.TabStop = false;
            // 
            // tmrNextImage
            // 
           
            // 
            // Slides
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.imgPicture);
            this.Name = "Slides";
            this.Size = new System.Drawing.Size(704, 388);
            ((System.ComponentModel.ISupportInitialize)(this.imgPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imgPicture;
        private System.Windows.Forms.Timer tmrNextImage;
    }
}
