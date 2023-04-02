
namespace TapeMeasureFormula
{
    partial class frmMain
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
            this.grpBoxGender = new System.Windows.Forms.GroupBox();
            this.rdoFemale = new System.Windows.Forms.RadioButton();
            this.rdoMale = new System.Windows.Forms.RadioButton();
            this.grpBoxAge = new System.Windows.Forms.GroupBox();
            this.rdoOver30 = new System.Windows.Forms.RadioButton();
            this.rdo30andUnder = new System.Windows.Forms.RadioButton();
            this.grpBoxWeight = new System.Windows.Forms.GroupBox();
            this.lblWeight = new System.Windows.Forms.Label();
            this.txtBoxWeight = new System.Windows.Forms.TextBox();
            this.grpBoxMeasurements = new System.Windows.Forms.GroupBox();
            this.lblWristWrist = new System.Windows.Forms.Label();
            this.lblForearmCalf = new System.Windows.Forms.Label();
            this.lblHipsThigh = new System.Windows.Forms.Label();
            this.lblWaistHips = new System.Windows.Forms.Label();
            this.txtBoxWristWrist = new System.Windows.Forms.TextBox();
            this.txtBoxForearmCalf = new System.Windows.Forms.TextBox();
            this.txtBoxHipsThigh = new System.Windows.Forms.TextBox();
            this.txtBoxWaistHips = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpBoxResults = new System.Windows.Forms.GroupBox();
            this.lblResults = new System.Windows.Forms.Label();
            this.grpBoxGender.SuspendLayout();
            this.grpBoxAge.SuspendLayout();
            this.grpBoxWeight.SuspendLayout();
            this.grpBoxMeasurements.SuspendLayout();
            this.grpBoxResults.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBoxGender
            // 
            this.grpBoxGender.Controls.Add(this.rdoFemale);
            this.grpBoxGender.Controls.Add(this.rdoMale);
            this.grpBoxGender.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxGender.Location = new System.Drawing.Point(61, 62);
            this.grpBoxGender.Name = "grpBoxGender";
            this.grpBoxGender.Size = new System.Drawing.Size(340, 127);
            this.grpBoxGender.TabIndex = 0;
            this.grpBoxGender.TabStop = false;
            this.grpBoxGender.Text = "Gender";
            // 
            // rdoFemale
            // 
            this.rdoFemale.AutoSize = true;
            this.rdoFemale.Location = new System.Drawing.Point(176, 58);
            this.rdoFemale.Name = "rdoFemale";
            this.rdoFemale.Size = new System.Drawing.Size(110, 30);
            this.rdoFemale.TabIndex = 1;
            this.rdoFemale.TabStop = true;
            this.rdoFemale.Text = "Female";
            this.rdoFemale.UseVisualStyleBackColor = true;
            this.rdoFemale.CheckedChanged += new System.EventHandler(this.rdoFemale_CheckedChanged);
            // 
            // rdoMale
            // 
            this.rdoMale.AutoSize = true;
            this.rdoMale.Checked = true;
            this.rdoMale.Location = new System.Drawing.Point(18, 58);
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.Size = new System.Drawing.Size(84, 30);
            this.rdoMale.TabIndex = 0;
            this.rdoMale.TabStop = true;
            this.rdoMale.Text = "Male";
            this.rdoMale.UseVisualStyleBackColor = true;
            this.rdoMale.CheckedChanged += new System.EventHandler(this.rdoMale_CheckedChanged);
            // 
            // grpBoxAge
            // 
            this.grpBoxAge.Controls.Add(this.rdoOver30);
            this.grpBoxAge.Controls.Add(this.rdo30andUnder);
            this.grpBoxAge.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxAge.Location = new System.Drawing.Point(497, 62);
            this.grpBoxAge.Name = "grpBoxAge";
            this.grpBoxAge.Size = new System.Drawing.Size(366, 127);
            this.grpBoxAge.TabIndex = 1;
            this.grpBoxAge.TabStop = false;
            this.grpBoxAge.Text = "Age";
            // 
            // rdoOver30
            // 
            this.rdoOver30.AutoSize = true;
            this.rdoOver30.Location = new System.Drawing.Point(226, 58);
            this.rdoOver30.Name = "rdoOver30";
            this.rdoOver30.Size = new System.Drawing.Size(119, 30);
            this.rdoOver30.TabIndex = 1;
            this.rdoOver30.TabStop = true;
            this.rdoOver30.Text = "Over 30";
            this.rdoOver30.UseVisualStyleBackColor = true;
            // 
            // rdo30andUnder
            // 
            this.rdo30andUnder.AutoSize = true;
            this.rdo30andUnder.Checked = true;
            this.rdo30andUnder.Location = new System.Drawing.Point(18, 58);
            this.rdo30andUnder.Name = "rdo30andUnder";
            this.rdo30andUnder.Size = new System.Drawing.Size(173, 30);
            this.rdo30andUnder.TabIndex = 0;
            this.rdo30andUnder.TabStop = true;
            this.rdo30andUnder.Text = "30 and under";
            this.rdo30andUnder.UseVisualStyleBackColor = true;
            // 
            // grpBoxWeight
            // 
            this.grpBoxWeight.Controls.Add(this.lblWeight);
            this.grpBoxWeight.Controls.Add(this.txtBoxWeight);
            this.grpBoxWeight.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxWeight.Location = new System.Drawing.Point(954, 62);
            this.grpBoxWeight.Name = "grpBoxWeight";
            this.grpBoxWeight.Size = new System.Drawing.Size(261, 127);
            this.grpBoxWeight.TabIndex = 2;
            this.grpBoxWeight.TabStop = false;
            this.grpBoxWeight.Text = "Weight";
            // 
            // lblWeight
            // 
            this.lblWeight.Location = new System.Drawing.Point(149, 63);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(100, 23);
            this.lblWeight.TabIndex = 1;
            this.lblWeight.Text = "lbs";
            // 
            // txtBoxWeight
            // 
            this.txtBoxWeight.Location = new System.Drawing.Point(22, 58);
            this.txtBoxWeight.Name = "txtBoxWeight";
            this.txtBoxWeight.Size = new System.Drawing.Size(100, 32);
            this.txtBoxWeight.TabIndex = 0;
            // 
            // grpBoxMeasurements
            // 
            this.grpBoxMeasurements.Controls.Add(this.lblWristWrist);
            this.grpBoxMeasurements.Controls.Add(this.lblForearmCalf);
            this.grpBoxMeasurements.Controls.Add(this.lblHipsThigh);
            this.grpBoxMeasurements.Controls.Add(this.lblWaistHips);
            this.grpBoxMeasurements.Controls.Add(this.txtBoxWristWrist);
            this.grpBoxMeasurements.Controls.Add(this.txtBoxForearmCalf);
            this.grpBoxMeasurements.Controls.Add(this.txtBoxHipsThigh);
            this.grpBoxMeasurements.Controls.Add(this.txtBoxWaistHips);
            this.grpBoxMeasurements.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxMeasurements.Location = new System.Drawing.Point(61, 210);
            this.grpBoxMeasurements.Name = "grpBoxMeasurements";
            this.grpBoxMeasurements.Size = new System.Drawing.Size(1154, 313);
            this.grpBoxMeasurements.TabIndex = 3;
            this.grpBoxMeasurements.TabStop = false;
            this.grpBoxMeasurements.Text = "Measurements in inches";
            // 
            // lblWristWrist
            // 
            this.lblWristWrist.Location = new System.Drawing.Point(222, 244);
            this.lblWristWrist.Name = "lblWristWrist";
            this.lblWristWrist.Size = new System.Drawing.Size(920, 52);
            this.lblWristWrist.TabIndex = 7;
            // 
            // lblForearmCalf
            // 
            this.lblForearmCalf.Location = new System.Drawing.Point(219, 183);
            this.lblForearmCalf.Name = "lblForearmCalf";
            this.lblForearmCalf.Size = new System.Drawing.Size(923, 49);
            this.lblForearmCalf.TabIndex = 6;
            // 
            // lblHipsThigh
            // 
            this.lblHipsThigh.Location = new System.Drawing.Point(218, 112);
            this.lblHipsThigh.Name = "lblHipsThigh";
            this.lblHipsThigh.Size = new System.Drawing.Size(924, 48);
            this.lblHipsThigh.TabIndex = 5;
            // 
            // lblWaistHips
            // 
            this.lblWaistHips.Location = new System.Drawing.Point(218, 46);
            this.lblWaistHips.Name = "lblWaistHips";
            this.lblWaistHips.Size = new System.Drawing.Size(914, 37);
            this.lblWaistHips.TabIndex = 4;
            this.lblWaistHips.Click += new System.EventHandler(this.lblWaistHips_Click);
            // 
            // txtBoxWristWrist
            // 
            this.txtBoxWristWrist.Location = new System.Drawing.Point(28, 256);
            this.txtBoxWristWrist.Name = "txtBoxWristWrist";
            this.txtBoxWristWrist.Size = new System.Drawing.Size(100, 32);
            this.txtBoxWristWrist.TabIndex = 3;
            // 
            // txtBoxForearmCalf
            // 
            this.txtBoxForearmCalf.Location = new System.Drawing.Point(28, 190);
            this.txtBoxForearmCalf.Name = "txtBoxForearmCalf";
            this.txtBoxForearmCalf.Size = new System.Drawing.Size(100, 32);
            this.txtBoxForearmCalf.TabIndex = 2;
            // 
            // txtBoxHipsThigh
            // 
            this.txtBoxHipsThigh.Location = new System.Drawing.Point(28, 120);
            this.txtBoxHipsThigh.Name = "txtBoxHipsThigh";
            this.txtBoxHipsThigh.Size = new System.Drawing.Size(100, 32);
            this.txtBoxHipsThigh.TabIndex = 1;
            // 
            // txtBoxWaistHips
            // 
            this.txtBoxWaistHips.Location = new System.Drawing.Point(28, 54);
            this.txtBoxWaistHips.Name = "txtBoxWaistHips";
            this.txtBoxWaistHips.Size = new System.Drawing.Size(100, 32);
            this.txtBoxWaistHips.TabIndex = 0;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(61, 551);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(128, 63);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(61, 632);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(128, 60);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(61, 711);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(128, 62);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // grpBoxResults
            // 
            this.grpBoxResults.Controls.Add(this.lblResults);
            this.grpBoxResults.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxResults.Location = new System.Drawing.Point(237, 551);
            this.grpBoxResults.Name = "grpBoxResults";
            this.grpBoxResults.Size = new System.Drawing.Size(990, 189);
            this.grpBoxResults.TabIndex = 7;
            this.grpBoxResults.TabStop = false;
            this.grpBoxResults.Text = "Results";
            // 
            // lblResults
            // 
            this.lblResults.Font = new System.Drawing.Font("MS Reference Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResults.Location = new System.Drawing.Point(30, 60);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(936, 90);
            this.lblResults.TabIndex = 0;
            this.lblResults.Click += new System.EventHandler(this.lblResults_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1270, 798);
            this.Controls.Add(this.grpBoxResults);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.grpBoxMeasurements);
            this.Controls.Add(this.grpBoxWeight);
            this.Controls.Add(this.grpBoxAge);
            this.Controls.Add(this.grpBoxGender);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmMain";
            this.Text = "Covert Bailey\'s Tape-Measure Fat Formula";
            this.grpBoxGender.ResumeLayout(false);
            this.grpBoxGender.PerformLayout();
            this.grpBoxAge.ResumeLayout(false);
            this.grpBoxAge.PerformLayout();
            this.grpBoxWeight.ResumeLayout(false);
            this.grpBoxWeight.PerformLayout();
            this.grpBoxMeasurements.ResumeLayout(false);
            this.grpBoxMeasurements.PerformLayout();
            this.grpBoxResults.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxGender;
        private System.Windows.Forms.RadioButton rdoFemale;
        private System.Windows.Forms.RadioButton rdoMale;
        private System.Windows.Forms.GroupBox grpBoxAge;
        private System.Windows.Forms.RadioButton rdoOver30;
        private System.Windows.Forms.RadioButton rdo30andUnder;
        private System.Windows.Forms.GroupBox grpBoxWeight;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.TextBox txtBoxWeight;
        private System.Windows.Forms.GroupBox grpBoxMeasurements;
        private System.Windows.Forms.Label lblWristWrist;
        private System.Windows.Forms.Label lblForearmCalf;
        private System.Windows.Forms.Label lblHipsThigh;
        private System.Windows.Forms.Label lblWaistHips;
        private System.Windows.Forms.TextBox txtBoxWristWrist;
        private System.Windows.Forms.TextBox txtBoxForearmCalf;
        private System.Windows.Forms.TextBox txtBoxHipsThigh;
        private System.Windows.Forms.TextBox txtBoxWaistHips;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox grpBoxResults;
        private System.Windows.Forms.Label lblResults;
    }
}

