

using System;
using System.Diagnostics;
using System.Windows.Forms;
using OpenRevitOleStorage.StructuredStorage;

namespace OpenRevitOleStorage
{

 
 public partial class Form1 : Form
 {
  public Form1()
  {
   InitializeComponent();
  }

  private void button1_Click(object sender, EventArgs e)
  {
   lblFilename.Text = string.Empty;
   txtFileInfo.Text = string.Empty;
   using(OpenFileDialog ofd = new OpenFileDialog())
   {

    ofd.Filter = "Revit Files (*.rvt; *.rte; *.rfa; *.rft)|*.rvt; *.rte; *.rfa; *.rft";
    ofd.Multiselect = false;
    ofd.Title = "Select Revit File";
    if(ofd.ShowDialog() == DialogResult.Cancel)
    {
     return;
    }

    Storage storage = new Storage(ofd.FileName);

    if(storage.IsInitialized == false)
    {
     Debug.WriteLine("OpenRevitOleStorage returning because Storage is not initialized - error reading Structured Storage.");
     return;
    }

    picPreview.Image = storage.ThumbnailImage.GetPreviewAsImage();

    if(storage.BasicInfo != null)
    {
     txtFileInfo.Text = storage.BasicInfo.ToString();
    }
      //MailMessage message = new MailMessage();
      //message.From = new MailAddress("d.echols@haengineers.com");

      //message.To.Add(new MailAddress("d.echols@haengineers.com"));
      ////message.To.Add(new MailAddress("d.shields@haengineers.com"));

      //message.Subject = "BasicFileInfo and Preview Image Test";

      //StringBuilder sb = new StringBuilder();
      //sb.Append(storage.BasicInfo.ToString());

      //message.Body = sb.ToString();
    //string fileName = string.Empty;

    //try
    //{
    // fileName = Path.ChangeExtension(Path.GetTempFileName(), ".png");

    // using(Bitmap bmNew = new Bitmap(picPreview.Image.Width, picPreview.Image.Height, PixelFormat.Format24bppRgb))
    // {
    //  Graphics g = Graphics.FromImage(bmNew);
    //  g.DrawImage(picPreview.Image, new Point(0, 0));
    //  g.Dispose();
    //  bmNew.Save(fileName, ImageFormat.Png);
    // }

    // // Create  the file attachment for this e-mail message.
    // Attachment attachmentData = new Attachment(fileName, MediaTypeNames.Application.Octet);

    // message.Attachments.Add(attachmentData);
    //}
    //catch(Exception ex)
    //{
    // LogManager.LogMessage(ex);
    //}

    //SmtpClient client = new SmtpClient();
    //  client.Host = "svexch2.haengineers.com";
    //client.DeliveryMethod = SmtpDeliveryMethod.Network;

    //  client.Send(message);

    //  sb.Length = 0;
    //  sb.Capacity = 0;
    //  sb = null;
    //FileUtility.Delete(fileName);
   }

  }
 }
}
