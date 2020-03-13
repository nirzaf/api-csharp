using System;
using System.Net;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;
namespace SendSMS
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
    {

        private TabPage tabPage3;
        private Button button2;
        private TextBox textBox1;
        private Label label3;
        private TabPage tabPage1;
        private Label label7;
        private Button button1;
        private Label lblNumbers;
        private TextBox txtNumbers;
        private Label label2;
        private TextBox txtMessage;
        private TextBox txtSender;
        private Label label1;
        private TabControl tabControl1;
        private RadioButton radioButton2;
        private RadioButton radioButton1;

        //===================================================

        public const string UserName = ""; //mobile no
        public const string Password = "";
        //========================================== //password
        //===================================================
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblNumbers = new System.Windows.Forms.Label();
            this.txtNumbers = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.txtSender = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.radioButton2);
            this.tabPage3.Controls.Add(this.radioButton1);
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Controls.Add(this.textBox1);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(481, 432);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "«· √ﬂœ „‰ «”„ «·„—”·";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(114, 52);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioButton2.Size = new System.Drawing.Size(69, 17);
            this.radioButton2.TabIndex = 32;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "··”⁄ÊœÌ…";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(196, 52);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioButton1.Size = new System.Drawing.Size(61, 17);
            this.radioButton1.TabIndex = 31;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "··≈„«—« ";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(126, 107);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(236, 21);
            this.button2.TabIndex = 30;
            this.button2.Text = "ÕÃ“ «”„ «·„—”·";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(157, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 26;
            this.textBox1.Text = "doo.ae";
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(279, 27);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 25;
            this.label3.Text = "≈”„ «·„—”·:";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.lblNumbers);
            this.tabPage1.Controls.Add(this.txtNumbers);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtMessage);
            this.tabPage1.Controls.Add(this.txtSender);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(481, 432);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "≈—”«· «·—”«∆·";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Location = new System.Drawing.Point(139, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(210, 20);
            this.label7.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(219, 403);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "«—”«·";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_3);
            // 
            // lblNumbers
            // 
            this.lblNumbers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNumbers.Location = new System.Drawing.Point(339, 248);
            this.lblNumbers.Name = "lblNumbers";
            this.lblNumbers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblNumbers.Size = new System.Drawing.Size(100, 23);
            this.lblNumbers.TabIndex = 13;
            this.lblNumbers.Text = "«·√—ﬁ«„:";
            // 
            // txtNumbers
            // 
            this.txtNumbers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumbers.Location = new System.Drawing.Point(19, 247);
            this.txtNumbers.Multiline = true;
            this.txtNumbers.Name = "txtNumbers";
            this.txtNumbers.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNumbers.Size = new System.Drawing.Size(300, 150);
            this.txtNumbers.TabIndex = 12;
            this.txtNumbers.Text = "97155555555555,971555555554";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(339, 88);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 11;
            this.label2.Text = "«·—”«·…:";
            // 
            // txtMessage
            // 
            this.txtMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMessage.Location = new System.Drawing.Point(19, 81);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMessage.Size = new System.Drawing.Size(300, 150);
            this.txtMessage.TabIndex = 10;
            this.txtMessage.Text = "Thank you for using doo.ae";
            // 
            // txtSender
            // 
            this.txtSender.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSender.Location = new System.Drawing.Point(219, 55);
            this.txtSender.Name = "txtSender";
            this.txtSender.Size = new System.Drawing.Size(100, 20);
            this.txtSender.TabIndex = 9;
            this.txtSender.Text = "doo.ae";
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(339, 55);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "≈”„ «·„—”·:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(25, 12);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeftLayout = true;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(489, 458);
            this.tabControl1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(535, 482);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		private bool isArabic(string val)
		{
            string str = "œÃÕŒÂ⁄€›ﬁÀ’÷ÿﬂ„‰ «·»Ì”‘Ÿ“Ê…Ï·«—ƒ¡∆≈·≈√·√¬·¬";

			for (int i=0; i<val.Length; i++)
			{
				if (str.IndexOf(val.Substring(i, 1)) != -1)
				{
					return true;
				}
			}			
			
			return false;
		}

		public string SendMessage(string username, string password, string msg, string sender, string numbers)
		{
			int temp = '0';

            HttpWebRequest req = (HttpWebRequest)
            WebRequest.Create("http://doo.ae/api/msgSend.php");
            req.Method = "POST";
            req.ContentType = "application/x-www-form-urlencoded";
            string postData = "mobile=" + username + "&password=" + password + "&numbers=" + numbers + "&sender=" + sender + "&msg=" + msg + "&applicationType=24";
            req.ContentLength = postData.Length;

            StreamWriter stOut = new
            StreamWriter(req.GetRequestStream(),
            System.Text.Encoding.ASCII);
            stOut.Write(postData);
            stOut.Close();
            // Do the request to get the response
            string strResponse;
            StreamReader stIn = new StreamReader(req.GetResponse().GetResponseStream());
            strResponse = stIn.ReadToEnd();
            stIn.Close();
            return  strResponse;
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
		}

		private void sendEnglishMessage()
		{
            string t = SendMessage(UserName, Password, ConvertToUnicode(txtMessage.Text), txtSender.Text, txtNumbers.Text);

			ShowResult(t);	
		}

		private void sendArabicMessage()
		{
			string t = SendMessage(UserName ,Password ,ConvertToUnicode(txtMessage.Text),txtSender.Text,txtNumbers.Text);

			ShowResult(t);	
		}
		
		private void ShowResult(string res)
		{
			switch (res)
			{
				case "1": MessageBox.Show(" „ «—”«· «·—”«·…"); break;
				case "2": MessageBox.Show("—’Ìœﬂ ’›—"); break;
				case "3": MessageBox.Show("«·—’Ìœ «·„ Ê›— ·« Ìﬂ›Ì"); break;
                case "4": MessageBox.Show("«·ÃÊ«· €Ì— „ÊÃÊœ"); break;
                case "5": MessageBox.Show("ﬂ·„… «·”— Œ«ÿ∆…"); break;
                case "6": MessageBox.Show("’›Õ… «·≈‰ —‰  €Ì— ›⁄«·…° Õ«Ê· «·≈—”«· „‰ ÃœÌœ"); break;
                case "13": MessageBox.Show("«”„ «·„—”· €Ì— „ﬁ»Ê·"); break;
                case "15": MessageBox.Show(" «·√—ﬁ«„ «·„—”· ·Â« €Ì— ’ÕÌÕÂ √Ê ›«—€Â.") ; break;
                case "16": MessageBox.Show(" ≈”„ «·„—”· ›«—€.") ; break;
                case "17": MessageBox.Show(" ‰’ «·—”«·Â €Ì— „‘›— »«·‘ﬂ· «·’ÕÌÕ √Ê ‰’ «·—”«·… ›«—€."); break;

				default: MessageBox.Show(res.ToString()); break;
			}
		}

        private void GetBalance(string username, string password)
        {
            int temp = '0';

            HttpWebRequest req = (HttpWebRequest)
            WebRequest.Create("http://doo.ae/api/balance.php");
            req.Method = "POST";
            req.ContentType = "application/x-www-form-urlencoded";
            string postData = "mobile=" + username + "&password=" + password;
            req.ContentLength = postData.Length;

            StreamWriter stOut = new
            StreamWriter(req.GetRequestStream(),
            System.Text.Encoding.ASCII);
            stOut.Write(postData);
            stOut.Close();
            // Do the request to get the response
            string strResponse;
            StreamReader stIn = new StreamReader(req.GetResponse().GetResponseStream());
            strResponse = stIn.ReadToEnd();
            stIn.Close();
            switch (strResponse)
            {
                case "1": MessageBox.Show("«·ÃÊ«· €Ì— „ÊÃÊœ"); break;
                case "2": MessageBox.Show("ﬂ·„… «·”— Œ«ÿ∆…"); break;
            }
            label7.Text = strResponse;

        }
		private string ConvertToUnicode(string val)
		{			
			string msg2 = string.Empty;

			for (int i=0; i<val.Length; i++)
			{
				msg2 += convertToUnicode(System.Convert.ToChar(val.Substring(i,1)));
			}

			return msg2;
		}

		private string convertToUnicode(char ch)
		{
			System.Text.UnicodeEncoding class1 = new System.Text.UnicodeEncoding();
			byte[] msg = class1.GetBytes(System.Convert.ToString(ch));

			return fourDigits(msg[1] + msg[0].ToString("X"));			
		}

		private string fourDigits(string val)
		{
			string result = string.Empty;

			switch (val.Length)
			{
				case 1: result = "000" + val; break;
				case 2: result = "00" + val; break;
				case 3: result = "0"+ val; break;
				case 4: result = val; break;				
			}

			return result;
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
            GetBalance(UserName, Password);

		}


        private void button1_Click_3(object sender, EventArgs e)
        {
            if (isArabic(txtMessage.Text))
            {
                sendArabicMessage();
            }
            else
            {
                sendEnglishMessage();
            }

        }

     
        

        private void button2_Click(object sender, EventArgs e)
        {
            
            string postData = "";
            HttpWebRequest req = (HttpWebRequest)
            WebRequest.Create("http://doo.ae/api/addSender.php");
            req.Method = "POST";
            req.ContentType = "application/x-www-form-urlencoded";

            if (radioButton1.Checked == true)
            {
                postData = "mobile=" + UserName + "&password=" + Password + "&sender=" + textBox1.Text + "&type=1";
            }
            else
            {
                postData = "mobile=" + UserName + "&password=" + Password + "&sender=" + textBox1.Text + "&type=2";
            }

            req.ContentLength = postData.Length;

            StreamWriter stOut = new
            StreamWriter(req.GetRequestStream(),
            System.Text.Encoding.ASCII);
            stOut.Write(postData);
            stOut.Close();
            // Do the request to get the response
            string strResponse;
            StreamReader stIn = new StreamReader(req.GetResponse().GetResponseStream());
            strResponse = stIn.ReadToEnd();
            stIn.Close();
            switch (strResponse)
            {
                case "1": MessageBox.Show("«”„ «·„” Œœ„ €Ì— „⁄—›"); break;
                case "2": MessageBox.Show("ﬂ·„… «·”— Œÿ√"); break;
                case "3": MessageBox.Show(": ≈”„ «·„—”· €Ì— ’ÕÌÕ"); break;
                case "4": MessageBox.Show("≈”„ «·„—”· „ÊÃÊœ „‰ ﬁ»·"); break;
                case "5": MessageBox.Show("—’Ìœﬂ €Ì— ﬂ«›Ì ·«—”«· ﬂÊœ «· ›⁄Ì·"); break;
                case "6": MessageBox.Show("  „ ÿ·» «”„ «·„—”· »‰Ã«Õ Ã«—Ì  ›⁄Ì·Â „‰ „Êﬁ⁄ œÊ"); break;
                case "7": MessageBox.Show(" ·„   „ ⁄„·Ì… ÿ·» «”„ «·„—”· »‰Ã«Õ"); break;
                default: MessageBox.Show("" + strResponse); break;

            }
            

        }

      
 

       

      

        

	}
}
