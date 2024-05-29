using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO.Ports;

namespace ProgramPoartaIP
{
    public partial class Form1 : Form
    {
        private string time;
        private Timer timer;
        private bool gateClosed = true;

        private string personName = "Necula Vlad";
        private string carNumber = "AR10VLN";
        private string direction = "Exit";

        private SQLiteConnection sqlite_conn;
        private SerialPort serialPort;

        public Form1()
        {
            InitializeComponent();

            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();

            InitializeDatabase();

            // Initialize SerialPort for Arduino communication
            serialPort = new SerialPort();
            serialPort.PortName = "COM7"; // Change COM port accordingly
            serialPort.BaudRate = 9600; // Match with Arduino's baud rate
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
            pictureBoxGate.Image = Properties.Resources.barrierDown;
            AlignImageToBottom();
            HidePersonDetails();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            time = DateTime.Now.ToString("HH:mm:ss");
            label1.Text = "Ora curentă: " + time;
        }

        private void buttonToggleGate_Click(object sender, EventArgs e)
        {
            ToggleGate();
        }

        private void AlignImageToBottom()
        {
            int pictureBoxHeight = pictureBoxGate.Height;
            int imageHeight = pictureBoxGate.Image.Height;

            int newY = pictureBoxHeight - imageHeight;

            pictureBoxGate.Location = new Point(pictureBoxGate.Location.X, newY);
        }

        private void PopulatePersonDetails()
        {
            labelPersonName.Text = "Name: " + personName;
            labelCarNumber.Text = "Car Number: " + carNumber;
            labelDirection.Text = "Direction: " + direction;

            labelPersonName.Visible = true;
            labelCarNumber.Visible = true;
            labelDirection.Visible = true;
        }

        private void HidePersonDetails()
        {
            labelPersonName.Visible = false;
            labelCarNumber.Visible = false;
            labelDirection.Visible = false;
        }

        private void ToggleGate()
        {
            gateClosed = !gateClosed;

            if (gateClosed)
            {
                CloseGate();
            }
            else
            {
                OpenGate();
            }

            AlignImageToBottom();
        }

        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            // This method will be called when data is received from Arduino
            string data = serialPort.ReadLine().Trim(); // Assuming Arduino sends a line of text

            // Update gate state based on received data
            if (data == "1")
            {
                this.Invoke((MethodInvoker)delegate
                {
                    OpenGate();
                });
            }
            else if (data == "2")
            {
                this.Invoke((MethodInvoker)delegate
                {
                    CloseGate();
                });
            }
        }

        private void OpenGate()
        {
            pictureBoxGate.Image = Properties.Resources.barrierUp;
            labelAccessStatus.Text = "Access granted! Gate is open.";
            labelAccessStatus.ForeColor = Color.Green;
            AlignImageToBottom();
        }

        private void CloseGate()
        {
            pictureBoxGate.Image = Properties.Resources.barrierDown;
            labelAccessStatus.Text = "Access denied! Gate is closed.";
            labelAccessStatus.ForeColor = Color.Red;
            AlignImageToBottom();
        }


        private void InitializeDatabase()
        {
            sqlite_conn = new SQLiteConnection("Data Source=access_log.db; Version = 3; New = True; Compress = True;");
            sqlite_conn.Open();

            string createTableQuery = @"CREATE TABLE IF NOT EXISTS AccessLog (
                                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                                        PersonName TEXT,
                                        CarNumber TEXT,
                                        Direction TEXT,
                                        AccessStatus TEXT,
                                        Timestamp DATETIME DEFAULT CURRENT_TIMESTAMP
                                    );";

            SQLiteCommand createTableCmd = new SQLiteCommand(createTableQuery, sqlite_conn);
            createTableCmd.ExecuteNonQuery();
        }

        private void LogAccess(string personName, string carNumber, string direction, string status)
        {
            string logQuery = "INSERT INTO AccessLog (PersonName, CarNumber, Direction, AccessStatus) VALUES (@PersonName, @CarNumber, @Direction, @Status)";
            SQLiteCommand logCmd = new SQLiteCommand(logQuery, sqlite_conn);
            logCmd.Parameters.AddWithValue("@PersonName", personName);
            logCmd.Parameters.AddWithValue("@CarNumber", carNumber);
            logCmd.Parameters.AddWithValue("@Direction", direction);
            logCmd.Parameters.AddWithValue("@Status", status);
            logCmd.ExecuteNonQuery();

            // Cod pentru sincronizarea cu serviciul cloud
            SyncToCloud(personName, carNumber, direction, status);
        }

        private void SyncToCloud(string personName, string carNumber, string direction, string status)
        {
            // Cod pentru sincronizarea datelor cu serviciul cloud
        }

        private void buttonValidateBluetooth_Click(object sender, EventArgs e)
        {
            string employeeName = GetEmployeeNameFromBluetooth();
            string employeeID = GetEmployeeIDFromBluetooth();

            if (!string.IsNullOrEmpty(employeeName) && !string.IsNullOrEmpty(employeeID))
            {
                labelBluetoothInfo.Text = $"Employee data:\nName: {employeeName}\nEmployee ID: {employeeID}";

                bool hasAccess = CheckAccessUsingBluetoothData(employeeName, employeeID);

                if (hasAccess)
                {
                    OpenGate();
                }
                else
                {
                    CloseGate();
                }
            }
            else
            {
                labelBluetoothInfo.Text = "Failed to retrieve employee data from Bluetooth.";
                CloseGate();
            }
        }

        private string GetEmployeeNameFromBluetooth()
        {
            // cod obtinere nume prin bt (lipsa)
            return "John Doe";
        }

        private string GetEmployeeIDFromBluetooth()
        {
            // cod obtinere ID prin bt (lipsa)
            return "EMP12345";
        }

        private bool CheckAccessUsingBluetoothData(string employeeName, string employeeID)
        {
            // cod pentru verificarea accesului cu datele obținute prin bt
            return true;
        }
    }
}
