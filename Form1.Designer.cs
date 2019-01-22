namespace OpenRevitOleStorage
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
   if(disposing && (components != null))
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
   this.button1 = new System.Windows.Forms.Button();
   this.lblFilename = new System.Windows.Forms.Label();
   this.txtFileInfo = new System.Windows.Forms.TextBox();
   this.picPreview = new System.Windows.Forms.PictureBox();
   ((System.ComponentModel.ISupportInitialize)(this.picPreview)).BeginInit();
   this.SuspendLayout();
   // 
   // button1
   // 
   this.button1.Location = new System.Drawing.Point(3, 21);
   this.button1.Name = "button1";
   this.button1.Size = new System.Drawing.Size(75, 23);
   this.button1.TabIndex = 0;
   this.button1.Text = "Open File";
   this.button1.UseVisualStyleBackColor = true;
   this.button1.Click += new System.EventHandler(this.button1_Click);
   // 
   // lblFilename
   // 
   this.lblFilename.AutoSize = true;
   this.lblFilename.Location = new System.Drawing.Point(8, 3);
   this.lblFilename.Name = "lblFilename";
   this.lblFilename.Size = new System.Drawing.Size(0, 13);
   this.lblFilename.TabIndex = 1;
   // 
   // txtFileInfo
   // 
   this.txtFileInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
               | System.Windows.Forms.AnchorStyles.Left)
               | System.Windows.Forms.AnchorStyles.Right)));
   this.txtFileInfo.Location = new System.Drawing.Point(3, 50);
   this.txtFileInfo.Multiline = true;
   this.txtFileInfo.Name = "txtFileInfo";
   this.txtFileInfo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
   this.txtFileInfo.Size = new System.Drawing.Size(876, 467);
   this.txtFileInfo.TabIndex = 2;
   // 
   // picPreview
   // 
   this.picPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
   this.picPreview.Location = new System.Drawing.Point(885, 50);
   this.picPreview.Name = "picPreview";
   this.picPreview.Size = new System.Drawing.Size(128, 128);
   this.picPreview.TabIndex = 3;
   this.picPreview.TabStop = false;
   // 
   // Form1
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.ClientSize = new System.Drawing.Size(1014, 519);
   this.Controls.Add(this.picPreview);
   this.Controls.Add(this.txtFileInfo);
   this.Controls.Add(this.lblFilename);
   this.Controls.Add(this.button1);
   this.Name = "Form1";
   this.Text = "Form1";
   ((System.ComponentModel.ISupportInitialize)(this.picPreview)).EndInit();
   this.ResumeLayout(false);
   this.PerformLayout();

  }

  #endregion

  private System.Windows.Forms.Button button1;
  private System.Windows.Forms.Label lblFilename;
  private System.Windows.Forms.TextBox txtFileInfo;
  private System.Windows.Forms.PictureBox picPreview;
 }
}

