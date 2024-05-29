using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO.Ports;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;

namespace ProgramPoartaIP
{
    public partial class Form1 : Form
    {
        private string time;
        private Timer timer;
        private bool gateClosed = true;

        private SerialPort serialPort;

        public Form1()
        {
            InitializeComponent();

            labelAccessStatus.Location = new Point(20, 50);

            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();

            serialPort = new SerialPort("COM8", 9600); 
            serialPort.DataReceived += SerialPort_DataReceived;

            try
            {
                serialPort.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening serial port: " + ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            pictureBoxGateCar.Image = Properties.Resources.barrierDown;
            AlignImageToBottom();

            pictureBoxGatePerson.Image = Properties.Resources.barrierDown;
            AlignImageToBottom2();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            time = DateTime.Now.ToString("HH:mm:ss");
            label1.Text = "Ora curentă: " + time;
        }

        private void buttonToggleGateCar_Click(object sender, EventArgs e)
        {
            gateClosed = !gateClosed;

            if (gateClosed)
            {
                pictureBoxGateCar.Image = Properties.Resources.barrierUp;
                AlignImageToBottom();

            }
            else
            {
                pictureBoxGateCar.Image = Properties.Resources.barrierDown;
                AlignImageToBottom();

            }

        }

        private void buttonToggleGatePerson_Click(object sender, EventArgs e)
        {
            gateClosed = !gateClosed;

            if (gateClosed)
            {
                pictureBoxGatePerson.Image = Properties.Resources.barrierUp;
                AlignImageToBottom2();

            }

            else
            {
                pictureBoxGatePerson.Image = Properties.Resources.barrierDown;
                AlignImageToBottom2();

            }
        }

        private void SendMessageToArduino(string message)
        {
            if (serialPort.IsOpen)
            {
                try
                {
                    serialPort.WriteLine(message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error sending data to Arduino: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Serial port is not open.");
            }
        }

        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            int number;
            string data = serialPort.ReadLine().Trim();
            if (int.TryParse(data, out number) && number >= 0 && number <= 1000 && number !=2)
            {
                string gooddata = data;
                this.Invoke((MethodInvoker)delegate
                {
                    //labelTest.Text = gooddata;
                    OpenGateCarDatabase(gooddata);
                });
            }
            else if (data == "Inchis")
            {
                this.Invoke((MethodInvoker)delegate
                {
                    CloseGateCarNice();
                    labelPersonName.Visible = false;
                    labelCarNumber.Visible = false;
                });
            }
        }

        private async void OpenGateCarDatabase(string specificUsername)
        {
            try
            {
                string connstring = "server=byrowjk8t7iswcuuyell-mysql.services.clever-cloud.com;" +
                                    "port=3306;" +
                                    "uid=ulthmvhrvmx0ykdw;" +
                                    "pwd=NdJoZz8ELnBDE7N343nK;" +
                                    "database=byrowjk8t7iswcuuyell";

                using (MySqlConnection con = new MySqlConnection(connstring))
                {
                    con.Open();

                    string sql = "SELECT Nume, NumarMasina, AccesAuto FROM Angajati WHERE ID_Angajat = @id";
                    using (MySqlCommand cmd = new MySqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@id", specificUsername);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                bool hasAccessAuto = reader.GetBoolean("AccesAuto");

                                if (hasAccessAuto)
                                {
                                    string personName = reader["Nume"].ToString();
                                    string carNumber = reader["NumarMasina"].ToString();

                                    labelPersonName.Text = "Name: " + personName;
                                    labelCarNumber.Text = "Car Number: " + carNumber;

                                    labelPersonName.Visible = true;
                                    labelCarNumber.Visible = true;

                                    serialPort.Write("2");

                                    OpenGateCar();


                                }
                                else
                                {
                                    string personName = reader["Nume"].ToString();

                                    labelPersonName.Text = "Name: " + personName;

                                    labelPersonName.Visible = true;

                                    OpenGatePerson();

                                    await Task.Delay(6000);

                                    CloseGatePersonNice();
                                    labelPersonName.Visible = false;
                                    labelCarNumber.Visible = false;

                                }
                            }
                            else
                            {
                                CloseGateCar();
                      
                            }
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
           
        }

        private void OpenGateCar()
        {
            labelAccessStatus.Visible = true;
            pictureBoxGateCar.Image = Properties.Resources.barrierUp;
            labelAccessStatus.Location = new Point(20, 50);
            labelAccessStatus.Text = "Car Access granted! Gate is open.";
            labelAccessStatus.ForeColor = Color.Green;
            AlignImageToBottom();

        }

        private void CloseGateCar()
        {
            pictureBoxGateCar.Image = Properties.Resources.barrierDown;
            labelAccessStatus.Location = new Point(20, 50);
            labelAccessStatus.Text = "Car Access denied! Gate is closed.";
            labelAccessStatus.ForeColor = Color.Red;
            AlignImageToBottom();
        }

        private void CloseGateCarNice()
        {
            labelAccessStatus.Visible = false;
            pictureBoxGateCar.Image = Properties.Resources.barrierDown;
            AlignImageToBottom();
        }

        private void OpenGatePerson()
        {
            labelAccessStatus.Visible = true;
            pictureBoxGatePerson.Image = Properties.Resources.barrierUp;
            labelAccessStatus.Location = new Point(450, 50);
            labelAccessStatus.Text = "Person Access granted! Gate is open.";
            labelAccessStatus.ForeColor = Color.Green;
            AlignImageToBottom2();

        }

        private void CloseGatePerson()
        {
            pictureBoxGatePerson.Image = Properties.Resources.barrierDown;
            labelAccessStatus.Location = new Point(450, 50);
            labelAccessStatus.Text = "Person Access denied! Gate is closed.";
            labelAccessStatus.ForeColor = Color.Red;
            AlignImageToBottom2();
        }

        private void CloseGatePersonNice()
        {
            labelAccessStatus.Visible = false; 
            pictureBoxGatePerson.Image = Properties.Resources.barrierDown;
            AlignImageToBottom2();
        }

        private void AlignImageToBottom()
        {
            if (pictureBoxGateCar.Image != null)
            {
                int pictureBoxHeight = pictureBoxGateCar.Height;
                int imageHeight = pictureBoxGateCar.Image.Height;

                int newY = pictureBoxHeight - imageHeight;

                pictureBoxGateCar.Padding = new Padding(0, newY, 0, 0);
                pictureBoxGateCar.Refresh();
            }
        }

        private void AlignImageToBottom2()
        {
            if (pictureBoxGatePerson.Image != null)
            {
                int pictureBoxHeight = pictureBoxGatePerson.Height;
                int imageHeight = pictureBoxGatePerson.Image.Height;

                int newY = pictureBoxHeight - imageHeight;

                pictureBoxGatePerson.Padding = new Padding(0, newY, 0, 0);
                pictureBoxGatePerson.Refresh();
            }

        }

    }
}
