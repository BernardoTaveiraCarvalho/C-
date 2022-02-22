using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _5412_Ficha1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool Validar = true;
        int min = 0;
        int seg = 0;
       
        string[] linha;
        int valortermina = 1;//minutos
        int valorsegundaparte = 30;//segundos
        private void button1_Click(object sender, EventArgs e)
        {
            if (min < valortermina  && seg>0 && seg != valorsegundaparte)
            {
                int a = Int32.Parse(label3.Text);
                if (min < valortermina)
                {
                    a++;
                    label3.Text = a.ToString();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (min < valortermina && seg > 0 && seg != valorsegundaparte)
            {
                int a = Int32.Parse(label3.Text);

                if (a != 0)
                {
                    a--;

                    label3.Text = a.ToString();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (min < valortermina && seg > 0 && seg != valorsegundaparte)
            {
                int a = Int32.Parse(label2.Text);
                a++;
                label2.Text = a.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            if (min < valortermina && seg > 0 && seg!=valorsegundaparte) {
                int a = Int32.Parse(label2.Text);
                if (a != 0)
            {
                a--;
                label2.Text = a.ToString();
            }
            }
        }
         
        private void timer1_Tick(object sender, EventArgs e)
        {
            
  
                if (min < 90)
                {
                    if (seg < 59)
                    {
                        seg++;
                    }
                    else if (seg == 59)
                    {
                        seg = 0; min++;
                    }
                }
                label1.Text = min + ":" + seg;
           if(min==0 && seg == valorsegundaparte)
            {
                label6.Text = "2ºparte";
                timer1.Enabled = false;
                button5.Visible = Enabled;
                button5.Text = "Começar 2ª parte";
            }
           if(min==valortermina && seg == 0)
            {
                timer1.Enabled = false;
                button5.Visible = true;
                button5.Text = "Gravar e recomeçar";
            }
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Validar == true)
            {
                comboboxloader();
            }
            selecionarimagem(label5, pictureBox1);
            selecionarimagem(label4, pictureBox2);
        }

        private void comboboxloader()
        {
            comboBox1.Items.Add(new KeyValuePair<string, string>("Porto", "0"));
            comboBox1.Items.Add(new KeyValuePair<string, string>("Benfica", "1"));
            comboBox1.Items.Add(new KeyValuePair<string, string>("Chaves", "2"));
            comboBox1.Items.Add(new KeyValuePair<string, string>("Belenenses", "3"));
            comboBox2.Items.Add(new KeyValuePair<string, string>("Porto", "0"));
            comboBox2.Items.Add(new KeyValuePair<string, string>("Benfica", "1"));
            comboBox2.Items.Add(new KeyValuePair<string, string>("Chaves", "2"));
            comboBox2.Items.Add(new KeyValuePair<string, string>("Belenenses", "3"));

            comboBox1.DisplayMember = "key";
            comboBox1.ValueMember = "value";
            comboBox2.DisplayMember = "key";
            comboBox2.ValueMember = "value";
        }

        private void selecionarimagem(Label a,PictureBox b)
        {
            switch (a.Text)
            {
                case "Benfica":
                    b.Image = Properties.Resources._500px_SL_Benfica_logo_svg;
                    break;
                case "Porto":
                    b.Image = Properties.Resources.F_C__Porto_logo;
                    break;
                case "Chaves":
                    b.Image = Properties.Resources.G_D_Chaves;
                    break;
                case "Belenenses":
                    b.Image = Properties.Resources.Os_Belenenses;
                    break;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            timer1.Enabled = true;
            button5.Visible = false;
            if (min == valortermina)
            {
                min = 0;
                seg = 0;
                try

                {
                    string[] txt;
                    Stream myStream;
                    SaveFileDialog saveFileDialog1 = new SaveFileDialog();

                    saveFileDialog1.Filter = "txt files (*.txt)|*.txt";
                    saveFileDialog1.FilterIndex = 2;
                    saveFileDialog1.RestoreDirectory = true;
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                       txt= saveFileDialog1.FileName.Split('.');
                        txt[1] = ".txt";

                            string texto = label4.Text + ";" + label3.Text + ";" + label5.Text + ";" + label2.Text;
                            File.WriteAllText(txt[0]+txt[1], texto);
                            label6.Text = "1ºparte";
                            label2.Text = "0";
                            label3.Text = "0";
                        
                    }
                    
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Não funcionou");
                }
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.InitialDirectory = "c:\\";
                    openFileDialog.Filter = "txt files (*.txt)|*.txt";
                    openFileDialog.FilterIndex = 2;
                    openFileDialog.RestoreDirectory = true;

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        //Get the path of specified file
                        string filePath = openFileDialog.FileName;

                        //Read the contents of the file into a stream
                        var fileStream = openFileDialog.OpenFile();

                        if (File.Exists(filePath) == true)
                        {
                            string texto = File.ReadAllText(filePath, Encoding.UTF8);
                            linha = texto.Split(";");
                            label4.Text = linha[0];
                            label3.Text = linha[1];
                            label5.Text = linha[2];
                            label2.Text = linha[3];
                            min = 0;
                            seg = 0;
                            label6.Text = "1ºparte";
                            label1.Text = "0:0";
                            button5.Text = "Começar 1ºparte";
                            Validar = false;
                            Form1_Load(sender, e);
                        }
                    }
                }
            }catch(Exception ex){
                MessageBox.Show("Não funcionou");
            }
            
            




        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {

            if (comboBox1.SelectedIndex >= 0 && comboBox2.SelectedIndex >= 0)
            {


                KeyValuePair<string, string> kvp = (KeyValuePair<string, string>)comboBox1.SelectedItem;
                KeyValuePair<string, string> kvp1 = (KeyValuePair<string, string>)comboBox2.SelectedItem;

                label4.Text = kvp.Key.ToString();
                label5.Text = kvp1.Key.ToString();
                Validar = false;
                Form1_Load(sender, e);

            }
        }
    }
}
