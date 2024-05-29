namespace ProgramPoartaIP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.sqLiteCommand1 = new System.Data.SQLite.SQLiteCommand();
            this.labelAccessStatus = new System.Windows.Forms.Label();
            this.labelBluetoothInfo = new System.Windows.Forms.Label();
            this.labelReceived = new System.Windows.Forms.Label();
            this.buttonToggleGatePerson = new System.Windows.Forms.Button();
            this.pictureBoxGateCar = new System.Windows.Forms.PictureBox();
            this.buttonToggleGateCar = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.labelCarNumber = new System.Windows.Forms.Label();
            this.labelPersonName = new System.Windows.Forms.Label();
            this.labelAcces = new System.Windows.Forms.Label();
            this.labelTest = new System.Windows.Forms.Label();
            this.pictureBoxGatePerson = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGateCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGatePerson)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(27, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Time";
            // 
            // sqLiteCommand1
            // 
            this.sqLiteCommand1.CommandText = null;
            // 
            // labelAccessStatus
            // 
            this.labelAccessStatus.AutoSize = true;
            this.labelAccessStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAccessStatus.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.labelAccessStatus.Location = new System.Drawing.Point(694, 303);
            this.labelAccessStatus.Name = "labelAccessStatus";
            this.labelAccessStatus.Size = new System.Drawing.Size(0, 32);
            this.labelAccessStatus.TabIndex = 8;
            // 
            // labelBluetoothInfo
            // 
            this.labelBluetoothInfo.AutoSize = true;
            this.labelBluetoothInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBluetoothInfo.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.labelBluetoothInfo.Location = new System.Drawing.Point(690, 475);
            this.labelBluetoothInfo.Name = "labelBluetoothInfo";
            this.labelBluetoothInfo.Size = new System.Drawing.Size(0, 29);
            this.labelBluetoothInfo.TabIndex = 9;
            // 
            // labelReceived
            // 
            this.labelReceived.AutoSize = true;
            this.labelReceived.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReceived.ForeColor = System.Drawing.Color.DarkOrange;
            this.labelReceived.Location = new System.Drawing.Point(690, 722);
            this.labelReceived.Name = "labelReceived";
            this.labelReceived.Size = new System.Drawing.Size(0, 26);
            this.labelReceived.TabIndex = 10;
            // 
            // buttonToggleGatePerson
            // 
            this.buttonToggleGatePerson.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonToggleGatePerson.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonToggleGatePerson.Image = ((System.Drawing.Image)(resources.GetObject("buttonToggleGatePerson.Image")));
            this.buttonToggleGatePerson.Location = new System.Drawing.Point(863, 622);
            this.buttonToggleGatePerson.Name = "buttonToggleGatePerson";
            this.buttonToggleGatePerson.Size = new System.Drawing.Size(138, 138);
            this.buttonToggleGatePerson.TabIndex = 3;
            this.buttonToggleGatePerson.UseVisualStyleBackColor = true;
            this.buttonToggleGatePerson.Click += new System.EventHandler(this.buttonToggleGatePerson_Click);
            // 
            // pictureBoxGateCar
            // 
            this.pictureBoxGateCar.Image = global::ProgramPoartaIP.Properties.Resources.barrierUp;
            this.pictureBoxGateCar.Location = new System.Drawing.Point(34, 129);
            this.pictureBoxGateCar.Name = "pictureBoxGateCar";
            this.pictureBoxGateCar.Size = new System.Drawing.Size(459, 409);
            this.pictureBoxGateCar.TabIndex = 3;
            this.pictureBoxGateCar.TabStop = false;
            // 
            // buttonToggleGateCar
            // 
            this.buttonToggleGateCar.AllowDrop = true;
            this.buttonToggleGateCar.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.buttonToggleGateCar.FlatAppearance.BorderSize = 3;
            this.buttonToggleGateCar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonToggleGateCar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonToggleGateCar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonToggleGateCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonToggleGateCar.ForeColor = System.Drawing.Color.Aqua;
            this.buttonToggleGateCar.Image = ((System.Drawing.Image)(resources.GetObject("buttonToggleGateCar.Image")));
            this.buttonToggleGateCar.Location = new System.Drawing.Point(34, 633);
            this.buttonToggleGateCar.Name = "buttonToggleGateCar";
            this.buttonToggleGateCar.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonToggleGateCar.Size = new System.Drawing.Size(138, 108);
            this.buttonToggleGateCar.TabIndex = 3;
            this.buttonToggleGateCar.UseVisualStyleBackColor = true;
            this.buttonToggleGateCar.Click += new System.EventHandler(this.buttonToggleGateCar_Click);
            // 
            // labelCarNumber
            // 
            this.labelCarNumber.AutoSize = true;
            this.labelCarNumber.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCarNumber.ForeColor = System.Drawing.SystemColors.Control;
            this.labelCarNumber.Location = new System.Drawing.Point(24, 135);
            this.labelCarNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCarNumber.Name = "labelCarNumber";
            this.labelCarNumber.Size = new System.Drawing.Size(140, 24);
            this.labelCarNumber.TabIndex = 14;
            this.labelCarNumber.Text = "Car number";
            this.labelCarNumber.Visible = false;
            // 
            // labelPersonName
            // 
            this.labelPersonName.AutoSize = true;
            this.labelPersonName.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPersonName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelPersonName.Location = new System.Drawing.Point(24, 95);
            this.labelPersonName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPersonName.Name = "labelPersonName";
            this.labelPersonName.Size = new System.Drawing.Size(62, 24);
            this.labelPersonName.TabIndex = 15;
            this.labelPersonName.Text = "Nume";
            this.labelPersonName.Visible = false;
            // 
            // labelAcces
            // 
            this.labelAcces.AutoSize = true;
            this.labelAcces.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAcces.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelAcces.Location = new System.Drawing.Point(24, 44);
            this.labelAcces.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAcces.Name = "labelAcces";
            this.labelAcces.Size = new System.Drawing.Size(75, 24);
            this.labelAcces.TabIndex = 17;
            this.labelAcces.Text = "Acces";
            this.labelAcces.Visible = false;
            // 
            // labelTest
            // 
            this.labelTest.AutoSize = true;
            this.labelTest.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelTest.Location = new System.Drawing.Point(1262, 46);
            this.labelTest.Name = "labelTest";
            this.labelTest.Size = new System.Drawing.Size(51, 20);
            this.labelTest.TabIndex = 18;
            this.labelTest.Text = "label2";
            this.labelTest.Visible = false;
            // 
            // pictureBoxGatePerson
            // 
            this.pictureBoxGatePerson.Image = global::ProgramPoartaIP.Properties.Resources.barrierDown;
            this.pictureBoxGatePerson.Location = new System.Drawing.Point(542, 129);
            this.pictureBoxGatePerson.Name = "pictureBoxGatePerson";
            this.pictureBoxGatePerson.Size = new System.Drawing.Size(459, 411);
            this.pictureBoxGatePerson.TabIndex = 11;
            this.pictureBoxGatePerson.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelAcces);
            this.groupBox1.Controls.Add(this.labelCarNumber);
            this.groupBox1.Controls.Add(this.labelPersonName);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox1.Location = new System.Drawing.Point(343, 582);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 189);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Employee Info";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1060, 837);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelTest);
            this.Controls.Add(this.pictureBoxGatePerson);
            this.Controls.Add(this.labelReceived);
            this.Controls.Add(this.labelBluetoothInfo);
            this.Controls.Add(this.labelAccessStatus);
            this.Controls.Add(this.buttonToggleGatePerson);
            this.Controls.Add(this.pictureBoxGateCar);
            this.Controls.Add(this.buttonToggleGateCar);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGateCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGatePerson)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonToggleGateCar;
        private System.Windows.Forms.PictureBox pictureBoxGateCar;
        private System.Windows.Forms.Button buttonToggleGatePerson;
        private System.Data.SQLite.SQLiteCommand sqLiteCommand1;
        private System.Windows.Forms.Label labelAccessStatus;
        private System.Windows.Forms.Label labelBluetoothInfo;
        private System.Windows.Forms.Label labelReceived;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label labelCarNumber;
        private System.Windows.Forms.Label labelPersonName;
        private System.Windows.Forms.Label labelAcces;
        private System.Windows.Forms.Label labelTest;
        private System.Windows.Forms.PictureBox pictureBoxGatePerson;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

