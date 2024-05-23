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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonToggleGate = new System.Windows.Forms.Button();
            this.pictureBoxGate = new System.Windows.Forms.PictureBox();
            this.labelPersonName = new System.Windows.Forms.Label();
            this.labelCarNumber = new System.Windows.Forms.Label();
            this.labelDirection = new System.Windows.Forms.Label();
            this.buttonValidateBluetooth = new System.Windows.Forms.Button();
            this.sqLiteCommand1 = new System.Data.SQLite.SQLiteCommand();
            this.labelAccessStatus = new System.Windows.Forms.Label();
            this.labelBluetoothInfo = new System.Windows.Forms.Label();
            this.labelReceived = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGate)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("OCR A Extended", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Time";
            // 
            // buttonToggleGate
            // 
            this.buttonToggleGate.Location = new System.Drawing.Point(655, 168);
            this.buttonToggleGate.Name = "buttonToggleGate";
            this.buttonToggleGate.Size = new System.Drawing.Size(111, 57);
            this.buttonToggleGate.TabIndex = 2;
            this.buttonToggleGate.Text = "Bariera";
            this.buttonToggleGate.UseVisualStyleBackColor = true;
            this.buttonToggleGate.Click += new System.EventHandler(this.buttonToggleGate_Click);
            // 
            // pictureBoxGate
            // 
            this.pictureBoxGate.Location = new System.Drawing.Point(19, 239);
            this.pictureBoxGate.Name = "pictureBoxGate";
            this.pictureBoxGate.Size = new System.Drawing.Size(618, 511);
            this.pictureBoxGate.TabIndex = 3;
            this.pictureBoxGate.TabStop = false;
            // 
            // labelPersonName
            // 
            this.labelPersonName.AutoSize = true;
            this.labelPersonName.Location = new System.Drawing.Point(804, 168);
            this.labelPersonName.Name = "labelPersonName";
            this.labelPersonName.Size = new System.Drawing.Size(51, 20);
            this.labelPersonName.TabIndex = 4;
            this.labelPersonName.Text = "label2";
            // 
            // labelCarNumber
            // 
            this.labelCarNumber.AutoSize = true;
            this.labelCarNumber.Location = new System.Drawing.Point(804, 205);
            this.labelCarNumber.Name = "labelCarNumber";
            this.labelCarNumber.Size = new System.Drawing.Size(51, 20);
            this.labelCarNumber.TabIndex = 5;
            this.labelCarNumber.Text = "label3";
            // 
            // labelDirection
            // 
            this.labelDirection.AutoSize = true;
            this.labelDirection.Location = new System.Drawing.Point(804, 239);
            this.labelDirection.Name = "labelDirection";
            this.labelDirection.Size = new System.Drawing.Size(51, 20);
            this.labelDirection.TabIndex = 6;
            this.labelDirection.Text = "label4";
            // 
            // buttonValidateBluetooth
            // 
            this.buttonValidateBluetooth.Location = new System.Drawing.Point(655, 332);
            this.buttonValidateBluetooth.Name = "buttonValidateBluetooth";
            this.buttonValidateBluetooth.Size = new System.Drawing.Size(181, 35);
            this.buttonValidateBluetooth.TabIndex = 7;
            this.buttonValidateBluetooth.Text = "Bluetooth simulare";
            this.buttonValidateBluetooth.UseVisualStyleBackColor = true;
            this.buttonValidateBluetooth.Click += new System.EventHandler(this.buttonValidateBluetooth_Click);
            // 
            // sqLiteCommand1
            // 
            this.sqLiteCommand1.CommandText = null;
            // 
            // labelAccessStatus
            // 
            this.labelAccessStatus.AutoSize = true;
            this.labelAccessStatus.Location = new System.Drawing.Point(922, 332);
            this.labelAccessStatus.Name = "labelAccessStatus";
            this.labelAccessStatus.Size = new System.Drawing.Size(51, 20);
            this.labelAccessStatus.TabIndex = 8;
            this.labelAccessStatus.Text = "label2";
            // 
            // labelBluetoothInfo
            // 
            this.labelBluetoothInfo.AutoSize = true;
            this.labelBluetoothInfo.Location = new System.Drawing.Point(651, 384);
            this.labelBluetoothInfo.Name = "labelBluetoothInfo";
            this.labelBluetoothInfo.Size = new System.Drawing.Size(51, 20);
            this.labelBluetoothInfo.TabIndex = 9;
            this.labelBluetoothInfo.Text = "label3";
            // 
            // labelReceived
            // 
            this.labelReceived.AutoSize = true;
            this.labelReceived.Location = new System.Drawing.Point(825, 521);
            this.labelReceived.Name = "labelReceived";
            this.labelReceived.Size = new System.Drawing.Size(143, 20);
            this.labelReceived.TabIndex = 10;
            this.labelReceived.Text = "labelReceivedData";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 782);
            this.Controls.Add(this.labelReceived);
            this.Controls.Add(this.labelBluetoothInfo);
            this.Controls.Add(this.labelAccessStatus);
            this.Controls.Add(this.buttonValidateBluetooth);
            this.Controls.Add(this.labelDirection);
            this.Controls.Add(this.labelCarNumber);
            this.Controls.Add(this.labelPersonName);
            this.Controls.Add(this.pictureBoxGate);
            this.Controls.Add(this.buttonToggleGate);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonToggleGate;
        private System.Windows.Forms.PictureBox pictureBoxGate;
        private System.Windows.Forms.Label labelPersonName;
        private System.Windows.Forms.Label labelCarNumber;
        private System.Windows.Forms.Label labelDirection;
        private System.Windows.Forms.Button buttonValidateBluetooth;
        private System.Data.SQLite.SQLiteCommand sqLiteCommand1;
        private System.Windows.Forms.Label labelAccessStatus;
        private System.Windows.Forms.Label labelBluetoothInfo;
        private System.Windows.Forms.Label labelReceived;
    }
}

