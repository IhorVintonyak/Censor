namespace Censor
{
    partial class Censor
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Censor));
            textInput = new TextBox();
            btnControl = new Button();
            lblResult = new Label();
            textOutput = new TextBox();
            lblInsert = new Label();
            cbObscene = new CheckBox();
            cbViolent = new CheckBox();
            lblTests = new Label();
            SuspendLayout();
            // 
            // textInput
            // 
            textInput.BackColor = Color.LightBlue;
            textInput.Location = new Point(21, 52);
            textInput.Multiline = true;
            textInput.Name = "textInput";
            textInput.Size = new Size(339, 238);
            textInput.TabIndex = 1;
            // 
            // btnControl
            // 
            btnControl.BackColor = Color.LightBlue;
            btnControl.ForeColor = Color.RoyalBlue;
            btnControl.Location = new Point(116, 388);
            btnControl.Name = "btnControl";
            btnControl.Size = new Size(131, 27);
            btnControl.TabIndex = 2;
            btnControl.Text = "CONTROL TEXT";
            btnControl.UseVisualStyleBackColor = false;
            btnControl.Click += btnControl_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.ForeColor = Color.LightBlue;
            lblResult.Location = new Point(543, 34);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(86, 15);
            lblResult.TabIndex = 3;
            lblResult.Text = "Result Window";
            // 
            // textOutput
            // 
            textOutput.BackColor = Color.LightBlue;
            textOutput.Location = new Point(407, 52);
            textOutput.Multiline = true;
            textOutput.Name = "textOutput";
            textOutput.ReadOnly = true;
            textOutput.Size = new Size(372, 363);
            textOutput.TabIndex = 4;
            // 
            // lblInsert
            // 
            lblInsert.AutoSize = true;
            lblInsert.ForeColor = Color.LightBlue;
            lblInsert.Location = new Point(155, 34);
            lblInsert.Name = "lblInsert";
            lblInsert.Size = new Size(60, 15);
            lblInsert.TabIndex = 5;
            lblInsert.Text = "Insert Text";
            // 
            // cbObscene
            // 
            cbObscene.AutoSize = true;
            cbObscene.ForeColor = Color.LightBlue;
            cbObscene.Location = new Point(130, 329);
            cbObscene.Name = "cbObscene";
            cbObscene.Size = new Size(107, 19);
            cbObscene.TabIndex = 6;
            cbObscene.Text = "Obscene words";
            cbObscene.UseVisualStyleBackColor = true;
            // 
            // cbViolent
            // 
            cbViolent.AutoSize = true;
            cbViolent.ForeColor = Color.LightBlue;
            cbViolent.Location = new Point(130, 354);
            cbViolent.Name = "cbViolent";
            cbViolent.Size = new Size(98, 19);
            cbViolent.TabIndex = 7;
            cbViolent.Text = "Violent words";
            cbViolent.UseVisualStyleBackColor = true;
            // 
            // lblTests
            // 
            lblTests.AutoSize = true;
            lblTests.ForeColor = Color.LightBlue;
            lblTests.Location = new Point(168, 310);
            lblTests.Name = "lblTests";
            lblTests.Size = new Size(32, 15);
            lblTests.TabIndex = 8;
            lblTests.Text = "Tests";
            // 
            // Censor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTests);
            Controls.Add(cbViolent);
            Controls.Add(cbObscene);
            Controls.Add(lblInsert);
            Controls.Add(textOutput);
            Controls.Add(lblResult);
            Controls.Add(btnControl);
            Controls.Add(textInput);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Censor";
            Text = "Censor";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInsert;
        private TextBox textInput;
        private Button btnControl;
        private Label lblResult;
        private TextBox textOutput;
        private CheckBox cbObscene;
        private CheckBox cbViolent;
        private Label lblTests;
    }
}